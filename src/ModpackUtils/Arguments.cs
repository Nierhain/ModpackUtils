namespace ModpackUtils;

public class Arguments
{
    public string Output { get; set; }
    public string Input { get; set; }

    public static Arguments Parse(string[] args)
    {
        var outputIndex =Array.IndexOf(args, "-o");
        var inputIndex = Array.IndexOf(args, "-i");
        var output = "";
        var input = "";
        if (outputIndex == -1) output = Environment.CurrentDirectory;
        else output = args[outputIndex + 1];
        if (inputIndex == -1) input = Environment.CurrentDirectory;
        else input = args[inputIndex + 1];
        return new Arguments()
        {
            Input = input,
            Output = output
        }
        ;
    }
}