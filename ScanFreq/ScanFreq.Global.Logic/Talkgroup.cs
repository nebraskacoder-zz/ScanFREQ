namespace RadioProjects.Astro25.Logic
{
    public class Talkgroup : IChannel
    {
        public int Id { get; set; }
        public int TalkGroupId { get; set; }
        public string Name { get; set; }
        public string AlphaTag { get; set; }
        public TalkgroupMode Mode { get; set; }
        public string Tag { get; set; }
        public string Category { get; set; }
    }
}