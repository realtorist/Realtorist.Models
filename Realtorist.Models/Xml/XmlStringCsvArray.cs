using Newtonsoft.Json;
using Realtorist.Models.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Realtorist.Models.Xml
{
    /// <summary>
    /// Helper class for parsing string array in CSV format from XML
    /// </summary>
    [JsonConverter(typeof(XmlStringCsvArrayJsonConverter))]
    public class XmlStringCsvArray : IXmlSerializable
    {
        public XmlStringCsvArray(string[] array)
        {
            Array = array;
        }

        public XmlStringCsvArray()
        {
        }

        public string[] Array { get; set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            var elementContent = reader.ReadElementContentAsString();
            var stringArray = string.IsNullOrWhiteSpace(elementContent) ? System.Array.Empty<string>() : elementContent.Split(',');

            Array = stringArray.Select(s => s.Trim()).ToArray();
        }

        public void WriteXml(XmlWriter writer)
        {
            var value = this.ToString();
            if (value is null) return;
            
            writer.WriteString(value);
        }

        public static implicit operator string[](XmlStringCsvArray input)
        {
            return input?.Array ?? System.Array.Empty<string>();
        }

        public static implicit operator XmlStringCsvArray(string[] input)
        {
            return new XmlStringCsvArray() { Array = input };
        }

        public override string ToString()
        {
            if (Array is null) return null;

            return string.Join(", ", Array);
        }
    }
}
