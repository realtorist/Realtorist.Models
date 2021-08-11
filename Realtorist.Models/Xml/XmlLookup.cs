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
    /// Helper class for parsing lookup from the xml
    /// </summary>
    /// <typeparam name="T">Type of the lookup</typeparam>
    [JsonConverter(typeof(XmlLookupJsonConverter))]
    public class XmlLookup<T> : IXmlSerializable where T : struct, System.Enum
    {
        public XmlLookup()
        {
        }

        public XmlLookup(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            var idString = reader.GetAttribute("ID") ?? string.Empty;
            if (!idString.IsNullOrEmpty())
            {
                Value = (T)Enum.ToObject(typeof(T), int.Parse(idString));
            }
            else
            {
                var elementContent = reader.ReadElementContentAsString();
                if (Enum.TryParse<T>(elementContent, true, out var tempValue))
                {
                    Value = tempValue;
                }
                else
                {
                    var enumValues = GetEnumXmlValuesBackwards();
                    foreach(var key in enumValues.Keys)
                    {
                        if (key.ToLower() == elementContent.ToLower())
                        {
                            Value = enumValues[key];
                            return;
                        }
                    }

                    throw new InvalidCastException($"Can't cast value '{elementContent}' to type '{typeof(T).FullName}'");
                }
            }

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
            writer.WriteAttributeString("ID", Convert.ToInt32(Value).ToString());
        }

        public static implicit operator T(XmlLookup<T> input)
        {
            return input.Value;
        }

        public static implicit operator XmlLookup<T>(T input)
        {
            return new XmlLookup<T>() { Value = input };
        }

        public override string ToString()
        {
            return Value.ToString();
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
