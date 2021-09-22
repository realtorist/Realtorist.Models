using System;

namespace Realtorist.Models.Attributes
{
    /// <summary>
    /// Marks property of the <see cref="PropertyDetails"/> as summary field
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class SummaryPropertyAttribute : Attribute
    {
        /// <summary>
        /// Creates new instance of <see cref="SummaryPropertyAttribute"/>
        /// </summary>
        /// <param name="order">Order of the propery</param>
        public SummaryPropertyAttribute(int order)
        {
            Order = order;
        }

        /// <summary>
        /// Order of the property on page
        /// </summary>
        public int Order { get; }

    }
}
