using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership_App.Entities
{
    public static class ChangeColor
    {
        public static string ToColor(this string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            return text;
        }
    }
}
