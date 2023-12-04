using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PeriodicTableofElements
{
    public partial class FormElements : Form
    {
        public FormElements()
        {
            InitializeComponent();
            elementsBindingSource.PositionChanged += ElementsBindingSource_PositionChanged;
        }

        private void FormElements_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Elements' table. You can move, or remove it, as needed.
            this.elementsTableAdapter.Fill(this.dataSet1.Elements);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elementsBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            elementsBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (elementsBindingSource.Position > 0)
                elementsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (elementsBindingSource.Position < elementsBindingSource.List.Count - 1)
                elementsBindingSource.MoveNext ();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process browserlauncher = new Process();
            browserlauncher.StartInfo.CreateNoWindow = true;
            browserlauncher.StartInfo.ErrorDialog = false;
            browserlauncher.StartInfo.UseShellExecute = false;
            browserlauncher.StartInfo.ErrorDialog = true;
            browserlauncher.StartInfo.FileName = @"cmd.exe";
            browserlauncher.StartInfo.Arguments = @"/c start https://www.google.com/search?q=periodic+table+of+elements";
            browserlauncher.Start();
        }

        private void ElementsBindingSource_PositionChanged(object sender, System.EventArgs e)
        {
            if (elementsBindingSource.Position == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }   

            if (elementsBindingSource.Position ==  elementsBindingSource.List.Count -1) 
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0) 
            {
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                button5.Enabled = true;
            }
            else 
            {
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                button5.Enabled = false;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length > 0)
            {
                textBox4.Enabled = false;
                textBox6.Enabled = false;
                button5.Enabled = true;
            }
            else
            {
                textBox4.Enabled = true;
                textBox6.Enabled = true;
                button5.Enabled = false;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length > 0)
            {
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                button5.Enabled = true;
            }
            else
            {
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                button5.Enabled= false;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int value))
            {
                if (value <= 0)
                    textBox4.Text = string.Empty;
                if (value > elementsBindingSource.Count)
                {
                    MessageBox.Show($"The highest element number is {elementsBindingSource.Count}",
                                    "Element number search",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox4.Text = string.Empty;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int row;

            if (textBox4.Text.Length > 0)
            {
                row = elementsBindingSource.Find("ElementNumber", textBox4.Text);
            }
            else if (textBox5.Text.Length > 0)
            {
                row = elementsBindingSource.Find("ElementSymbol", textBox5.Text);
            }
            else
            {
                row = elementsBindingSource.Find("ElementName", textBox6.Text);
            }
            if (row >= 0)
            {
                elementsBindingSource.Position = row;
            }
            else
            {
                string searchtext = textBox4.TextLength > 0 ? $"Element Number: '{textBox4.Text}'" : string.Empty;
                searchtext += textBox5.TextLength > 0 ? $"Element Symbol: '{textBox5.Text}'" : string.Empty;
                searchtext += textBox6.TextLength > 0 ? $"Element Name: '{textBox6.Text}'" : string.Empty;
                MessageBox.Show($"No element returned by the search\n{searchtext}", "Element search",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
        }
    }
}
