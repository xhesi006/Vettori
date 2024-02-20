using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vettori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(3, 5);
            Vector vector2 = new Vector(2, 4);

            Console.WriteLine("somma:");
            Vector vector3 = vector1 + vector2;
            Console.WriteLine(vector3.X + " , " + vector3.Y);

            Console.WriteLine("sottrazione:");
            Vector vector4 = vector1 - vector2;
            Console.WriteLine(vector4.X + " , " + vector4.Y);

            Console.WriteLine("prodotto tra due vettori:");
            double vector5 = vector1 * vector2;
            Console.WriteLine(vector5);

            Console.WriteLine("prodotto tra uno scalare e un vettore:");
            double a = 5;
            Vector vector6 = vector2 * a;
            Console.WriteLine(vector6.X+ " , " + vector6.Y);

            Console.WriteLine("prodotto tra un vettore e uno scalare:");
            double b=10;
            Vector vector7=vector1*b;
            Console.WriteLine(vector7.X+" , "+vector7.Y);

            Console.WriteLine("divisione:");
            Vector vector8 = vector1 /b;
            Console.WriteLine(vector8.X+" , "+vector8.Y);

            Console.WriteLine("vettore negativo:");
            vector2 = -vector1 ;
            Console.WriteLine(vector2.X + " " + vector2.Y);

            Console.WriteLine("vettore positivo:");
            vector2 = +vector1;
            Console.WriteLine(vector2);


            Console.ReadLine();
        }
    }
}
