using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WinFormsMotorShip
{
    public class Ship : Vehicle
    {
        protected readonly int ShipWidth = 250;
        protected readonly int ShipHeight = 100;

        public Ship(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        protected Ship(int maxSpeed, float weight, Color mainColor, int ShipWidth, int
       ShipHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.ShipWidth = ShipWidth;
            this.ShipHeight = ShipHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 150 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - ShipWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - ShipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush br = new SolidBrush(MainColor);

            //Корабль
            PointF point1 = new PointF(_startPosX + 50, _startPosY + 50);
            PointF point2 = new PointF(_startPosX + 100, _startPosY + 100);
            PointF point3 = new PointF(_startPosX + 200, _startPosY + 100);
            PointF point4 = new PointF(_startPosX + 250, _startPosY + 50);

            PointF[] curvePoints =
            {
                 point1,
                 point2,
                 point3,
                 point4
            };

            // Draw polygon to screen.
            g.FillPolygon(br, curvePoints);
            g.DrawPolygon(pen, curvePoints);

            //Каюта
            g.FillRectangle(br, _startPosX + 100, _startPosY + 10, 130, 40);
            g.DrawRectangle(pen, _startPosX + 100, _startPosY + 10, 130, 40);

            //Якорь
            g.DrawLine(pen, _startPosX + 100, _startPosY + 60, _startPosX + 100, _startPosY + 80);
            g.DrawLine(pen, _startPosX + 90, _startPosY + 70, _startPosX + 110, _startPosY + 70);
            g.DrawLine(pen, _startPosX + 95, _startPosY + 80, _startPosX + 105, _startPosY + 80);
        }
    }
}

