namespace ModpackUtils;

public class ModToml
{
    public Mods Mods { get; set; }
}

public class Mods
{
    public string ModId { get; set; }
    public string Version { get; set; }
    public string DisplayName { get; set; }
    public string Authors { get; set; }
}