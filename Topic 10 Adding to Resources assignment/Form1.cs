﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10_Adding_to_Resources_assignment
{
    public partial class Animals : Form
    {
        public Animals()
        {
            InitializeComponent();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            imgBox.Visible = true;
            imgBox.Image = Properties.Resources.Cat;
            lblinfo.Text = "Cats can survive falls from up to 30 stories high!";
            lblinfo.Visible = true;
        }

        private void btnCat_MouseHover(object sender, EventArgs e)
        {
            imgBox.Visible = true;
            imgBox.Image = Properties.Resources.Cat;
            lblinfo.Text = "Click on the box to learn more!";
            lblinfo.Visible = true;
        }

        private void btnFox_Click(object sender, EventArgs e)
        {
            imgBox.Visible = true;
            imgBox.Image = Properties.Resources.Fox;
            lblinfo.Text = "Foxes can make up to 40 different sounds!";
            lblinfo.Visible = true;
        }

        private void btnFox_MouseHover(object sender, EventArgs e)
        {
            imgBox.Visible = true;
            imgBox.Image = Properties.Resources.Fox;
            lblinfo.Text = "Click on the box to learn more!";
            lblinfo.Visible = true;
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            imgBox.Visible = true;
            imgBox.Image = Properties.Resources.Dog2;
            lblinfo.Text = "Dogs are the most common type of pet to have in a home!";
            lblinfo.Visible = true;
        }

        private void btnDog_MouseHover(object sender, EventArgs e)
        {
            imgBox.Visible = true;
            imgBox.Image = Properties.Resources.Dog2;
            lblinfo.Text = "Click on the box to learn more!";
            lblinfo.Visible = true;
        }

        private void btnTurtle_Click(object sender, EventArgs e)
        {
            imgBox.Visible = true;
            imgBox.Image = Properties.Resources.Turtle2;
            lblinfo.Text = "Turtles Don't have teeth!";
            lblinfo.Visible = true;
        }

        private void btnTurtle_MouseHover(object sender, EventArgs e)
        {
            imgBox.Visible = true;
            imgBox.Image = Properties.Resources.Turtle2;
            lblinfo.Text = "Click on the box to learn more!";
            lblinfo.Visible = true;
        }

        private void btnAxolotl_Click(object sender, EventArgs e)
        {
            imgBox.Visible = true;
            imgBox.Image = Properties.Resources.axolotl;
            lblinfo.Text = "Axolotl can regrow a bunch of their limbs, but they are dangerously close to extinction";
            lblinfo.Visible = true;
        }

        private void btnAxolotl_MouseHover(object sender, EventArgs e)
        {
            imgBox.Visible = true;
            imgBox.Image = Properties.Resources.axolotl;
            lblinfo.Text = "Click on the box to learn more!";
            lblinfo.Visible = true;
        }
    }
}
