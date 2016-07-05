namespace ScanFreq.Global.Logic
{
    public class ConventionalChannel : IChannel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AlphaTag { get; set; }
        public string Tag { get; set; }
        public string Category { get; set; }
        public ChannelMode Mode { get; set; }
        public FrequencyModulation Modulation { get; set; }
        public decimal FrequencyReceive { get; set; }
        public decimal FrequencyTransmit { get; set; }
        public string SquelchType { get; set; }
        public string SquelchValue { get; set; }
        public int P25NacReceive { get; set; }
        public int P25NacTransmit { get; set; }
    }
}