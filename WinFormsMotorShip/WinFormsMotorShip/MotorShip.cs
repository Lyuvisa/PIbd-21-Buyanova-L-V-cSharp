using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsMotorShip
{
    public class MotorShip : Ship
    {
        public Color DopColor { private set; get; }

        /// Признак наличия дополнительного этажа
        public bool DopFloor { private set; get; }

        /// Признак наличия окон в кабинах
        public bool CabinWindows { private set; get; }

        /// Признак наличиz Труб
        public bool CabinsMotorShip { private set; get; }

        /// Признак налич флага
        public bool DecorFlag { private set; get; }

        public MotorShip(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool dopFloor, bool cabinWindows, bool cabinsMotorShip, bool decorFlag) :
            base(maxSpeed, weight, mainColor, 250, 100)

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

        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);

            Pen pen = new Pen(Color.Black);
            Brush brDopColor = new SolidBrush(DopColor);
            Brush brLightSalmon = new SolidBrush(Color.LightSalmon);
            Brush brWindows = new SolidBrush(Color.LavenderBlush);
            Brush brBrown = new SolidBrush(Color.Sienna);
            
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
