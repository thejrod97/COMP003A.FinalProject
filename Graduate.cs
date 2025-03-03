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
    internal class Graduate : Student
    {
        /// <summary>
        /// Graduate constructor to be later called in the main body of logic.
        /// </summary>
        /// <param name="gstudentID"></param>
        /// <param name="gfirstName"></param>
        /// <param name="gmiddleName"></param>
        /// <param name="glastName"></param>
        public Graduate(int gstudentID, string gfirstName, string gmiddleName, string glastName)
        {
            StudentID = gstudentID;
            FirstName = gfirstName;
            MiddleName = gmiddleName;
            LastName = glastName;
        }

        /// <summary>
        /// Overrided method with implementations.
        /// </summary>
        public override void DegreeType()
        {
            Console.WriteLine("Masters of Arts: M.A.");
            Console.WriteLine("Masters of Science: M.S.");
            Console.WriteLine("Doctor of Philosophy: Ph.D.");
        }
    }
}
