namespace OpenMeteo.Options
{
    /// <summary>
    /// Geocoding Options for obtaining Latitude/Longitude and other info via Querying the Geocoding API.
    /// </summary>
    public class GeocodingOptions
    {
        /// <summary>
        /// Location to search for.
        /// </summary>
        /// <value></value>
        public string Name { get; }

        /// <summary>
        /// Return translated results, if available, otherwise return english or the native location name. 
        /// Lower-cased.
        /// Default is: "en"
        /// </summary>
        /// <value></value>
        public string Language { get; }

        /// <summary>
        /// Default is "json".
        /// </summary>
        /// <value></value>
        public string Format { get; }

        /// <summary>
        /// The number of search results to return.
        /// Default is 10. Up to 100 can be retrieved.
        /// </summary>
        /// <value></value>
        public int Count { get; }

        /// <summary>
        /// Create Geocoding Options for a specific city and language
        /// </summary>
        /// <param name="city"></param>
        /// <param name="language"></param>
        /// <param name="count"></param>
        public GeocodingOptions(string city, string language, int count)
        {
            Name = city;
            Language = language;
            Format = "json";
            Count = count;
        }

        /// <summary>
        /// Create Geocoding Options for a city.
        /// </summary>
        /// <param name="city"></param>
        public GeocodingOptions(string city)
        {
            Name = city;
            Language = "en";
            Format = "json";
            Count = 100;
        }
    }
}
