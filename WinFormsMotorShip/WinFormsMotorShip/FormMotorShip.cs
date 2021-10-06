using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMotorShip
{
    public partial class FormMotorShip : Form
    {
        private ITransport Ship;
        public FormMotorShip()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxMotorShip.Width, pictureBoxMotorShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            Ship.DrawTransport(gr);
            pictureBoxMotorShip.Image = bmp;
        }

        private void buttonCreateShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Ship = new Ship(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.BurlyWood); 
            Ship.SetPosition(50 + rnd.Next(10, 100), 50 + rnd.Next(10, 100), pictureBoxMotorShip.Width, pictureBoxMotorShip.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    Ship.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    Ship.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    Ship.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    Ship.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreateMotorShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Ship = new MotorShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.BurlyWood, Color.Gray, true, true, true, true);
            Ship.SetPosition(50 + rnd.Next(10, 100), 50 + rnd.Next(10, 100), pictureBoxMotorShip.Width, pictureBoxMotorShip.Height);
            Draw();
        }
    }
}
