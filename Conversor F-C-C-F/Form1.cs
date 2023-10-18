﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_F_C_C_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear_Click_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0.0";
            textBox2.Text = "0.0";
        }

        private void CtoF_Click_Click(object sender, EventArgs e)
        {
            float C = float.Parse(textBox2.Text);
            float F = (C * 9f / 5f) + 32;
            textBox1.Text = F.ToString();
        }

        private void FToC_Click_Click(object sender, EventArgs e)
        {
            float F = float.Parse(textBox1.Text);
            float C = (F - 32) * 5.0f / 9.0f;
            textBox2.Text = C.ToString();
        }
    }
}
