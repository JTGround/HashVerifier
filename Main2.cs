using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
                String fileName = openFile.FileName;
                labelFileName.Text = fileName;
            }
        }

        private void buttonHash_Click(object sender, EventArgs e)
        {
            String filePath = labelFileName.Text;
            if (filePath == String.Empty)
            {
                MessageBox.Show("The file path cannot be empty.", "File not found");
                labelFileName.Focus();
                return;
            }

            try
            {
                buttonHash.Enabled = false;
                _md5Hash = _engine.HashFileMD5(filePath);
                PrintHash(textMD5, HashType.MD5, _md5Hash);
                _sha1Hash = _engine.HashFileSHA1(filePath);
                PrintHash(textSHA1, HashType.SHA1, _sha1Hash);
                _sha256Hash = _engine.HashFileSHA256(filePath);
                PrintHash(textSHA256, HashType.SHA256, _sha256Hash);

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

        enum HashType
        {
            MD5,
            SHA1,
            SHA256
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
    }
}
