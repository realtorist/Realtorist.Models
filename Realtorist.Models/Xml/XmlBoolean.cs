using Newtonsoft.Json;
using Realtorist.Models.Json;
using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Realtorist.Models.Xml
{
    /// <summary>
    /// Helper class for parsing boolean as element presence in XML
    /// </summary>
    [JsonConverter(typeof(XmlBooleanJsonConverter))]
    public class XmlBoolean : IXmlSerializable
    {
        public XmlBoolean()
        {
        }

        public XmlBoolean(bool value)
        {
            Value = value;
        }

        public bool Value { get; set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            var elementContent = reader.ReadElementContentAsString();
            Value = string.IsNullOrEmpty(elementContent) || string.Equals(elementContent, true.ToString(), StringComparison.InvariantCultureIgnoreCase);
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(Value.ToString().ToLowerInvariant());
        }

        public static implicit operator bool(XmlBoolean input)
        {
            return input is not null && input.Value;
        }

        public static implicit operator XmlBoolean(bool input)
        {
            return new XmlBoolean() { Value = input };
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
