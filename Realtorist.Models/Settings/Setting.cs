namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Descrines generic setting stored in database
    /// </summary>
    public class Setting
    {
        /// <summary>
        /// Setting type
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Setting value
        /// </summary>
        public dynamic Value { get; set; }
    }
}