using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMindbox
{
    public class Circle: Figure
    {
        public double R { get; init; }
        public Circle(double r)
        {
            Name = "Круг";
            R = r;
            Square = MakeSquare(r); // получаем площадь
        }
    }
}
