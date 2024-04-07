using System;

namespace OpenMeteo.Options
{
	/// <summary>
	/// API Options for Daily variables.
	/// </summary>
    public class DailyOptions : EnumOptionsBase<DailyOptionsParameter>
    {
		/// <summary>
		/// Get an instance of DailyOptions with all DailyOptionsParameter values set.
		/// </summary>
		public static DailyOptions All
		{
			get
			{
				return new DailyOptions((Enum[])Enum.GetValues(typeof(DailyOptionsParameter)));
			}
		}

		/// <summary>
		/// Create DailyOptions with a predefined array of values
		/// </summary>
		/// <param name="values"></param>
		public DailyOptions(Enum[] values) : base(values) { }

		/// <summary>
		/// Create DailyOptions with one value
		/// </summary>
		/// <param name="value"></param>
		public DailyOptions(Enum value) : base(value) { }

		/// <summary>
		/// Create the default DailyOptions. See EnumOptionsBase.
		/// </summary>
		public DailyOptions() : base() { }
	}

	/// <summary>
	/// See https://open-meteo.com/en/docs.
	/// Variables for entire days.
	/// </summary>
	public enum DailyOptionsParameter
    {
		/// <summary>
		/// The most severe weather condition on a given day
		/// </summary>
        weather_code,

		/// <summary>
		/// Maximum daily temperature at 2 meters above ground
		/// </summary>
        temperature_2m_max,
		/// <summary>
		/// Minimum daily temperature at 2 meters above ground
		/// </summary>
        temperature_2m_min,
		/// <summary>
		/// Maximum daily apparent temperature
		/// </summary>
        apparent_temperature_max,
		/// <summary>
		/// Minimum daily apparent temperature
		/// </summary>
		apparent_temperature_min,
		/// <summary>
		/// iso8601 sun rise time
		/// </summary>
        sunrise,
		/// <summary>
		/// iso8601 sun set time
		/// </summary>
		sunset,
		/// <summary>
		/// Sum of daily precipitation (including rain, showers and snowfall)
		/// </summary>
        precipitation_sum,
		/// <summary>
		/// Sum of daily rain
		/// </summary>
        rain_sum,
		/// <summary>
		/// Sum of daily showers
		/// </summary>
        showers_sum,
		/// <summary>
		/// Sum of daily snowfall
		/// </summary>
        snowfall_sum,
		/// <summary>
		/// The numbers of hours with rain
		/// </summary>
        precipitation_hours,
		/// <summary>
		/// Maximum wind speed on a day
		/// </summary>
        windspeed_10m_max,
		/// <summary>
		/// Maximum wind gust speed on a day
		/// </summary>
        windgusts_10m_max,
		/// <summary>
		/// Dominant wind direction
		/// </summary>
        winddirection_10m_dominant,
		/// <summary>
		/// The sum of solar radiation on a given day in Megajoules
		/// </summary>
        shortwave_radiation_sum,
		/// <summary>
		/// Daily sum of ET0 Reference Evapotranspiration of a well watered grass field
		/// </summary>
        et0_fao_evapotranspiration,
		/// <summary>
		/// Number of seconds of daylight per day
		/// </summary>
		daylight_duration,
		/// <summary>
		/// The number of seconds of sunshine per day is determined by calculating direct normalized irradiance exceeding 120W/m², following the WMO definition.
		/// Sunshine duration will consistently be less than daylight duration due to dawn and dusk.
		/// </summary>
		sunshine_duration,
		/// <summary>
		/// Daily maximum in UV Index starting from 0.
		/// </summary>
		uv_index_max,
		/// <summary>
		/// Assumes cloud free conditions. Please follow the official WMO guidelines for ultratiolet index.
		/// </summary>
		uv_index_clear_sky_max
    }
}
