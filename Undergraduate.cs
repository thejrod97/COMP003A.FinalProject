using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    /// <summary>
    /// Derived class of the base student class in order to use the shared properties needed for modification.
    /// Also overrided an abstract method from student class to implement the specific body of code for this class.
    /// </summary>
    internal class Undergraduate : Student
    {
        /// <summary>
        /// Undergraduate constructor to be later called in the main body of logic.
        /// </summary>
        /// <param name="ugstudentID"></param>
        /// <param name="ugfirstName"></param>
        /// <param name="ugmiddleName"></param>
        /// <param name="uglastName"></param>
        public Undergraduate(int ugstudentID, string ugfirstName, string ugmiddleName, string uglastName)
        {
            StudentID = ugstudentID;
            FirstName = ugfirstName;
            MiddleName = ugmiddleName;
            LastName = uglastName;
        }

        /// <summary>
        /// Overrided method with implementations.
        /// </summary>
        public override void DegreeType()
        {
            Console.WriteLine("Associate of Arts: A.A.");
            Console.WriteLine("Associate of Science: A.S.");
            Console.WriteLine("Bachelor of Arts: B.A.");
            Console.WriteLine("Bachelor of Science: B.S.");
        }
    }
}
