using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsMotorShip
{
    public class Pier<T> where T : class, ITransport
    {
        private readonly T[] places;

        private readonly int pictureWidth;
        private readonly int pictureHeight;

        private readonly int placeSizeWidth = 300;
        private readonly int placeSizeHeight = 160;

        public Pier(int picWidth, int picHeight)
        {
            int width = picWidth / placeSizeWidth;
            int height = picHeight / placeSizeHeight;
            places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static int operator +(Pier<T> p, T Ship)
        {
            for (int i = 0; i < p.places.Length; i++)
            {
                if (p.places[i] is null)
                {
                    p.places[i] = Ship;
                    int width = p.pictureWidth / p.placeSizeWidth;
                    int height = p.pictureHeight / p.placeSizeHeight;
                    int column = i / height;
                    int row = i % width;
                    Ship.SetPosition(row * p.placeSizeWidth + p.placeSizeWidth / 8, column * p.placeSizeHeight + p.placeSizeHeight / 3, p.pictureWidth, p.pictureHeight);
                    return 1;
                }
            }
            return -1;
        }

        public static T operator -(Pier<T> p, int index)
        {
            if (index >= 0 && index < p.places.Length)
            {
                var res = p.places[index];
                p.places[index] = null;
                return res;
            }
            return null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < places.Length; i++)
            {
                places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + placeSizeWidth / 2, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, (pictureHeight / placeSizeHeight) * placeSizeHeight);
            }
        }
    }
}
