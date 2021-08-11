using Newtonsoft.Json;
using Realtorist.Models.Xml;
using System;

namespace Realtorist.Models.Json
{
    /// <summary>
    /// Describes JSON converter for the <see cref="XmlLookup{T}">XmlLookup{T}</see>
    /// </summary>
    /// <typeparam name="T">Type of the lookup</typeparam>
    public class XmlLookupJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType.GetGenericTypeDefinition() == typeof(XmlLookup<>);
        }

        public override bool CanRead => true;

        public override bool CanWrite => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var lookupType = objectType.GetGenericArguments()[0];
            var value = reader.ReadAsInt32();
            var lookup = value != null ? Enum.ToObject(lookupType, value) : null;
            return lookup != null ? objectType.GetConstructor(new[] { lookupType }).Invoke(new[] { lookup }) : null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var lookup = value != null ? value.GetType().GetProperty("Value").GetValue(value) : null;
            if (lookup != null)
            {
                writer.WriteValue(lookup as int?);
            }
        }
    }
}
