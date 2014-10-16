namespace HashVerifier
{
    partial class Main
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.buttonHash = new System.Windows.Forms.Button();
            this.textMD5 = new System.Windows.Forms.TextBox();
            this.textSHA1 = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMD5Copy = new System.Windows.Forms.Button();
            this.buttonSHA1Copy = new System.Windows.Forms.Button();
            this.buttonFilePath = new System.Windows.Forms.Button();
            this.textTarget = new System.Windows.Forms.TextBox();
            this.textSHA256 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(13, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 13);
            label1.TabIndex = 1;
            label1.Text = "File Path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 210);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 13);
            label2.TabIndex = 3;
            label2.Text = "MD5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 253);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 13);
            label3.TabIndex = 5;
            label3.Text = "SHA1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(13, 72);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 13);
            label4.TabIndex = 11;
            label4.Text = "Target (optional)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(16, 298);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 13);
            label5.TabIndex = 13;
            label5.Text = "SHA256";
            // 
            // textFilePath
            // 
            this.textFilePath.AllowDrop = true;
            this.textFilePath.Location = new System.Drawing.Point(13, 45);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(425, 20);
            this.textFilePath.TabIndex = 0;
            this.textFilePath.TextChanged += new System.EventHandler(this.textFilePath_TextChanged);
            this.textFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textFilePath_DragDrop);
            this.textFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textFilePath_DragEnter);
            // 
            // buttonHash
            // 
            this.buttonHash.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHash.Location = new System.Drawing.Point(10, 114);
            this.buttonHash.Name = "buttonHash";
            this.buttonHash.Size = new System.Drawing.Size(425, 36);
            this.buttonHash.TabIndex = 2;
            this.buttonHash.Text = "Hash";
            this.buttonHash.UseVisualStyleBackColor = false;
            this.buttonHash.Click += new System.EventHandler(this.buttonHash_Click);
            // 
            // textMD5
            // 
            this.textMD5.Location = new System.Drawing.Point(16, 226);
            this.textMD5.Name = "textMD5";
            this.textMD5.ReadOnly = true;
            this.textMD5.Size = new System.Drawing.Size(422, 20);
            this.textMD5.TabIndex = 4;
            // 
            // textSHA1
            // 
            this.textSHA1.Location = new System.Drawing.Point(16, 269);
            this.textSHA1.Name = "textSHA1";
            this.textSHA1.ReadOnly = true;
            this.textSHA1.Size = new System.Drawing.Size(422, 20);
            this.textSHA1.TabIndex = 6;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(380, 360);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMD5Copy
            // 
            this.buttonMD5Copy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMD5Copy.BackgroundImage")));
            this.buttonMD5Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMD5Copy.Location = new System.Drawing.Point(444, 225);
            this.buttonMD5Copy.Name = "buttonMD5Copy";
            this.buttonMD5Copy.Size = new System.Drawing.Size(20, 20);
            this.buttonMD5Copy.TabIndex = 8;
            this.buttonMD5Copy.UseVisualStyleBackColor = true;
            this.buttonMD5Copy.Click += new System.EventHandler(this.buttonMD5Copy_Click);
            // 
            // buttonSHA1Copy
            // 
            this.buttonSHA1Copy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSHA1Copy.BackgroundImage")));
            this.buttonSHA1Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSHA1Copy.Location = new System.Drawing.Point(444, 268);
            this.buttonSHA1Copy.Name = "buttonSHA1Copy";
            this.buttonSHA1Copy.Size = new System.Drawing.Size(20, 20);
            this.buttonSHA1Copy.TabIndex = 9;
            this.buttonSHA1Copy.UseVisualStyleBackColor = true;
            this.buttonSHA1Copy.Click += new System.EventHandler(this.buttonSHA1Copy_Click);
            // 
            // buttonFilePath
            // 
            this.buttonFilePath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFilePath.BackgroundImage")));
            this.buttonFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilePath.Location = new System.Drawing.Point(444, 45);
            this.buttonFilePath.Name = "buttonFilePath";
            this.buttonFilePath.Size = new System.Drawing.Size(20, 20);
            this.buttonFilePath.TabIndex = 10;
            this.buttonFilePath.UseVisualStyleBackColor = true;
            this.buttonFilePath.Click += new System.EventHandler(this.buttonFilePath_Click);
            // 
            // textTarget
            // 
            this.textTarget.BackColor = System.Drawing.Color.White;
            this.textTarget.Location = new System.Drawing.Point(13, 88);
            this.textTarget.Name = "textTarget";
            this.textTarget.Size = new System.Drawing.Size(422, 20);
            this.textTarget.TabIndex = 12;
            this.textTarget.TextChanged += new System.EventHandler(this.textTarget_TextChanged);
            // 
            // textSHA256
            // 
            this.textSHA256.Location = new System.Drawing.Point(16, 314);
            this.textSHA256.Name = "textSHA256";
            this.textSHA256.ReadOnly = true;
            this.textSHA256.Size = new System.Drawing.Size(422, 20);
            this.textSHA256.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(444, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textSHA256);
            this.Controls.Add(label5);
            this.Controls.Add(this.textTarget);
            this.Controls.Add(label4);
            this.Controls.Add(this.buttonFilePath);
            this.Controls.Add(this.buttonSHA1Copy);
            this.Controls.Add(this.buttonMD5Copy);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textSHA1);
            this.Controls.Add(label3);
            this.Controls.Add(this.textMD5);
            this.Controls.Add(label2);
            this.Controls.Add(this.buttonHash);
            this.Controls.Add(label1);
            this.Controls.Add(this.textFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash Verifier";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFilePath;
        private System.Windows.Forms.Button buttonHash;
        private System.Windows.Forms.TextBox textMD5;
        private System.Windows.Forms.TextBox textSHA1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMD5Copy;
        private System.Windows.Forms.Button buttonSHA1Copy;
        private System.Windows.Forms.Button buttonFilePath;
        private System.Windows.Forms.TextBox textTarget;
        private System.Windows.Forms.TextBox textSHA256;
        private System.Windows.Forms.Button button1;
    }
}