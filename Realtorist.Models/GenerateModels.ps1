[cmdletbinding()]
param([string]$Target)

if ([string]::IsNullOrWhiteSpace($Target)) { $Target = 'rets' }

if ($PWD.Provider.Name -eq 'FileSystem') {
    [System.IO.Directory]::SetCurrentDirectory($PWD)
}

$csv = Import-Csv -Path DDFModel.csv
$classes = @{};

function CamelCase {
    param (
        $str
    )
    
    return [System.Char]::ToLower($str[0]) + $str.Substring(1)
}

[xml] $xml = Get-Content -Path "lookup_types.xml"
[System.Xml.XmlNodeList] $types = $xml["RETS"]["METADATA"].ChildNodes
$knownLookups = New-Object System.Collections.Generic.HashSet[string]

foreach ($type in $types) {
    $knownLookups.Add($type.Attributes["Lookup"].Value.Replace(" ", ""));
}

foreach ($line in $csv) 
{
    if (!$classes.ContainsKey($line.Parent)) {
        $classes[$line.Parent] = New-Object System.Collections.ArrayList;
    }

    $classes[$line.Parent].Add($line)
}

if ($Target.ToLower() -eq 'rets') {

foreach ($class in $classes.Keys)
{
    $content = [System.Text.StringBuilder]::new(
@"
using Realtorist.Models.Enums.LookupTypes;
using Realtorist.Models.Xml;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace Realtorist.Models.RetsModels
{
    [XmlRoot(ElementName = "$class")]
    public class $($class)
    {

"@)

    $visitedProps = New-Object System.Collections.Generic.HashSet[string]
    foreach ($prop in $classes[$class])
    {
        if ($visitedProps.Contains($prop.Name)) {continue;}
        $visitedProps.Add($prop.Name);

        $type = 'string'
        if ($prop.Type -eq 'Integer') { $type = 'int' }
        elseif ($prop.Type -eq 'Double') { $type = 'double' }
        elseif ($prop.Type -eq 'DateTime') { $type = 'XmlDateTime' }
        elseif ($prop.Type -eq 'Boolean') { $type = 'XmlBoolean' }
        elseif ($prop.Type.StartsWith('Lookup')) { if ($knownLookups.Contains($prop.Lookup)) { $type = "XmlLookup<$($prop.Lookup)>" } else { $type = 'string' } }
        elseif ($prop.Type -eq 'Complex' -or $prop.Type -eq 'Collection') 
        { 
            if ($prop.Lookup -ne $null -and $prop.Lookup.Length -gt 0 ) { $type = $prop.Lookup } else { $type = $prop.Name } 
        }

        if ($prop.Lookup -eq 'MeasureUnit*')
        {
            $type = 'Measurement'
            $prop.Type = 'Complex'
        }

        $name = $($prop.Name)

        $array = ''
        #if ($prop.Type.EndsWith('(CSV)')) { $array = '[]' }
        if ($prop.Cardinality -eq '1..*') { $array = '[]' }

        $nullable = ''
        if (($prop.Type -eq 'Integer' -or $prop.Type -eq 'Double') -and $prop.Cardinality -eq '0..1') { $nullable = '?' }

        $maybeNull = ''
        if (($prop.Type -eq 'String' -or $prop.Type -eq 'Complex' -or ($prop.Type -eq 'Lookup')) -and $prop.Cardinality -eq '0..1') { $maybeNull = "$([Environment]::NewLine)        [MaybeNull]" }


        $prop.Description = $prop.Description.Replace([Environment]::NewLine, "$([Environment]::NewLine)        /// ")
        $prop.Description = $prop.Description.Replace("`n", "$([Environment]::NewLine)        /// ")

        $dataType = ''
        $xmlAttributeName = 'Element'
        if ($prop.Type.EndsWith('(CSV)')) { 
            $baseType = $prop.Type.Replace('(CSV)', '').Trim();
            $genericType = ''
            if ($type -ne 'string') { $genericType = "<$type>" }
            if ($prop.Type.StartsWith('Lookup') -eq 'Lookup' -and $type -ne 'string') { $genericType = "<$($prop.Lookup)>" }
            $type = "Xml$($baseType)CsvArray$genericType"
        } elseif ($prop.Type -eq 'DateTime') {
            #$dataType = "Type = typeof(XmlDateTime)"
        }

        $getSet = ' { get; set; }'

        if ($prop.Description.StartsWith('(Attribute) ')) { 
            $prop.Description = $prop.Description.Replace('(Attribute) ', '');
            $xmlAttributeName = 'Attribute'

            if ($prop.Type -eq 'DateTime') { 
                $type = 'string'
                $xmlAttribute = 'Element'
                $dataType = "AttributeName = ""$($prop.Name)"""
                $name += 'String'

                $getSet =
@"

        {
            get { return $($prop.Name).ToString(XmlDateTime.ExpectedGmtFormat); }
            set { $($prop.Name) = DateTime.Parse(value); }
        }
"@
                $content.AppendLine(
@"
        /// <summary>
        /// Helper for parsing <see cref="$($prop.Name)">$($prop.Name)</see>
        /// </summary>
        [XmlIgnore]
        public DateTime$nullable $($prop.Name) { get; set; }

"@)
            }
        }

        if ($prop.Description.StartsWith('(Text) ')) { 
            $prop.Description = $prop.Description.Replace('(Text) ', '');
            $xmlAttributeName = 'Text'
        }

         $xmlAttribute = "$([Environment]::NewLine)        [Xml$xmlAttributeName($dataType)]"

        $content.AppendLine(
@"
        /// <summary>
        /// $($prop.Description)
        /// </summary>$maybeNull$xmlAttribute
        public $type$array$nullable $name$getSet

"@)
    }

    $content.Remove($content.Length-[Environment]::NewLine.Length,[Environment]::NewLine.Length)

    $content.Append(
@"
    }
}
"@)

    $path = "RetsModels/$class.cs"
    [System.IO.File]::WriteAllText($path, $content.ToString())
}
}

elseif ($Target.ToLower() -eq 'db') 
{
foreach ($class in $classes.Keys)
{
    $content = [System.Text.StringBuilder]::new(
@"
using Realtorist.Models.Attributes;
using Realtorist.Models.Enums.LookupTypes;
using Realtorist.Models.Xml;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Models
{
    public class $($class)
    {

"@)

    $visitedProps = New-Object System.Collections.Generic.HashSet[string]
    foreach ($prop in $classes[$class])
    {
        if ($visitedProps.Contains($prop.Name)) {continue;}
        $visitedProps.Add($prop.Name);

        $type = 'string'
        if ($prop.Type -eq 'Integer') { $type = 'int' }
        elseif ($prop.Type -eq 'Double') { $type = 'double' }
        elseif ($prop.Type -eq 'DateTime') { $type = 'DateTime' }
        elseif ($prop.Type -eq 'Boolean') { $type = 'bool' }
        elseif ($prop.Type.StartsWith('Lookup')) { if ($knownLookups.Contains($prop.Lookup)) { $type = "$($prop.Lookup)" } else { $type = 'string' } }
        elseif ($prop.Type -eq 'Complex' -or $prop.Type -eq 'Collection') 
        { 
            if ($prop.Lookup -ne $null -and $prop.Lookup.Length -gt 0 ) { $type = $prop.Lookup } else { $type = $prop.Name } 
        }

        if ($prop.Lookup -eq 'MeasureUnit*')
        {
            $type = 'Measurement'
            $prop.Type = 'Complex'
        }

        $name = $($prop.Name)

        $array = ''
        if ($prop.Type.EndsWith('(CSV)')) { $array = '[]' }
        if ($prop.Cardinality -eq '1..*') { $array = '[]' }

        $nullable = ''
        if (($prop.Type -eq 'Integer' -or $prop.Type -eq 'Double' -or ($prop.Type -eq 'Lookup')) -and $prop.Cardinality -eq '0..1') { $nullable = '?' }

        $maybeNull = ''
        if (($prop.Type -eq 'String' -or $prop.Type -eq 'Complex') -and $prop.Cardinality -eq '0..1') { $maybeNull = "$([Environment]::NewLine)        [MaybeNull]" }


        $prop.Description = $prop.Description.Replace([Environment]::NewLine, "$([Environment]::NewLine)        /// ")
        $prop.Description = $prop.Description.Replace("`n", "$([Environment]::NewLine)        /// ")

        $getSet = ' { get; set; }'

        $displayAttribute = ''
        if (![string]::IsNullOrEmpty($prop.DisplayName) -or ![string]::IsNullOrEmpty($prop.GroupName))
        {
            $displayAttribute = "$([Environment]::NewLine)        [Display("
            $displayAttributeProps = @();
            if (![string]::IsNullOrEmpty($prop.DisplayName)) {
                $displayAttributeProps += "Name = ""$($prop.DisplayName)"""
            }
            if (![string]::IsNullOrEmpty($prop.GroupName)) {
                $displayAttributeProps += "GroupName = ""$($prop.GroupName)"""
            }

            $displayAttribute += [string]::Join(', ', $displayAttributeProps) + ')]'
        }

        $isShownAttribute = ''
        if ($prop.Display -eq 'Table') 
        {
            $isShownAttribute = "$([Environment]::NewLine)        [TableView]"
        }
        elseif ($prop.Display) 
        {
            $isShownAttribute = "$([Environment]::NewLine)        [DisplayableProperty]"
        }

        $isSummaryAttribute = ''
        if (![string]::IsNullOrEmpty($prop.Summary)) 
        {
            $isSummaryAttribute = "$([Environment]::NewLine)        [SummaryProperty($($prop.Summary))]"
        }

        $content.AppendLine(
@"
        /// <summary>
        /// $($prop.Description)
        /// </summary>$maybeNull$isShownAttribute$isSummaryAttribute$displayAttribute
        public $type$array$nullable $name$getSet

"@)
    }

    $content.Remove($content.Length-[Environment]::NewLine.Length,[Environment]::NewLine.Length)

    $content.Append(
@"
    }
}
"@)

    $path = "Models/$class.cs"
    [System.IO.File]::WriteAllText($path, $content.ToString())
}
}


elseif ($Target.ToLower() -eq 'ts') 
{
foreach ($class in $classes.Keys)
{
    $content = [System.Text.StringBuilder]::new(
@"
export interface $($class) {

"@)

    $imports = New-Object System.Collections.Generic.HashSet[string]

    $visitedProps = New-Object System.Collections.Generic.HashSet[string]
    foreach ($prop in $classes[$class])
    {
        if ($visitedProps.Contains($prop.Name)) {continue;}
        $visitedProps.Add($prop.Name);

        $type = 'string'
        if ($prop.Type -eq 'Integer') { $type = 'number' }
        elseif ($prop.Type -eq 'Double') { $type = 'number' }
        elseif ($prop.Type -eq 'DateTime') { 
            $type = 'moment.Moment' 
            $imports.Add('import * as moment from "moment";')
        }
        elseif ($prop.Type -eq 'Boolean') { $type = 'boolean' }
        elseif ($prop.Type.StartsWith('Lookup')) { 
            if ($knownLookups.Contains($prop.Lookup)) { 
                $type = "$($prop.Lookup)" 
                $imports.Add("import { $($prop.Lookup) } from '../lookups/$(CamelCase $prop.Lookup)';")
            } else { $type = 'string' } }
        elseif ($prop.Type -eq 'Complex' -or $prop.Type -eq 'Collection') 
        { 
            if ($prop.Lookup -ne $null -and $prop.Lookup.Length -gt 0 ) { 
                $type = $prop.Lookup
                $imports.Add("import { $($prop.Lookup) } from './$(CamelCase $prop.Lookup)';")
            } else { 
                $type = $prop.Name
                $imports.Add("import { $($prop.Name) } from './$(CamelCase $prop.Name)';")
            } 
        }

        if ($prop.Lookup -eq 'MeasureUnit*')
        {
            $type = 'Measurement'
            $prop.Type = 'Complex'

            $imports.Add("import { Measurement } from '../units/Measurement';")
        }

        $name = $($prop.Name)

        $array = ''
        if ($prop.Type.EndsWith('(CSV)')) { $array = '[]' }
        if ($prop.Cardinality -eq '1..*') { $array = '[]' }

        $nullable = ''
        if (($prop.Type -eq 'Integer' -or $prop.Type -eq 'Double' -or ($prop.Type -eq 'Lookup')) -and $prop.Cardinality -eq '0..1') { $nullable = '?' }
        if (($prop.Type -eq 'String' -or $prop.Type -eq 'Complex') -and $prop.Cardinality -eq '0..1') { $nullable = '?' }

        $prop.Description = $prop.Description.Replace([Environment]::NewLine, "$([Environment]::NewLine)`t * ")
        #$prop.Description = $prop.Description.Replace("`n", "$([Environment]::NewLine)        /// ")

        $displayAttribute = ''
        if (![string]::IsNullOrEmpty($prop.DisplayName) -or ![string]::IsNullOrEmpty($prop.GroupName))
        {
            $displayAttribute = "$([Environment]::NewLine)        [Display("
            $displayAttributeProps = @();
            if (![string]::IsNullOrEmpty($prop.DisplayName)) {
                $displayAttributeProps += "Name = ""$($prop.DisplayName)"""
            }
            if (![string]::IsNullOrEmpty($prop.GroupName)) {
                $displayAttributeProps += "GroupName = ""$($prop.GroupName)"""
            }

            $displayAttribute += [string]::Join(', ', $displayAttributeProps) + ')]'
        }

        $isShownAttribute = ''
        if ($prop.Display -eq 'Table') 
        {
            $isShownAttribute = "$([Environment]::NewLine)        [TableView]"
        }
        elseif ($prop.Display) 
        {
            $isShownAttribute = "$([Environment]::NewLine)        [DisplayableProperty]"
        }

        $isSummaryAttribute = ''
        if (![string]::IsNullOrEmpty($prop.Summary)) 
        {
            $isSummaryAttribute = "$([Environment]::NewLine)        [SummaryProperty($($prop.Summary))]"
        }

        $content.AppendLine(
@"
    /**
     * $($prop.Description)
     */
    $(CamelCase $name)$($nullable): $type$array;
"@)
    }

    $content.Remove($content.Length-[Environment]::NewLine.Length,[Environment]::NewLine.Length)

    $content.Append(
@"

}
"@)


    if ($imports.Count -gt 0) { $content.Insert(0, [Environment]::NewLine) }
    foreach ($import in $imports) {
        $content.Insert(0, $import + [Environment]::NewLine)
    }

    $classCamelCase = CamelCase $class
    $path = "../../real-estate-admin/src/app/@core/models/listings/details/$classCamelCase.ts"
    [System.IO.File]::WriteAllText($path, $content.ToString())
}
}