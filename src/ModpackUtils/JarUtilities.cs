using System.IO.Compression;
using Tomlyn;

namespace ModpackUtils;

public static class JarUtilities
{
    public static List<ModToml> GetModTomls(IEnumerable<string> filePaths)
    {
        var tomls = new List<ModToml>();
        foreach (var path in filePaths)
        {
            var stream = new FileStream(path, FileMode.Open);
            var jar = new ZipArchive(stream, ZipArchiveMode.Read);
            var toml = jar.GetEntry("mods.toml");
            if (toml is null) continue;
            var tomlStream = toml.Open();
            var reader = new StreamReader(tomlStream);
            var modToml = Toml.ToModel<ModToml>(reader.ReadToEnd());
            tomls.Add(modToml);
        }

        return tomls;
    }
}