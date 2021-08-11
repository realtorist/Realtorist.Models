using Realtorist.Models.Settings.Appearance.Theme;

namespace Realtorist.Models.Settings.Appearance
{
    /// <summary>
    /// Contains type names for the appearance settings
    /// </summary>
    public static class AppearanceSettingTypes
    {
        /// <summary>
        /// Type of the current theme settings
        /// </summary>
        public const string ThemeSettings = "ThemeSettings";

        /// <summary>
        /// Type of the current theme settings
        /// </summary>
        public const string HomePageSettings = "HomePageSettings";

        static AppearanceSettingTypes()
        {
            SettingTypes.SettingTypeMap.Add(ThemeSettings, typeof(ThemeSettings));
            SettingTypes.SettingTypeMap.Add(HomePageSettings, typeof(HomePageSettings));
        }
    }
}