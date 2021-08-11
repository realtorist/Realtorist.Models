using Newtonsoft.Json;
using Realtorist.Models.Xml;
using System;

namespace Realtorist.Models.Json
{
    /// <summary>
    /// Describes JSON converter for the <see cref="XmlDateTime">XmlDateTime</see>
    /// </summary>
    public class XmlDateTimeJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(XmlDateTime);
        }

        public override bool CanRead => true;

        public override bool CanWrite => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.ReadAsDateTime();
            return new XmlDateTime(value);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var xmlLookup = value as XmlDateTime;
            var dateTime = xmlLookup?.DateTime;
            
            writer.WriteValue(dateTime);
        }
    }
}
