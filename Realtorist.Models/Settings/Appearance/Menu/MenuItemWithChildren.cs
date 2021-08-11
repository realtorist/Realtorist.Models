namespace Realtorist.Models.Settings.Appearance.Menu
{
    /// <summary>
    /// Describes single menu item
    /// </summary>
    public class MenuItemWithChildren : MenuItemSingle
    {
        /// <summary>
        /// Child links i.e for dropdown
        /// </summary>
        public MenuItemSingle[] Children { get; set; }
    }
}