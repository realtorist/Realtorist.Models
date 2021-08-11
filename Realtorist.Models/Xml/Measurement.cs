using Realtorist.Models.Enums.LookupTypes;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Realtorist.Models.Xml
{
    public class Measurement : IXmlSerializable
    {
        private static readonly Regex _regex = new Regex("^(-?[0-9]+\\.?[0-9]*)");

        public MeasureUnit Unit { get; set; }
        public double? Value { get; set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            var unitString = reader.GetAttribute("Unit");
            if (!string.IsNullOrEmpty(unitString))
            {
                Unit = (MeasureUnit)int.Parse(unitString);
            }

            var valueString = reader.ReadElementContentAsString();
            var match = _regex.Match(valueString ?? string.Empty);
            if (match.Success)
            {
                Value = double.Parse(match.Groups[0].Value);
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("Unit", ((int)Unit).ToString());
            if (Value.HasValue)
            {
                writer.WriteString(Value.ToString());
            }
        }
    }
}
