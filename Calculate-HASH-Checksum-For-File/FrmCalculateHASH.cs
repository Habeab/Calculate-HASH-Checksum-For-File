using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
/*
 Name: Eng. Habeab Alhamed
 Twitter: @Eng_Habeab
 GitHub: https://github.com/Habeab
 Email: Habeab@gmail.com
 Whatsapp: 0553400333
 Location: Saudi Arabia
*/
namespace Calculate_HASH_Checksum_For_File
{
    public partial class FrmCalculateHASH : Form
    {
        public FrmCalculateHASH()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
        }

        #region PictureBox
        string FilePath;
        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                int count = 0;
                var Files = data as string[];
                foreach (var item in Files)
                { count += 1; }
                if (count > 1) { MessageBox.Show(Convert.ToString("Choose only One File!")); }
                else
                { FilePath = Files[0]; TbxPathFile.Text = FilePath; TbxHASH.Text = string.Empty; LblCharactersLength.Text = "0"; }
            }
        }
        private void pictureBox1_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Copy;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                // dialog.Filter = "Image Files(*.JPG)|*.JPG";
                if (dialog.ShowDialog() == DialogResult.OK)
                { FilePath = dialog.FileName; TbxPathFile.Text = FilePath; TbxHASH.Text = string.Empty; LblCharactersLength.Text = "0"; }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        #endregion

        private void BtnMD5_Click(object sender, EventArgs e)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(FilePath))
                {
                    byte[] hashBytes = md5.ComputeHash(stream);
                    string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();

                    TbxHASH.Text = hash;
                    LblCharactersLength.Text = hash.Length.ToString();
                }
            }
        }

        private void BtnSHA1_Click(object sender, EventArgs e)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                using (var stream = File.OpenRead(FilePath))
                {
                    byte[] hashBytes = sha1.ComputeHash(stream);
                    string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();

                    TbxHASH.Text = hash;
                    LblCharactersLength.Text = hash.Length.ToString();
                }
            }
        }

        private void BtnSHA256_Click(object sender, EventArgs e)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(FilePath))
                {
                    byte[] hashBytes = sha256.ComputeHash(stream);
                    string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();

                    TbxHASH.Text = hash;
                    LblCharactersLength.Text = hash.Length.ToString();
                }
            }
        }

        private void BtnSHA384_Click(object sender, EventArgs e)
        {
            using (SHA384 sha384 = SHA384.Create())
            {
                using (var stream = File.OpenRead(FilePath))
                {
                    byte[] hashBytes = sha384.ComputeHash(stream);
                    string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();

                    TbxHASH.Text = hash;
                    LblCharactersLength.Text = hash.Length.ToString();
                }
            }
        }

        private void BtnSHA512_Click(object sender, EventArgs e)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                using (var stream = File.OpenRead(FilePath))
                {
                    byte[] hashBytes = sha512.ComputeHash(stream);
                    string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();

                    TbxHASH.Text = hash;
                    LblCharactersLength.Text = hash.Length.ToString();
                }
            }
        }
    }
}
