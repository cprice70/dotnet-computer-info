using System;
using System.Runtime.InteropServices;

namespace ComputerInfo
{
    public static class OperatingSystem
    {
        public static bool IsWindows =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        public static bool IsMacOS =>
            RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

        public static bool IsLinux =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

        public static new string ToString => IsWindows ? "Windows" : (IsMacOS ? "MacOS" : "Linux");
    }
}

