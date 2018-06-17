using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var driveInfo in DriveInfo.GetDrives())
            {
                Console.WriteLine("---------------------------------");

                Console.WriteLine("DriveType : " + driveInfo.DriveType);

                if (driveInfo.IsReady)
                {
                    Console.WriteLine("Name : " + driveInfo.Name);
                    Console.WriteLine("RootDirectory : " + driveInfo.RootDirectory);
                    Console.WriteLine("TotalFreeSpace : " + (driveInfo.TotalFreeSpace/1024/1024/1024));
                }

            }

            Console.ReadKey();

        }
    }
}
