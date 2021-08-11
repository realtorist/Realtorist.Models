using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Realtorist.Models.Xml;
using System;

namespace Realtorist.Models.Json
{
    /// <summary>
    /// Describes JSON converter for the <see cref="XmlLookupCsvArray{T}">XmlLookupCsvArray{T}</see>
    /// </summary>
    /// <typeparam name="T">Type of the lookup</typeparam>
    public class XmlLookupCsvArrayJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType.GetGenericTypeDefinition() == typeof(XmlLookupCsvArray<>);
        }

        public override bool CanRead => true;

        public override bool CanWrite => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.StartArray)
            {
                throw new FormatException("Wrong JSON property type. Should be an array");
            }

            var lookupType = objectType.GetGenericArguments()[0];
            var arrayType = lookupType.MakeArrayType();

            var jArray = JToken.ReadFrom(reader);
            var array = jArray.ToObject(arrayType);

            return objectType.GetConstructor(new[] { arrayType }).Invoke(new[] { array });
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var array = value != null ? value.GetType().GetProperty("Array").GetValue(value) : null;
            
            if (array != null)
            {
                var token = JToken.FromObject(array);
                token.WriteTo(writer);
            }
        }
    }
}
