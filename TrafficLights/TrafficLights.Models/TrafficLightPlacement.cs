namespace TrafficLights.Models
{
	public struct TrafficLight
	{
		public byte X { get; set; }
		public byte Y { get; set; }
		public byte Z { get; set; }
		public State State { get; set; }
	}
}