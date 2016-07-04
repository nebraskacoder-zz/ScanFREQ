namespace RadioProjects.Astro25.Logic
{
    public interface IChannel
    {
        string Name { get; set; }
        string AlphaTag { get; set; }
        string Tag { get; set; }
        string Category { get; set; }
    }
}