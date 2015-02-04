using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeFactorization;

namespace PrimeFactorizationGUI
{
    public partial class Form1 : Form
    {
        private string _filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            richTextBox1.Clear();
            if (string.IsNullOrWhiteSpace(ofd.FileName) || Path.GetExtension(ofd.FileName) != ".txt")
            {
                MessageBox.Show("Select a valid .txt file");
                computePrimesButton.Enabled = false;
                label1.Text = "No File Selected";
                return;
            }
            computePrimesButton.Enabled = true;
            _filePath = ofd.FileName;
            label1.Text = Path.GetFileName(_filePath);
        }

        private void computePrimesButton_Click(object sender, EventArgs e)
        {
           if (!File.Exists(_filePath))
            {
                MessageBox.Show("Select a valid .txt file");
                return;
            }
            IEnumerable<string> numbersString = File.ReadLines(_filePath);
            List<int> numbers = numbersString.Select(int.Parse).ToList();
            foreach (int number in numbers)
            {
                richTextBox1.Text += FunctionRepository.BuildOutputString(number) + "\n";
            }
        }
    }
}
