﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBnB_Project
{
    public partial class deleteForm : Form
    {
        public deleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Owner.Close();
        }

        private void DeletePropertyButton_Click(object sender, EventArgs e)
        {
            //Code to delete a property
            doesntWork();
        }

        private void deleteHostButton_Click(object sender, EventArgs e)
        {
            //Code to delete a property
            doesntWork();
        }

        public void doesntWork()
        {
            MessageBox.Show("This button does not work yet", "Important", MessageBoxButtons.OK);
        }
    }
}
