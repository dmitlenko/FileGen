using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileGen
{
    public partial class MainForm : Form
    {
        private void createFile(string path,int size)
        {
            FileStream fs = new FileStream(@path, FileMode.OpenOrCreate);
            fs.Seek(((long)size) * 1024 * 1024, SeekOrigin.Begin);
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
            createFile(fileCreator.FileName, Convert.ToInt32(Regex.Replace(input, "[^0-9]", "")));
        }
    }
}
