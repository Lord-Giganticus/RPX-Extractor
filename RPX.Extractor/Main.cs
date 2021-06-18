using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using RPX.Extractor.GUI;
using RPX.Extractor.Classes;

namespace RPX.Extractor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            RpxData.Files = new ObservableCollection<(MemoryStream stream, string name)>();
            RpxData.Files.CollectionChanged += Files_CollectionChanged;
        }

        private void Files_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            for (int i = e.NewStartingIndex; i > RpxData.Files.Count; i++)
                RPXRichTextBox.Text += $"\n{RpxData.Files[i].name}";
        }

        private void WUPbutton_Click(object sender, EventArgs e)
        {
            var wup = new WUPForm
            {
                Text = Text
            };
            wup.ShowDialog();
        }

        private void TitleDumperbutton_Click(object sender, EventArgs e)
        {
            var TDF = new TitleDumperForm
            {
                Text = Text
            };
            TDF.ShowDialog();
        }

        private void FTPiiUbutton_Click(object sender, EventArgs e)
        {
            var FTPii = new FTPiiUForm
            {
                Text = Text
            };
            FTPii.ShowDialog();
        }

        private async void Exportbutton_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.Recent,
                Description = "Select a folder to save the RPX files.",
                AutoUpgradeEnabled = true,
                UseDescriptionForTitle = true,
                ShowNewFolderButton = true
            };
            if (fbd.ShowDialog() is DialogResult.OK)
            {
                if (RpxData.Files is null)
                    throw new NullReferenceException();
                Directory.SetCurrentDirectory(fbd.SelectedPath);
                foreach (var (stream, name) in RpxData.Files)
                    await File.WriteAllBytesAsync(name, stream.ToArray());
                MessageBox.Show("Complete. Reseting the list of files.");
                RpxData.Files.Clear();
                RPXRichTextBox.Text = string.Empty;
            }
        }
    }
}
