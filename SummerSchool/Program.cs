using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        static string[] Students = new string[15];

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1.Enroll a student");
                Console.WriteLine("2.Unenroll a student");
                Console.WriteLine("3.Print student list");
                Console.WriteLine("4.Exit");


                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Enrollment();
                }
                else if (choice == 2)
                {
                    Unenrollment();
                }
                else if (choice == 3)
                {
                    Print();
                }
                else if (choice == 4)
                {
                    Exit();
                }

            }

        }

        private static void Unenrollment()
        {

        }

        private static void Print()
        {

        }

        static void Exit()
        {
            Console.ReadKey();

        }

        static void Enrollment()
        {

        }



    }
}
