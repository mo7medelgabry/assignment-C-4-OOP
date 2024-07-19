using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_C__4_OOP.Interfaces
{
    internal class Rectangle : IShape, IRectangle
    {
        public double Area { get ; set; }
        public int Height { get; set ; }
        public int Width { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The Area Of Rectangle is{Area}");
        }
    }
}
