using Realtorist.Models.Models;
using System;

namespace Realtorist.Models.Attributes
{
    /// <summary>
    /// Marks property of the <see cref="PropertyDetails"/> as shown field
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DisplayablePropertyAttribute : Attribute
    {
    }
}
