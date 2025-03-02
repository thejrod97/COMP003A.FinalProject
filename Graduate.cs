using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    /// <summary>
    /// Derived class
    /// </summary>
    internal class Graduate : Student
    {
        public Graduate(int gstudentID, string gfirstName, string gmiddleName, string glastName)
        {
            StudentID = gstudentID;
            FirstName = gfirstName;
            MiddleName = gmiddleName;
            LastName = glastName;
        }

        public override void DegreeType()
        {
            Console.WriteLine("Masters of Arts: M.A.");
            Console.WriteLine("Masters of Science: M.S.");
            Console.WriteLine("Doctor of Philosophy: Ph.D.");
        }
    }
}
