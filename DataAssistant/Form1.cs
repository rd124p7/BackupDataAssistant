using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAssistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DetectDrives.Device dev = new DetectDrives.Device();

            txtDriveLetter.Text = dev.GetDeviceLetter();

            lblFreeSpace.Text = String.Format("Free Space: {0}", dev.ConvertSize(dev.GetDevFreeSpace()));

            lblTotalSpace.Text = String.Format("Total Size: {0}", dev.ConvertSize(dev.GetDevTotalSize()));
        }
    }
}
