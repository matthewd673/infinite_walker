using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infinite_Walker
{
    public partial class Form1 : Form
    {
        int stance = 0;
        int choice;
        int curscore = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager.Start();
            spawnstuff();
            move_stuff.Start();
            animate.Start();
        }
        private void spawnstuff()
        {
            Random rnd = new Random();
            int which = rnd.Next(0, 2);
            spike1.Location = new Point(192, which * 64);
            which = rnd.Next(0, 2);
            spike2.Location = new Point(192, which * 64);
        }

        private void move_stuff_Tick(object sender, EventArgs e)
        {
            spike1.Location = new Point(spike1.Location.X - 1, spike1.Location.Y);
            spike2.Location = new Point(spike2.Location.X - 1, spike2.Location.Y);
            tiles.Location = new Point(tiles.Location.X - 1, tiles.Location.Y);
            if (tiles.Location.X <= -192)
            {
                tiles.Location = new Point(0, 0);
            }
        }

        private void animate_Tick(object sender, EventArgs e)
        {
            if (stance == 0)
            {
                stance = 1;
                player.Image = sprite.Images[0];
            }
            else
            {
                stance = 0;
                player.Image = sprite.Images[1];
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                player.Top -= 8;
            }
            if (e.KeyCode == Keys.Down)
            {
                player.Top += 8;
            }
        }

        private void manager_Tick(object sender, EventArgs e)
        {
            checkloc();
            checkbounds();
            respawn();
        }
        private void checkbounds()
        {
            if (player.Bounds.IntersectsWith(spike1.Bounds))
            {
                score.Text = "FAIL";
            }
            if (player.Bounds.IntersectsWith(spike2.Bounds))
            {
                score.Text = "FAIL";
            }
        }
        private void checkloc()
        {
            if (player.Location.Y >= 129)
            {
                player.Location = new Point(player.Location.X, 130);
            }
            if (player.Location.Y <= 0)
            {
                player.Location = new Point(player.Location.X, 0);
            }
        }
        private void respawn()
        {
            if (spike1.Location.X <= -64)
            {
                spawnstuff();
                curscore += 50;
                score.Text = curscore.ToString();
            }
        }
    }
}
