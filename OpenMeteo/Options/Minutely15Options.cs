using System;

namespace OpenMeteo.Options
{
	/// <summary>
	/// Which 15minutely variables to get defined by <see cref="Minutely15OptionsParameter"/> <br/>
	/// 15-minutely data can be requested for other weather variables that are available for hourly data, but will use interpolation.
	/// </summary>
	public class Minutely15Options : EnumOptionsBase<Minutely15OptionsParameter>
	{
		/// <summary>
		/// Get an instance of Minutely15Options with all HourlyOptionsParameter values set.
		/// </summary>
		public static Minutely15Options All
		{
			get
			{
				return new Minutely15Options((Enum[])Enum.GetValues(typeof(Minutely15OptionsParameter)));
			}
		}

		/// <summary>
		/// Create Minutely15Options with a predefined array of values
		/// </summary>
		/// <param name="values"></param>
		public Minutely15Options(Enum[] values) : base(values) { }

		/// <summary>
		/// Create Minutely15Options with one value
		/// </summary>
		/// <param name="value"></param>
		public Minutely15Options(Enum value) : base(value) { }

		/// <summary>
		/// Create the default Minutely15Options. See EnumOptionsBase.
		/// </summary>
		public Minutely15Options() : base() { }

	}

	/// <summary>
	/// Mostly the same as <see cref="HourlyOptionsParameter"/>
	/// </summary>
    public enum Minutely15OptionsParameter
    {
		/// <summary>
		/// Air temperature at 2 meters above ground
		/// </summary>
		temperature_2m,
		/// <summary>
		/// Relative humidity at 2 meters above ground
		/// </summary>
		relativehumidity_2m,
		/// <summary>
		/// Dew point temperature at 2 meters above ground
		/// </summary>
		dewpoint_2m,
		/// <summary>
		/// Apparent temperature is the perceived feels-like temperature combining wind chill factor, relative humidity and solar radiation
		/// </summary>
		apparent_temperature,
		/// <summary>
		/// Shortwave solar radiation as average of the preceeding 15 minutes. This is equal to the total global horizontal irradiation
		/// </summary>
		shortwave_radiation,
		/// <summary>
		/// Direct solar radiation as average of the preceding 15 minutes on the horizontal plane and the normal plane (perpendicular to the sun)
		/// </summary>
		direct_radiation,
		/// <summary>
		/// Direct solar radiation as average of the preceding 15 minutes on the horizontal plane and the normal plane (perpendicular to the sun)
		/// </summary>
		direct_normal_irradiance,
		/// <summary>
		/// See <see cref="HourlyOptionsParameter.global_tilted_irradiance"/>
		/// </summary>
		global_tilted_irradiance,
		/// <summary>
		/// See <see cref="HourlyOptionsParameter.global_tilted_irradiance"/>
		/// </summary>
		global_tilted_irradiance_instance,
		/// <summary>
		/// Diffuse solar radiation as average of the preceding 15 minutes
		/// </summary>
		diffuse_radiation,
#pragma warning disable CS1591
		sunshine_duration,
		lightning_potential,
		precipitation,
		snowfall,
		rain,
		showers,
		snowfall_height,
		freezing_level_height,
		cape,
		wind_speed_10m,
		wind_speed_80m,
		wind_gusts_10m,
		visibility,
		weather_code
#pragma warning restore CS1591
	}
}
