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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Code to delete a record
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Owner.Close();
        }
    }
}
