using Realtorist.Models.Attributes;
using Realtorist.Models.Listings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Realtorist.Models.Helpers
{
    /// <summary>
    /// Provides different helpers to work with property details
    /// </summary>
    public static class PropertyExtensions
    {
        /// <summary>
        /// Gets formated string with price and unit/duration if needed
        /// </summary>
        /// <param name="details">Property details</param>
        /// <returns>Formated price with additional info</returns>
        public static string GetPriceString(this Listing details)
        {
            var sb = new StringBuilder();
            sb.Append(details.Price.FormatPrice());


            if (details.PricePerTime.HasValue)
            {
                sb.Append(' ');
                sb.Append(details.PricePerTime.Value.GetLookupDisplayText());
            }

            if (details.PricePerUnit.HasValue)
            {
                sb.Append(" / ");
                sb.Append(details.PricePerUnit.Value.GetLookupDisplayText());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Gets map of summary properties with values for the Property details
        /// </summary>
        /// <param name="listing">Property details</param>
        /// <returns>Map of property name - property value</returns>
        public static IDictionary<string, string> GetPropertySummary(this Listing listing)
        {
            return GetPropertiesForSummary(listing)
                .OrderBy(p => p.order)
                .ToDictionary(p => p.property, p => p.value);
        }

        private static IEnumerable<(string property, string value, int order)> GetPropertiesForSummary(object obj)
        {
            var main = obj.GetType()
                .GetProperties()
                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType == typeof(SummaryPropertyAttribute)))
                .Where(p => p.GetValue(obj) != null)
                .Select(p => (p.GetPropertyDisplayName(), p.GetValue(obj).ToDisplayString(), (((SummaryPropertyAttribute)(p.GetCustomAttributes(typeof(SummaryPropertyAttribute), true).First())).Order)));

            var complex = obj.GetType()
                .GetProperties()
                .Where(p => p.PropertyType.IsClass && p.PropertyType.Assembly.FullName == Assembly.GetExecutingAssembly().FullName)
                .Where(p => p.GetValue(obj) != null)
                .SelectMany(p => GetPropertiesForSummary(p.GetValue(obj)));

            return main.Union(complex);
        }

        /// <summary>
        /// Gets map of details properties with values for the Property details grouped by group name
        /// </summary>
        /// <param name="listing">Property details</param>
        /// <returns>Map of property name - property value, grouped by group name</returns>
        public static IDictionary<string, IDictionary<string, string>> GetPropertyDetails(this Listing listing)
        {
            return GetPropertiesForDetails(listing, string.Empty)
                .GroupBy(x => x.group)
                .OrderBy(x => x.Key)
                .ToDictionary(p => p.Key, p => (IDictionary<string, string>)p.ToDictionary(v => v.property, v => v.value.ToDisplayString()));
        }

        private static IEnumerable<(string property, string value, string group)> GetPropertiesForDetails(object obj, string property)
        {
            var main = obj.GetType()
                .GetProperties()
                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType == typeof(DisplayablePropertyAttribute))
                    && p.GetValue(obj) != null
                    && (!p.PropertyType.IsArray || (p.GetValue(obj) as Array).Length > 0))
                .Select(p => (p.GetPropertyDisplayName(), p.GetValue(obj).ToDisplayString(), GetGroupName(p, property)));

            var complex = obj.GetType()
                .GetProperties()
                .Where(p => p.PropertyType.IsClass 
                    && p.PropertyType.Assembly.FullName == Assembly.GetExecutingAssembly().FullName
                    && p.GetValue(obj) != null 
                    && (!p.PropertyType.IsArray || (p.GetValue(obj) as Array).Length > 0))
                .SelectMany(p => GetPropertiesForDetails(p.GetValue(obj), p.Name));

            return main.Union(complex);
        }

        private static string GetGroupName(PropertyInfo property, string fallback)
        {
            var displayAttribute = property.GetCustomAttributes(typeof(DisplayAttribute), true).FirstOrDefault() as DisplayAttribute;
            if (displayAttribute != null && !string.IsNullOrWhiteSpace(displayAttribute.GroupName))
            {
                return displayAttribute.GroupName;
            }

            return fallback;
        }

        /// <summary>
        /// Gets all array properties including nested that should be displayed as a table
        /// </summary>
        /// <param name="listing">Property details</param>
        /// <returns>Array properties that should be displayed as a table</returns>
        public static IDictionary<string, object[]> GetTableProperties(this Listing listing)
        {
            return GetTableProperiesForObject(listing).ToDictionary(x => x.name, x => x.array);
        }

        private static IEnumerable<(string name, object[] array)> GetTableProperiesForObject(object obj)
        {
            var main = obj.GetType()
                .GetProperties()
                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType == typeof(TableViewAttribute)))
                .Where(p => p.PropertyType.IsArray && p.GetValue(obj) != null && (p.GetValue(obj) as Array).Length > 0)
                .Select(p => (p.GetPropertyDisplayName(), p.GetValue(obj) as object[]));

            var complex = obj.GetType()
                .GetProperties()
                .Where(p => p.PropertyType.IsClass && p.PropertyType.Assembly.FullName == Assembly.GetExecutingAssembly().FullName)
                .Where(p => p.GetValue(obj) != null)
                .SelectMany(p => GetTableProperiesForObject(p.GetValue(obj)));

            return main.Union(complex);
        }
    }
}
