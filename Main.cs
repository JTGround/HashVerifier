﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Security.Cryptography;
using System.IO;
using System.Globalization;
using System.Diagnostics;
using System.Threading.Tasks;

namespace HashVerifier
{
    public partial class Main : Form
    {

        private HashEngine _engine = null;

        public Main()
        {
            InitializeComponent();

            //initialize hash engine
            _engine = new HashEngine();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

                var md5Hash = _engine.HashFileMD5(filePath);
                var sha1Hash = _engine.HashFileSHA1(filePath);
                var sha256Hash = _engine.HashFileSHA256(filePath);

                textMD5.Text = _engine.ConvertToHexString(md5Hash);
                textSHA1.Text = _engine.ConvertToHexString(sha1Hash);
                textSHA256.Text = _engine.ConvertToHexString(sha256Hash);

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

        private void buttonMD5Copy_Click(object sender, EventArgs e)
        {
            if (textMD5.TextLength > 0)
            {
                textMD5.SelectAll();
                String textValue = textMD5.Text;
                Clipboard.SetText(textValue);
            }
            
        }

        private void buttonSHA1Copy_Click(object sender, EventArgs e)
        {
            if (textSHA1.TextLength > 0)
            {
                textSHA1.SelectAll();
                String textValue = textSHA1.Text;
                Clipboard.SetText(textValue);
            }
            
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

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void textTarget_TextChanged(object sender, EventArgs e)
        {
            Color matchColor = Color.FromArgb(241, 226, 61);
            Color whiteColor = Color.FromName("White");
            String target = textTarget.Text;

            //clear existing color
            textTarget.BackColor = whiteColor;
            textMD5.BackColor = whiteColor;
            textSHA1.BackColor = whiteColor;
            textSHA256.BackColor = whiteColor;

            CultureInfo info = CultureInfo.CurrentCulture;
            StringComparer co = StringComparer.Create(info, true);
            if (co.Compare(target,textMD5.Text) == 0)
            {
                textTarget.BackColor = matchColor;
                textMD5.BackColor = matchColor;
            }
            else if (co.Compare(target,textSHA1.Text) == 0)
            {
                textTarget.BackColor = matchColor;
                textSHA1.BackColor = matchColor;
            }
            else if (co.Compare(target,textSHA256.Text) == 0)
            {
                textTarget.BackColor = matchColor;
                textSHA256.BackColor = matchColor;
            }
        }

        private void textFilePath_TextChanged(object sender, EventArgs e)
        {
            if (textFilePath.Text == String.Empty)
            {
                ClearHashes();
            }
        }

        private void ClearHashes()
        {
            //clear existing hashes
            textMD5.Text = "";
            textSHA1.Text = "";
            textSHA256.Text = "";
        }
    }
}
