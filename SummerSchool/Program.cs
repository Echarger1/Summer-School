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
        static double[] StudentCost = new double[15];
        
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
                else
                {
                    Console.WriteLine("NOT A VALID NUMBER TRY AGAIN");
                }
            }

        }

        private static void Unenrollment()
        {
            
            Console.WriteLine("ENTER STUDENT TO REMOVE");
            Print();

            int studentnumber = Convert.ToInt32(Console.ReadLine());
            int studentnumber1 = studentnumber - 1;

            Console.WriteLine("STUDENT " + Students[studentnumber1] + " HAS BEEN REMOVED");

            Students[studentnumber1] = null;


        }

        private static void Print()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + Students[i] + " £" + StudentCost[i]);
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

            double cost = 200;
            Console.WriteLine("ENTER STUDENT");
            string student = Console.ReadLine();
            int spot = GetNextSpot();
            if (student.ToLower() == "malfoy")
            {
                Console.WriteLine("THIS STUDENT CAN NOT BE ENTERED");

            }
            else if (student.ToLower() == "tom")
            {
                Console.WriteLine("RED ALERT!!! HE WHO MUST NOT BE NAMED!!!");
            }
            else if (student.ToLower() == "riddle")
            {
                Console.WriteLine("RED ALERT!!! HE WHO MUST NOT BE NAMED!!!");
            }
            else if (student.ToLower() == "voldemort")
            {
                Console.WriteLine("RED ALERT!!! HE WHO MUST NOT BE NAMED!!!");
            }
            else if (student.ToLower() == "potter")
            {
                Students[spot] = student;
                StudentCost[spot] = cost;
                Console.WriteLine(Students[spot] + " WAS ENROLLED AND THEY OWE £" + cost/2);
            }
            else if (student.ToLower() == "longbottom")
            {
                Students[spot] = student;
                StudentCost[spot] = cost;
                if (CountStudents() < 10)
                {
                    Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + 0 % cost);
                    Console.WriteLine("Press enter to continue");
                }
                else
                {
                    Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + cost);
                    Console.WriteLine("Press enter to continue");
                }
            }


            else
            {
                Students[spot] = student;
                StudentCost[spot] = cost;
                Console.WriteLine(Students[spot] + " WAS ENROLLED AND THEY OWE £" + cost);
                
            }

            
        }

        static int CountStudents()
        {
            int Count = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] != null)
                {
                    Count++;
                }
            }
            return Count;
        }


    }
}
