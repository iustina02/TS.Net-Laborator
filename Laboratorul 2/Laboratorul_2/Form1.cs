using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorul_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool nonNumberEntered = false;

        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1].Equals('*'))
                MessageBox.Show("Deja e simbolul *");
            else if (textBox1.Text[textBox1.Text.Length - 1].Equals('-') || textBox1.Text[textBox1.Text.Length - 1].Equals('/') || textBox1.Text[textBox1.Text.Length - 1].Equals('+'))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.Text = textBox1.Text + "*";
            }
            else
                textBox1.Text = textBox1.Text + "*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1].Equals('/'))
                MessageBox.Show("Deja e simbolul /");
            else if (textBox1.Text[textBox1.Text.Length - 1].Equals('-') || textBox1.Text[textBox1.Text.Length - 1].Equals('+') || textBox1.Text[textBox1.Text.Length - 1].Equals('*'))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.Text = textBox1.Text + "/";
            }
            else
                textBox1.Text = textBox1.Text + "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "9";
        }

        private void unu_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "1";
        }

        private void doi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "2";
        }

        private void trei_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "3";
        }

        private void patru_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "4";
        }

        private void cinci_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "5";
        }

        private void sase_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "6";
        }

        private void sapte_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "7";
        }

        private void opt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "8";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1].Equals('+'))
                MessageBox.Show("Deja e simbolul +");
            else if (textBox1.Text[textBox1.Text.Length - 1].Equals('-') || textBox1.Text[textBox1.Text.Length - 1].Equals('/') || textBox1.Text[textBox1.Text.Length - 1].Equals('*'))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.Text = textBox1.Text + "+";
            }
            else
                textBox1.Text = textBox1.Text + "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1].Equals('-'))
                MessageBox.Show("Deja e simbolul -");
            else if (textBox1.Text[textBox1.Text.Length - 1].Equals('+') || textBox1.Text[textBox1.Text.Length - 1].Equals('/') || textBox1.Text[textBox1.Text.Length - 1].Equals('*'))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.Text = textBox1.Text + "-";
            }
            else
                textBox1.Text = textBox1.Text + "-";
        }

        private void result_Click(object sender, EventArgs e)
        {
            string calc = textBox1.Text;
            if (!calc[calc.Length - 1].Equals('+') && !calc[calc.Length - 1].Equals('-') && !calc[calc.Length - 1].Equals('/') && !calc[calc.Length - 1].Equals('*'))
            {
                for (int i = 0; i < calc.Length; i++)
                {
                    if (calc[i].Equals('+') || calc[i].Equals('-') || calc[i].Equals('*') || calc[i].Equals('/'))
                    {
                        string num1 = "";
                        for (int j = 0; j < i; j++)
                        {
                            num1 += calc[j];
                        }

                        string num2 = "";
                        for (int j = i + 1; j < calc.Length; j++)
                        {
                            num2 += calc[j];
                        }

                        float result = 0;
                        string result2 = "";

                        if (calc[i].Equals('+'))
                        {

                            result = float.Parse(num1) + float.Parse(num2);
                        }

                        if (calc[i].Equals('-'))
                        {
                            result = float.Parse(num1) - float.Parse(num2);
                        }

                        if (calc[i].Equals('*'))
                        {
                            result = float.Parse(num1) * float.Parse(num2);
                        }

                        if (calc[i].Equals('/'))
                        {
                            if (Int32.Parse(num2) != 0)
                            {
                                result = float.Parse(num1) / float.Parse(num2);
                            }
                            else
                            {
                                result2 = "Imposibil";
                                textBox1.Text = result2.ToString();
                            }
                        }

                        if (!textBox1.Text.Equals("Imposibil"))
                        {
                            label2.Text = textBox1.Text;
                            textBox1.Text = result.ToString();
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void punct_Click(object sender, EventArgs e)
        {
            int count_simbol = 0;
            int count_punct = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i].Equals('.'))
                    count_punct++;
                if (textBox1.Text[i].Equals('+') || textBox1.Text[i].Equals('-') || textBox1.Text[i].Equals('*') || textBox1.Text[i].Equals('/'))
                    count_simbol++;
            }
            if (count_punct < count_simbol + 1 )
                if(textBox1.Text.Length == 0)
                    textBox1.Text = textBox1.Text + "0.";
                else if (textBox1.Text[textBox1.Text.Length -1].Equals('+') || textBox1.Text[textBox1.Text.Length - 1].Equals('-') || textBox1.Text[textBox1.Text.Length - 1].Equals('/') || textBox1.Text[textBox1.Text.Length - 1].Equals('*'))
                    textBox1.Text = textBox1.Text + "0.";
                else
                    textBox1.Text = textBox1.Text + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }
    }
}
