using System;

namespace OpenMeteo.Options
{
	/// <summary>
	/// CurrentOptions use the <see cref="CurrentOptionsParameter"/> Enum by default.
	/// But all values from <see cref="HourlyOptionsParameter"/> are available aswell.
	/// </summary>
	public class CurrentOptions : EnumOptionsBase<CurrentOptionsParameter>
    {
        /// <summary>
        /// Get an instance of CurrentOptions with all CurrentOptionsParameter values set.
        /// </summary>
		public static CurrentOptions All
		{
			get
			{
				return new CurrentOptions((Enum[])Enum.GetValues(typeof(CurrentOptionsParameter)));
			}
		}

        /// <summary>
        /// Create CurrentOptions with a predefined array of values
        /// </summary>
        /// <param name="values"></param>
		public CurrentOptions(Enum[] values) : base(values) { }

        /// <summary>
        /// Create CurrentOptions with one value
        /// </summary>
        /// <param name="value"></param>
		public CurrentOptions(Enum value) : base(value) { }

        /// <summary>
        /// Create the default CurrentOptions. See EnumOptionsBase.
        /// </summary>
		public CurrentOptions() : base() { }
	}

	/// <summary>
	/// Parameters for CurrentOptions that are guaranteed (within reason) to be available through the API.
	/// Full documentation on these Options is available at https://open-meteo.com/en/docs and also included with <see cref="HourlyOptionsParameter"/> due to a large overlap.
	/// </summary>
	public enum CurrentOptionsParameter
    {
#pragma warning disable CS1591
        temperature_2m,
        relative_humidity_2m,
        apparent_temperature,
        is_day, 
        precipitation,
        rain,
        showers,
        snowfall,
        weather_code,
        cloud_cover,
        pressure_msl,
        surface_pressure,
        wind_speed_10m,
        wind_direction_10m,
        wind_gusts_10m
#pragma warning restore CS1591
    }
}
