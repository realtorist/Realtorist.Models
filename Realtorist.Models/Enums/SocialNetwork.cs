using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Enums
{
    /// <summary>
    /// Types of the supported social networks for social links
    /// </summary>
    public enum SocialNetwork
    {
        [Display(Name = "Facebook")]
        Facebook = 0,

        [Display(Name = "Instagram")]
        Instagram = 1,

        [Display(Name = "Twitter")]
        Twitter = 2,

        [Display(Name = "Linkedin")]
        Linkedin = 3
    }
}
