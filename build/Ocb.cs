using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Ardalis.GuardClauses;
using static Nuke.Common.Tools.Pwsh.PwshTasks;

public static class Ocb
{
    public static IEnumerable<string?> Install(string? version = null)
    {
        Guard.Against.Null(version, nameof(version));
        var ocbName = GetOcbName();
        if (File.Exists(ocbName))
        {
            File.Delete(ocbName);
        }

        var ocbUrl = GetOcbUrl(version);
	    var result = Pwsh($"-Command (New-Object System.Net.WebClient).DownloadFile('{ocbUrl}', '{ocbName}')").FirstOrDefault();
        yield return result.Text;
        if (Os.IsLinux)
        {
            result = Pwsh($"-Command chmod u+x {ocbName}").FirstOrDefault();
            yield return result.Text;
        }
    }

    public static string GetOcbName()
    {
        return Os.IsWindows ? "ocb.exe" : "ocb";
    }

    private static string GetOcbUrl(string version)
    {
        if (Os.IsWindows)
        {
            return $"https://github.com/open-telemetry/opentelemetry-collector-releases/releases/download/cmd%2Fbuilder%2Fv{version}/ocb_{version}_windows_amd64.exe";
        }
        else if (Os.IsLinux)
        {
            return $"https://github.com/open-telemetry/opentelemetry-collector-builder/releases/download/v{version}/opentelemetry-collector-builder_{version}_linux_amd64";
        }
        else
        {
            throw new Exception("Unsupported OS");
        }
    }
}

