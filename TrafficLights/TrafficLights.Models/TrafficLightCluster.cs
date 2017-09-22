namespace TrafficLights.Models
{
	public class TrafficLightCluster
	{
		public Mode Mode { get; set; }
		public Group Group { get; set; }
		public TrafficLight[] TrafficLights { get; set; }

	}
}
