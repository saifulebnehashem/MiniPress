using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPress
{
    class Program
    {
        static string gender;
        static void Main(string[] args)
        {
            /* Console.WriteLine("Welcome To MiniPress | Make by Saiful.\n");
            Console.WriteLine("Please input a Name.");
            string name = Console.ReadLine();
            Console.WriteLine("Please input a Discription.");
            string discription = Console.ReadLine();
            Console.WriteLine("Please input a Title.");
            string title = Console.ReadLine();
            Console.WriteLine("<!DOCTYPE html><html><head><title>{0}</title></head><body><h1>{1}</h1><p>{2}</p></body></html>",title,name,discription);
            */
            Console.Write("Input Name:");
            string name = Console.ReadLine();
            Console.WriteLine(name);




            Console.WriteLine("Input Gender:");
            string g = Console.ReadLine();
            Console.WriteLine("if - Pic naem:");
            string p = Console.ReadLine();

            if (g == "f")
            {
                gender = "female";
            }
            else 
            {
                gender = "male";
            }

            if (gender == "female" & p == "-" )
            {
                Console.WriteLine("f No pic");
            }
            else if (gender == "female")
            {
                Console.WriteLine("f pic");
            }
            else if (gender == "male" & p == "-")
            {
                Console.WriteLine("m no pic");
            }
            else if (gender == "male")
            {
                Console.WriteLine("m pic");
            }
            else
            {
                Console.WriteLine("Wrong input!!");
            }
            Console.WriteLine();
            


            Console.ReadKey();
        }
    }
}
