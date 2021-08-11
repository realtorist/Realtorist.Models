using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Search.Enums
{
    /// <summary>
    /// Describes min number of rooms (bedroom or bathroom) in search
    /// </summary>
    public enum RoomNumberSearch
    {
        /// <summary>
        /// Any number of rooms
        /// </summary>
        [Display(Name = "Any")]
        Any = 0,

        /// <summary>
        /// Exactly one room
        /// </summary>
        [Display(Name = "1")]
        One,

        /// <summary>
        /// Exactly two rooms
        /// </summary>
        [Display(Name = "2")]
        Two,

        /// <summary>
        /// Exactly three rooms
        /// </summary>
        [Display(Name = "3")]
        Three,

        /// <summary>
        /// Exactly four rooms
        /// </summary>
        [Display(Name = "4")]
        Four,

        /// <summary>
        /// Exactly five rooms
        /// </summary>
        [Display(Name = "5")]
        Five,

        /// <summary>
        /// At least one room
        /// </summary>
        [Display(Name = "1+")]
        OnePlus = 101,

        /// <summary>
        /// At least two rooms
        /// </summary>
        [Display(Name = "2+")]
        TwoPlus,

        /// <summary>
        /// At least three rooms
        /// </summary>
        [Display(Name = "3+")]
        ThreePlus,

        /// <summary>
        /// At least four rooms
        /// </summary>
        [Display(Name = "4+")]
        FourPlus,

        /// <summary>
        /// At least five rooms
        /// </summary>
        [Display(Name = "5+")]
        FivePlus
    }
}
