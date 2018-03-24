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

            Console.Write("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n" +
                          "+  Programmed by MD.Saiful Ebne Hashem. And Sajid helped. +\n" +
                          "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n" +
                          "+                           Contact                       +\n" +
                          "+---------------------------------------------------------+\n" +
                          "+\tEmail:\tme@saifulebnehashem.ml                    +\n" +
                          "+\tFB:\tfb.com/saifulebnehashem                   +\n" +
                          "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            /*
            Console.WriteLine("Welcome To MiniPress | Make by Saiful.\n");
            Console.WriteLine("Please input a Name.");
            string name = Console.ReadLine();
            Console.WriteLine("Please input a Discription.");
            string discription = Console.ReadLine();
            Console.WriteLine("Please input a Title.");
            string title = Console.ReadLine();
            Console.WriteLine("<!DOCTYPE html><html><head><title>{0}</title></head><body><h1>{1}</h1><p>{2}</p></body></html>",title,name,discription);
            */
            
            
            Console.Write("\nInput Your Full Name:");
            string fullname = Console.ReadLine();

            Console.Write("Input Your Profile pic Name:");
            string profilepic = Console.ReadLine();

            Console.Write("Input Your Nickname:");
            string nickname = Console.ReadLine();

            Console.Write("Input Your Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Your Phone Number:");
            string phone = Console.ReadLine();

            Console.Write("Input Your Email Address:");
            string email = Console.ReadLine();

            Console.Write("Input Your Address:");
            string address = Console.ReadLine();

            Console.Write("Input Your Web-Title:");
            string webtitle = Console.ReadLine();
            

            Console.Write("\n------------------------------------------------------" +
                          "\nCopy and paste the following text into index.html file" +
                          "\n------------------------------------------------------\n\n\n<!--\nThis is Copyright Free Web Template For Everyone\n.................................................\nThis Webpage Create for MiniPress use!!\n- - - - - - - - - - - - - - - - - - - - - - - - -\nThis WebPage Make by MD.Saiful Ebne Hahshem\nFB: SaifulEbneHahshem\nWebsite: https://www.SaifulEbneHahshem.ml\nE - mail:me@saifulebnehahshem.ml\nPhone: +880 1633 700075\n.................................................\n-->\n<!DOCTYPE html>\n<html>\n<head>\n<title>{0}</title>\n<link rel=\"stylesheet\" type=\"text/css\" href=\"./css/materialize.min.css\">\n<script src = \"./js/materialize.min.js/\"></script>\n</head>\n<body>\n<div class=\"z -depth-5 container #6a1b9a purple darken-3\">\n<div class=\"center-align #4a148c purple darken-4 z-depth-2\">\n<img class=\"responsive-img z-depth-5 profileimg\" src=\"./img/{1}\">\n</div>\n<div class=\"center-align #8e24aa purple darken-1 z-depth-5 z-depth-5 hadingd1name\">\n<h1 class=\"center-align hadingname\">{2}</h1>\n</div>\n<div class=\"#aa00ff purple accent-4 z-depth-5\">\n<table class=\"striped\">\n<tbody>\n<tr>\n<td class=\"td\">Name:</td>\n<td class=\"td2\">&nbsp;&nbsp;&nbsp;{3}</td>\n</tr>\n<tr>\n<td class=\"td\">Phone:</td>\n<td class=\"td2\">&nbsp;&nbsp;&nbsp;{4}</td>\n</tr>\n<tr>\n<td class=\"td\">Age:</td>\n<td class=\"td2\">&nbsp;&nbsp;&nbsp;{5}</td>\n</tr>\n<tr>\n<td class=\"td\">Email:</td>\n<td class=\"td2\">&nbsp;&nbsp;&nbsp;{6}</td>\n</tr>\n<tr>\n<td class=\"td\">Address:</td>\n<td class=\"td2\">&nbsp;&nbsp;&nbsp;{7}</td>\n</tr>\n</tbody>\n</table>\n</div>\n</div>\n</body>\n</html>", webtitle, profilepic, nickname, fullname, phone, age, email, address);
            /*
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
            */


            Console.ReadKey();
        }
    }
}
