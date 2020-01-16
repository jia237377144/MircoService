using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperDemo
{
    public class YieldTest
    {

        //static Vector vector1 = new Vector(1, 1);
        //static Vector vector2 = new Vector(2, 3);
        //static Vector vector3 = new Vector(4, 5);

        public static void Run()
        {
            IEnumerable<Vector> vectors = GetVectors();
            //foreach (var vector in vectors)
            foreach (var vector in GetVectors())
            {
                vector.X++;
                vector.Y += 4;
            }

            //foreach (var vector in vectors)
            foreach (var vector in GetVectors())
            {
                System.Console.WriteLine(vector);
            }
        }

        static IEnumerable<Vector> GetVectors()
        {
            //yield return vector1;
            //yield return vector2;
            //yield return vector3;


            yield return new Vector(1, 1);
            yield return new Vector(2, 3);
            yield return new Vector(4, 5);
        }
    }
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Vector(double x, double y)
        {
            System.Console.WriteLine("Vector object is instantiated.");
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("X = {0}, Y = {1}", this.X, this.Y);
        }
    }

}

