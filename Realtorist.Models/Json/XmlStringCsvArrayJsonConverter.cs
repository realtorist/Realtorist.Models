using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Realtorist.Models.Xml;
using System;

namespace Realtorist.Models.Json
{
    /// <summary>
    /// Describes JSON converter for the <see cref="XmlStringCsvArray">XmlStringCsvArray</see>
    /// </summary>
    public class XmlStringCsvArrayJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(XmlStringCsvArray);
        }

        public override bool CanRead => true;

        public override bool CanWrite => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.StartArray)
            {
                throw new FormatException("Wrong JSON property type. Should be an array");
            }

            var jArray = JArray.ReadFrom(reader);
            var array = jArray.ToObject<string[]>();
            return new XmlStringCsvArray(array);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var xmlLookup = value as XmlStringCsvArray;
            var array = xmlLookup?.Array;
            if (array != null)
            {
                var token = JToken.FromObject(array);
                token.WriteTo(writer);
            }
        }
    }
}
