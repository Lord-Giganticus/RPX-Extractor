
namespace RPX.Extractor.GUI
{
    partial class TitleDumperForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DumperLogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Stopbutton = new System.Windows.Forms.Button();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // DumperLogRichTextBox
            // 
            this.DumperLogRichTextBox.Location = new System.Drawing.Point(175, 35);
            this.DumperLogRichTextBox.Name = "DumperLogRichTextBox";
            this.DumperLogRichTextBox.Size = new System.Drawing.Size(209, 194);
            this.DumperLogRichTextBox.TabIndex = 0;
            this.DumperLogRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "TitleDumper Log:";
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(12, 35);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(157, 194);
            this.Startbutton.TabIndex = 2;
            this.Startbutton.Text = "Start TitleDumper";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Stopbutton
            // 
            this.Stopbutton.Location = new System.Drawing.Point(390, 35);
            this.Stopbutton.Name = "Stopbutton";
            this.Stopbutton.Size = new System.Drawing.Size(75, 194);
            this.Stopbutton.TabIndex = 3;
            this.Stopbutton.Text = "Stop";
            this.Stopbutton.UseVisualStyleBackColor = true;
            this.Stopbutton.Click += new System.EventHandler(this.Stopbutton_Click);
            // 
            // Worker
            // 
            this.Worker.WorkerSupportsCancellation = true;
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            // 
            // TitleDumperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 241);
            this.Controls.Add(this.Stopbutton);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DumperLogRichTextBox);
            this.MaximizeBox = false;
            this.Name = "TitleDumperForm";
            this.ShowIcon = false;
            this.Text = "TitleDumperForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox DumperLogRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Stopbutton;
        private System.ComponentModel.BackgroundWorker Worker;
    }
}