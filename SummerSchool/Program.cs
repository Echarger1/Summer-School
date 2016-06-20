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
                    break;
                }
                
            }

        }

        private static void Unenrollment()
        {
            for (int i = 0; i < 15; i++ )
            {

            }
        }

        private static void Print()
        {
            for ( int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(Students[i]);
            }
        }

        static int GetNextSpot()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] == null)
                {
                    return i;
                }
 
            }
            return -1;
        }
      
        static void Enrollment()
        {
        
           
            Console.WriteLine("ENTER STUDENT");
            string student = Console.ReadLine();

            int spot = GetNextSpot();
            Students[spot] = student;
           
        }



    }
}
