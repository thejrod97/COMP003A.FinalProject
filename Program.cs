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
            // List to hold both undergraduate and graduate student information.
            List<Student> students = new List<Student>();

            // Created a count variable to let the user keep track of the number of students currently added to the system.
            int undergraduateCount = 1;
            int graduateCount = 1;

            // While loop to bring the user back to the main menu until they opt out by entering option 5.
            while (true)
            {
                // Main Menu
                Console.WriteLine("\nStudent Course Registration System");
                
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("1. Add Student Information");
                Console.WriteLine("2. View All Student Information");
                Console.WriteLine("3. Edit Student Information");
                Console.WriteLine("4. Delete Student Information");
                Console.WriteLine("5. Exit");
                
                Console.Write("\nYour Choice: ");
                
                // Encased the entire main body of logic with a try-catch exception handling to catch most errors.
                try
                {
                    int input = int.Parse(Console.ReadLine());

                    // Used an else if ladder for user's choice in the menu.
                    if (input == 1)
                    {
                        // Used this prompt in order to keep the different types of student information seperate.
                        Console.Write("\nEnter student type (Undergraduate/Graduate): ");
                        string studentType = Console.ReadLine().ToLower();

                        // Validation
                        if (int.TryParse(studentType, out _))
                        {
                            Console.WriteLine("\nError: Student type cannot be a number. Please try again.");
                        }
                        else
                        {
                            // else if statement to keep student info seperate.
                            if (studentType == "undergraduate")
                            {
                                // For loop to iterate no more than 50 undergrad students added to the system because that meets the requirements.
                                for (int i = 0; i < 50; i++)
                                {
                                    // Some extra exception handling. I don't think it was needed but I did it just incase.
                                    try
                                    {
                                        Console.WriteLine($"\nEnter the details for student {undergraduateCount}");

                                        Console.Write("Enter Student ID: ");
                                        int ugstudentID = int.Parse(Console.ReadLine());

                                        Console.Write("Enter Student's First Name: ");
                                        string ugfirstName = Console.ReadLine().ToLower();

                                        // Validation
                                        if (string.IsNullOrWhiteSpace(ugfirstName))
                                        {
                                            throw new ArgumentException("Error: First name cannot be null or white space.");
                                        }

                                        Console.Write("Enter Student's Middle Name (Press Enter to skip): ");
                                        string ugmiddleName = Console.ReadLine().ToLower();

                                        Console.Write("Enter Student's Last Name: ");
                                        string uglastName = Console.ReadLine().ToLower();

                                        // Validation
                                        if (string.IsNullOrWhiteSpace(uglastName))
                                        {
                                            throw new ArgumentException("Error: Last name cannot be null or white space.");
                                        }

                                        // Undergraduate object
                                        Undergraduate undergraduate = new Undergraduate(ugstudentID, ugfirstName, ugmiddleName, uglastName);

                                        students.Add(undergraduate); // added to collection

                                        Console.WriteLine($"\nStudent {undergraduateCount} Registration Successful!");
                                        undergraduateCount++;

                                        /* I added this feature because I didn't want the user to get stuck adding all 50 students at once.
                                         * This allows them to go back to the menu and view, edit, or delete the student they just added or go back to adding more students.
                                         */
                                        Console.Write("\nAdd another student? (yes/no): ");
                                        string userResponse = Console.ReadLine().ToLower();

                                        if (userResponse != "yes")
                                        {
                                            break;
                                        }
                                    }
                                    catch (ArgumentException)
                                    {
                                        Console.WriteLine("\nError: Student name cannot be empty. Please try again.");
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("An unexpected error has occurred.");
                                    }
                                }
                            }
                            // All comments cover the same topics in this block of code, this section is for the graduate student info being added.
                            else if (studentType == "graduate")
                            {
                                for (int i = 0; i < 50; i++)
                                {
                                    try
                                    {
                                        Console.WriteLine($"\nEnter the details for student {graduateCount}");

                                        Console.Write("Enter Student ID: ");
                                        int gstudentID = int.Parse(Console.ReadLine());

                                        Console.Write("Enter Student's First Name: ");
                                        string gfirstName = Console.ReadLine().ToLower();
                                        if (string.IsNullOrWhiteSpace(gfirstName))
                                        {
                                            throw new ArgumentException("Error: First name cannot be null or white space.");
                                        }

                                        Console.Write("Enter Student's Middle Name (Press Enter to skip): ");
                                        string gmiddleName = Console.ReadLine().ToLower();

                                        Console.Write("Enter Student's Last Name: ");
                                        string glastName = Console.ReadLine().ToLower();
                                        if (string.IsNullOrWhiteSpace(glastName))
                                        {
                                            throw new ArgumentException("Error: Last name cannot be null or white space.");
                                        }

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
                                    catch (ArgumentException)
                                    {
                                        Console.WriteLine("\nError: Student name cannot be empty. Please try again.");
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("An unexpected error has occurred.");
                                    }                                
                                }
                            }
                            // Anthing I have for else I consider validation.
                            else
                            {
                                Console.WriteLine("\nInvalid student type. Please try again.");
                            }
                        }                       
                    }
                    else if (input == 2)
                    {
                        // I consider this a validation since it checks to see if the list isn't empty.
                        if (students.Count == 0)
                        {
                            Console.WriteLine("\nNo student to view.");
                        }

                        // Foreach loop to iterate over the collection of student information I had inside the list and display it to the user.
                        foreach (Student student in students)
                        {
                            Console.WriteLine($"\nStudent ID: {student.StudentID}");
                            Console.WriteLine($"First Name: {student.FirstName}");
                            Console.WriteLine($"Middle Name: {student.MiddleName}");
                            Console.WriteLine($"Last Name: {student.LastName}");
                            Console.WriteLine($"Type: {(student is Undergraduate ? "Undergraduate" : "Graduate")}");

                            // Method override displayed here.
                            student.DegreeType();
                        }
                    }
                    else if (input == 3)
                    {
                        // Validation
                        if (students.Count == 0)
                        {
                            Console.WriteLine("\nNo student to edit");
                            continue;
                        }

                        // I added this search method feature so I could use my method overloads and it is a nice feature because it gives more options.
                        Console.WriteLine("\nPlease enter search method to edit student.");
                        Console.WriteLine("1. By Student ID");
                        Console.WriteLine("2. By Student Last Name");
                        Console.Write("Enter your choice (1 or 2): ");
                        int userChoice = int.Parse(Console.ReadLine());

                        if (userChoice == 1)
                        {
                            Console.Write("\nEnter the Student ID: ");
                            int studentID = int.Parse(Console.ReadLine());

                            // Method overloading displayed here.
                            StudentUtility.FindStudent(studentID);

                            // I used the foundStudent variable and foreach loop to match the user's id that they entered with the id in the list.
                            Student foundStudent = null;

                            foreach (var student in students)
                            {
                                if (student.StudentID == studentID)
                                {
                                    foundStudent = student;
                                    break;
                                }
                            }

                            // Here I am able to update that specific student's info.
                            if (foundStudent != null)
                            {
                                Console.Write("\nEnter New Student ID: ");
                                foundStudent.StudentID = int.Parse(Console.ReadLine());

                                Console.Write("Enter New Student's First Name: ");
                                foundStudent.FirstName = Console.ReadLine();
                                // Validation
                                if (string.IsNullOrWhiteSpace(foundStudent.FirstName))
                                {
                                    throw new ArgumentException("Error: First name cannot be null or white space.");
                                }

                                Console.Write("Enter New Student's Middle Name (Press Enter to skip): ");
                                foundStudent.MiddleName = Console.ReadLine();

                                Console.Write("Enter New Student's Last Name: ");
                                foundStudent.LastName = Console.ReadLine();
                                // Validation
                                if (string.IsNullOrWhiteSpace(foundStudent.LastName))
                                {
                                    throw new ArgumentException("Error: Last name cannot be null or white space.");
                                }

                                Console.WriteLine("\nStudent information updated successfully!");
                            }
                        }
                        // Same comments apply from userChoice == 1.
                        else if (userChoice == 2)
                        {
                            Console.Write("\nEnter the Last Name: ");
                            string lastName = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(lastName))
                            {
                                throw new ArgumentException("Error: Last name cannot be null or white space.");
                            }

                            StudentUtility.FindStudent(lastName);

                            Student studentFound = null;

                            foreach (var student in students)
                            {
                                if (student.LastName == lastName)
                                {
                                    studentFound = student;
                                    break;
                                }
                            }

                            if (studentFound != null)
                            {
                                Console.Write("\nEnter New Student ID: ");
                                studentFound.StudentID = int.Parse(Console.ReadLine());

                                Console.Write("Enter New Student's First Name: ");
                                studentFound.FirstName = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(studentFound.FirstName))
                                {
                                    throw new ArgumentException("Error: First name cannot be null or white space.");
                                }

                                Console.Write("Enter New Student's Middle Name (Press Enter to skip): ");
                                studentFound.MiddleName = Console.ReadLine();

                                Console.Write("Enter New Student's Last Name: ");
                                studentFound.LastName = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(studentFound.LastName))
                                {
                                    throw new ArgumentException("Error: Last name cannot be null or white space.");
                                }

                                Console.WriteLine("\nStudent information updated successfully!");
                            }
                        }
                        // Validation
                        else
                        {
                            Console.WriteLine("\nInvalid choice. Please try again.");
                        }
                    }
                    // Very similar process to option 3 and similar comments to refer to.
                    else if (input == 4)
                    {
                        if (students.Count == 0)
                        {
                            Console.WriteLine("\nNo student to delete");
                            continue;
                        }

                        Console.WriteLine("\nPlease enter search method to delete student.");
                        Console.WriteLine("1. By Student ID");
                        Console.WriteLine("2. By Student Last Name");
                        Console.Write("Enter your choice (1 or 2): ");
                        int userChoice = int.Parse(Console.ReadLine());

                        if (userChoice == 1)
                        {
                            Console.Write("\nEnter the Student ID: ");
                            int studentID = int.Parse(Console.ReadLine());
                            StudentUtility.FindStudent(studentID);

                            Student removeStudent = null;

                            foreach (var student in students)
                            {
                                if (student.StudentID == studentID)
                                {
                                    removeStudent = student;
                                    break;
                                }
                            }

                            // Only difference is inside the if statement.
                            if (removeStudent != null)
                            {
                                students.Remove(removeStudent);
                                Console.WriteLine("\nStudent has been deleted from the system.");
                            }
                        }
                        else if (userChoice == 2)
                        {
                            Console.Write("\nEnter the Last Name: ");
                            string lastName = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(lastName))
                            {
                                throw new ArgumentException("Error: Last name cannot be null or white space.");
                            }

                            StudentUtility.FindStudent(lastName);

                            Student removeStudent = null;

                            foreach (var student in students)
                            {
                                if (student.LastName == lastName)
                                {
                                    removeStudent = student;
                                    break;
                                }
                            }

                            // Here is the removal process again but if the user entered by last name.
                            if (removeStudent != null)
                            {
                                students.Remove(removeStudent);
                                Console.WriteLine("\nStudent has been deleted from the system.");
                            }
                        }
                        // Validation
                        else
                        {
                            Console.WriteLine("\nInvalid choice. Please try again.");
                        }
                    }
                    // To exit the application.
                    else if (input == 5)
                    {
                        Console.WriteLine("\nHave a nice day!");
                        break;
                    }
                    // Validation
                    else
                    {
                        Console.WriteLine("\nInvalid choice. Please try again.");
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("\nError: Student name cannot be empty. Please try again.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nError: Input must be numeric. Please try again.");
                }
                catch (Exception)
                {
                    Console.WriteLine("\nAn unexpected error has occurred.");
                }
            }
        }
    }
}
