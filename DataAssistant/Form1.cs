﻿/*
MIT License

Copyright (c) 2017 rd124p7

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

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

            for (int i = 0; i < dev.GetHDDLetters().Count; i++)
            {
                lblFixedDrives.Text += dev.GetHDDLetters()[i] + "  ";
            }


            Backup.Split spl = new Backup.Split(dev.GetHDDLetters()[0]);
            //for (int i = 0; i < spl.getFirstSectionFolder().Count; i++) Console.WriteLine(spl.getFirstSectionFolder()[i]);
            //for (int i = 0; i < spl.getLastSectionFolder().Count; i++) Console.WriteLine(spl.getLastSectionFolder()[i]);

            for(int i = 0; i < spl.ffListCount().Length; i++)
            {
                Console.WriteLine(spl.ffListCount()[i]);
            }
        }
    }
}
