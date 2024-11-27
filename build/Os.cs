using System;

public static class Os
{
    public static bool IsWindows => Environment.OSVersion.Platform == PlatformID.Win32NT;
    public static bool IsLinux => Environment.OSVersion.Platform == PlatformID.Unix;
}
