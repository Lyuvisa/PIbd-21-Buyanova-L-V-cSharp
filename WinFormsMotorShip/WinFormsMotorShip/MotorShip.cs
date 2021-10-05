using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsMotorShip
{
    /// Класс отрисовки теплохода
    class MotorShip
    {
        /// Левая координата отрисовки теплохода
        private float _startPosX;

        /// Правая кооридната отрисовки теплохода
        private float _startPosY;

        /// Ширина окна отрисовки
        private int _pictureWidth;

        /// Высота окна отрисовки
        private int _pictureHeight;

        /// Ширина отрисовки теплохода
        private readonly int MotorShipWidth = 250;

        /// Высота отрисовки теплохода
        private readonly int MotorShipHeight = 100;

        /// Максимальная скорость
        public int MaxSpeed { private set; get; }

        /// Вес теплохода
        public int Weight { private set; get; }

        /// Основной цвет теплохода
        public Color MainColor { private set; get; }

        /// Дополнительный цвет
        public Color DopColor { private set; get; }

        /// Признак наличия дополнительного этажа
        public bool DopFloor { private set; get; }

        /// Признак кабин
        public bool CabinWindows { private set; get; }

        /// Признак наличие Труб
        public bool CabinsMotorShip { private set; get; }

        /// Признак наличия флага
        public bool DecorFlag { private set; get; }

        public void Init(int maxSpeed, int weight, Color mainColor, Color dopColor,
        bool dopFloor, bool cabinWindows, bool cabinsMotorShip, bool decorFlag)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;

            DopFloor = dopFloor;
            CabinWindows = cabinWindows;
            CabinsMotorShip = cabinsMotorShip;
            DecorFlag = decorFlag;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;

            _pictureHeight = height;
            _pictureWidth = width;
        }

        public void MoveTransport(Direction direction)
        {
            int step = MaxSpeed * 150 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - MotorShipWidth)
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
                    if (_startPosY + step < _pictureHeight - MotorShipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush br = new SolidBrush(MainColor);
            Brush brDopColor = new SolidBrush(DopColor);
            Brush brLightSalmon = new SolidBrush(Color.LightSalmon);
            Brush brWindows = new SolidBrush(Color.LavenderBlush);
            Brush brBrown = new SolidBrush(Color.Sienna);

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

            //Флаг
            if (DecorFlag)
            {
                g.DrawLine(pen, _startPosX + 60, _startPosY + 25, _startPosX + 60, _startPosY + 50);
                g.FillRectangle(brLightSalmon, _startPosX + 60, _startPosY + 10, 30, 25);
            }

            //Окна кают и дверь
            if (CabinWindows)
            {
                g.FillRectangle(brWindows, _startPosX + 120, _startPosY + 25, 15, 15);
                g.DrawRectangle(pen, _startPosX + 120, _startPosY + 25, 15, 15);
                g.FillRectangle(brWindows, _startPosX + 140, _startPosY + 25, 15, 15);
                g.DrawRectangle(pen, _startPosX + 140, _startPosY + 25, 15, 15);
                g.FillRectangle(brWindows, _startPosX + 160, _startPosY + 25, 15, 15);
                g.DrawRectangle(pen, _startPosX + 160, _startPosY + 25, 15, 15);
                g.FillRectangle(brWindows, _startPosX + 180, _startPosY + 25, 15, 15);
                g.DrawRectangle(pen, _startPosX + 180, _startPosY + 25, 15, 15);
                g.FillRectangle(brBrown, _startPosX + 205, _startPosY + 20, 20, 30);
                g.DrawRectangle(pen, _startPosX + 205, _startPosY + 20, 20, 30);
            }

            //Трубы
            if (CabinsMotorShip)
            {
                g.FillRectangle(brDopColor, _startPosX + 162, _startPosY - 40, 20, 50);
                g.DrawRectangle(pen, _startPosX + 162, _startPosY - 40, 20, 50);
                g.FillRectangle(brDopColor, _startPosX + 184, _startPosY - 30, 20, 40);
                g.DrawRectangle(pen, _startPosX + 184, _startPosY - 30, 20, 40);
                g.FillRectangle(brDopColor, _startPosX + 206, _startPosY - 20, 20, 30);
                g.DrawRectangle(pen, _startPosX + 206, _startPosY - 20, 20, 30);
            }

            //Доп. этаж
            if (DopFloor)
            {
                g.FillRectangle(brBrown, _startPosX + 110, _startPosY - 20, 50, 30);
                g.DrawRectangle(pen, _startPosX + 110, _startPosY - 20, 50, 30);
                g.FillRectangle(brWindows, _startPosX + 110, _startPosY - 11, 30, 15);
                g.DrawRectangle(pen, _startPosX + 110, _startPosY - 11, 30, 15);
            }
        }
    }
}
