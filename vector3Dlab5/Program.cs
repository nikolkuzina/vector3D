using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector3Dlab5
{
    class Vector3D
    {
        int X1, Y1, Z1;

        public void ToStart();

    }
    

    class Program
    { 
        static void Main(string[] args)
        {
            Vector3D vector3D = new Vector3D();

            Console.WriteLine("Введіть X координату вектора");
            vector3D.X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть Y координату вектора");
            vector3D.Y1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Введіть Z координату вектора");
            vector3D.Y1 = Convert.ToInt32(Console.ReadLine());

            vector3D.ToStart();
        }
    }
}
