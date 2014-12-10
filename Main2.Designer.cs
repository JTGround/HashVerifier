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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main2));
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonHash = new System.Windows.Forms.Button();
            this.comboHashType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkShowSpaces = new System.Windows.Forms.CheckBox();
            this.checkUseUpper = new System.Windows.Forms.CheckBox();
            this.textHash = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonFilePath = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(6, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 13);
            label1.TabIndex = 12;
            label1.Text = "File Path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(505, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 13);
            label2.TabIndex = 13;
            label2.Text = "Hash Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(6, 16);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 13);
            label3.TabIndex = 14;
            label3.Text = "Output";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 16);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(32, 13);
            label6.TabIndex = 17;
            label6.Text = "Hash";
            // 
            // textFilePath
            // 
            this.textFilePath.AllowDrop = true;
            this.textFilePath.Location = new System.Drawing.Point(9, 32);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(434, 20);
            this.textFilePath.TabIndex = 11;
            this.textFilePath.TextChanged += new System.EventHandler(this.textFilePath_TextChanged);
            this.textFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textFilePath_DragDrop);
            this.textFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textFilePath_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFilePath);
            this.groupBox1.Controls.Add(this.buttonHash);
            this.groupBox1.Controls.Add(this.textFilePath);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.comboHashType);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 117);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // buttonHash
            // 
            this.buttonHash.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHash.Location = new System.Drawing.Point(114, 71);
            this.buttonHash.Name = "buttonHash";
            this.buttonHash.Size = new System.Drawing.Size(425, 36);
            this.buttonHash.TabIndex = 14;
            this.buttonHash.Text = "Hash";
            this.buttonHash.UseVisualStyleBackColor = false;
            this.buttonHash.Click += new System.EventHandler(this.buttonHash_Click);
            // 
            // comboHashType
            // 
            this.comboHashType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHashType.FormattingEnabled = true;
            this.comboHashType.Items.AddRange(new object[] {
            "MD5",
            "SHA-1",
            "SHA-256"});
            this.comboHashType.Location = new System.Drawing.Point(503, 31);
            this.comboHashType.Name = "comboHashType";
            this.comboHashType.Size = new System.Drawing.Size(139, 21);
            this.comboHashType.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(9, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 2);
            this.panel1.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkShowSpaces);
            this.groupBox2.Controls.Add(this.checkUseUpper);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Location = new System.Drawing.Point(500, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 157);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // checkShowSpaces
            // 
            this.checkShowSpaces.Checked = true;
            this.checkShowSpaces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkShowSpaces.Location = new System.Drawing.Point(6, 51);
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
            this.checkUseUpper.Location = new System.Drawing.Point(6, 33);
            this.checkUseUpper.Name = "checkUseUpper";
            this.checkUseUpper.Size = new System.Drawing.Size(139, 17);
            this.checkUseUpper.TabIndex = 15;
            this.checkUseUpper.Text = "Use Capital Letters";
            this.checkUseUpper.UseVisualStyleBackColor = true;
            this.checkUseUpper.CheckedChanged += new System.EventHandler(this.checkUseUpper_CheckedChanged);
            // 
            // textHash
            // 
            this.textHash.Location = new System.Drawing.Point(6, 32);
            this.textHash.Name = "textHash";
            this.textHash.ReadOnly = true;
            this.textHash.Size = new System.Drawing.Size(422, 20);
            this.textHash.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textHash);
            this.groupBox3.Controls.Add(label6);
            this.groupBox3.Location = new System.Drawing.Point(9, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 157);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // buttonFilePath
            // 
            this.buttonFilePath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFilePath.BackgroundImage")));
            this.buttonFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilePath.Location = new System.Drawing.Point(449, 32);
            this.buttonFilePath.Name = "buttonFilePath";
            this.buttonFilePath.Size = new System.Drawing.Size(20, 20);
            this.buttonFilePath.TabIndex = 15;
            this.buttonFilePath.UseVisualStyleBackColor = true;
            this.buttonFilePath.Click += new System.EventHandler(this.buttonFilePath_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(585, 316);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 24;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 352);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main2";
            this.Text = "Hash Verifier";
            this.Load += new System.EventHandler(this.Main2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textFilePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboHashType;
        private System.Windows.Forms.CheckBox checkUseUpper;
        private System.Windows.Forms.CheckBox checkShowSpaces;
        private System.Windows.Forms.Button buttonHash;
        private System.Windows.Forms.TextBox textHash;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonFilePath;
        private System.Windows.Forms.Button buttonClose;
    }
}