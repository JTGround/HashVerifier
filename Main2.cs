using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashVerifier
{
    public partial class Main2 : Form
    {
        private HashEngine _engine = null;
        private byte[] _md5Hash = null;
        private byte[] _sha1Hash = null;
        private byte[] _sha256Hash = null;

        public Main2()
        {
            InitializeComponent();

            //initialize hash engine
            _engine = new HashEngine();
        }

        private void Main2_Load(object sender, EventArgs e)
        {
            groupFileSelect.AllowDrop = true;
        }

        private void buttonFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                var filePath = openFile.FileName;
                var fileInfo = new FileInfo(filePath);


                if (filePath != labelFileName.Text) ClearHashes();
                labelFileName.Text = filePath;
                labelFileSize.Text = GetSizeString(fileInfo.Length);
            }
        }

        private void buttonHash_Click(object sender, EventArgs e)
        {
            String filePath = labelFileName.Text;
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("The file path cannot be empty.", "File not found");
                labelFileName.Focus();
                return;
            }

            try
            {
                buttonHash.Enabled = false;
                backgroundMD5.RunWorkerAsync();
                backgroundSHA1.RunWorkerAsync();
                backgroundSHA256.RunWorkerAsync();

                buttonHash.Enabled = true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The specified file was not found.", "File not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem hashing the file:\n\n" + ex.Message);
            }
        }

        private void HashSHA256()
        {
            var filePath = labelFileName.Text;
            _sha256Hash = _engine.HashFileSHA256(filePath);
            var hashString = _engine.ConvertToHexString(_sha256Hash);
            hashString = hashString.ToUpper();
            textSHA256.Text = hashString;
        }

        private void HashMD5()
        {
            var filePath = labelFileName.Text;
            _md5Hash = _engine.HashFileMD5(filePath);
            var hashString = _engine.ConvertToHexString(_md5Hash);
            hashString = hashString.ToUpper();
            textMD5.Text = hashString;
        }

        private void HashSHA1()
        {
            var filePath = labelFileName.Text;
            _sha1Hash = _engine.HashFileSHA1(filePath);
            var hashString = _engine.ConvertToHexString(_sha1Hash);
            hashString = hashString.ToUpper();
            textSHA1.Text = hashString;
        }

        private void ClearHashes()
        {
            //clear existing hashes
            _md5Hash = null;
            _sha1Hash = null;
            _sha256Hash = null;
            textMD5.Text = "";
            textSHA1.Text = "";
            textSHA256.Text = "";
        }

        private void PrintHash(TextBox textBox, HashType hashType, byte[] hash)
        {
            bool upper = checkUseUpper.Checked;
            bool spaces = checkShowSpaces.Checked;

            var hashString = _engine.ConvertToHexString(hash);

            if (upper) hashString = hashString.ToUpper();
            else hashString = hashString.ToLower();

            textBox.Text = hashString;
        }

        enum HashType
        {
            MD5,
            SHA1,
            SHA256
        }

        private void checkUseUpper_CheckedChanged(object sender, EventArgs e)
        {
            bool ch = checkUseUpper.Checked;

            if (_md5Hash != null) PrintHash(textMD5, HashType.MD5, _md5Hash);
            if (_sha1Hash != null) PrintHash(textSHA1, HashType.SHA1, _sha1Hash);
            if (_sha256Hash != null) PrintHash(textSHA256, HashType.SHA256, _sha256Hash);
        }

        private void checkShowSpaces_CheckedChanged(object sender, EventArgs e)
        {
            bool ch = checkShowSpaces.Checked;

            if (_md5Hash != null) PrintHash(textMD5, HashType.MD5, _md5Hash);
            if (_sha1Hash != null) PrintHash(textSHA1, HashType.SHA1, _sha1Hash);
            if (_sha256Hash != null) PrintHash(textSHA256, HashType.SHA256, _sha256Hash);
        }

        private void groupFileSelect_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                ClearHashes();

                String[] fileList;
                fileList = e.Data.GetData(DataFormats.FileDrop) as String[];
                if (fileList.Count() > 1)
                {
                    MessageBox.Show("You may only select one file at a time.", "File Error");
                    return;
                }
                String filePath = fileList[0];

                if(filePath != labelFileName.Text) ClearHashes();
                labelFileName.Text = filePath;
            }
        }

        private void groupFileSelect_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        
        private void backgroundHash_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HashMD5();
        }

        private void backgroundSHA1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HashSHA1();
        }

        private void backgroundSHA256_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HashSHA256();
        }

        private string GetSizeString(long size)
        {
            if (size < 1000) return size + "b";
            else if (size < 1000000) return (size/1000).ToString() + "KB";
            else if (size < 1000000000) return (size/1000000).ToString() + "MB";
            else if (size < 1000000000000) return (size/1000000000).ToString() + "GB";
            else return "large";
        }
    }
}
