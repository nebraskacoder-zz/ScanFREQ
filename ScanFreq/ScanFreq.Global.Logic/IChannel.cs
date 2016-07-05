namespace ScanFreq.Global.Logic
{
    public interface IChannel
    {
        string Name { get; set; }
        string AlphaTag { get; set; }
        string Tag { get; set; }
        string Category { get; set; }
        ChannelMode Mode { get; set; }
    }
}