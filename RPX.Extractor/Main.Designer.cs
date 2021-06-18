
namespace RPX.Extractor
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.WUPbutton = new System.Windows.Forms.Button();
            this.TitleDumperbutton = new System.Windows.Forms.Button();
            this.FTPiiUbutton = new System.Windows.Forms.Button();
            this.RPXRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Exportbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a method to aquire the RPX file.";
            // 
            // WUPbutton
            // 
            this.WUPbutton.Location = new System.Drawing.Point(12, 27);
            this.WUPbutton.Name = "WUPbutton";
            this.WUPbutton.Size = new System.Drawing.Size(176, 68);
            this.WUPbutton.TabIndex = 1;
            this.WUPbutton.Text = "WUP";
            this.WUPbutton.UseVisualStyleBackColor = true;
            this.WUPbutton.Click += new System.EventHandler(this.WUPbutton_Click);
            // 
            // TitleDumperbutton
            // 
            this.TitleDumperbutton.Location = new System.Drawing.Point(194, 27);
            this.TitleDumperbutton.Name = "TitleDumperbutton";
            this.TitleDumperbutton.Size = new System.Drawing.Size(175, 68);
            this.TitleDumperbutton.TabIndex = 2;
            this.TitleDumperbutton.Text = "TitleDumper";
            this.TitleDumperbutton.UseVisualStyleBackColor = true;
            this.TitleDumperbutton.Click += new System.EventHandler(this.TitleDumperbutton_Click);
            // 
            // FTPiiUbutton
            // 
            this.FTPiiUbutton.Location = new System.Drawing.Point(12, 101);
            this.FTPiiUbutton.Name = "FTPiiUbutton";
            this.FTPiiUbutton.Size = new System.Drawing.Size(357, 68);
            this.FTPiiUbutton.TabIndex = 3;
            this.FTPiiUbutton.Text = "FTPiiU";
            this.FTPiiUbutton.UseVisualStyleBackColor = true;
            this.FTPiiUbutton.Click += new System.EventHandler(this.FTPiiUbutton_Click);
            // 
            // RPXRichTextBox
            // 
            this.RPXRichTextBox.Location = new System.Drawing.Point(375, 27);
            this.RPXRichTextBox.Name = "RPXRichTextBox";
            this.RPXRichTextBox.Size = new System.Drawing.Size(357, 139);
            this.RPXRichTextBox.TabIndex = 4;
            this.RPXRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "RPX files found";
            // 
            // Exportbutton
            // 
            this.Exportbutton.Location = new System.Drawing.Point(738, 26);
            this.Exportbutton.Name = "Exportbutton";
            this.Exportbutton.Size = new System.Drawing.Size(175, 140);
            this.Exportbutton.TabIndex = 6;
            this.Exportbutton.Text = "Export files";
            this.Exportbutton.UseVisualStyleBackColor = true;
            this.Exportbutton.Click += new System.EventHandler(this.Exportbutton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 178);
            this.Controls.Add(this.Exportbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RPXRichTextBox);
            this.Controls.Add(this.FTPiiUbutton);
            this.Controls.Add(this.TitleDumperbutton);
            this.Controls.Add(this.WUPbutton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "RPX Extractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WUPbutton;
        private System.Windows.Forms.Button TitleDumperbutton;
        private System.Windows.Forms.Button FTPiiUbutton;
        private System.Windows.Forms.RichTextBox RPXRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exportbutton;
    }
}

