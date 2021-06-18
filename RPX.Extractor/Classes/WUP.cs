using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using RPX.Extractor.Properties;
using System.Collections.ObjectModel;

namespace RPX.Extractor.Classes
{
    public class WUP
    {
        DirectoryInfo InitalDirectory { get; set; }
        
        public WUP()
        {
            var fbd = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.Recent,
                AutoUpgradeEnabled = true,
                Description = "Search for a folder with WUP install files.",
                UseDescriptionForTitle = true,
                ShowNewFolderButton = false
            };
            if (fbd.ShowDialog() is DialogResult.OK)
                InitalDirectory = new DirectoryInfo(fbd.SelectedPath);
        }

        public WUP(FolderBrowserDialog fbd)
        {
            if (fbd.ShowDialog() is DialogResult.OK)
                InitalDirectory = new DirectoryInfo(fbd.SelectedPath);
        }

        public WUP(DirectoryInfo dir)
        {
            InitalDirectory = dir;
        }

        public WUP(FileInfo file)
        {
            InitalDirectory = file.Directory;
        }

        public ObservableCollection<(MemoryStream stream,string name)> UseWUP(bool RemoveWupFiles = false)
        {
            Environment.CurrentDirectory = InitalDirectory.FullName;
            Directory.SetCurrentDirectory(Environment.CurrentDirectory);
            File.WriteAllBytes("Cdecrypt_v2.0b.zip", Resources.Cdecrypt_v2_0b);
            ZipFile.ExtractToDirectory("Cdecrypt_v2.0b.zip", Directory.GetCurrentDirectory());
            var info = new ProcessStartInfo
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/c Decrypt.bat"
            };
            Process.Start(info).WaitForExit();
            var stream = new ObservableCollection<(MemoryStream stream,string name)>();
            foreach (var d in new DirectoryInfo(Environment.CurrentDirectory).GetDirectories())
                switch (d.Name)
                {
                    case "content":
                    case "meta":
                        d.Delete();
                        break;
                    case "code":
                            foreach (var f in d.GetFiles())
                                switch (f.Extension)
                                {
                                    case ".rpx":
                                        stream.Add((new MemoryStream(File.ReadAllBytes(f.FullName)), f.Name));
                                        f.Delete();
                                        break;
                                    default:
                                        if (RemoveWupFiles)
                                            switch (f.Extension)
                                            {
                                                case ".h3":
                                                case ".app":
                                                case ".cert":
                                                case ".tik":
                                                case ".tmd":
                                                    f.Delete();
                                                    break;
                                            }
                                        break;
                                }
                            d.Delete(true);
                            break;
                }
            File.Delete("CDecrypt_v2.0b.zip");
            File.Delete("CDecrypt_v2.0b.exe");
            File.Delete("Decrypt.bat");
            File.Delete("libeay32.dll");
            File.Delete("msvcr120d.dll");
            return stream;
        }
    }
}
