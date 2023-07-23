using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace C__GUI_with_Pickit
{
    public partial class Form1 : Form
    {
        private const string PICKIT_EXECUTABLE_PATH = "C:\\Path\\To\\pk2cmd.exe"; //REPLACE WITH ACTUAL PATH TO PICKIT DEVICE
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hexFilePath = txtHexFilePath.Text; 
            if (File.Exists(hexFilePath))
            {
                string command = $"/c \"{PICKIT_EXECUTABLE_PATH}\" -PPIC{"\"" + hexFilePath + "\""}"; //replace with path to pickit device on the computer

                ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", command);
                processInfo.RedirectStandardOutput = true;
                //processInfo.RedirectStandardError = true;
                processInfo.CreateNoWindow = true;
                processInfo.UseShellExecute = false;

                using (Process process = Process.Start(processInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    txtOutput.Text = output; 
                }
            }
            else
            {
                MessageBox.Show("Inalid hex file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtHexFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHexFilePath_Enter(object sender, EventArgs e)
        {
            if (txtHexFilePath.Text == "Insert path to pickit device")
            {
                txtHexFilePath.Text = "";

                txtHexFilePath.ForeColor = Color.Black;
            }
        }

        private void txtHexFilePath_Leave(object sender, EventArgs e)
        {
            if (txtHexFilePath.Text == "")
            {
                txtHexFilePath.Text = "Insert path to pickit device";

                txtHexFilePath.ForeColor = Color.Silver;
            }
        }
    }
}
