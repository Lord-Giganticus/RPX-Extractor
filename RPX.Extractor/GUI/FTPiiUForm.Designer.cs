
namespace RPX.Extractor.GUI
{
    partial class FTPiiUForm
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
            this.TitleIDcheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.TitleIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleIDcheckedListBox
            // 
            this.TitleIDcheckedListBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TitleIDcheckedListBox.FormattingEnabled = true;
            this.TitleIDcheckedListBox.Items.AddRange(new object[] {
            "Base",
            "Update",
            "DLC"});
            this.TitleIDcheckedListBox.Location = new System.Drawing.Point(12, 12);
            this.TitleIDcheckedListBox.Name = "TitleIDcheckedListBox";
            this.TitleIDcheckedListBox.Size = new System.Drawing.Size(122, 58);
            this.TitleIDcheckedListBox.TabIndex = 0;
            this.TitleIDcheckedListBox.SelectedIndexChanged += new System.EventHandler(this.TitleIDcheckedListBox_SelectedIndexChanged);
            // 
            // TitleIDTextBox
            // 
            this.TitleIDTextBox.Location = new System.Drawing.Point(140, 47);
            this.TitleIDTextBox.Name = "TitleIDTextBox";
            this.TitleIDTextBox.Size = new System.Drawing.Size(118, 23);
            this.TitleIDTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last 8 chars of TitleID";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(264, 47);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(118, 23);
            this.IPTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wii U IP Adress";
            // 
            // Worker
            // 
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 87);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(370, 32);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // FTPiiUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 142);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleIDTextBox);
            this.Controls.Add(this.TitleIDcheckedListBox);
            this.MaximizeBox = false;
            this.Name = "FTPiiUForm";
            this.ShowIcon = false;
            this.Text = "FTPiiUForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox TitleIDcheckedListBox;
        private System.Windows.Forms.TextBox TitleIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker Worker;
        private System.Windows.Forms.Button StartButton;
    }
}