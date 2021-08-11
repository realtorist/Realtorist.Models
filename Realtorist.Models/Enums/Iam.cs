using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Enums
{
    /// <summary>
    /// Describes customer in request form
    /// </summary>
    public enum Iam
    {
        [Display(Name = "Buyer & Seller")]
        BuyerSeller = 0,
        [Display(Name = "Seller")]
        Seller,
        [Display(Name = "Buyer")]
        Buyer,
        [Display(Name = "Renter")]
        Renter
    }
}
