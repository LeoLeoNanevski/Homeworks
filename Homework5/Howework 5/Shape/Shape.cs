using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Shape
    {
        private string name;
        private string color;
        private int[] position = new int[2];

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be null or empty");
                }
                else
                {
                    Console.WriteLine($"Setting name to {value}");
                    name = value;
                }
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Color cannot be null or empty");
                }
                else
                {
                    Console.WriteLine($"Setting color to {value}");
                    color = value;
                }
            }
        }

        public int[] Position
        {
            get { return position; }
            set { position = value; }
        }

        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for area");
        }

        public virtual void GetPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter");
        }

        public static void Move(Shape shape)
        {
            Console.WriteLine($"Moving {shape.Name} by (5, 5)");
            shape.Position[0] += 5;
            shape.Position[1] += 5;
        }
    }
}
