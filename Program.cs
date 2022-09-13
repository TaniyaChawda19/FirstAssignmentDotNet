using System.Collections.Immutable;
using System.Diagnostics;
using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace FirstAssignmentDotNet
{
    internal class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of C#");
        }
    }

    internal class Greetings
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Welcome to the world of C#");

        }
    }

    class NumberBetweenTwoNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number 1 : ");
            Console.Write("Enter Number 2 : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number between two given numbers:");
            if (number1 < number2)
            {
                for (int i = number1; i < number2+1; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = number2; i < number1+1; i++)
                {
                    Console.WriteLine(i);
                }

            }
        }

    }

    class OddorEven
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }


    class OddEvenCount
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 5 Numbers: ");
            int[] arr = new int[5];
            int ecount = 0, ocount = 0;
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] % 2 == 0)
                {
                    ecount++;
                }
                else
                {
                    ocount++;
                }
            }
            Console.WriteLine("Count of Even number : " + ecount);
            Console.WriteLine("Count of Odd number : " + ocount);

        }
    }

    class FtoC
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Fahrenheit value : ");
            int f = Convert.ToInt32(Console.ReadLine());
            var c = (f - 32) * 5 / 9;

            Console.WriteLine("Fahrenheit to Celsius ="+c);
        }



    }

    class Square
    {
        static void Main(string[] args)
    {

            Console.WriteLine("Square of 1 to 25 are given below");
            for (int i = 1; i < 26; i++)
        {
            Console.WriteLine(i * i);
        }
    }
    }

    class Factorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            var fact = 1;
            if(n<0)
            {
                Console.WriteLine("Enter another number");
            }
            if(n==0)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i=n; i>0;i--)
                {
                    fact=fact*i;
                }
                Console.WriteLine( "Factorial of "+"n : "+fact);
            }
        }
    }

    class Fibo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Series from 1 to 40 is given below");
            int a = 0;
            int b = 1;
            int c;
        Console.Write(a + " " + b+ " ");
            for(int i=2;i<41;i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;

            }
        }
        


    }

    class SumOfCubes
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            for( int i=5;i<n+1;i++)
            {
                sum += i * i * i;
            }
            Console.WriteLine("Sum of cube of 5 to "+n+" is : " +sum);
        }
    }

    class MultiTable
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication table of " + n + " till 20");
            for(int i=1;i<21;i++)
            {
                Console.Write(n * i + " ");
            }
        }
    }

    class DivbySeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number divisible by 7 between 200 to 300");
            for (int i=200;i<301;i++)
            {
                if(i%7==0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }

    class LargestOfThree
    {
        static void Main(string[] args)
        {
            Console.Write("A=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("C=");
            int c = Convert.ToInt32(Console.ReadLine());    
            if( a>b && a>c)
            {
                Console.WriteLine("A is largest");
            }
            else if (b>a && b>c)
            {
                Console.WriteLine("B is largest");


            }
            else
            {
                Console.WriteLine("C is largest");
            }
        }
    }

    class SmallestOfFive
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter 5 numbers");
            for (int i=0;i<5;i++)
            {
                Console.Write("Number " + (i + 1 )+ " : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = a[0];
            for (int i = 0; i < 5; i++)
            {
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Minimum Number : " + min);
        }
    }

    class TenMarks
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int sum = 0;
            int min, max;
            Console.WriteLine("Enter marks ");
            for (int i = 0; i < 10; i++)
            { 
                a[i] = Convert.ToInt32(Console.ReadLine());
                sum += a[i];

            }
            min = a[0];
            max = a[0];

            for (int i = 0; i < 10; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + (float)(sum / 10));
            Console.WriteLine("Minimum : " + min);
            Console.WriteLine("Maximum :" + max);
            Array.Sort(a);
            Console.Write("Asscending order : ");
            foreach (int val in a)
            {
                Console.Write(val  + " ");
            }
            Array.Reverse(a);
            Console.Write("Descending order : ");
            foreach (int val in a)
            {
                Console.Write(val + " ");
            }
        }
    }


    class LengthOfWord
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word:");
            string n = Console.ReadLine();
            int len = n.Length;
            Console.WriteLine("Lenght of the Word: " + len);
        }
    }

    class ReverseWord
    {
        static void Main(string[]args)
        {
            Console.Write("Enter word:");
            string n = Console.ReadLine();
            string rev = "";
            int a = n.Length - 1;
            while(a>=0)
            {
                rev += n[a];
                a--;

            }
            Console.WriteLine("Reverse word:" + rev);
        }
    }

    class TwoWordSame
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st word : ");
            string a = Console.ReadLine();
            Console.Write("Enter 2nd word : ");
            string b = Console.ReadLine();

            if(a.Equals(b))
            {
                Console.WriteLine("Both words are Equal");
            }
            else
            {
                Console.WriteLine("Both words are Not Equal");
            }
        }
    }

    class WordPalindrome
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Word : ");
            string a = Console.ReadLine();
            string rev = "";
            int len = a.Length - 1;
            while (len>= 0)
            {
                rev += a[len];
                len--;

            }
            if(rev==a)
            {
                Console.WriteLine("Word is Palindrome");

            }
            else
            {
                Console.WriteLine("Word is Not a Palindrome");
            }
        }
    }
}

