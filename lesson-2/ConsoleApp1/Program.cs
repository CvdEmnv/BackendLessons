using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Include Name");
            //var name = Console.ReadLine();
            //Console.WriteLine(name + " " + "Hello");

            //Console.WriteLine("insert your age");
            //int num1=Convert.ToInt32(Console.ReadLine());

            //if (num1>18)
            //{
            //    Console.WriteLine("Hello");

            //} 
            //else
            //{
            //    Console.WriteLine("You are not 18");

            //}

            Console.WriteLine("Insert first number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert second number");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert symbol");
            string symb=Console.ReadLine();

            if (symb == "+")
            {
                Console.WriteLine("num1+ num2");
            }
            else if(symb == "/")
            {
                Console.WriteLine(num1/ num2);
            }
            else if(symb=="*")
            {
                Console.WriteLine(num1* num2);
            }
            else
            {
                Console.WriteLine("The symbol is not exsist");
            }
            
            
        }

    }
}
