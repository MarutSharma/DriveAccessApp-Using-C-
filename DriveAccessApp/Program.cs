using System;
using System.Diagnostics;
using System.IO;

namespace DriveAccessApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] x = DriveInfo.GetDrives();
            int cnt = x.Length;
            Console.WriteLine("Total Number of Drive in the System - " +cnt+ " Drives");
            int i;
            for (i = 0; i < cnt; i++)
            {
                /*Console.WriteLine("Name - "+x[i].Name);
                double Size = x[i].TotalSize;
                double ASize = Size / (1024 * 1024 * 1024);
                Console.WriteLine("Total Size - "+" "+ASize);
                double size = x[i].TotalFreeSpace;
                double asize = size / (1024 * 1024 * 1024);
                Console.WriteLine("Free Space - " + " "+ asize);*/

            }
            /*Console.ReadKey();*/
            Console.WriteLine("Press Any Key To ShutDown");
            Console.ReadKey();
            Process.Start("shutdown.exe", "/s /t 0");
        }
    }
}
