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
        private byte[] _currentHash = null;

        public Main2()
        {
            InitializeComponent();

            //initialize hash engine
            _engine = new HashEngine();
        }

        private void Main2_Load(object sender, EventArgs e)
        {
            comboHashType.SelectedIndex = 0;
        }

        private void buttonFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                String fileName = openFile.FileName;
                textFilePath.Text = fileName;
            }
        }

        private void buttonHash_Click(object sender, EventArgs e)
        {
            String filePath = textFilePath.Text;
            if (filePath == String.Empty)
            {
                MessageBox.Show("The file path cannot be empty.", "File not found");
                textFilePath.Focus();
                return;
            }

            try
            {
                buttonHash.Enabled = false;

                string hashType = comboHashType.Text;
                if (string.IsNullOrEmpty(hashType)) return;

                switch (hashType)
                {
                    case "MD5":
                        _currentHash = _engine.HashFileMD5(filePath);
                        PrintHash();
                        break;
                    case "SHA-1":
                        _currentHash = _engine.HashFileSHA1(filePath);
                        PrintHash();
                        break;
                    case "SHA-256":
                        _currentHash = _engine.HashFileSHA256(filePath);
                        PrintHash();
                        break;
                    default:
                        break;
                }

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
            finally
            {
                textFilePath.Focus();
            }              
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textFilePath_DragDrop(object sender, DragEventArgs e)
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

                textFilePath.Text = filePath;
            }
        }

        private void textFilePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ClearHashes()
        {
            //clear existing hashes
            _currentHash = null;
            textHash.Text = "";
        }

        private void PrintHash()
        {
            bool upper = checkUseUpper.Checked;
            bool spaces = checkShowSpaces.Checked;
            string hashString;

            if (_currentHash == null) throw new Exception("Unable to display a null hash");

            hashString = _engine.ConvertToHexString(_currentHash);

            if (upper) hashString = hashString.ToUpper();
            else hashString = hashString.ToLower();

            textHash.Text = hashString;
        }

        private void checkUseUpper_CheckedChanged(object sender, EventArgs e)
        {
            bool ch = checkUseUpper.Checked;

            if(_currentHash == null) return;  //exit silently

            PrintHash();
        }

        private void checkShowSpaces_CheckedChanged(object sender, EventArgs e)
        {
            bool ch = checkShowSpaces.Checked;

            if (_currentHash == null) return; //exit silently

            PrintHash();
        }

        private void textFilePath_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textFilePath.Text)) ClearHashes();
        }
    }
}
