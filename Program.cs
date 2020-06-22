using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector3Dlab5
{
    class Vector
    {
        double x, y, z;

        public Vector()
        {
            x = 0;
            y = 0;
            z = 0;
        }


        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        

        public void AddVector(Vector b) 
        {
            Vector c = new Vector();
            c.x = x + b.x;
            c.y = y + b.y;
            c.z = z + b.z;
            Console.WriteLine("Сума векторів: {0}.{1}.{2}",c.x,c.y,c.z);
        }

        public void MinVector (Vector b)
        {
            Vector c = new Vector();
            c.x = x - b.x;
            c.y = y - b.y;
            c.z = z - b.z;
            Console.WriteLine("Різниця векторів : {0}.{1}.{2}", c.x, c.y, c.z);
        }

        public double ScalarDob(Vector b)
        {
            double c = x * b.x + y * b.y + z * b.z;
            Console.WriteLine("Скалярний добуток: {0}", c);
            return c;
        }

        public void DobScalar(double b)
        {
            Vector c = new Vector();
            c.x = x * b;
            c.y = y * b;
            c.z = z * b;
            Console.WriteLine("Добуток скаляра на вектор: {0},{1},{2}", c.x,c.y,c.x);
        }

        public void CompareVector (Vector b)
        {
            double lenghtA = Math.Sqrt(Math.Pow(x, 2) + Math.Pow (y, 2) + Math.Pow (z,2));
            double lenghtB = Math.Sqrt(Math.Pow(b.x, 2) + Math.Pow(b.y, 2) + Math.Pow(b.z, 2));
            if (lenghtA > lenghtB)
            {
                Console.WriteLine("Перший вектор більший");
            }
            else if (lenghtA < lenghtB)
            {
                Console.WriteLine("Другий вектор більший");
            }
            else
            {
                Console.WriteLine("Вектори рівні");
            }

        }

        public void VidnimDovzVector(Vector b)
        {
            double lenghtA = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            double lenghtB = Math.Sqrt(Math.Pow(b.x, 2) + Math.Pow(b.y, 2) + Math.Pow(b.z, 2));
            Console.WriteLine("Різниця довжин векторів {0}", lenghtA - lenghtB);
        }
    } 

    

    class Program
    { 
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введіть три координати для первшого вектора");
            double x,y,z;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            z = Convert.ToDouble(Console.ReadLine());
            Vector a = new Vector(x, y, z);

            Console.WriteLine("Введіть три координати для другого вектора");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            z = Convert.ToDouble(Console.ReadLine());
            Vector b = new Vector(x, y, z);

            a.AddVector(b);
            a.MinVector(b);

            double scalar = a.ScalarDob(b);
            a.DobScalar(scalar);
            a.DobScalar(scalar);

            a.CompareVector(b);
            b.VidnimDovzVector(a);

            Console.ReadKey();
        }
    }
}
