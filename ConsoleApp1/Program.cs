
using System;
using System.IO;
using Xabe.FFmpeg;
using System.Diagnostics;
namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            void exec(string comm)
            {
                Process Process = new Process();
                ProcessStartInfo ProcessInfo;
                ProcessInfo = new ProcessStartInfo("cmd.exe", "/C " + comm);
                ProcessInfo.CreateNoWindow = true;
                ProcessInfo.UseShellExecute = false;
                Process = Process.Start(ProcessInfo);
                Process.WaitForExit();
                Process.Close();
            }

            int[] start = new int[] { 5, 10, 15 };
            int time = 5;
            for (int i = 0; i < start.Length; i++)
            {
                string arguments = $"ffmpeg -ss {start[i]} -i C:\\Users\\Dogukan\\Desktop\\a.mp4 -t {time} -c copy output\\{i}.mp4";
                exec(arguments);
            }
        }

  

    }
}
