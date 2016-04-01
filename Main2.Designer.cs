namespace HashVerifier
{
    partial class Main2
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main2));
            this.groupFileSelect = new System.Windows.Forms.GroupBox();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonFilePath = new System.Windows.Forms.Button();
            this.buttonHash = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkShowSpaces = new System.Windows.Forms.CheckBox();
            this.checkUseUpper = new System.Windows.Forms.CheckBox();
            this.textMD5 = new System.Windows.Forms.TextBox();
            this.textSHA1 = new System.Windows.Forms.TextBox();
            this.textSHA256 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSHA1Copy = new System.Windows.Forms.Button();
            this.buttonMD5Copy = new System.Windows.Forms.Button();
            this.backgroundMD5 = new System.ComponentModel.BackgroundWorker();
            this.backgroundSHA1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundSHA256 = new System.ComponentModel.BackgroundWorker();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupFileSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(6, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 13);
            label1.TabIndex = 12;
            label1.Text = "File Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(380, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 13);
            label3.TabIndex = 14;
            label3.Text = "Output";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(380, 87);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(30, 13);
            label6.TabIndex = 17;
            label6.Text = "MD5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(6, 46);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(49, 13);
            label7.TabIndex = 17;
            label7.Text = "File Size:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(380, 139);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(35, 13);
            label4.TabIndex = 25;
            label4.Text = "SHA1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(380, 193);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 13);
            label2.TabIndex = 27;
            label2.Text = "SHA256";
            // 
            // groupFileSelect
            // 
            this.groupFileSelect.Controls.Add(this.labelFileSize);
            this.groupFileSelect.Controls.Add(label7);
            this.groupFileSelect.Controls.Add(this.labelFileName);
            this.groupFileSelect.Controls.Add(this.buttonFilePath);
            this.groupFileSelect.Controls.Add(label1);
            this.groupFileSelect.Location = new System.Drawing.Point(12, 12);
            this.groupFileSelect.Name = "groupFileSelect";
            this.groupFileSelect.Size = new System.Drawing.Size(350, 225);
            this.groupFileSelect.TabIndex = 14;
            this.groupFileSelect.TabStop = false;
            this.groupFileSelect.DragDrop += new System.Windows.Forms.DragEventHandler(this.groupFileSelect_DragDrop);
            this.groupFileSelect.DragEnter += new System.Windows.Forms.DragEventHandler(this.groupFileSelect_DragEnter);
            // 
            // labelFileSize
            // 
            this.labelFileSize.Location = new System.Drawing.Point(69, 46);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(273, 13);
            this.labelFileSize.TabIndex = 18;
            // 
            // labelFileName
            // 
            this.labelFileName.Location = new System.Drawing.Point(69, 16);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(273, 13);
            this.labelFileName.TabIndex = 16;
            // 
            // buttonFilePath
            // 
            this.buttonFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilePath.Location = new System.Drawing.Point(287, 172);
            this.buttonFilePath.Name = "buttonFilePath";
            this.buttonFilePath.Size = new System.Drawing.Size(57, 47);
            this.buttonFilePath.TabIndex = 15;
            this.buttonFilePath.Text = "Browse";
            this.buttonFilePath.UseVisualStyleBackColor = true;
            this.buttonFilePath.Click += new System.EventHandler(this.buttonFilePath_Click);
            // 
            // buttonHash
            // 
            this.buttonHash.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHash.Location = new System.Drawing.Point(12, 261);
            this.buttonHash.Name = "buttonHash";
            this.buttonHash.Size = new System.Drawing.Size(350, 36);
            this.buttonHash.TabIndex = 14;
            this.buttonHash.Text = "Hash";
            this.buttonHash.UseVisualStyleBackColor = false;
            this.buttonHash.Click += new System.EventHandler(this.buttonHash_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 2);
            this.panel1.TabIndex = 15;
            // 
            // checkShowSpaces
            // 
            this.checkShowSpaces.Checked = true;
            this.checkShowSpaces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkShowSpaces.Location = new System.Drawing.Point(380, 54);
            this.checkShowSpaces.Name = "checkShowSpaces";
            this.checkShowSpaces.Size = new System.Drawing.Size(148, 17);
            this.checkShowSpaces.TabIndex = 16;
            this.checkShowSpaces.Text = "Show Separating Spaces";
            this.checkShowSpaces.UseVisualStyleBackColor = true;
            this.checkShowSpaces.CheckedChanged += new System.EventHandler(this.checkShowSpaces_CheckedChanged);
            // 
            // checkUseUpper
            // 
            this.checkUseUpper.Checked = true;
            this.checkUseUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkUseUpper.Location = new System.Drawing.Point(380, 36);
            this.checkUseUpper.Name = "checkUseUpper";
            this.checkUseUpper.Size = new System.Drawing.Size(139, 17);
            this.checkUseUpper.TabIndex = 15;
            this.checkUseUpper.Text = "Use Capital Letters";
            this.checkUseUpper.UseVisualStyleBackColor = true;
            this.checkUseUpper.CheckedChanged += new System.EventHandler(this.checkUseUpper_CheckedChanged);
            // 
            // textMD5
            // 
            this.textMD5.Location = new System.Drawing.Point(380, 103);
            this.textMD5.Name = "textMD5";
            this.textMD5.ReadOnly = true;
            this.textMD5.Size = new System.Drawing.Size(422, 20);
            this.textMD5.TabIndex = 18;
            // 
            // textSHA1
            // 
            this.textSHA1.Location = new System.Drawing.Point(380, 155);
            this.textSHA1.Name = "textSHA1";
            this.textSHA1.ReadOnly = true;
            this.textSHA1.Size = new System.Drawing.Size(422, 20);
            this.textSHA1.TabIndex = 26;
            // 
            // textSHA256
            // 
            this.textSHA256.Location = new System.Drawing.Point(380, 209);
            this.textSHA256.Name = "textSHA256";
            this.textSHA256.ReadOnly = true;
            this.textSHA256.Size = new System.Drawing.Size(422, 20);
            this.textSHA256.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(808, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonSHA1Copy
            // 
            this.buttonSHA1Copy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSHA1Copy.BackgroundImage")));
            this.buttonSHA1Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSHA1Copy.Location = new System.Drawing.Point(808, 154);
            this.buttonSHA1Copy.Name = "buttonSHA1Copy";
            this.buttonSHA1Copy.Size = new System.Drawing.Size(20, 20);
            this.buttonSHA1Copy.TabIndex = 30;
            this.buttonSHA1Copy.UseVisualStyleBackColor = true;
            // 
            // buttonMD5Copy
            // 
            this.buttonMD5Copy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMD5Copy.BackgroundImage")));
            this.buttonMD5Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMD5Copy.Location = new System.Drawing.Point(808, 102);
            this.buttonMD5Copy.Name = "buttonMD5Copy";
            this.buttonMD5Copy.Size = new System.Drawing.Size(20, 20);
            this.buttonMD5Copy.TabIndex = 29;
            this.buttonMD5Copy.UseVisualStyleBackColor = true;
            // 
            // backgroundMD5
            // 
            this.backgroundMD5.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundHash_RunWorkerCompleted);
            // 
            // backgroundSHA1
            // 
            this.backgroundSHA1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundSHA1_RunWorkerCompleted);
            // 
            // backgroundSHA256
            // 
            this.backgroundSHA256.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundSHA256_RunWorkerCompleted);
            // 
            // Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSHA1Copy);
            this.Controls.Add(this.buttonMD5Copy);
            this.Controls.Add(this.checkShowSpaces);
            this.Controls.Add(this.textSHA256);
            this.Controls.Add(this.checkUseUpper);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.textSHA1);
            this.Controls.Add(label4);
            this.Controls.Add(this.textMD5);
            this.Controls.Add(label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonHash);
            this.Controls.Add(this.groupFileSelect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main2";
            this.Text = "Hash Verifier";
            this.Load += new System.EventHandler(this.Main2_Load);
            this.groupFileSelect.ResumeLayout(false);
            this.groupFileSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupFileSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkUseUpper;
        private System.Windows.Forms.CheckBox checkShowSpaces;
        private System.Windows.Forms.Button buttonHash;
        private System.Windows.Forms.TextBox textMD5;
        private System.Windows.Forms.Button buttonFilePath;
        private System.Windows.Forms.Label labelFileSize;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.TextBox textSHA1;
        private System.Windows.Forms.TextBox textSHA256;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSHA1Copy;
        private System.Windows.Forms.Button buttonMD5Copy;
        private System.ComponentModel.BackgroundWorker backgroundMD5;
        private System.ComponentModel.BackgroundWorker backgroundSHA1;
        private System.ComponentModel.BackgroundWorker backgroundSHA256;
    }
}