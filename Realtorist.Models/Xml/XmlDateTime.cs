using Newtonsoft.Json;
using Realtorist.Models.Json;
using System;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Realtorist.Models.Xml
{
    /// <summary>
    /// Helper class for parsing DateTime from not usual formats in XML
    /// </summary>
    [JsonConverter(typeof(XmlDateTimeJsonConverter))]
    public class XmlDateTime : IXmlSerializable
    {
        public DateTime? DateTime { get; set; }
        public const string ExpectedGmtFormat = "ddd, dd MMM yyyy HH:mm:ss \"GMT\"";
        public const string ExpectedLocalFormat = "dd/MM/yyyy hh:mm:ss tt";

        public XmlDateTime(DateTime? dateTime)
        {
            DateTime = dateTime;
        }

        public XmlDateTime()
        {
        }

        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            var elementContent = reader.ReadElementContentAsString();
            DateTime = string.IsNullOrWhiteSpace(elementContent) 
                ? (DateTime?)null 
                : System.DateTime.ParseExact(elementContent, new[] { ExpectedGmtFormat, ExpectedLocalFormat }, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
        }

        public void WriteXml(XmlWriter writer)
        {
            if (!DateTime.HasValue) return;
            writer.WriteString(DateTime.Value.ToString(ExpectedGmtFormat));
        }

        public static implicit operator DateTime?(XmlDateTime input)
        {
            return input?.DateTime;
        }

        public static implicit operator DateTime(XmlDateTime input)
        {
            return input?.DateTime ?? new DateTime();
        }

        public static implicit operator XmlDateTime(DateTime input)
        {
            return new XmlDateTime() { DateTime = input };
        }

        public static implicit operator XmlDateTime(DateTime? input)
        {
            return new XmlDateTime() { DateTime = input };
        }

        public override string ToString()
        {
            if (DateTime == null) return null;
            return DateTime.Value.ToString();
        }
    }
}
