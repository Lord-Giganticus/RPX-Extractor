using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPX.Extractor.Classes
{
    public class TitleDumper
    {
        public static Process DumperProcess;

        public static event Action<Process> ProcessStarted;

        public static ObservableCollection<(MemoryStream stream, string name)> RunDumper()
        {
            File.WriteAllBytes("titledumper.exe", Properties.Resources.titledumper);
            DumperProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    RedirectStandardOutput = true,
                    FileName = "titledumper.exe",
                    Arguments = $"/vol/code ${Directory.GetCurrentDirectory()}/output"
                }
            };
            DumperProcess.Start();
            ProcessStarted?.Invoke(DumperProcess);
            while (!DumperProcess.HasExited)
                if (DumperProcess.HasExited)
                    break;
            var list = new ObservableCollection<(MemoryStream stream, string name)>();
            foreach (var d in new DirectoryInfo(Directory.GetCurrentDirectory()).GetDirectories())
                if (d.FullName.EndsWith("output"))
                    foreach (var f in d.GetFiles())
                        if (f.Extension is ".rpx")
                            list.Add((new MemoryStream(File.ReadAllBytes(f.FullName)),f.Name));
            File.Delete("titledumper.exe");
            return list;
        }
    }
}
