using System;
using System.Collections.Generic;
using System.Text;

namespace VacancyTask
{
    class Circle : Figure
    {
        private const double Pi = 3.14;
        private int r { get; set; }

        public Circle(int radius)
        {
            r = radius;
        }

        public override int CalculateSquarespace()
        {
            return (int)(Pi * (r ^ 2));
        }
    }
}
