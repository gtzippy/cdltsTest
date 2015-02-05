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
        private IEnumerable<string> _numbersString;
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "text documents (*.txt)|*.txt"
            };
            ofd.ShowDialog();
            richTextBox1.Clear();
            computePrimesButton.Enabled = false;
            if (string.IsNullOrWhiteSpace(ofd.FileName) || Path.GetExtension(ofd.FileName) != ".txt")   //only take in .txt files
            {
                MessageBox.Show("Select a valid .txt file");
                label1.Text = "No File Selected";
                return;
            }
            _filePath = ofd.FileName;
            _numbersString = File.ReadLines(_filePath);
            _numbersString = _numbersString.Where(entry => !string.IsNullOrWhiteSpace(entry));    //remove empty entries caused by empty lines
            if (_numbersString.Any(entry => !FunctionRepository.CheckStringValue(entry)))
            {
                MessageBox.Show("All values in .txt file must be integers.  Please reference your file for non-integer values");
                return;
            }
            computePrimesButton.Enabled = true;
            label1.Text = Path.GetFileName(_filePath);
        }

        private void computePrimesButton_Click(object sender, EventArgs e)
        {
           if (!File.Exists(_filePath))
            {
                MessageBox.Show("Select a valid .txt file");
                return;
            }

            List<int> numbers = _numbersString.Select(int.Parse).ToList();
            foreach (int number in numbers)
            {
                string productString;
                richTextBox1.Text += number+": Prime Factors: "+FunctionRepository.BuildOutputString(number, out productString) + "\n";
            }
        }
    }
}
