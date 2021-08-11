using System;

namespace Realtorist.Models.Models
{
    /// <summary>
    /// Describes boundaries of the map
    /// </summary>
    public class CoordinateBoundaries
    {
        /// <summary>
        /// Top left coordinates
        /// </summary>
        public Coordinates NorthEast { get; set; }

        /// <summary>
        /// Bottom right coordinates
        /// </summary>
        public Coordinates SouthWest { get; set; }

        /// <summary>
        /// Creates boundaries from a point and a distance in meters to the corner
        /// </summary>
        /// <param name="center">Center point</param>
        /// <param name="distanceToCornerInMeters">Distance in meters to the corner</param>
        /// <returns>Boundaries</returns>
        public static CoordinateBoundaries FromCenterAndDistanceToCorner(Coordinates center, double distanceToCornerInMeters)
        {
            if (center == null) throw new ArgumentNullException(nameof(center));

            var latAccuracy = 360d * distanceToCornerInMeters / 40075017;
            var lngAccuracy = latAccuracy / Math.Cos((Math.PI / 180) * center.Latitude);

            return new CoordinateBoundaries
            {
                SouthWest = new Coordinates(center.Latitude - latAccuracy, center.Longitude - lngAccuracy),
                NorthEast = new Coordinates(center.Latitude + latAccuracy, center.Longitude + lngAccuracy)
            };
        }
    }
}
