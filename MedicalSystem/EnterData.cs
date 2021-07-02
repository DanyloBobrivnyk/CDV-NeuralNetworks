using NeuralNetworks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class EnterData : Form
    {
        private List<TextBox> Inputs = new List<TextBox>();

        public EnterData()
        {
            
            InitializeComponent();

            //var propInfo = typeof(Patient).GetProperties();
            var propInfo = typeof(TestPatient).GetProperties();

            for (int i = 0; i < propInfo.Length; i++)
            {
                var property = propInfo[i];
                var textBox = CreateTextBox(i, property);
                Controls.Add(textBox);
                Inputs.Add(textBox);
            }

        }

        public bool? ShowForm()
        {
            var form = new EnterData();
            if(form.ShowDialog() == DialogResult.OK)
            {
                var patient = new TestPatient();
                List<double> inputSignals = new List<double>();
                foreach(var textBox in form.Inputs)
                {
                    patient.GetType().InvokeMember(textBox.Tag.ToString(),
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
                        Type.DefaultBinder, patient, new object[] { textBox.Text });

                    inputSignals.Add(Double.Parse(textBox.Text.ToString()));
                }

                var topology = new Topology(4, 1, 0.1, 2);
                var neuralNetwork = new NeuralNetwork(topology);

                //var difference = neuralNetwork.Learn(TestDataSet.outputs, TestDataSet.inputs, 10000);
                //Program.Controller.TestDataNetwork.Learn(TestDataSet.outputs, TestDataSet.inputs, 2);

                var result = Program.Controller.TestDataNetwork.Predict(inputSignals.ToArray())?.Output;
                var simplifiedResult = Math.Round((double)result, 4);

                System.Windows.Forms.MessageBox.Show(simplifiedResult.ToString());
                return true;
            }

            return null;
        }

        private void EnterData_Load(object sender, EventArgs e)
        {

        }

        private TextBox CreateTextBox(int number, PropertyInfo property)
        {
            var y = number * 25 + 12;
            var textbox = new TextBox
            {
                Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right),
                Location = new Point(12, y),
                Name = "textBox" + number,
                Size = new Size(335, 20),
                TabIndex = number,
                Text = property.Name,
                Tag = property.Name,
                Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 204),
                ForeColor = Color.Gray
        };

            textbox.GotFocus += Textbox_GotFocus;
            textbox.LostFocus += Textbox_LostFocus;

            return textbox;
        }

        private void Textbox_LostFocus(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text == "")
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
                textBox.ForeColor = Color.Gray;
            }
        }

        private void Textbox_GotFocus(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
                textBox.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
