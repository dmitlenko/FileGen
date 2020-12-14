
namespace FileGen
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fileCreator = new System.Windows.Forms.SaveFileDialog();
            this.filenameField = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filesizeField = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.link = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSizeNumField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSizeNumField)).BeginInit();
            this.SuspendLayout();
            // 
            // fileCreator
            // 
            this.fileCreator.FileOk += new System.ComponentModel.CancelEventHandler(this.fileCreator_FileOk);
            // 
            // filenameField
            // 
            this.filenameField.Location = new System.Drawing.Point(8, 72);
            this.filenameField.Name = "filenameField";
            this.filenameField.Size = new System.Drawing.Size(280, 20);
            this.filenameField.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(224, 152);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(64, 24);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File name:";
            // 
            // filesizeField
            // 
            this.filesizeField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filesizeField.FormattingEnabled = true;
            this.filesizeField.Items.AddRange(new object[] {
            "b",
            "Kb",
            "Mb",
            "Gb"});
            this.filesizeField.Location = new System.Drawing.Point(224, 120);
            this.filesizeField.Name = "filesizeField";
            this.filesizeField.Size = new System.Drawing.Size(64, 21);
            this.filesizeField.TabIndex = 3;
            this.filesizeField.SelectedIndexChanged += new System.EventHandler(this.filesizeField_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File size:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(8, 184);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(66, 13);
            this.link.TabIndex = 6;
            this.link.TabStop = true;
            this.link.Text = "by dmitlenko";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(232, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "v1.1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fileSizeNumField
            // 
            this.fileSizeNumField.Location = new System.Drawing.Point(8, 120);
            this.fileSizeNumField.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.fileSizeNumField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fileSizeNumField.Name = "fileSizeNumField";
            this.fileSizeNumField.Size = new System.Drawing.Size(208, 20);
            this.fileSizeNumField.TabIndex = 8;
            this.fileSizeNumField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 208);
            this.Controls.Add(this.fileSizeNumField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.link);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filesizeField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.filenameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "FileGen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSizeNumField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog fileCreator;
        private System.Windows.Forms.TextBox filenameField;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filesizeField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown fileSizeNumField;
    }
}

