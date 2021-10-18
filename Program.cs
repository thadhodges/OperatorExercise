using System;

namespace OperatorExercise
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            //Exercise 1

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

            Console.ReadKey();


        }
    }
}
