namespace RAWFileReader
{
    partial class mainForm
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
            this.RAWopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RAWpictureBox = new System.Windows.Forms.PictureBox();
            this.openRAWButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RAWpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RAWopenFileDialog
            // 
            this.RAWopenFileDialog.FileName = "RAWopenFileDialog";
            this.RAWopenFileDialog.Filter = "RAW файлы|*.raw";
            // 
            // RAWpictureBox
            // 
            this.RAWpictureBox.Location = new System.Drawing.Point(12, 12);
            this.RAWpictureBox.Name = "RAWpictureBox";
            this.RAWpictureBox.Size = new System.Drawing.Size(700, 700);
            this.RAWpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RAWpictureBox.TabIndex = 0;
            this.RAWpictureBox.TabStop = false;
            // 
            // openRAWButton
            // 
            this.openRAWButton.Location = new System.Drawing.Point(570, 718);
            this.openRAWButton.Name = "openRAWButton";
            this.openRAWButton.Size = new System.Drawing.Size(142, 23);
            this.openRAWButton.TabIndex = 1;
            this.openRAWButton.Text = "Открыть RAW файл";
            this.openRAWButton.UseVisualStyleBackColor = true;
            this.openRAWButton.Click += new System.EventHandler(this.openRAWButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 753);
            this.Controls.Add(this.openRAWButton);
            this.Controls.Add(this.RAWpictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xRay RAW Files Reader";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RAWpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private OpenFileDialog RAWopenFileDialog;
        private PictureBox RAWpictureBox;
        private Button openRAWButton;
    }
}