using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Before doing anything, make sure retail resources are decrypted
//make use of the VOiD Decryptor 

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();

       //This is where buttons call for file locations
        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = ofd.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = ofd.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = ofd.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = ofd.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox8.Text = ofd.FileName;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = ofd.FileName;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox7.Text = ofd.FileName;
            }
        }

        //Make buttons and textboxes enabled
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button7.Enabled = true;
            }
            if (checkBox1.Checked == false)
            {
                button7.Enabled = false;
            }
            if (checkBox1.Checked == true)
            {
                textBox6.Enabled = true;
            }
            if (checkBox1.Checked == false)
            {
                textBox6.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                button8.Enabled = true;
            }
            if (checkBox2.Checked == false)
            {
                button8.Enabled = false;
            }
            if (checkBox2.Checked == true)
            {
                textBox7.Enabled = true;
            }
            if (checkBox2.Checked == false)
            {
                textBox7.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                button6.Enabled = true;
            }
            if (checkBox3.Checked == false)
            {
                button6.Enabled = false;
            }
            if (checkBox3.Checked == true)
            {
                textBox8.Enabled = true;
            }
            if (checkBox3.Checked == false)
            {
                textBox8.Enabled = false;
            }
        }

        //If an ELF is used:
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                button1.Enabled = false;
            }
            if (checkBox5.Checked == false)
            {
                button1.Enabled = true;
            }
            if (checkBox5.Checked == true)
            {
                textBox1.Enabled = false;
            }
            if (checkBox5.Checked == false)
            {
                textBox1.Enabled = true;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                checkBox4.Enabled = false;
            }
            if (radioButton2.Checked == false)
            {
                checkBox4.Enabled = true;
            }
        }
        
        //Text is copied to the textbox for the output command.
        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (checkBox4.Checked == true)
                {
                    richTextBox1.Text = "makerom -f cci -target d -alignwr ";
                }
                else
                richTextBox1.Text = "makerom -f cci -target d ";
            }

            if (radioButton2.Checked == true)
            {
                richTextBox1.Text = "makerom -f cia -desc app:4 -target d ";
            }
            richTextBox1.AppendText("-rsf ");
            richTextBox1.AppendText(label3.Text);
            richTextBox1.AppendText(textBox5.Text);
            richTextBox1.AppendText(label3.Text);
            richTextBox1.AppendText(" -o ");
            richTextBox1.AppendText(label3.Text);
            richTextBox1.AppendText(textBox9.Text);
            richTextBox1.AppendText(label3.Text);
            richTextBox1.AppendText(" -exefslogo ");
            richTextBox1.AppendText("-icon ");
            richTextBox1.AppendText(label3.Text);
            richTextBox1.AppendText(textBox4.Text);
            richTextBox1.AppendText(label3.Text);
            richTextBox1.AppendText(" -banner ");
            richTextBox1.AppendText(label3.Text);
            richTextBox1.AppendText(textBox3.Text);
            richTextBox1.AppendText(label3.Text);
            
            if (checkBox5.Checked == true)
            {
                richTextBox1.AppendText(" -elf ");
                richTextBox1.AppendText(label3.Text);
                richTextBox1.AppendText(textBox2.Text);
                richTextBox1.AppendText(label3.Text);
            }
            else
            {
                richTextBox1.AppendText(" -code ");
                richTextBox1.AppendText(label3.Text);
                richTextBox1.AppendText(textBox2.Text);
                richTextBox1.AppendText(label3.Text);
            }

            if (checkBox5.Checked == false)
            {
                richTextBox1.AppendText(" -exheader ");
                richTextBox1.AppendText(label3.Text);
                richTextBox1.AppendText(textBox1.Text);
                richTextBox1.AppendText(label3.Text);
            }

            if (checkBox3.Checked == true)
            {
                richTextBox1.AppendText(" -romfs ");
                richTextBox1.AppendText(label3.Text);
                richTextBox1.AppendText(textBox8.Text);
                richTextBox1.AppendText(label3.Text);
            }
            if (checkBox2.Checked == true)
            {
                richTextBox1.AppendText(" -content ");
                richTextBox1.AppendText(label3.Text);
                richTextBox1.AppendText(textBox8.Text);
                richTextBox1.AppendText(label3.Text);
                richTextBox1.AppendText(":1 ");
            }
            if (checkBox1.Checked == true)
            {
                richTextBox1.AppendText(" -content ");
                richTextBox1.AppendText(label3.Text);
                richTextBox1.AppendText(textBox8.Text);
                richTextBox1.AppendText(label3.Text);
                richTextBox1.AppendText(":7 ");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textBox9.Text = sfd.FileName;
            }
        }
    }
}
