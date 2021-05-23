using System;

namespace OperatorsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
             //Assignment
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x += 5;
            Console.WriteLine(x);

            //Logical (||, &&, !)
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if(isSuccess || isCompleted)
                Console.WriteLine("Great");

            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine");

            //Relational (<, >, <=, >=, ==, !=)
            int a = 3;
            int b = 4;

            bool rslt = a<b;            
            Console.WriteLine(rslt);
            rslt = a>b;
            Console.WriteLine(rslt);
            rslt = a>=b;
            Console.WriteLine(rslt);
            rslt = a<=b;
            Console.WriteLine(rslt);
            rslt = a==b;
            Console.WriteLine(rslt);
            rslt = a!=b;
            Console.WriteLine(rslt);

            //Arithmetic (/, *, +, -)
            int num1 = 10;
            int num2 = 5;

            int rslt1 = num1/num2;
            Console.WriteLine(rslt1);
            rslt1 = num1*num2;
            Console.WriteLine(rslt1);
            rslt1 = num1+num2;
            Console.WriteLine(rslt1);
            rslt1 = num1-num2;
            Console.WriteLine(rslt1);
            rslt1 = num1++;
            Console.WriteLine(rslt1);

            // % : MOD
            int rslt2 = 20 % 3;
            Console.WriteLine(rslt2);
        }
    }
}
