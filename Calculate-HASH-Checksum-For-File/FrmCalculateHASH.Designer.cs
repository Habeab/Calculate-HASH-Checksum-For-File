namespace Calculate_HASH_Checksum_For_File
{
    partial class FrmCalculateHASH
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
            this.BtnSHA512 = new System.Windows.Forms.Button();
            this.BtnSHA384 = new System.Windows.Forms.Button();
            this.BtnSHA256 = new System.Windows.Forms.Button();
            this.BtnSHA1 = new System.Windows.Forms.Button();
            this.BtnMD5 = new System.Windows.Forms.Button();
            this.LblCharactersLength = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxHASH = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TbxPathFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSHA512
            // 
            this.BtnSHA512.Location = new System.Drawing.Point(600, 435);
            this.BtnSHA512.Name = "BtnSHA512";
            this.BtnSHA512.Size = new System.Drawing.Size(80, 23);
            this.BtnSHA512.TabIndex = 30;
            this.BtnSHA512.Text = "SHA512";
            this.BtnSHA512.UseVisualStyleBackColor = true;
            this.BtnSHA512.Click += new System.EventHandler(this.BtnSHA512_Click);
            // 
            // BtnSHA384
            // 
            this.BtnSHA384.Location = new System.Drawing.Point(514, 435);
            this.BtnSHA384.Name = "BtnSHA384";
            this.BtnSHA384.Size = new System.Drawing.Size(80, 23);
            this.BtnSHA384.TabIndex = 31;
            this.BtnSHA384.Text = "SHA384";
            this.BtnSHA384.UseVisualStyleBackColor = true;
            this.BtnSHA384.Click += new System.EventHandler(this.BtnSHA384_Click);
            // 
            // BtnSHA256
            // 
            this.BtnSHA256.Location = new System.Drawing.Point(428, 435);
            this.BtnSHA256.Name = "BtnSHA256";
            this.BtnSHA256.Size = new System.Drawing.Size(80, 23);
            this.BtnSHA256.TabIndex = 32;
            this.BtnSHA256.Text = "SHA256";
            this.BtnSHA256.UseVisualStyleBackColor = true;
            this.BtnSHA256.Click += new System.EventHandler(this.BtnSHA256_Click);
            // 
            // BtnSHA1
            // 
            this.BtnSHA1.Location = new System.Drawing.Point(342, 435);
            this.BtnSHA1.Name = "BtnSHA1";
            this.BtnSHA1.Size = new System.Drawing.Size(80, 23);
            this.BtnSHA1.TabIndex = 33;
            this.BtnSHA1.Text = "SHA1";
            this.BtnSHA1.UseVisualStyleBackColor = true;
            this.BtnSHA1.Click += new System.EventHandler(this.BtnSHA1_Click);
            // 
            // BtnMD5
            // 
            this.BtnMD5.Location = new System.Drawing.Point(256, 435);
            this.BtnMD5.Name = "BtnMD5";
            this.BtnMD5.Size = new System.Drawing.Size(80, 23);
            this.BtnMD5.TabIndex = 34;
            this.BtnMD5.Text = "MD5";
            this.BtnMD5.UseVisualStyleBackColor = true;
            this.BtnMD5.Click += new System.EventHandler(this.BtnMD5_Click);
            // 
            // LblCharactersLength
            // 
            this.LblCharactersLength.AutoSize = true;
            this.LblCharactersLength.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LblCharactersLength.Location = new System.Drawing.Point(235, 477);
            this.LblCharactersLength.Name = "LblCharactersLength";
            this.LblCharactersLength.Size = new System.Drawing.Size(18, 19);
            this.LblCharactersLength.TabIndex = 27;
            this.LblCharactersLength.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(93, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Characters Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(30, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "HASH";
            // 
            // TbxHASH
            // 
            this.TbxHASH.BackColor = System.Drawing.Color.White;
            this.TbxHASH.Location = new System.Drawing.Point(97, 409);
            this.TbxHASH.Name = "TbxHASH";
            this.TbxHASH.ReadOnly = true;
            this.TbxHASH.Size = new System.Drawing.Size(817, 20);
            this.TbxHASH.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculate_HASH_Checksum_For_File.Properties.Resources.drag_drop;
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // TbxPathFile
            // 
            this.TbxPathFile.BackColor = System.Drawing.Color.White;
            this.TbxPathFile.Location = new System.Drawing.Point(97, 383);
            this.TbxPathFile.Name = "TbxPathFile";
            this.TbxPathFile.ReadOnly = true;
            this.TbxPathFile.Size = new System.Drawing.Size(817, 20);
            this.TbxPathFile.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(12, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "File Path";
            // 
            // FrmCalculateHASH
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSHA512);
            this.Controls.Add(this.BtnSHA384);
            this.Controls.Add(this.BtnSHA256);
            this.Controls.Add(this.BtnSHA1);
            this.Controls.Add(this.BtnMD5);
            this.Controls.Add(this.LblCharactersLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxPathFile);
            this.Controls.Add(this.TbxHASH);
            this.Name = "FrmCalculateHASH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate HASH checksum for a file";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSHA512;
        private System.Windows.Forms.Button BtnSHA384;
        private System.Windows.Forms.Button BtnSHA256;
        private System.Windows.Forms.Button BtnSHA1;
        private System.Windows.Forms.Button BtnMD5;
        private System.Windows.Forms.Label LblCharactersLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxHASH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TbxPathFile;
        private System.Windows.Forms.Label label1;
    }
}

