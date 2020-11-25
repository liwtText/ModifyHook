using System;
using System.IO;

namespace FastWinTest
{
    class Program
    {
        static void Main(string[] args)
        {
             var di = DriveInfo.GetDrives();
 
             foreach (var d in di)
             {
                 try
                 {
                     Console.WriteLine(d.Name);
                     Console.WriteLine($"可用空间：{d.AvailableFreeSpace}");
                     Console.WriteLine($"格式：{d.DriveFormat}");
                     Console.WriteLine($"类型：{d.DriveType}");
                     Console.WriteLine($"已准备好：{d.IsReady}");
                     Console.WriteLine($"名称：{d.Name}");
                     Console.WriteLine($"根目录：{d.RootDirectory}");
                     Console.WriteLine($"总剩余空间：{d.TotalFreeSpace}");
                     Console.WriteLine($"总空间：{d.TotalSize}");
                     Console.WriteLine($"标签：{d.VolumeLabel}");
                     Console.WriteLine();
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine(ex.Message);
                 }
             }
        }
    }
}
