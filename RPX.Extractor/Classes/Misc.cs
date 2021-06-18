using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Net;

namespace RPX.Extractor.Classes
{
    public struct TitleIdStarters
    {
        public const string Base = "00050000";

        public const string Update = "0005000e";

        public const string DLC = "0005000c";
    }

    public enum TitleIdType
    {
        Base,
        Update,
        DLC
    }

    public struct MiscData
    {
        public static FileInfo ExeInfo
        {
            get => new FileInfo(AppContext.BaseDirectory);
        }

        public static string PublicIP
        {
            get => new WebClient().DownloadString("https://ipinfo.io/ip");
        }
    }
}
