
namespace RPX.Extractor.GUI
{
    partial class WUPForm
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
            this.FileCheckBox = new System.Windows.Forms.CheckBox();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // FileCheckBox
            // 
            this.FileCheckBox.AutoSize = true;
            this.FileCheckBox.Location = new System.Drawing.Point(12, 12);
            this.FileCheckBox.Name = "FileCheckBox";
            this.FileCheckBox.Size = new System.Drawing.Size(151, 19);
            this.FileCheckBox.TabIndex = 0;
            this.FileCheckBox.Text = "Delete WUP related files";
            this.FileCheckBox.UseVisualStyleBackColor = true;
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(12, 37);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(151, 49);
            this.Startbutton.TabIndex = 1;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Worker
            // 
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            // 
            // WUPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 98);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.FileCheckBox);
            this.MaximizeBox = false;
            this.Name = "WUPForm";
            this.ShowIcon = false;
            this.Text = "WUPFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FileCheckBox;
        private System.Windows.Forms.Button Startbutton;
        private System.ComponentModel.BackgroundWorker Worker;
    }
}