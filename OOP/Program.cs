using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP {

    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in allDrives)
            {
                long bytes = drive.TotalSize;

                double sizeInGB = (double)bytes / (1024 * 1024 * 1024);
                double sizeInMB = (double)bytes / (1024 * 1024);

                Console.WriteLine($"Название диска: {drive.Name}");
                Console.WriteLine($"Метка тома: {drive.VolumeLabel}");
                Console.WriteLine($"Общий размер в GB: {sizeInGB:F2}");
                Console.WriteLine($"Общий размер в MB: {sizeInMB:F2}");
                Console.WriteLine($"Свободное место для использования: {drive.AvailableFreeSpace}");
                Console.WriteLine($"Тип файловой системы: {drive.DriveFormat}");
            }

            Console.ReadKey();
        }      
    }
}
