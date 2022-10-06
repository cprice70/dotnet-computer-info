using System.Runtime.InteropServices;

namespace ComputerInfo;

public static class HardwareInfo
{
    public static string CpuInfo => RuntimeInformation.ProcessArchitecture.ToString();

    public static string MemoryInfo 
    {
        get
        {
            var gcMemoryInfo = GC.GetGCMemoryInfo();
            var installedMemory = gcMemoryInfo.TotalAvailableMemoryBytes;
            // it will give the size of memory in MB
            var physicalMemory = installedMemory / 1048576.0;
            return Convert.ToInt32(physicalMemory).ToString();
        }
    }
}