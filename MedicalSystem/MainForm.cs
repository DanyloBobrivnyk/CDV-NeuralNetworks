using NeuralNetworks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void enterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var enterdataForm = new EnterData();
            var result = enterdataForm.ShowForm();
        }

        private void insertTestDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var enterdataForm = new EnterData();
            var result = enterdataForm.ShowForm();
        }
        private void initializeController(object sender, EventArgs e)
        {
            Program.Controller = new SystemController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            var epochsAmount = int.Parse(EpochsTestTextBox.Text);

            stopwatch.Start();
            Program.Controller.TestDataNetwork.Learn(TestDataSet.outputs, TestDataSet.inputs, epochsAmount);
            stopwatch.Stop();


            System.Windows.Forms.MessageBox.Show("Training was finished with " + epochsAmount + " epochs" +
                "\nTime required:" + stopwatch.ElapsedMilliseconds + " milliseconds");
        }


        private void ExtendedDataSet_Button_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            var epochsAmount = int.Parse(ExtendedDataSet_TextBox.Text);

            stopwatch.Start();
            Program.Controller.DataNetwork.Learn(TestDataSet.outputs, TestDataSet.inputs, epochsAmount);
            stopwatch.Stop();


            System.Windows.Forms.MessageBox.Show("Training was finished with " + epochsAmount + " epochs" +
                "\nTime required:" + stopwatch.ElapsedMilliseconds + " milliseconds");
        }
    }
}
