using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        static int cells1=8,cells2=8;
        int[,] space = new int[cells1+2,cells2+2];
        int x=0, y=0;
        bool plose = false;

        private void Form2_Load(object sender, EventArgs e)
        {
            spacecreate();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            snake_move();
        }

        private void snake_move()
        {
            int for1, for2;
            for (for1 = 1; for1 <= cells1; for1++)
                for (for2 = 1; for2 <= cells2; for2++)
                {
                    if (space[for1, for2] == 1)
                    {
                        space[for1 + x, for2 + y] = 1;
                        space[for1, for2] = 0;
                    }
                }
            //for (for1 = 0; for1 <= cells1; for1++)
            //    if (space[for1, 0] == 1)
            //        lose();
            snake_visual();
        }

        private void lose()
        {
            plose = true;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Enabled=true;
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    x = 1;
                    y = 0;
                    break;
                case "Left":
                    x = -1;
                    y = 0;
                    break;
                case "Up":
                    y = 1;
                    x = 0;
                    break;
                case "Down":
                    y = -1;
                    x = 0;
                    break;
            }
        }

        private void snake_visual()
        {
            //if (plose == false)
            {
                int for1, for2;
                for (for1 = 1; for1 <= cells1; for1++)
                    for (for2 = 1; for2 <= cells2; for2++)
                    {
                        if (space[for1, for2] == 0)
                        {
                            PictureBox pic = (PictureBox)panel1.Controls[for1.ToString() + for2.ToString()];
                            pic.BackColor = Color.White;
                        }
                        if (space[for1, for2] == 1)
                        {
                            PictureBox pic = (PictureBox)panel1.Controls[for1.ToString() + for2.ToString()];
                            pic.BackColor = Color.Green;
                        }
                    }
            }
        }

        private void spacecreate()
        {
            int for1, for2;
            panel1.Controls.Clear();
            Text = "Snake";
            int w = panel1.Width / cells1;
            int h = panel1.Height / cells2;
            for (for1 = 1; for1 <= cells1; for1++)
                for (for2 = 1; for2 <= cells2; for2++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Height = h;
                    pic.Width = w;
                    pic.Location = new Point(w * (for1 - 1), h * (for2 - 1));
                    pic.BackColor = Color.White;
                    pic.BorderStyle = BorderStyle.FixedSingle;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    //pic.Tag = new Point(for1, for2);
                    pic.Name = for1.ToString() + for2.ToString();
                    //pic.Click += pic_Click;
                    panel1.Controls.Add(pic);
                }
            space[cells1 / 2, cells2 / 2] = 1;
            snake_visual();
        }
        
    }
}
