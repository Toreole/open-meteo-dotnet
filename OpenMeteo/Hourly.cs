using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenMeteo
{
    public class Hourly
    {
        public string[]? Time { get; set; }
        public float?[]? Temperature_2m { get; set; }
        public int?[]? Relativehumidity_2m { get; set; }
        public float?[]? Dewpoint_2m { get; set; }
        public float?[]? Apparent_temperature { get; set; }
        public float?[]? Precipitation { get; set; }
        public float?[]? Rain { get; set; }
        public float?[]? Showers { get; set; }
        public float?[]? Snowfall { get; set; }
        public float?[]? Snow_depth { get; set; }
        public float?[]? Freezinglevel_height { get; set; }
        public int?[]? Weather_code { get; set; }
        public float?[]? Pressure_msl { get; set; }
        public float?[]? Surface_pressure { get; set; }
        public int?[]? Cloud_cover { get; set; }
        public int?[]? Cloud_cover_low { get; set; }
        public int?[]? Cloud_cover_mid { get; set; }
        public int?[]? Cloud_cover_high { get; set; }
        public float?[]? Visibility { get; set; }
        public float?[]? Evapotranspiration { get; set; }
        public float?[]? Et0_fao_evapotranspiration { get; set; }
        public float?[]? Vapor_pressure_deficit { get; set; }
        public float?[]? Cape { get; set; }
        public float?[]? Windspeed_10m { get; set; }
        public float?[]? Windspeed_80m { get; set; }
        public float?[]? Windspeed_120m { get; set; }
        public float?[]? Windspeed_180m { get; set; }
        public int?[]? Winddirection_10m { get; set; }
        public int?[]? Winddirection_80m { get; set; }
        public int?[]? Winddirection_120m { get; set; }
        public int?[]? Winddirection_180m { get; set; }
        public float?[]? Windgusts_10m { get; set; }
        public float?[]? Temperature_80m { get; set; }
        public float?[]? Temperature_120m { get; set; }
        public float?[]? Temperature_180m { get; set; }
        public float?[]? Soil_temperature_0cm { get; set; }
        public float?[]? Soil_temperature_6cm { get; set; }
        public float?[]? Soil_temperature_18cm { get; set; }
        public float?[]? Soil_temperature_54cm { get; set; }
        public float?[]? Soil_moisture_0_1cm { get; set; }
        public float?[]? Soil_moisture_1_to_3cm { get; set; }
        public float?[]? Soil_moisture_3_to_9cm { get; set; }
        public float?[]? Soil_moisture_9_to_27cm { get; set; }
        public float?[]? Soil_moisture_27_to_81cm { get; set; }
        public float?[]? Shortwave_radiation { get; set; }
        public float?[]? Direct_radiation { get; set; }
        public float?[]? Diffuse_radiation { get; set; }
        public float?[]? Direct_normal_irradiance { get; set; }
        public float?[]? Terrestrial_radiation { get; set; }
        public float?[]? Shortwave_radiation_instant { get; set; }
        public float?[]? Direct_radiation_instant { get; set; }
        public float?[]? Diffuse_radiation_instant { get; set; }
        public float?[]? Direct_normal_irradiance_instant { get; set; }
        
        public float?[]? Uv_index { get; set; }
        public float?[]? Uv_index_clear_sky { get; set; }
        public int?[]? Is_day { get; set; }
        public int?[]? Precipitation_probability { get; set; }
    }
}
