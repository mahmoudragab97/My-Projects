using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, choice;
            string name;
            Console.WriteLine("Enter number of students");
            x = int.Parse(Console.ReadLine());
            string[] names = new string[x];
            int[] degs = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter student " + (i + 1) + " name ");
                names[i] = Console.ReadLine();
                Console.WriteLine("Enter student " + (i + 1) + " degree ");
                degs[i] = int.Parse(Console.ReadLine());
            }
        start:
            Console.WriteLine("Choose an option from the following menu");
            Console.WriteLine("=========================================");
            Console.WriteLine("[1] Search for a student degree");
            Console.WriteLine("[2] Get top student name and degree");
            Console.WriteLine("[3] Change a student's name");
            Console.WriteLine("    Please enter your choice");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter student name");
                name = Console.ReadLine();
                if (names.Contains(name))
                {
                    int result = -2;
                    for (int i = 0; i < names.Length; i++)
                    {
                        result = Array.IndexOf(names, name);
                    }
                    Console.WriteLine("Student name " + names[result] + " Student degree " + degs[result]);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Student not found ");
                    Console.ReadLine();
                }
                goto start;

            }
            else if (choice == 2)
            {
                int maxdeg = degs.Max();
                int top = 1;
                for (int i = 0; i < degs.Length; i++)
                {
                    top = Array.IndexOf(degs, maxdeg);
                }
                Console.WriteLine("Top student is " + names[top] + " has a score of " + maxdeg);
                Console.ReadLine();
                goto start;
            }
            else if (choice == 3)
            {
                string oldname, newname;
                Console.WriteLine("Type a name to be changed");
                oldname = Console.ReadLine();
                Console.WriteLine("Type the new name");
                newname = Console.ReadLine();
                names[Array.IndexOf(names, oldname)] = newname;
                Console.WriteLine("Name is changed");
                foreach (string item in names)
                {
                    Console.WriteLine(item.ToString());
                    Console.ReadLine();
                }

                goto start;
            }
        }
    }
}
