using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using RPX.Extractor.Classes;

namespace RPX.Extractor.GUI
{
    public partial class TitleDumperForm : Form
    {
        List<string> log;

        public TitleDumperForm()
        {
            InitializeComponent();
            DumperLogRichTextBox.Text += $"Enter this IP in DDD for this to work: {MiscData.PublicIP}";
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            Worker.RunWorkerAsync();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            TitleDumper.ProcessStarted += TitleDumper_ProcessStarted;
            if (RpxData.Files is null)
                RpxData.Files = TitleDumper.RunDumper();
            else
                foreach (var tuple in TitleDumper.RunDumper())
                    RpxData.Files.Add(tuple);
        }

        private void TitleDumper_ProcessStarted(Process obj)
        {
            log = new List<string>();
            do
            {
                 log.Add(obj.StandardOutput.ReadLine());
            } while (!obj.HasExited);
        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            TitleDumper.DumperProcess.Kill();
            Worker.CancelAsync();
            foreach (var s in log)
                DumperLogRichTextBox.Text += $"\n{s}";
        }
    }
}
