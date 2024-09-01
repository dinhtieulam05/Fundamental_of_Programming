internal class Program
{
    private static void Main(string[] args)
    {
        ex10();
    }

    private static void ex01() {
        //Write a C# Sharp program to check whether a given number is even or odd.
        Console.WriteLine("Enter a number: ");
        int number = Int32.Parse(Console.ReadLine());
        if (number % 2 == 0) Console.WriteLine($"{number} is an even number.");
        else Console.WriteLine($"{number} is an odd number.");
    }

    private static void ex02() {
        //Write a C# Sharp program to find the largest of three numbers.
        Console.WriteLine("Enter 3 number one by one:");
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        int c = Int32.Parse(Console.ReadLine());
        int max = a;
        if(max < b) max = b;
        if (max < c) max = c;
        Console.WriteLine($"The max number is {max}");
    }

    private static void ex03() {
        //Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        Console.Write("Enter the value for X coordinate: ");
        Double X = double.Parse(Console.ReadLine());
        Console.Write("Enter the value for Y coordinate: ");
        Double Y = double.Parse(Console.ReadLine());
        if(X > 0 && Y > 0) Console.WriteLine($"The coordinate point ({X} ; {Y}) lies in the first quandrant.\n\n");
        else if(X < 0 && Y > 0) Console.WriteLine($"The coordinate point ({X} ; {Y}) lies in the second quandrant.\n\n");
        else if(X < 0 && Y < 0) Console.WriteLine($"The coordinate point ({X} ; {Y}) lies in the third quandrant.\n\n");
        else if(X > 0 && Y < 0) Console.WriteLine($"The coordinate point ({X} ; {Y}) lies in the Fourth quandrant.\n\n");
        else if(X == 0 && Y == 0) Console.WriteLine($"The coordinate point ({X} ; {Y}) lies at the origin.\n\n");
    }

    private static void ex04() {
        //Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        Console.WriteLine("Enter three sides of a triangle one by one: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        
        if (a+b>c && a+c>b && b+c>a)  //Điều kiện để là 1 tam giác
        {
            //Xét các tam giác
            if(a==b || a==c || b==c) System.Console.WriteLine("This is a Isosceles Triangle.");
            else if(a==b && a==c ) System.Console.WriteLine("This is a Equilateral Triangle.");
            else if (a*a+b*b==c*c || a*a+c*c==b*b || c*c+b*b==a*a) Console.WriteLine("This is a Right Triangle.");
            else Console.WriteLine("It is a Scalene triangle.");
        }
        else {
            Console.WriteLine("This is not a triangle."); 
            }
    }

    private static void ex05() {
        //Write a program to read 10 numbers and their average and sum
        float s = 0;
        for ( int i=0; i<10; i++) {
            Console.WriteLine("Enter a number: ");
            float a = Single.Parse(Console.ReadLine());
            s = s + a;
        }
        Console.WriteLine($"Sum of 10 numbers: {s}");
        Console.WriteLine($"Average of 10 numbers: {s/10}");
    }

    private static void ex06() {
        //Write a program to display the multiplication table of a given integer 
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Multiplication table of {number}:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }   
    }

    private static void ex07() {
        //Write a program to display a pattern like triangles with a number
        Console.WriteLine("Enter the number of rows: ");
        int n = int.Parse(Console.ReadLine());

        //Type1:
        // for(int i = 1 ; i<=n ; i++) {
        //     for (int j = 1; j<=i; j++) {
        //     Console.Write($"{j} ");
        //     }
        //     Console.WriteLine();
        // }


        //Type2:
        // int num = 1;
        // for(int i = 1 ; i<=n ; i++) {
        //     for (int j = 1; j<=i; j++) {
        //     Console.Write($"{num} ");
        //     num++;
        //     }
        //     Console.WriteLine(); 
        // }


        //Type3:
        int num = 1;
        for(int i = 1 ; i<=n ; i++) {
            for (int k = 1; k<=n-i; k++) {
                Console.Write(" ");
            }
                for (int j = 1; j<=i; j++) {
                Console.Write($"{num} ");
                num++;
                } 
            Console.WriteLine(); 
        }
    }

    private static void ex08() {
        //Write a program to display the n terms of harmonic series and their sum. 
        Console.Write("Enter the number of terms (n): ");
        int n = int.Parse(Console.ReadLine());
        double s = 0;
        for ( int i=1; i<=n; i++) {
            Console.Write($"1/{i} "); 
            s = s + (double)1/i;
        }
        Console.WriteLine();
        Console.WriteLine($"Sum of harmonic series: {s}");
    }

    private static void ex09() {
        //Write a program to find the 'perfect' numbers within a given number range.
        Console.Write("Enter the lower bound of the range: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the upper bound of the range: ");
        int b = int.Parse(Console.ReadLine());
        int s = 0;
        for(int i = a; i<=b; i++) {
            for (int j = 1; j<i; j++) {
            if (i % j == 0) s=s+j; }
            if (s == i) Console.WriteLine ($"{i} is Perfect number!");
            s = 0;
      } 
    }

    private static void ex10() {
        //Write a program to determine whether a given number is prime or not.
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        bool cont = true;
        if (n<=1) Console.WriteLine("This is not a prime number.");
        else { for (int i=2; i<Math.Sqrt(n) ; i++) {
                if (n % i == 0) { 
                cont = false; 
                break; }
            }
        if (cont == false) Console.WriteLine("This is not a prime number.");
        else Console.WriteLine("This is a prime number."); }
    } 
}
