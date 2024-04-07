using System;

namespace OpenMeteo.Options
{
	/// <summary>
	/// CurrentOptions use the <see cref="CurrentOptionsParameter"/> Enum by default.
	/// But all values from <see cref="HourlyOptionsParameter"/> are available aswell.
	/// </summary>
	public class CurrentOptions : EnumOptionsBase<CurrentOptionsParameter>
    {
		public static CurrentOptions All
		{
			get
			{
				return new CurrentOptions((Enum[])Enum.GetValues(typeof(CurrentOptionsParameter)));
			}
		}

		public CurrentOptions(Enum[] values) : base(values) { }
		public CurrentOptions(Enum value) : base(value) { }
		public CurrentOptions() : base() { }
	}

    public enum CurrentOptionsParameter
    {
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
    }
}
