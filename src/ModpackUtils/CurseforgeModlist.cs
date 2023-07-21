namespace ModpackUtils;

public class CurseforgeModlist
{
    public void CreateCurseforgeList(List<ModToml> tomls, string path)
    {
        var output = tomls.Select(x => 
            $"{x.Mods.DisplayName} {x.Mods.Version} (by {x.Mods.Authors})");
        File.WriteAllLines(path, output);
    }
}