

using System.Text;

using CommandLine;

public class CommandLineOptions
{
    [Option('?', "help", DefaultValue = false, Required = false, HelpText = "Display usage")]
    public bool ShowHelp { get; set; }

    [Option('p', "pattern", DefaultValue = "*.*",  HelpText = "Filepattern", Required = true)]
    public string FilePattern { get; set; }
    
    [Option('d', "StartDirectory", DefaultValue = null, HelpText = "StartDirectory", Required = false)]
    public string StartDirectory { get; set; }

    [Option('s', "spaces", DefaultValue = 4, HelpText = "Number of spaces", Required = false)]
    public int Spaces { get; set; }

    [Option("TabToSpaces", DefaultValue = false, HelpText = "Convert tabs to spaces", Required = false)]
    public bool ConvertTabsToSpaces { get; set; }

    [Option("EnsureCrLf", DefaultValue = false, HelpText = "EnsureCrLf", Required = false)]
    public bool EnsureCrLf { get; set; }

    [Option("RemoveConsecutiveEmptyLines", DefaultValue = false, HelpText = "RemoveConsecutiveEmptyLines", Required = false)]
    public bool RemoveConsecutiveEmptyLines { get; set; }

    [Option("TrimTrailingWhitespace", DefaultValue = false, HelpText = "TrimTrailingWhitespace", Required = false)]
    public bool TrimTrailingWhitespace { get; set; }

    [Option("Encoding", DefaultValue = null, HelpText = "Encoding", Required = false)]
    public string EncodingName { get; set; }
}
