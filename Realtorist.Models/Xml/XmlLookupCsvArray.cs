using Newtonsoft.Json;
using Realtorist.Models.Helpers;
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
    /// Helper class for parsing string lookups in CSV format from XML
    /// </summary>
    [JsonConverter(typeof(XmlLookupCsvArrayJsonConverter))]
    public class XmlLookupCsvArray<T> : IXmlSerializable where T : struct, System.Enum
    {
        public XmlLookupCsvArray(T[] array)
        {
            Array = array;
        }

        public XmlLookupCsvArray()
        {
        }

        public T[] Array { get; set; }

        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            var idsString = reader.GetAttribute("ID") ?? string.Empty;
            Array = idsString
                .Split(',')
                .Select(id => int.Parse(id))
                .Select(id => (T)Enum.ToObject(typeof(T), id))
                .ToArray();

            /*var elementContent = reader.ReadElementContentAsString();
            var stringArray = string.IsNullOrWhiteSpace(elementContent) ? System.Array.Empty<string>() : elementContent.Split(',');
            var types = GetEnumXmlValuesBackwards();

            Array = stringArray.Select(s => types[s.Trim()]).ToArray();*/
        }

        public void WriteXml(XmlWriter writer)
        {
            var value = this.ToString();
            if (value is null) return;
            
            writer.WriteString(value);
            writer.WriteAttributeString("ID", Array.Cast<int>().Join(","));
        }

        public static implicit operator T[](XmlLookupCsvArray<T> input)
        {
            return input?.Array ?? System.Array.Empty<T>();
        }

        public static implicit operator XmlLookupCsvArray<T>(T[] input)
        {
            return new XmlLookupCsvArray<T>() { Array = input };
        }

        public override string ToString()
        {
            if (Array is null) return null;

            var types = GetEnumXmlValues();
            return string.Join(", ", Array.Select(s => types[s]));
        }

        private Dictionary<T, string> GetEnumXmlValues()
        {
            var enumType = typeof(T);
            return Enum.GetValues<T>().ToDictionary(
                value => value,
                value =>
            {
                var name = Enum.GetName(enumType, value);
                var memberInfos = enumType.GetMember(name);
                var enumValueMemberInfo = memberInfos.FirstOrDefault(m => m.DeclaringType == enumType);
                var valueAttributes = enumValueMemberInfo.GetCustomAttributes(typeof(XmlEnumAttribute), false);
                return ((XmlEnumAttribute)valueAttributes[0]).Name;
            });            
        }

        private Dictionary<string, T> GetEnumXmlValuesBackwards() => GetEnumXmlValues().ToDictionary(x => x.Value, x => x.Key);
    }
}
