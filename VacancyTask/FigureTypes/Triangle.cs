using System;

namespace VacancyTask
{
    class Triangle : Figure
    {
        private int[] sides = new int[3];

        public Triangle(int a, int b, int c)
        {
            sides[0] = a;
            sides[1] = b;
            sides[2] = c;
        }

        public override int CalculateSquarespace()
        {
            int sum = 0;
            int p;
            foreach (int side in sides)
            {
                sum += side;
            }
            p = sum / 2;
            return (int)Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
        }

        public bool IsRightAngle()
        {
            int hypIndex = LongestSideIndex();
            int hypSquared = sides[hypIndex] ^ 2;
            int cathSquaredSum = 0;
            for (int i = 0; i < sides.Length; i++)
            {
                if (i != hypIndex)
                {
                    cathSquaredSum += sides[i] ^ 2;
                }
            }
            if (hypSquared == cathSquaredSum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int LongestSideIndex()
        {
            int x = 0;
            for (int i = 0; i < sides.Length - 1; i++)
            {

                if (sides[i] > sides[i + 1])
                {
                    x = i;
                }
                else
                {
                    x = i + 1;
                }
            }
            return x;
        }
    }
}
