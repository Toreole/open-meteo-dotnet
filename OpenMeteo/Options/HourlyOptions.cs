using System;

namespace OpenMeteo.Options
{
    /// <summary>
    /// Which hourly variables to get defined by <see cref="HourlyOptionsParameter"/>
    /// </summary>
    public class HourlyOptions : EnumOptionsBase<HourlyOptionsParameter>
	{
		/// <summary>
		/// Get an instance of HourlyOptions with all HourlyOptionsParameter values set.
		/// </summary>
		public static HourlyOptions All
		{
            get
			{
                return new HourlyOptions((Enum[])Enum.GetValues(typeof(HourlyOptionsParameter)));
			}
		}

		/// <summary>
		/// Create HourlyOptions with a predefined array of values
		/// </summary>
		/// <param name="values"></param>
		public HourlyOptions(Enum[] values) : base(values) { }

		/// <summary>
		/// Create HourlyOptions with one value
		/// </summary>
		/// <param name="value"></param>
		public HourlyOptions(Enum value) : base(value) { }

		/// <summary>
		/// Create the default HourlyOptions. See EnumOptionsBase.
		/// </summary>
		public HourlyOptions() : base() { }
	}

	/// <summary>
	/// See https://open-meteo.com/en/docs.
    /// Available Parameters for Hourly (and Current) Variables.
	/// </summary>
	public enum HourlyOptionsParameter
    {
        /// <summary>
        /// Air temperature at 2 meters above ground
        /// </summary>
        temperature_2m,
        /// <summary>
        /// Relative humidity at 2 meters above ground
        /// </summary>
        relative_humidity_2m,
        /// <summary>
        /// Dew point temperature at 2 meters above ground
        /// </summary>
        dewpoint_2m,
        /// <summary>
        /// Apparent temperature is the perceived feels-like temperature combining wind chill factor, relative humidity and solar radiation
        /// </summary>
        apparent_temperature,
        /// <summary>
        /// Atmospheric air pressure reduced to mean sea level
        /// </summary>
		pressure_msl,
        /// <summary>
        /// Atmospheric pressure at surface. Gets lower with increasing elevation.
        /// </summary>
		surface_pressure,
        /// <summary>
        /// Total cloud cover as an area fraction
        /// </summary>
		cloud_cover,
        /// <summary>
        /// Low level clouds and fog up to 3km altitude
        /// </summary>
		cloud_cover_low,
        /// <summary>
        /// Mid level cloud from 3 to 8km altitude
        /// </summary>
		cloud_cover_mid,
        /// <summary>
        /// High level clouds from 8km altitude
        /// </summary>
		cloud_cover_high,
        /// <summary>
        /// Wind speed at 10m above ground. Standard level.
        /// </summary>
		wind_speed_10m,
        /// <summary>
        /// Wind speed at 80m above ground.
        /// </summary>
		wind_speed_80m,
        /// <summary>
        /// Wind speed at 120m above ground
        /// </summary>
		wind_speed_120m,
        /// <summary>
        /// Wind speed at 180m above ground
        /// </summary>
		wind_speed_180m,
        /// <summary>
        /// Wind direction at 10m above ground
        /// </summary>
		wind_direction_10m,
		/// <summary>
		/// Wind direction at 80m above ground
		/// </summary>
		wind_direction_80m,
		/// <summary>
		/// Wind direction at 120m above ground
		/// </summary>
		wind_direction_120m,
		/// <summary>
		/// Wind direction at 180m above ground
		/// </summary>
		wind_direction_180m,
        /// <summary>
        /// Gusts at 10m above ground as a maximum of the preceeding hour
        /// </summary>
		wind_gusts_10m,
        /// <summary>
        /// Shortwave solar radiation as average of the preceeding hour. This is equal to the total global horizontal irradiation
        /// </summary>
		shortwave_radiation,
		/// <summary>
		/// Direct solar radiation as average of the preceding hour on the horizontal plane and the normal plane (perpendicular to the sun)
		/// </summary>
		direct_radiation,
		/// <summary>
		/// Direct solar radiation as average of the preceding hour on the horizontal plane and the normal plane (perpendicular to the sun)
		/// </summary>
		direct_normal_irradiance,
		/// <summary>
		/// Diffuse solar radiation as average of the preceding hour
		/// </summary>
		diffuse_radiation,
		/// <summary>
		/// Total radiation received on a tilted pane as average of the preceding hour. 
        /// The calculation is assuming a fixed albedo of 20% and in isotropic sky. 
        /// Please specify tilt and azimuth parameter. 
        /// Tilt ranges from 0° to 90° and is typically around 45°.
        /// Azimuth should be close to 0° (0° south, -90° east, 90° west). If azimuth is set to "nan", the calculation assumes a horizontal tracker. 
        /// If tilt is set to "nan", it is assumed that the panel has a vertical tracker. 
        /// If both are set to "nan", a bi-axial tracker is assumed.
		/// </summary>
		global_tilted_irradiance,
		/// <summary>
		/// Vapour Pressure Deficit (VPD) in kilopascal (kPa). 
        /// For high VPD (above 1.6), water transpiration of plants increases. For low VPD (below 0.4), transpiration decreases
		/// </summary>
		vapour_pressure_deficit,
		/// <summary>
		/// Convective available potential energy. See <see href="https://en.wikipedia.org/wiki/Convective_available_potential_energy"/>
		/// </summary>
		cape,
		/// <summary>
		/// Evapotranspration from land surface and plants that weather models assumes for this location. 
        /// Available soil water is considered.
        /// 1 mm evapotranspiration per hour equals 1 liter of water per spare meter.
		/// </summary>
		evapotranspiration,
		/// <summary>
		/// ET₀ Reference Evapotranspiration of a well watered grass field. 
        /// Based on FAO-56 Penman-Monteith equations ET₀ is calculated from temperature, wind speed, humidity and solar radiation. 
        /// Unlimited soil water is assumed. ET₀ is commonly used to estimate the required irrigation for plants.
		/// </summary>
		et0_fao_evapotranspiration,
		/// <summary>
		/// Total precipitation (rain, showers, snow) sum of the preceding hour
		/// </summary>
		precipitation,
		/// <summary>
		/// Snowfall amount of the preceding hour in centimeters. 
		/// For the water equivalent in millimeter, divide by 7. E.g. 7 cm snow = 10 mm precipitation water equivalent
		/// </summary>
		snowfall,
		/// <summary>
		/// Probability of precipitation with more than 0.1 mm of the preceding hour. 
		/// Probability is based on ensemble weather models with 0.25° (~27 km) resolution. 
		/// 30 different simulations are computed to better represent future weather conditions.
		/// </summary>
		precipitation_probability,
		/// <summary>
		/// Rain from large scale weather systems of the preceding hour in millimeter
		/// </summary>
		rain,
		/// <summary>
		/// Showers from convective precipitation in millimeters from the preceding hour
		/// </summary>
		showers,
		/// <summary>
		/// Weather condition as a numeric code. Follow WMO weather interpretation codes.
		/// </summary>
		weather_code,
		/// <summary>
		/// Snow depth on the ground
		/// </summary>,
		/// 
		snow_depth,
		/// <summary>
		/// Altitude above sea level of the 0°C level
		/// </summary>
		freezing_level_height,
		/// <summary>
		/// Viewing distance in meters. Influenced by low clouds, humidity and aerosols. Maximum visibility is approximately 24 km.
		/// </summary>
		visibility,
		/// <summary>
		/// Temperature in the soil at 0cm depth
		/// </summary>
		soil_temperature_0cm,
		/// <summary>
		/// Temperature in the soil at 6cm depth
		/// </summary>
		soil_temperature_6cm,
		/// <summary>
		/// Temperature in the soil at 18cm depth
		/// </summary>
		soil_temperature_18cm,
		/// <summary>
		/// Temperature in the soil at 54cm depth
		/// </summary>
		soil_temperature_54cm,
		/// <summary>
		/// Average soil water content as volumetric mixing ratio at 0-1cm depth
		/// </summary>
		soil_moisture_0_to_1cm,
		/// <summary>
		/// Average soil water content as volumetric mixing ratio at 1-3cm depth
		/// </summary>
		soil_moisture_1_to_3cm,
		/// <summary>
		/// Average soil water content as volumetric mixing ratio at 3-9cm depth
		/// </summary>
		soil_moisture_3_to_9cm,
		/// <summary>
		/// Average soil water content as volumetric mixing ratio at 9-27cm depth
		/// </summary>
		soil_moisture_9_to_27cm,
		/// <summary>
		/// Average soil water content as volumetric mixing ratio at 27-81cm depth
		/// </summary>
		soil_moisture_27_to_81cm,
		/// <summary>
		/// 1 if the current time step has daylight, 0 at night.
		/// </summary>
		is_day
	}
}