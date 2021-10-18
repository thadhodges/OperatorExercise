using System;

namespace OperatorExercise
{
    class Program
    {

        //is even (bool) this example from lecture
        public static bool IsEven(int number)
        {
            if (number % 2 == 0) 
            {
                return true;
            }

            return false;
        }


        // Exercise 2 Creating the Method

        public static double AreaOfCir(double radius)
        {
            Console.WriteLine("What is the radius of the Circle?");
            radius = double.Parse(Console.ReadLine());
            double area = (radius * radius) * Math.PI;
            return area;
            
        }
        //is even (bool) this example from lecture
        static void Main(string[] args)
        {
            //Exercise 1


            int x = 17;
            int y = 4;
            int quotient = x / y;
            int remainder = x % y;

            Console.WriteLine($"{x}/{y} is {quotient} remainder {remainder}");


            //Exercise 2 calling method AreaOfCir

            
            Console.WriteLine((AreaOfCir(2)));
            
            
            
            
            
            
            
            
            
            //increment/decrement
            int a = 1;
            int b = 2;
            int c = 5;
            int d = 5;
            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(++a);
            Console.WriteLine(++a);
            
            Console.WriteLine();
            Console.WriteLine(b);
            Console.WriteLine(b++);
            Console.WriteLine(b++);
            Console.WriteLine(b++);
           
            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine(c--);
            Console.WriteLine(c--);
            Console.WriteLine(c--);
            
            Console.WriteLine();
            Console.WriteLine(d);
            Console.WriteLine(--d);
            Console.WriteLine(--d);
            Console.WriteLine(--d);
           

            //is even (bool) this example from lecture
            Console.WriteLine();
            Console.WriteLine(IsEven(3446786));
            Console.WriteLine(IsEven(34467869));

            Console.ReadKey();


        }
    }
}
