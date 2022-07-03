using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs223_project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter your Physics marks: ");
                int Marks = int.Parse(Console.ReadLine());

                if (Marks >= 90)
                {
                    Console.WriteLine("You got A+ grade. \n\n");
                }
                else if (Marks >= 50 && Marks < 90)
                {
                    Console.WriteLine("You passed the exam. \n\n");
                }
                else
                {
                    Console.WriteLine("You failed the exam. \n\n");
                }

            }
        }

    }
}
