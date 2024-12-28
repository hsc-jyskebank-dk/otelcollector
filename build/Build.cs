using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.Tools.Pwsh.PwshTasks;

class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.BuildCollector);

    [Parameter("OpenTelemetry Collector Builder version")]
    [Required]
    readonly string? CollectorVersion;

    Target BuildCollector => _ => _
        .Requires(() => CollectorVersion)
        .Executes(() =>
        {
            var collectorDir = RootDirectory / "collector";
            collectorDir.CreateOrCleanDirectory();

            Ocb.Install(CollectorVersion).ForEach(x => Serilog.Log.Information(x ?? string.Empty));

            var collectorConfig = RootDirectory / "manifest.yaml";
	        var builder = RootDirectory / Ocb.GetOcbName();

            var result = Pwsh($"-Command {builder} --config {collectorConfig}").FirstOrDefault();
        });
}
