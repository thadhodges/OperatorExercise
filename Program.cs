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
        //is even (bool) this example from lecture
        static void Main(string[] args)
        {
            //Exercise 1
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

            Console.ReadKey();


        }
    }
}
