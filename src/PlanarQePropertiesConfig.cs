using Newtonsoft.Json;

namespace PlanarQeDisplay
{
	public class PlanarQePropertiesConfig
	{		
		/// <summary>
		/// Poll interval in miliseconds, defaults 45,000ms (45-seconds)
		/// </summary>
        [JsonProperty("pollIntervalMs")]
        public long PollIntervalMs { get; set; }

		/// <summary>
		/// Device cooling time, defaults to 15,000ms (15-seconds)
		/// </summary>
        [JsonProperty("coolingTimeMs")]
        public uint CoolingTimeMs { get; set; }

		/// <summary>
		/// Device warming time, defaults to 15,000ms (15-seconds)
		/// </summary>
        [JsonProperty("warmingTimeMs")]
        public uint WarmingTimeMs { get; set; }
	}
}