using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Circle : Shape
    {
        private int radius;

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override void GetArea()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area of {Name} is {area}");
        }

        public override void GetPerimeter()
        {
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine($"Perimeter of {Name} is {perimeter}");
        }
    }
}
