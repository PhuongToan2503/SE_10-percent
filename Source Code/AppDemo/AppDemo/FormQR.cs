﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDemo
{
    public partial class FormQR : Form
    {
        public FormQR()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mua vé thành công!");
            this.Close();
        }
    }
}
