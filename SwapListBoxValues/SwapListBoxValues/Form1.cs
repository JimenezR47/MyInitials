using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Author: Rigoberto Jimenez    Purpose: To generate a list of 50 numbers and a list of 10 numbers than to swap them. Also the ability to save to a file and import.    Date: 10/28/2018
namespace SwapListBoxValues
{
    public partial class SwapBox : Form
    {
        public bool Value { get; set; }
        public SwapBox()
        {
            InitializeComponent();
        }

        private void bGenerate50_Click(object sender, EventArgs e)
        {
            lbGenerate50.Items.Clear();

            Random randomNumber = new Random();
            int tempNumber;

            for (int i = 1; i <= 50; i++)
            {
                tempNumber = randomNumber.Next(1000);
                lbGenerate50.Items.Add(tempNumber);
            }

            bGenerate10.Enabled = true;
        }

        private void bGenerate10_Click(object sender, EventArgs e)
        {
            lbGenerate10.Items.Clear();

            Random randomNumber = new Random();
            int tempNumber;

            for (int i = 1; i <= 10; i++)
            {
                tempNumber = randomNumber.Next(100);
                lbGenerate10.Items.Add(tempNumber);
            }
            bSave50.Enabled = true;
            bSwap.Enabled = true;
        }

        private void bSave50_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.CreateText(saveFileDialog.FileName);

                for (int i = 0; i < lbGenerate50.Items.Count; i++)
                {
                    outputFile.WriteLine(lbGenerate50.Items[i]);
                }

                outputFile.Close();

                MessageBox.Show("Numbers 50 saved.");
                bSave10.Enabled = true;
            }
        }

        private void bSave10_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.CreateText(saveFileDialog.FileName);

                for (int i = 0; i < lbGenerate10.Items.Count; i++)
                {
                    outputFile.WriteLine(lbGenerate10.Items[i]);
                }

                outputFile.Close();

                MessageBox.Show("Numbers 10 saved.");
                bClear.Enabled = true;
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            lbGenerate50.Items.Clear();
            lbGenerate10.Items.Clear();

            bLoad50.Enabled = true;
        }

        private void bLoad50_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            string lineIn;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFileDialog.FileName);

                while (!inputFile.EndOfStream)
                {
                    lineIn = inputFile.ReadLine();

                    lbGenerate50.Items.Add(lineIn);
                }

                inputFile.Close();
                MessageBox.Show("Numbers 50 loaded.");
                bLoad10.Enabled = true;
            }
        }

        private void bLoad10_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            string lineIn;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFileDialog.FileName);

                while (!inputFile.EndOfStream)
                {
                    lineIn = inputFile.ReadLine();

                    lbGenerate10.Items.Add(lineIn);
                }

                inputFile.Close();
                MessageBox.Show("Numbers 10 loaded.");
            }
        }

        private void bSwap_Click(object sender, EventArgs e)
        {
            if (Value == true)
            {
                lbGenerate10.Location = new Point(12, 12);
                lbGenerate50.Location = new Point(219, 12);

                Value = false;
            }

            else
            {
                lbGenerate10.Location = new Point(219, 12);
                lbGenerate50.Location = new Point(12, 12);

                Value = true;
            }
        }
    }
}
