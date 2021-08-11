using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Search.Enums
{
    /// <summary>
    /// Describes transaction type for the searches
    /// </summary>
    public enum TransactionTypeSearch
    {
        /// <summary>
        /// For sale
        /// </summary>
        [Display(Name = "For sale")]
        ForSale,

        /// <summary>
        /// For rent
        /// </summary>
        [Display(Name = "For rent")]
        ForRent
    }
}
