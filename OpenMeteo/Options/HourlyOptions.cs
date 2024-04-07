using System;

namespace OpenMeteo.Options
{
    /// <summary>
    /// Which hourly variables to get defined by <see cref="HourlyOptionsParameter"/>
    /// </summary>
    public class HourlyOptions : EnumOptionsBase<HourlyOptionsParameter> 
    {
		public static HourlyOptions All
		{
            get
			{
                return new HourlyOptions((Enum[])Enum.GetValues(typeof(HourlyOptionsParameter)));
			}
		}

        public HourlyOptions(Enum[] values) : base(values) { }
		public HourlyOptions(Enum value) : base(value) { }
		public HourlyOptions() : base() { }
	}

    // This is converted to string so it has to be the exact same name like in 
    // https://open-meteo.com/en/docs #Hourly Parameter Definition
    public enum HourlyOptionsParameter
    {
        temperature_2m,
        relativehumidity_2m,
        dewpoint_2m,
        apparent_temperature,

        precipitation,
        rain,
        showers,
        snowfall,
        snow_depth,

        freezing_level_height,
        weather_code,
        pressure_msl,
        surface_pressure,
        cloud_cover,
        cloud_cover_low,
        cloud_cover_mid,
        cloud_cover_high,
        visibility,
        evapotranspiration,
        et0_fao_evapotranspiration,
        vapor_pressure_deficit,
        cape,

        windspeed_10m,
        windspeed_80m,
        windspeed_120m,
        windspeed_180m,
        winddirection_10m,
        winddirection_80m,
        winddirection_120m,
        winddirection_180m,
        windgusts_10m,

        soil_temperature_0cm,
        soil_temperature_6cm,
        soil_temperature_18cm,
        soil_temperature_54cm,
        soil_moisture_0_1cm,
        soil_moisture_1_3cm,
        soil_moisture_3_9cm,
        soil_moisture_9_27cm,
        soil_moisture_27_81cm,

        shortwave_radiation,
        direct_radiation,
        diffuse_radiation,
        direct_normal_irradiance,
        terrestrial_radiation,
        global_tilted_irradiance,
        shortwave_radiation_instant,
        direct_radiation_instant,
        diffuse_radiation_instant,
        direct_normal_irradiance_instant,
        terrestrial_radiation_instant,

        is_day,
        uv_index,
        uv_index_clear_sky,
        precipitation_probability

    }
}