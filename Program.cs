using System;

namespace OperatorExercise
{
    class Program
    {

        //is even (bool) this example from lecture
        //public static bool IsEven(int number)
        //{
        //    if (number % 2 == 0) 
        //    {
        //        return true;
        //    }

        //    return false;
        //}


        // Exercise 2 Creating the Method

        public static double AreaOfCir(double radius)
        {
            //Console.WriteLine("What is the radius of the Circle?");
            //radius = double.Parse(Console.ReadLine());
            //double area = (radius * radius) * Math.PI;
            ////return area;
            return radius * radius * Math.PI;
        }
        
        static void Main(string[] args)
        {
            //Exercise 1


            int x = 17;
            int y = 4;
            int quotient = x / y;
            int remainder = x % y;
            Console.WriteLine("Operator Exercise 1...Quotient and Remainder (Modulus)");
            Console.WriteLine();
            Console.WriteLine($"{x}/{y} is {quotient} remainder {remainder}");
            Console.WriteLine();

            //Exercise 2 calling method AreaOfCir
            Console.WriteLine("Operator Exercise 2...Area of a circle method");
            Console.WriteLine();
            Console.WriteLine("What is the Radius of the Circle?");
            var radius = Double.Parse(Console.ReadLine());
            Console.WriteLine($"The Area of a Circle with a radius of {radius} is {AreaOfCir(radius)}...");
            
            
            
            
            
            
            
            
            //increment/decrement examples
            //int a = 1;
            //int b = 2;
            //int c = 5;
            //int d = 5;
            //Console.WriteLine(a);
            //Console.WriteLine(++a);
            //Console.WriteLine(++a);
            //Console.WriteLine(++a);
            
            //Console.WriteLine();
            //Console.WriteLine(b);
            //Console.WriteLine(b++);
            //Console.WriteLine(b++);
            //Console.WriteLine(b++);
           
            //Console.WriteLine();
            //Console.WriteLine(c);
            //Console.WriteLine(c--);
            //Console.WriteLine(c--);
            //Console.WriteLine(c--);
            
            //Console.WriteLine();
            //Console.WriteLine(d);
            //Console.WriteLine(--d);
            //Console.WriteLine(--d);
            //Console.WriteLine(--d);
           

            //is even (bool) this example from lecture
            //Console.WriteLine();
            //Console.WriteLine(IsEven(3446786));
            //Console.WriteLine(IsEven(34467869));

            //Console.ReadKey();


        }
    }
}
