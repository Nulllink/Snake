﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i=0; i<10; i++) { }

            //PictureBox pic = new PictureBox();
            //pic.Width = panel1.Width / 10;
            //pic.Height = panel1.Height / 10;
        }
    }
}
