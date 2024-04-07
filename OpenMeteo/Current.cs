using OpenMeteo.Options;

namespace OpenMeteo
{
    /// <summary>
    /// Api response containing information about current weather conditions
    /// </summary>
    public class Current
    {
        public string? Time { get; set; }

        public int? Interval { get; set; }

        /// <summary>
        /// Temperature in <see cref="WeatherForecastOptions.Temperature_Unit"/>
        /// </summary>
        public float? Temperature { get { return Temperature_2m; } private set { } } 

        public float? Temperature_2m { get; set; }

        /// <summary>
        /// WMO Weather interpretation code.
        /// To get an actual string representation use <see cref="OpenMeteo.OpenMeteoClient.WeathercodeToString(int)"/>
        /// </summary>
        public int? Weathercode { get; set; }

        /// <summary>
        /// Windspeed. Unit defined in <see cref="WeatherForecastOptions.Windspeed_Unit"/>
        /// </summary>
        /// <value></value>
        public float? Windspeed_10m { get; set; }

		/// <summary>
		/// Wind direction in degrees
		/// </summary>
		public int? Winddirection_10m { get; set; }
		public float? Windgusts_10m { get; set; }

        public int? Relative_humidity_2m { get; set; }
        public float? Apparent_temperature { get; set; }
        public int? Is_day { get; set; }
        public float? Precipitation { get; set; }
        public float? Rain { get; set; }
        public float? Showers { get; set; }
        public float? Snowfall { get; set; }
        public int? Cloud_cover { get; set; }
        public float? Pressure_msl { get; set; }
        public float? Surface_pressure { get; set; }

        //taken from other available options via HourlyOptionsParam
        public float? Cloud_cover_low { get; set; }
		public float? Cloud_cover_mid { get; set; }
		public float? Cloud_cover_high { get; set; }

		public float? Windspeed_80m { get; set; }
		public float? Windspeed_120m { get; set; }
		public float? Windspeed_180m { get; set; }
		public int? Winddirection_80m { get; set; }
		public int? Winddirection_120m { get; set; }
		public int? Winddirection_180m { get; set; }

        public float? Shortwave_radiation { get; set; }

		public float? Direct_radiation { get; set; }
		public float? Direct_normal_irradiance { get; set; }

		public float? Diffuse_radiation { get; set; }

		public float? Global_tilted_irradiance { get; set; }

		public float? Vapour_pressure_deficit { get; set; }

		public float? Cape { get; set; }

		public float? Evapotranspiration { get; set; }

		public float? Et0_fao_evapotranspiration { get; set; }

		public float? Precipitation_probability { get; set; }
		public float? Snow_depth { get; set; }
		public float? Freezing_level_height { get; set; }
		public float? Visibility { get; set; }

		public float? Soil_temperature_0cm { get; set; }
		public float? Soil_temperature_6cm { get; set; }
		public float? Soil_temperature_18cm { get; set; }
		public float? Soil_temperature_54cm { get; set; }

		public float? Soil_moisture_0_to_1cm { get; set; }
		public float? Soil_moisture_1_to_3cm { get; set; }
		public float? Soil_moisture_3_to_9cm { get; set; }
		public float? Soil_moisture_9_to_27cm { get; set; }
		public float? Soil_moisture_27_to_81cm { get; set; }
	}
}
