using namespace System.Xml

[cmdletbinding()]
param([string]$Target)

function CamelCase {
    param (
        $str
    )
    
    return [System.Char]::ToLower($str[0]) + $str.Substring(1)
}

[xml] $xml = Get-Content -Path "lookup_types.xml"
[XmlNodeList] $types = $xml["RETS"]["METADATA"].ChildNodes

if ($PWD.Provider.Name -eq 'FileSystem') {
    [System.IO.Directory]::SetCurrentDirectory($PWD)
}

if ([string]::IsNullOrWhiteSpace($Target)) { $Target = 'c#' }

if  ($Target -eq 'csharp')
{
    foreach ($type in $types)
    {
        $typeName = $type.Attributes["Lookup"].Value.Replace(" ", "")
        [XmlNodeList] $values = $type.ChildNodes
        $content = [System.Text.StringBuilder]::new(
    @"
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    namespace Realtorist.Models.Enums.LookupTypes
    {
        public enum $typeName
        {

"@
    )
        $list = New-Object System.Collections.ArrayList;
        foreach ($item in $values) 
        {
            $value = $item.Value
            $displayName = $item.LongValue
            $name = $displayName.Replace(" ", "_").Replace("-", "_").Replace("/", "_").Replace('"', '\"') -replace "[^a-zA-Z0-9_]","" -replace '^([0-9])','_$1'

            if ($name -eq "") {$name = "None"}
            if ($displayName -eq "") {$name = "None"}

            $list.Add(@{value = $value; displayName = $displayName; name = $name});

        }

        foreach($item in ($list | Sort-Object -Property value))
        {
            
            $content.AppendLine("`t`t[Display(Name = `"$($item.displayName.Replace('"', '\"'))`")]")
            $content.AppendLine("`t`t[XmlEnum(Name = `"$($item.displayName.Replace('"', '\"'))`")]")
            $content.AppendLine("`t`t$($item.name) = $($item.value),")
            $content.AppendLine()
        }
        
        $content.Remove($content.Length-([Environment]::NewLine.Length * 2)-1,[Environment]::NewLine.Length*2+1)
        $content.AppendLine()

        $content.Append(
    @"
        }
    }
"@
    )
        $path = "Enums/LookupTypes/$typeName.cs"
        [System.IO.File]::WriteAllText($path, $content.ToString())
    }
} elseif ($Target -eq 'ts' ) {
    $path2 = "../../real-estate-admin/src/app/@core/models/listings/lookups/displayValues.ts"
    $prepend2 = 
    @"
import { IEnumDisplayMap } from "../../enumDisplayMap";

export const addLookupValuesToDisplayMap = (map: IEnumDisplayMap) => {

"@

    [System.IO.File]::WriteAllText($path2, $prepend2)

    foreach ($type in $types)
    {
        $typeName = $type.Attributes["Lookup"].Value.Replace(" ", "")
        [XmlNodeList] $values = $type.ChildNodes
        $content = [System.Text.StringBuilder]::new(
    @"
export enum $typeName {

"@)
        $content2 = [System.Text.StringBuilder]::new(
    @"
`tmap.$typeName = {

"@
    )
        $list = New-Object System.Collections.ArrayList;
        foreach ($item in $values) 
        {
            $value = $item.Value
            $displayName = $item.LongValue
            $name = $displayName.Replace(" ", "_").Replace("-", "_").Replace("/", "_").Replace('"', '\"') -replace "[^a-zA-Z0-9_]","" -replace '^([0-9])','_$1'

            if ($name -eq "") {$name = "None"}
            if ($displayName -eq "") {$name = "None"}

            $list.Add(@{value = $value; displayName = $displayName; name = $name});

        }

        foreach($item in ($list | Sort-Object -Property value))
        {            
            $content.AppendLine("`t$($item.name) = $($item.value),")
            $content.AppendLine()
            $content2.AppendLine("`t`t$($item.value): '$($item.displayName.Replace("'", "\'"))',")
        }
        
        $content.Remove($content.Length-([Environment]::NewLine.Length * 2)-1,[Environment]::NewLine.Length*2+1)
        $content.AppendLine()
        
        $content2.Remove($content2.Length-([Environment]::NewLine.Length)-1,[Environment]::NewLine.Length+1)
        $content2.AppendLine()

        $content.Append(
    @"
}
"@
    )

    $content2.Append(
    @"
    };

"@
)
        $path = "../../real-estate-admin/src/app/@core/models/listings/lookups/$(CamelCase $typeName).ts"
        Write-Host "Writing $path"
        [System.IO.File]::WriteAllText($path, $content.ToString())
        Write-Host "Writing $path2"
        Add-Content $path2 $content2.ToString()
    }

    Add-Content $path2 @"
}
"@
} 