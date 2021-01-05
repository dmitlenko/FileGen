using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace FileGen
{
    public partial class MainForm : Form
    {
        private void createFile(string path,long size)
        {
            FileStream fs = new FileStream(@path, FileMode.OpenOrCreate);
            fs.Seek((size - 1), SeekOrigin.Begin);
            fs.WriteByte(0);
            fs.Close();
        }
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dmitlenko/FileGen");
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            fileCreator.FileName = filenameField.Text;
            fileCreator.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            filesizeField.SelectedIndex = 0;
            filenameField.Text = "myfile.bin";
        }

        private void fileCreator_FileOk(object sender, CancelEventArgs e)
        {
            string input = filesizeField.SelectedItem.ToString();
            //createFile(fileCreator.FileName, (int)(fileSizeNumField.Value * (10 ^ ( filesizeField.SelectedIndex + 1 ))));
            switch (filesizeField.SelectedIndex)
            {
                case 0:
                    createFile(fileCreator.FileName, (long)fileSizeNumField.Value );
                    break;
                case 1:
                    createFile(fileCreator.FileName, (long)(fileSizeNumField.Value * 1024));
                    break;
                case 2:
                    createFile(fileCreator.FileName, (long)(fileSizeNumField.Value * 1024 * 1024));
                    break;
                case 3:
                    createFile(fileCreator.FileName, (long)(fileSizeNumField.Value * 1024 * 1024 * 1024));
                    break;
            }
        }

        private void filesizeField_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hello)
        }
    }
}
