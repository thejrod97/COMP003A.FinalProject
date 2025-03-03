using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    /// <summary>
    /// Using this concrete class as a utility class for method overloading.
    /// These methods proved to be useful as I was able to overload them more than once.
    /// </summary>
    public class StudentUtility
    {
        /// <summary>
        /// Used for method overloading.
        /// </summary>
        /// <param name="studentID"></param>
        public static void FindStudent(int studentID)
        {
            Console.WriteLine($"\nStudent ID found!: {studentID}");
        }
        /// <summary>
        /// Used for method overloading.
        /// </summary>
        /// <param name="lastName"></param>
        public static void FindStudent(string lastName)
        {
            Console.WriteLine($"\nStudent Last Name found!: {lastName}");
        }
    }
}
