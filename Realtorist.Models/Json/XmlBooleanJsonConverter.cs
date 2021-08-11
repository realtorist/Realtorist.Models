using Newtonsoft.Json;
using Realtorist.Models.Xml;
using System;

namespace Realtorist.Models.Json
{
    /// <summary>
    /// Describes JSON converter for <see cref="XmlBoolean">XmlBoolean</see>
    /// </summary>
    public class XmlBooleanJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(XmlBoolean);
        }

        public override bool CanRead => true;

        public override bool CanWrite => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.ReadAsBoolean();
            return new XmlBoolean(value ?? false);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var xmlBoolean = value as XmlBoolean;
            writer.WriteValue(xmlBoolean?.Value ?? false);
        }
    }
}
