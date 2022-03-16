using System;
using System.Windows.Forms;

namespace Binary_Calculator
{
    public partial class Form1 : Form
    {
        Computer computer = new Computer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a, b = 0, c = 0;
            try
            {
                a = Convert.ToInt32(firstNum.Text, 2);
                if (textBox2.Enabled)
                {
                    b = Convert.ToInt32(textBox2.Text, 2);
                }
            }
            catch (Exception)
            {
                a = 0;
                b = 0;
                firstNum.Text = "0";
                textBox2.Text = "0";
                MessageBox.Show("Двоичное число может содержать только цифры 0 и 1");
            }
            
            switch (comboBox1.Text)
            {
                case "AND":
                    c = computer.And(a,b);
                    break;
                case "OR":
                    c = computer.Or(a, b);
                    break;
                case "XOR":
                    c = computer.Xor(a, b);
                    break;
                case "NOT":
                    c = computer.Not(a);
                    break;
                default:
                    break;
            }
            if (radioButton1.Checked)
            {
                textBox3.Text = Convert.ToString(c, 2);
            }
            if (radioButton2.Checked)
            {
                textBox3.Text = Convert.ToString(c, 8);
            }
            if (radioButton3.Checked)
            {
                textBox3.Text = Convert.ToString(c, 10);
            }
            if (radioButton4.Checked)
            {
                textBox3.Text = Convert.ToString(c, 16);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstNum.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox1.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = comboBox1.Text != "NOT";
        }
    }
}
