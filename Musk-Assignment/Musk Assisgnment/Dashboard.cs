﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musk_Assisgnment
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Safety_Audit_Form newSafetyAuditForm = new Safety_Audit_Form();
            this.Hide();
            newSafetyAuditForm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List_of_Inspection newListOfInspection = new List_of_Inspection();
            this.Hide();
            newListOfInspection.ShowDialog();
            this.Show();
        }
    }
}
