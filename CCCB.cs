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
using System.Diagnostics;

//Before doing anything, make sure retail resources are decrypted
//make use of the VOiD Decryptor 

namespace CommandBuilder
{
    public partial class CCCB : Form
    {
        public CCCB()
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
                exheaderText.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                codeText.Text = ofd.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bannerText.Text = ofd.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                iconText.Text = ofd.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rsfText.Text = ofd.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                romfsText.Text = ofd.FileName;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                manualText.Text = ofd.FileName;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                updateText.Text = ofd.FileName;
            }
        }

        //Make buttons and textboxes enabled
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            manualButton.Enabled = useManual.Checked;
            manualText.Enabled = useManual.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            updateText.Enabled = useUpdate.Checked;
            updateButton.Enabled = useUpdate.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            romfsButton.Enabled = useRomFS.Checked;
            romfsText.Enabled = useRomFS.Checked;
        }

        //If an ELF is used:
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            exheaderButton.Enabled = !useELF.Checked;
            exheaderText.Enabled = !useELF.Checked;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            alignwr.Enabled = !ciaMode.Checked;
            fwNumber.Enabled = ciaMode.Checked;
        }
        
        //Text is copied to the textbox for the output command.
        private void button9_Click(object sender, EventArgs e)
        {
            if (cciMode.Checked == true)
            {
                if (alignwr.Checked == true)
                {
                    commandText.Text = "makerom -f cci -target d -alignwr ";
                }
                else
                commandText.Text = "makerom -f cci -target d ";
            }

            if (ciaMode.Checked == true)
            {
                commandText.Text = "makerom -f cia -desc app:" + fwNumber.Text;
                commandText.AppendText(" -target d ");
            }
            commandText.AppendText("-rsf ");
            commandText.AppendText(quotation.Text);
            commandText.AppendText(rsfText.Text);
            commandText.AppendText(quotation.Text);
            commandText.AppendText(" -o ");
            commandText.AppendText(quotation.Text);
            commandText.AppendText(outputText.Text);
            commandText.AppendText(quotation.Text);
            commandText.AppendText(" -exefslogo ");
            commandText.AppendText("-icon ");
            commandText.AppendText(quotation.Text);
            commandText.AppendText(iconText.Text);
            commandText.AppendText(quotation.Text);
            commandText.AppendText(" -banner ");
            commandText.AppendText(quotation.Text);
            commandText.AppendText(bannerText.Text);
            commandText.AppendText(quotation.Text);
            
            if (useELF.Checked == true)
            {
                commandText.AppendText(" -elf ");
                commandText.AppendText(quotation.Text);
                commandText.AppendText(codeText.Text);
                commandText.AppendText(quotation.Text);
            }
            else
            {
                commandText.AppendText(" -code ");
                commandText.AppendText(quotation.Text);
                commandText.AppendText(codeText.Text);
                commandText.AppendText(quotation.Text);
            }

            if (useELF.Checked == false)
            {
                commandText.AppendText(" -exheader ");
                commandText.AppendText(quotation.Text);
                commandText.AppendText(exheaderText.Text);
                commandText.AppendText(quotation.Text);
            }

            if (useRomFS.Checked == true)
            {
                commandText.AppendText(" -romfs ");
                commandText.AppendText(quotation.Text);
                commandText.AppendText(romfsText.Text);
                commandText.AppendText(quotation.Text);
            }
            if (useUpdate.Checked == true)
            {
                commandText.AppendText(" -content ");
                commandText.AppendText(quotation.Text);
                commandText.AppendText(manualText.Text);
                commandText.AppendText(quotation.Text);
                commandText.AppendText(":1 ");
            }
            if (useManual.Checked == true)
            {
                commandText.AppendText(" -content ");
                commandText.AppendText(quotation.Text);
                commandText.AppendText(updateText.Text);
                commandText.AppendText(quotation.Text);
                commandText.AppendText(":7 ");
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                outputText.Text = sfd.FileName;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/C" + commandText.Text);
        }
    }
}
