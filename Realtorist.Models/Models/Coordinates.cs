namespace Realtorist.Models.Models
{
    /// <summary>
    /// Describes coordinates
    /// </summary>
    public class Coordinates
    {
        /// <summary>
        /// Creates new instance of <see cref="Coordinates"/>
        /// </summary>
        public Coordinates()
        {
        }

        /// <summary>
        /// Creates new instance of <see cref="Coordinates"/>
        /// </summary>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        public Coordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        /// <summary>
        /// Latitude
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        public double Longitude { get; set; }
    }
}
