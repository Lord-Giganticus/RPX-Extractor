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
    public partial class WUPForm : Form
    {
        WUP WUP { get; set; }

        public WUPForm()
        {
            InitializeComponent();
            WUP = new WUP();
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            Worker.RunWorkerAsync();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (RpxData.Files is null)
                RpxData.Files = WUP.UseWUP(FileCheckBox.Checked);
            else
                foreach (var t in WUP.UseWUP(FileCheckBox.Checked))
                    RpxData.Files.Add(t);
        }
    }
}
