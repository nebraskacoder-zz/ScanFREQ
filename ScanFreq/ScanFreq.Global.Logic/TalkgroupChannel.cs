namespace ScanFreq.Global.Logic
{
    public class TalkgroupChannel : IChannel
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public int TalkGroupId { get; set; }
        public string Name { get; set; }
        public string AlphaTag { get; set; }
        public ChannelMode Mode { get; set; }
        public string Tag { get; set; }
        public string Category { get; set; }
    }
}