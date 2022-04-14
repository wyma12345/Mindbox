using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMindbox
{
    public class Triangle: Figure
    {
        private double[] h = new double[3];
        /// <summary>
        /// Массив сторон треугольника
        /// </summary>
        public double[] H { get { return h; } init { } }
        /// <summary>
        /// Наличие прямого угла
        /// </summary>
        public bool IsStraight { get; init; }

        public Triangle(double h1, double h2, double h3)
        {
            H[0] = h1;
            H[1] = h2;
            H[2] = h3;
            Name = "Треугольник";
            Square = MakeSquare(h1, h2, h3); // получаем площадь
            IsStraight = GetStraight(); //  есть ли прямой угол? 
        }

        /// <summary>
        /// Проверка на прямой угол
        /// </summary>
        /// <returns>Наличие прямого угла</returns>
        private bool GetStraight()
        {
            Array.Sort(h);
            if (h[2] * h[2] == h[1] * h[1] + h[0] * h[0])
                return true;
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $", треугольник {(IsStraight ? "прямоугольный" : "не прямоугольный")}";
        }
    }
}
