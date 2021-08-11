using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Realtorist.Models.Attributes;
using Realtorist.Models.Models;
using Realtorist.Models.Xml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml;

namespace Realtorist.Models.Helpers
{
    /// <summary>
    /// Contains different helpful extension methods
    /// </summary>
    public static class Extensions
    {
        private static readonly Regex _camelCaseSplitRegex = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

        /// <summary>
        /// Parses XML and returns deserialized object
        /// </summary>
        /// <typeparam name="T">Output type</typeparam>
        /// <param name="xml">XML to parse</param>
        /// <returns>Deserialized XML</returns>
        public static T FromXml<T>(this string xml)
        {
            if (xml is null)
            {
                throw new ArgumentNullException(nameof(xml));
            }

            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using var stringReader = new StringReader(xml);
            var xmlReader = new XmlTextReader(stringReader);
            xmlReader.Namespaces = false;

            return (T)xmlSerializer.Deserialize(xmlReader);
        }

        /// <summary>
        /// Parses JSON and returns deserialized object
        /// </summary>
        /// <typeparam name="T">Output type</typeparam>
        /// <param name="json">JSON to parse</param>
        /// <returns>Deserialized JSON</returns>
        public static T FromJson<T>(this string json)
        {
            if (json is null)
            {
                throw new ArgumentNullException(nameof(json));
            }

            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Serializes object into JSON
        /// </summary>
        /// <param name="obj">Object to serialize</param>
        /// <returns>JSON representation of the object</returns>
        public static string ToJson(this object obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            });
        }

        /// <summary>
        /// Converts dynamic object into specific type
        /// </summary>
        /// <typeparam name="T">Output type</typeparam>
        /// <param name="obj">Dynamic object to convert</param>
        /// <returns>Object of the specificed type</returns>
        public static T ToObject<T>(this ExpandoObject obj)
        {
            return obj.ToJson().FromJson<T>();
        }

        /// <summary>
        /// Concatenates the members of a collection, using the specified separator between each member.
        /// </summary>
        /// <typeparam name="T">The type of the members of values.</typeparam>
        /// <param name="enumerable">A collection that contains the objects to concatenate.</param>
        /// <param name="separator">The string to use as a separator. separator is included in the returned string only if values has more than one element.</param>
        /// <returns>A string that consists of the members of values delimited by the separator string. If values has no members, the method returns System.String.Empty.</returns>
        public static string Join<T>(this IEnumerable<T> enumerable, string separator)
        {
            if (enumerable is null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            return string.Join(separator, enumerable);
        }

        /// <summary>
        /// Creates new string from the <see cref="char">char</see> enumerable
        /// </summary>
        /// <param name="chars">Enumerable of <see cref="char">char</see></param>
        /// <returns>String</returns>
        public static string AsString(this IEnumerable<char> chars)
        {
            if (chars is null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            return new string(chars.ToArray());
        }

        /// <summary>
        /// Gets <see cref="DisplayAttribute"/> value or enum field for the enum field
        /// </summary>
        /// <param name="enumValue">Enum value</param>
        /// <param name="propertyName">Name of the field in <see cref="DisplayAttribute"/></param>
        /// <returns><see cref="DisplayAttribute"/> value for the enum field</returns>
        public static string GetLookupDisplayFieldFromObject(this object enumValue, string propertyName = "Name")
        {
            var enumType = enumValue.GetType();
            if (!enumType.IsEnum)
            {
                throw new ArgumentException($"Argument is {enumType.FullName} not enum");
            }

            var name = Enum.GetName(enumType, enumValue);
            if (name == null) return "Unknown";

            var memberInfos = enumType.GetMember(name);
            var enumValueMemberInfo = memberInfos.FirstOrDefault(m => m.DeclaringType == enumType);
            var valueAttributes = enumValueMemberInfo.GetCustomAttributes(typeof(DisplayAttribute), false);

            var property = typeof(DisplayAttribute).GetProperty(propertyName);

            return valueAttributes.Length > 0 ? property.GetValue(valueAttributes[0]) as string : enumValue.ToString();
        }

        /// <summary>
        /// Gets <see cref="DisplayAttribute"/> value or enum field name  for the enum field
        /// </summary>
        /// <param name="enumValue">Enum value</param>
        /// <returns><see cref="DisplayAttribute"/> value for the enum field</returns>
        public static string GetLookupDisplayTextFromObject(this object enumValue)
        {
            var enumType = enumValue.GetType();
            if (!enumType.IsEnum)
            {
                throw new ArgumentException($"Argument is {enumType.FullName} not enum");
            }

            var name = Enum.GetName(enumType, enumValue);
            if (name == null) return "Unknown";

            var memberInfos = enumType.GetMember(name);
            var enumValueMemberInfo = memberInfos.FirstOrDefault(m => m.DeclaringType == enumType);
            var valueAttributes = enumValueMemberInfo.GetCustomAttributes(typeof(DisplayAttribute), false);
            return valueAttributes.Length > 0 ? ((DisplayAttribute)valueAttributes[0]).Name : enumValue.ToString();
        }

        /// <summary>
        /// Gets <see cref="DisplayAttribute"/> value or enum field name for the enum field
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <param name="enumValue">Enum value</param>
        /// <returns><see cref="DisplayAttribute"/> value for the enum field</returns>
        public static string GetLookupDisplayText<T>(this T enumValue) where T : struct, Enum
        {
            return GetLookupDisplayTextFromObject(enumValue);
        }

        /// <summary>
        /// Gets Enum value from <see cref="DisplayAttribute"/> value or enum field name 
        /// </summary>
        /// <param name="enumType">Enum type</param>
        /// <param name="enumValue">Enum string value</param>
        /// <returns>Enum value</returns>
        public static object GetEnumValueFromLookupDisplayText(this Type enumType, string enumValue)
        {
            if (!enumType.IsEnum)
            {
                throw new ArgumentException($"Argument is {enumType.FullName} not enum");
            }

            var fromName = Enum.GetValues(enumType).Cast<object>().FirstOrDefault(x => Enum.GetName(enumType, x) == enumValue);
            if (fromName is not null) return fromName;

            var enumValueMemberInfos = enumType.GetMembers().Where(m => m.DeclaringType == enumType);
            var name = enumValueMemberInfos
                .FirstOrDefault(m => m.GetCustomAttributes(typeof(DisplayAttribute), false)
                    .Any(y => ((DisplayAttribute)y).Name == enumValue))?.Name;

            if (name is null)
            {
                throw new InvalidCastException($"Can't find enum member of type {enumType.FullName} with display name or name '{enumValue}'");
            }

            return Enum.Parse(enumType, name);
        }

        /// <summary>
        /// Gets Enum value from <see cref="DisplayAttribute"/> value or enum field name 
        /// </summary>
        /// <param name="enumType">Enum type</param>
        /// <param name="enumValue">Enum string value</param>
        /// <returns>Enum value</returns>
        public static TEnum GetEnumValueFromLookupDisplayText<TEnum>(this string enumValue) where TEnum : struct, Enum
        {
            var fromName = Enum.GetValues<TEnum>().Where(x => Enum.GetName<TEnum>(x) == enumValue);
            if (!fromName.IsNullOrEmpty()) return fromName.First();

            var enumValueMemberInfos = typeof(TEnum).GetMembers().Where(m => m.DeclaringType == typeof(TEnum));
            var name = enumValueMemberInfos
                .FirstOrDefault(m => m.GetCustomAttributes(typeof(DisplayAttribute), false)
                    .Any(y => ((DisplayAttribute)y).Name == enumValue))?.Name;

            if (name is null)
            {
                var temp = (TEnum)Enum.ToObject(typeof(TEnum), int.MaxValue);
                return temp;
            }

            return Enum.Parse<TEnum>(name);
        }

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation, using the specified format.
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="format">A numeric format string.</param>
        /// <returns>The string representation of the value of this instance as specified by format. Empty if null</returns>
        public static string ToString(this double? value, string format)
        {
            return value.HasValue ? value.Value.ToString(format) : string.Empty;
        }

        /// <summary>
        /// Checks whether enumerable is null or empty
        /// </summary>
        /// <param name="enumerable">Enumerable to check</param>
        /// <returns>Whether enumerable is null or empty</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable is null || !enumerable.Any();
        }

        /// <summary>
        /// Checks whether enumerable is null or empty
        /// </summary>
        /// <param name="enumerable">Enumerable to check</param>
        /// <returns>Whether enumerable is null or empty</returns>
        public static bool IsNullOrEmpty(this IEnumerable enumerable)
        {
            return enumerable is null || !enumerable.Cast<object>().Any();
        }

        /// <summary>
        /// Checks whether coordinate are null or empty
        /// </summary>
        /// <param name="coordinates">Coordinate to check</param>
        /// <returns>Whether coordinate are null or empty</returns>
        public static bool IsNullOrEmpty(this Coordinates coordinates)
        {
            return coordinates is null
                || (
                    coordinates.Latitude == 0
                    && coordinates.Longitude == 0
                );
        }

        /// <summary>
        /// Checks whether coordinate boundaries are null or empty
        /// </summary>
        /// <param name="boundaries">Coordinate boundaries to check</param>
        /// <returns>Whether coordinate boundaries are null or empty</returns>
        public static bool IsNullOrEmpty(this CoordinateBoundaries boundaries)
        {
            return boundaries is null
                || boundaries.NorthEast.IsNullOrEmpty()
                || boundaries.SouthWest.IsNullOrEmpty();
        }

        /// <summary>
        /// Formats double as price. Will remove decimal places if zero
        /// </summary>
        /// <param name="price">Value to format</param>
        /// <returns>Formatted value. Empty if value is null</returns>
        public static string FormatPrice(this double? price)
        {
            if (price is null) return string.Empty;
            return FormatPrice(price.Value);
        }

        /// <summary>
        /// Formats double as price. Will remove decimal places if zero
        /// </summary>
        /// <param name="price">Value to format</param>
        /// <returns>Formatted value</returns>
        public static string FormatPrice(this double price)
        {
            var s = price.ToString("N2");
            return s.EndsWith(".00") ? s.Substring(0, s.Length - 3) : s;
        }

        /// <summary>
        /// Gets displayable name for the property from the <see cref="DisplayAttribute"/> or splits property name by capital letters
        /// </summary>
        /// <param name="property">Property info</param>
        /// <returns>Displayable name foro the property</returns>
        public static string GetPropertyDisplayName(this PropertyInfo property)
        {

            var displayAttribute = property.GetCustomAttributes(true).Where(attr => attr.GetType() == typeof(DisplayAttribute)).FirstOrDefault();
            if (displayAttribute != null && !string.IsNullOrEmpty(((DisplayAttribute)displayAttribute).Name))
            {
                return ((DisplayAttribute)displayAttribute).Name;
            }

            return property.Name.CamelCaseToWhiteSpace();
        }

        /// <summary>
        /// Splits string with camel case naming using white space
        /// </summary>
        /// <param name="str">String to split</param>
        /// <returns>Camel case string splitted using white space</returns>
        public static string CamelCaseToWhiteSpace(this string str)
        {
            return CamelCaseSplit(str, " ");
        }

        /// <summary>
        /// Splits string with camel case naming using specified separator
        /// </summary>
        /// <param name="str">String to split</param>
        /// <param name="separator">Separator</param>
        /// <returns>Camel case string splitted using <paramref name="separator"/></returns>
        public static string CamelCaseSplit(this string str, string separator)
        {
            return _camelCaseSplitRegex.Replace(str, " ");
        }

        /// <summary>
        /// Gets from the object
        /// </summary>
        /// <param name="obj">Object value</param>
        /// <returns>Equivalent of ToString value</returns>
        public static string ToDisplayString(this object obj)
        {
            if (obj is null) return null;

            var type = obj.GetType();
            if (type.IsArray)
            {
                return ((IEnumerable)obj).Cast<object>().Select(x => x.ToDisplayString()).Join(", ");
            }

            if (type.IsEnum)
            {
                return obj.GetLookupDisplayTextFromObject();
            }

            if (type == typeof(bool))
            {
                return (bool)obj ? "Yes" : "No";
            }

            if (type == typeof(Measurement))
            {
                var measurement = (Measurement)obj;
                return $"{measurement.Value} {measurement.Unit.GetLookupDisplayText()}";
            }

            if (type == typeof(string))
            {
                return (string)obj;
            }

            return obj.ToString();
        }

        /// <summary>
        /// Gets properties of the object that have <see cref="DisplayablePropertyAttribute"/> attribute
        /// </summary>
        /// <param name="obj">Object to check</param>
        /// <returns>Properties of the object that have <see cref="DisplayablePropertyAttribute"/> attribute</returns>
        public static PropertyInfo[] GetDisplayableProperties(this object obj)
        {
            return GetDisplayableProperties(obj.GetType());
        }

        /// <summary>
        /// Gets properties of the type that have <see cref="DisplayablePropertyAttribute"/> attribute
        /// </summary>
        /// <param name="type">Type to check</param>
        /// <returns>Properties of the type that have <see cref="DisplayablePropertyAttribute"/> attribute</returns>
        public static PropertyInfo[] GetDisplayableProperties(this Type type)
        {
            return type.GetProperties().Where(p => p.GetCustomAttributes<DisplayablePropertyAttribute>().Any()).ToArray();
        }

        /// <summary>
        /// Checks whether object has any not null or empty (for arrays) property
        /// </summary>
        /// <param name="obj">Object to check</param>
        /// <returns>Whether object has any not null or empty (for arrays) property</returns>
        public static bool IsNotNullAndHasNotNullOrEmptyProperties(this object obj)
        {
            if (obj == null) return false;

            return obj.GetType().GetProperties(BindingFlags.GetProperty | BindingFlags.Public)
                .Any(p => !IsNullOrEmpty(p, obj));
        }

        /// <summary>
        /// Gets object all not null or empty (for arrays) properties
        /// </summary>
        /// <param name="obj">Object to check</param>
        /// <returns>Object all not null or empty (for arrays) properties</returns>
        public static IDictionary<string, string> GetNotNullOrEmptyProperties(this object obj)
        {
            if (obj == null) return new Dictionary<string, string>();

            return obj.GetType().GetProperties()
                .Where(p => !IsNullOrEmpty(p, obj))
                .ToDictionary(p => p.GetPropertyDisplayName(), p => p.GetValue(obj).ToDisplayString());
        }

        /// <summary>
        /// Gets an expression for selecting property
        /// </summary>
        /// <param name="fieldOrPropertyName">Name of the property or field</param>
        /// <param name="parameterExpression">Expresseion for parameter</param>
        /// <typeparam name="T">Object type</typeparam>
        /// <returns>Property selection expression</returns>
        public static MemberExpression GetPropertyExpression<T>(this string fieldOrPropertyName, ParameterExpression parameterExpression)
        {
            var property = (typeof(T)).GetProperties().FirstOrDefault(p => p.Name.ToLowerInvariant() == fieldOrPropertyName.ToLowerInvariant());
            if (property is null)
            {
                throw new InvalidOperationException($"Can't find property {fieldOrPropertyName} on type {typeof(T).FullName}");
            }

            return Expression.PropertyOrField(parameterExpression, property.Name);
        }

        /// <summary>
        /// Gets an expression for selecting property
        /// </summary>
        /// <param name="fieldOrPropertyName">Name of the property or field</param>
        /// <typeparam name="T">Object type</typeparam>
        /// <returns>Property selection expression</returns>
        public static Expression<Func<T, object>> GetSelectExpression<T>(this string fieldOrPropertyName)
        {
            var property = (typeof(T)).GetProperties().FirstOrDefault(p => p.Name.ToLowerInvariant() == fieldOrPropertyName.ToLowerInvariant());
            if (property is null)
            {
                throw new InvalidOperationException($"Can't find property {fieldOrPropertyName} on type {typeof(T).FullName}");
            }

            var parameter = Expression.Parameter(typeof(T), "item");
            var body = Expression.Convert(Expression.PropertyOrField(parameter, property.Name), typeof(object));
            return Expression.Lambda<Func<T, object>>(body, parameter);
        }

        /// <summary>
        /// Formats phone number in (000) 000-0000 format
        /// </summary>
        /// <param name="phoneNumber">Phone number to format</param>
        /// <returns>Formatted phone number</returns>
        public static string FormatPhoneNumber(this string phoneNumber) => Regex.Replace(phoneNumber, @".*(\d{3}).*(\d{3}).*(\d{4}).*", "($1) $2-$3");

        /// <summary>
        /// Checks whether two dates are equal up to the minutes (disregards seconds and milliseconds)
        /// </summary>
        /// <param name="left">First date</param>
        /// <param name="right">Second date</param>
        /// <returns>Whether two dates are equal up to the minutes</returns>
        public static bool EqualsToMinute(this DateTime left, DateTime right) => left.Date.AddHours(left.Hour).AddMinutes(left.Minute) == right.Date.AddHours(right.Hour).AddMinutes(right.Minute);

        private static bool IsNullOrEmpty(PropertyInfo property, object obj)
        {
            var value = property.GetValue(obj);
            if (value is null) return true;

            var type = property.PropertyType;
            if (type == typeof(string)) return (value as string).IsNullOrEmpty();
            if (type.IsArray) return (value as IEnumerable).IsNullOrEmpty();
            if (type == typeof(bool)) return !(bool)value;
            if (type.IsPrimitive) return value.Equals(0);

            return false;
        }
    }
}
