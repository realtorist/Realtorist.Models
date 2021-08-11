using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Enums
{
    /// <summary>
    /// Describes customer request type
    /// </summary>
    public enum RequestType
    {
        [Display(Name = "Generic")]
        Generic = 0,
        [Display(Name = "Tell me more about the property")]
        TellMeMore = 1,
        [Display(Name = "Request a showing")]
        Showing,
        [Display(Name = "Neighbourhood information")]
        NeighbourhoodInformation,
        [Display(Name = "Recent sales in area")]
        RecentSalesInArea,
        [Display(Name = "What's my house worth")]
        WhatsMyHouseWorths,
        [Display(Name = "Create account")]
        CreateAccount
    }
}
