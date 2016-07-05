namespace ScanFreq.Global.Logic
{
    /// <summary>
    /// Channel Modes: This tells what kind of traffic (mode) the channel contains.
    /// </summary>
    public enum ChannelMode
    {
        Analog,
        Digital,
        Mixed,
        Encrypted,
        TdmaCapable,
        AnalogEncrypted
    }
}