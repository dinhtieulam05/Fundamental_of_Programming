// See https://aka.ms/new-console-template for more information
using System;
using System.Net;
using System.Runtime.InteropServices;
namespace Sample
{
    class Test
    {
        public static void Main(string[] args)
        {
            exstring02();
        }
        public static void ex1()
        {
            Console.Write("Nhap do C: Celsius = ");
            float Celsius = Convert.ToSingle(Console.ReadLine());
            System.Console.WriteLine("{0} celsius = {1} kelvin", Celsius, Celsius + 273);
            System.Console.WriteLine("{0} celsius = {1} fahrenheit", Celsius, Celsius * 18 / 10 + 32);
        }

        public static void ex2()
        {
            Console.Write("Nhap ban kinh hinh cau: radius = ");
            double radius = Convert.ToSingle(Console.ReadLine());
            float pi = 3.14f;
            System.Console.WriteLine("Dien tich hinh cau: surface = {0}", 4*pi*Math.Pow(radius,2));
            System.Console.WriteLine("The tich hinh cau: Volume = {0}", 4/3 * pi * Math.Pow(radius,3));
        }

        public static void ex3()
        {
            Console.Write("Nhap so thu nhat = ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap so thu hai = ");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}",a,b,a+b );
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} x {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} : {1} = {2}", a, b, a / b);
            Console.WriteLine("{0} mod {1} = {2}", a, b, a % b );
        }

        static void exstring01()
        {
            Console.WriteLine("Input the string: ");
            string a = Console.ReadLine();
            Console.WriteLine($"The string you entered is \"{a}\" ");

        }

        static void exstring02()
        {
            Console.WriteLine("Input the string: ");
            string a = Console.ReadLine();
            Console.WriteLine("Length of the string is: {0}",a.Length);

        }
    }
}
