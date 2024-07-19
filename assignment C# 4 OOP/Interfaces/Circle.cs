using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_C__4_OOP.Interfaces
{
    internal class Circle : IShape, ICircle
    {
        public double Area { get ; set; }
        public double Raduis { get ; set; }

        
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The area of the circle is {Area}");         

        }
    }
}
