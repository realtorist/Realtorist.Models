using System.Diagnostics.CodeAnalysis;
using Realtorist.Models.Geo;

namespace Realtorist.Models.Listings.Details
{
    public class Address
    {
        /// <summary>
        /// This field returns a formatted street address. It may contain a vertical bar (|) line delimiter if address contains multiple lines.
        /// It includes the following address fields if available: AdditionalStreetInfo,
        /// UnitNumber,
        /// StreetNumber, StreetDirectionPrefix, StreetName, StreetSuffix, StreetDirectionSuffix, BoxNumber,
        /// 
        /// If the above fields do not yield a valid street Address, the following fields will be included instead (if available)
        /// 
        /// AdditionalStreetInfo, UnitNumber, AddressLine1,
        /// AddressLine2
        /// </summary>
        [MaybeNull]
        public string StreetAddress { get; set; }

        /// <summary>
        /// The first address line of the address
        /// </summary>
        [MaybeNull]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The second address line of the address
        /// </summary>
        [MaybeNull]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The building number in the address
        /// </summary>
        [MaybeNull]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Directional indicator that precedes the street name
        /// </summary>
        [MaybeNull]
        public string StreetDirectionPrefix { get; set; }

        /// <summary>
        /// Official name of the street in the address
        /// </summary>
        [MaybeNull]
        public string StreetName { get; set; }

        /// <summary>
        /// The street type
        /// </summary>
        [MaybeNull]
        public string StreetSuffix { get; set; }

        /// <summary>
        /// Directional indicator that follows a street name
        /// </summary>
        [MaybeNull]
        public string StreetDirectionSuffix { get; set; }

        /// <summary>
        /// Apartment, suite or office number portion of a postal address
        /// </summary>
        [MaybeNull]
        public string UnitNumber { get; set; }

        /// <summary>
        /// Post office box if applicable
        /// </summary>
        [MaybeNull]
        public string BoxNumber { get; set; }

        /// <summary>
        /// City of the address
        /// </summary>
        [MaybeNull]
        public string City { get; set; }

        /// <summary>
        /// Province of the address
        /// </summary>
        [MaybeNull]
        public string Province { get; set; }

        /// <summary>
        /// Postal code of the address
        /// </summary>
        [MaybeNull]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country of the address
        /// </summary>
        [MaybeNull]
        public string Country { get; set; }

        /// <summary>
        /// Additional information about the street
        /// </summary>
        [MaybeNull]
        public string AdditionalStreetInfo { get; set; }

        /// <summary>
        /// Community name of the address
        /// </summary>
        [MaybeNull]
        public string CommunityName { get; set; }

        /// <summary>
        /// Neighbourhood name of the address
        /// </summary>
        [MaybeNull]
        public string Neighbourhood { get; set; }

        /// <summary>
        /// Subdivision name of the address
        /// </summary>
        [MaybeNull]
        public string Subdivision { get; set; }

        /// <summary>
        /// Coordinates
        /// </summary>
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Gets display string for the address
        /// </summary>
        public string AddressDisplayString => StreetAddress + ", " + City + ", " + Province + ", " + PostalCode;

        /// <summary>
        /// Checks if two addresses are equal except the coordinates
        /// </summary>
        /// <param name="address">Another address</param>
        /// <returns>If two addresses are equal except the coordinates</returns>
        public bool EqualsNoCoordinates(Address address)
        {
            return StreetAddress == address.StreetAddress &&
                   AddressLine1 == address.AddressLine1 &&
                   AddressLine2 == address.AddressLine2 &&
                   StreetNumber == address.StreetNumber &&
                   StreetDirectionPrefix == address.StreetDirectionPrefix &&
                   StreetName == address.StreetName &&
                   StreetSuffix == address.StreetSuffix &&
                   StreetDirectionSuffix == address.StreetDirectionSuffix &&
                   UnitNumber == address.UnitNumber &&
                   BoxNumber == address.BoxNumber &&
                   City == address.City &&
                   Province == address.Province &&
                   PostalCode == address.PostalCode &&
                   Country == address.Country &&
                   AdditionalStreetInfo == address.AdditionalStreetInfo &&
                   CommunityName == address.CommunityName &&
                   Neighbourhood == address.Neighbourhood &&
                   Subdivision == address.Subdivision;
        }
    }
}