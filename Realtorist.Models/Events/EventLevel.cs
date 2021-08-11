namespace Realtorist.Models.Events
{
    /// <summary>
    /// Describes level of severity of the event
    /// </summary>
    public enum EventLevel
    {
        /// Information
        Info,

        /// Operation completed successfully
        Success,

        /// Warning
        Warning,

        /// Error has happened
        Error
    }
}