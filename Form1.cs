using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace GTA_Suspend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void durationBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.duration = durationBox.Text;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            closeRadioButton.Checked = Properties.Settings.Default.closeAfter;
            programToSuspend.Text = Properties.Settings.Default.program;
            durationBox.Text = Properties.Settings.Default.duration;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            var durationString = durationBox.Text;
            bool canConvert = long.TryParse(durationString, out _);
            bool closeAfter = closeRadioButton.Checked;

            string program = programToSuspend.Text;

            if (program == "" || program == " ")
            {
                MessageBox.Show("Invalid Program Name\nMake sure you just wrote the program name - don't include .exe");
            }
            else
            {
                if (canConvert)
                {
                    var duration = int.Parse(durationString);
                    // Suspend GTA
                    System.Diagnostics.Process.Start("pssuspend.exe", program);
                    // Pause for duration specified
                    System.Threading.Thread.Sleep(duration * 1000);
                    // Resume GTA
                    program += " -r";
                    System.Diagnostics.Process.Start("pssuspend.exe", program);

                    if (closeAfter)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Duration is not a number");
                }
            }

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://github.com/jack-bailey/gta-suspend";
            System.Diagnostics.Process.Start("explorer.exe", url);
        }

        private void programToSuspend_TextChanged(object sender, EventArgs e)

        {
            Properties.Settings.Default.program = programToSuspend.Text;
            Properties.Settings.Default.Save();
        }

        private void closeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.closeAfter = closeRadioButton.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
