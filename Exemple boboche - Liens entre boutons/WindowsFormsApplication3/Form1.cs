﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SettAllButtons();
        }

        private void SettAllButtons()
        {
            SuperBoutonC.SetAllButtons(SuperBoutonG, SuperBoutonH, SuperBoutonD, SuperBoutonB);
        }

        private void superBouton1_Click(object sender, EventArgs e)
        {
            SuperBoutonC.EnableAll();
        }

    }
}