using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectangle : Shape
    {
        private int sideA;
        private int sideB;

        public int SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        public int SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public override void GetArea()
        {
            int area = sideA * sideB;
            Console.WriteLine($"Area of {Name} is {area}");
        }

        public override void GetPerimeter()
        {
            int perimeter = 2 * (sideA + sideB);
            Console.WriteLine($"Perimeter of {Name} is {perimeter}");
        }
    }
}
