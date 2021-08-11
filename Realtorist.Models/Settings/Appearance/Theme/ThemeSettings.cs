using System.Collections.Generic;
using Realtorist.Models.Settings.Appearance.Menu;

namespace Realtorist.Models.Settings.Appearance.Theme
{
    /// <summary>
    /// Describes settings for the default theme
    /// </summary>
    public class ThemeSettings
    {
        public MenuItemSingle[] FooterMenu { get; set; } = new MenuItemSingle[0];

        public MenuItemWithChildren[] HeaderMenu { get; set; } = new MenuItemWithChildren[0];

        public Dictionary<string, string> StyleOverrides { get; set; } = new Dictionary<string, string>();

        public string AdditionalCss { get; set; } 

        public string HeroTitle { get; set; }

        public string HeroLogo { get; set; }

        public string HeroSubTitle { get; set; }
    }
}