// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using ComputerInfo;

var os = Environment.OSVersion;

Console.WriteLine($"{ComputerInfo.OperatingSystem.ToString()} {os.Version}");

Console.WriteLine($"Dotnet {Frameworks.DotnetVersion}");

Console.WriteLine($"{HardwareInfo.CpuInfo}");

Console.WriteLine($"{HardwareInfo.MemoryInfo} MB");