﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maraton_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FaultSubmit frm = new FaultSubmit();
            frm.ShowDialog();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CustomerSubmit frm = new CustomerSubmit();
            frm.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TecnicalSubmit frm = new TecnicalSubmit();
            frm.ShowDialog();
            this.Hide();

        }

        private void CustomerSubmitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerQuickly cm = new CustomerQuickly();
            cm.ShowDialog();

        }

        private void TechnicianSubmitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserQuickly um = new UserQuickly();
            um.ShowDialog();
        }

        private void FaultSubmitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRole ad = new AddRole();
            ad.ShowDialog();
        }
    }
}
