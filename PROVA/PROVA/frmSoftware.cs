﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROVA
{
    public partial class frmSoftware : Form
    {
        public frmSoftware()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSairSoftware_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}