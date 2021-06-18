using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPX.Extractor.Classes;

namespace RPX.Extractor.GUI
{
    public partial class FTPiiUForm : Form
    {
        TitleIdType IdType { get; set; }

        public FTPiiUForm()
        {
            InitializeComponent();
        }

        private void TitleIDcheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i > TitleIDcheckedListBox.Items.Count; i++)
            {
                if (TitleIDcheckedListBox.GetItemChecked(i))
                    switch (i)
                    {
                        case 0:
                            IdType = TitleIdType.Base;
                            break;
                        case 1:
                            IdType = TitleIdType.Update;
                            break;
                        case 2:
                            IdType = TitleIdType.DLC;
                            break;
                    }
            }
        }

        private async void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var fTPii = new FTPiiU(IPTextBox.Text, IdType);
            if (RpxData.Files is null)
                RpxData.Files = await fTPii.FindRPX(TitleIDTextBox.Text);
            else
                foreach (var f in await fTPii.FindRPX(TitleIDTextBox.Text))
                    RpxData.Files.Add(f);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Worker.RunWorkerAsync();
        }
    }
}
