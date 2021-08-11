namespace Realtorist.Models.Settings.Appearance.Menu
{
    /// <summary>
    /// Describes single menu item
    /// </summary>
    public class MenuItemSingle
    {
        /// <summary>
        /// Absolute or fully qualified URL for the menu
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Title for the link
        /// </summary>
        public string Title { get; set; }
    }
}