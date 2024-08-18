using System;
namespace Sample
{
    class Test {
        public static void Main(string[] args) {
            baitap1();
        }
        
        public static void baitap1() {
            Console.Write("Nhap so thu nhat: a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu hai: b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("a + b = {0}", a+b);
        }

        public static void baitap2() {
            Console.Write("So thu nhat truoc khi hoan doi: a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("So thu hai truoc khi hoan doi: b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            a = a + b ;
            b = a - b ;
            a = a - b ;
            System.Console.WriteLine("Sau khi hoan doi, so thu nhat a = {0}, so thu hai b = {1}", a, b);
        }

        public static void baitap3() {
            Console.Write("Nhap so thu nhat: a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu hai: b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("a x b = {0}", a*b);
        }

        public static void baitap4() {
            Console.Write("Nhap so feet: a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = a / 3.2808 ;
            System.Console.WriteLine("{0} feet = {1} mét", a, b);
        }

        public static void baitap5() {
            Console.Write("Nhap do C: a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap do F: b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("{0} do C = {1} do F", a, a*1.8 + 32);
            System.Console.WriteLine("{0} do F = {1} do C", b, (b - 32)* 5/9);
        }

        public static void baitap8() {
            Console.Write("Nhap duong kinh cua hinh tron: a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("dien tich hinh tron la: {0}", (a/2)*(a/2)*3.14);
        }

        public static void baitap9() {
            Console.Write("Nhap mot canh cua hinh vuong: a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("dien tich hinh vuong la: {0}", a*a);
        }
    }
}