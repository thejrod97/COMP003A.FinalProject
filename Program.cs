// Author: Justin Rodriguez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Student Course Registration System
using System.Reflection.Metadata;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int undergraduateCount = 1;
            int graduateCount = 1;

            while (true)
            {
                Console.WriteLine("\nStudent Course Registration System");
                
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("1. Add Student Information");
                Console.WriteLine("2. View All Student Information");
                Console.WriteLine("3. Edit Student Information");
                Console.WriteLine("4. Delete Student Information");
                Console.WriteLine("5. Exit");
                
                Console.Write("\nYour Choice: ");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Write("\nEnter student type (Undergraduate/Graduate): ");
                    string studentType = Console.ReadLine().ToLower();

                    if (studentType == "undergraduate")
                    {
                        for (int i = 0; i < 50; i++)
                        {
                             
                            Console.WriteLine($"\nEnter the details for student {undergraduateCount}");

                            Console.Write("Enter Student ID: ");
                            int ugstudentID = int.Parse(Console.ReadLine());

                            Console.Write("Enter Student's First Name: ");
                            string ugfirstName = Console.ReadLine().ToLower();

                            Console.Write("Enter Student's Middle Name (Press Enter to skip): ");
                            string ugmiddleName = Console.ReadLine().ToLower();

                            Console.Write("Enter Student's Last Name: ");
                            string uglastName = Console.ReadLine().ToLower();

                            Undergraduate undergraduate = new Undergraduate(ugstudentID, ugfirstName, ugmiddleName, uglastName);

                            students.Add(undergraduate); // added to collection

                            Console.WriteLine($"\nStudent {undergraduateCount} Registration Successful!");
                            undergraduateCount++;

                            Console.Write("\nAdd another student? (yes/no): ");
                            string userResponse = Console.ReadLine().ToLower();

                            if (userResponse != "yes")
                            {
                                break;
                            }
                        }
                    }
                    else if (studentType == "graduate")
                    {
                        for (int i = 0; i < 50; i++)
                        {

                            Console.WriteLine($"\nEnter the details for student {graduateCount}");

                            Console.Write("Enter Student ID: ");
                            int gstudentID = int.Parse(Console.ReadLine());

                            Console.Write("Enter Student's First Name: ");
                            string gfirstName = Console.ReadLine().ToLower();

                            Console.Write("Enter Student's Middle Name (Press Enter to skip): ");
                            string gmiddleName = Console.ReadLine().ToLower();

                            Console.Write("Enter Student's Last Name: ");
                            string glastName = Console.ReadLine().ToLower();

                            Graduate graduate = new Graduate(gstudentID, gfirstName, gmiddleName, glastName);

                            students.Add(graduate); // added to collection

                            Console.WriteLine($"\nStudent {graduateCount} Registration Successful!");
                            graduateCount++;

                            Console.Write("\nAdd another student? (yes/no): ");
                            string userResponse = Console.ReadLine().ToLower();
                            
                            if (userResponse != "yes")
                            {
                                break;
                            }
                        }
                    }
                }
                else if (input == 2)
                {
                    foreach (Student student in students)
                    {
                        Console.WriteLine($"\nStudent ID: {student.StudentID}");
                        Console.WriteLine($"First Name: {student.FirstName}");
                        Console.WriteLine($"Middle Name: {student.MiddleName}");
                        Console.WriteLine($"Last Name: {student.LastName}");
                        Console.WriteLine($"Type: {(student is Undergraduate ? "Undergraduate" : "Graduate")}");
                        student.DegreeType();
                    }
                }
            }
        }
    }
}
