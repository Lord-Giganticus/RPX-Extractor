using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPX.Extractor.Classes
{
    public struct RpxData
    {
        public static ObservableCollection<(MemoryStream stream, string name)> Files;
    }
}
