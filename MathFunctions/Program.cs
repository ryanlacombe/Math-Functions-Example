using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is X for the equation?");
            string algebraInput = Console.ReadLine();
            AlgebraFunction(Convert.ToInt32(algebraInput));

            Console.WriteLine("What is A for the equation?");
            string qInput1 = Console.ReadLine();
            Console.WriteLine("What is B for the equation?");
            string qInput2 = Console.ReadLine();
            Console.WriteLine("What is C for the equation?");
            string qInput3 = Console.ReadLine();
            QuadraticFunction(Convert.ToInt32(qInput1), Convert.ToInt32(qInput2), Convert.ToInt32(qInput3));

            Console.WriteLine("What is S for the equation?");
            string bInput1 = Console.ReadLine();
            Console.WriteLine("What is E for the equation?");
            string bInput2 = Console.ReadLine();
            Console.WriteLine("What is T for the equation?");
            string bInput3 = Console.ReadLine();
            BlendFunction(Convert.ToInt32(bInput1), Convert.ToInt32(bInput2), Convert.ToInt32(bInput3));

            Console.ReadKey();
        }
        static int AlgebraFunction(int x)
        {
            int result = (x * x) + (2 * x) - 7;
            Console.WriteLine(result);
            return result;
        }
        static double QuadraticFunction(int a, int b, int c)
        {
            double root = Math.Sqrt(b * b - 4 * a * c);
            if (root >= 0)
            {
                double result = (-b + -root) / (2 * a);
                Console.WriteLine(result);
                return result;
            }
            else
            {
                double result = 0;
                Console.WriteLine("No roots.");
                return result;
            }
        }
        static int BlendFunction(int s, int e, int t)
        {
            int result = s + t * (e - s);
            Console.WriteLine(result);
            return result;
        }
        static double distanceFunction(int x1, int x2, int y1, int y2)
        {
            double result = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            return result;
        }
        static int OutterFunction(int[] P, int[] Q, int x, int y, int z)
        {
            int[] p = { x, y, z };
            P = p;
            int[] q = { x, y, z };
            Q = q;
            int innerFunction()
            {
                int innerResult = P[0] * Q[0] + P[1] * Q[1] + P[2] * P[2];
                return innerResult;
            }
            int result = innerFunction();
            Console.WriteLine(result);
            return result;
        }
        static double PlaneFunction(int a, int b, int c, int d, int x, int y, int z)
        {
            double root = Math.Sqrt((a * a) + (b * b) + (c * c));
            int plane = a * x + b * y + c * z + d;
            double result = (plane) / root;
            Console.WriteLine(result);
            return result;
        }
        static float BezierCurveFunction(float t, float P0, float P1, float P2, float P3)
        {
            float result = ((1 - t) * (1 - t) * (1 - t)) * P0 + 3 * ((1 - t) * (1 - t)) * t * P1 + 3 * (1 - t) * (t * t) * P2 + (t * t * t) * P3;
            Console.WriteLine(result);
            return result;
        }
    }
}
