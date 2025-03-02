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
    internal class Undergraduate : Student
    {
        public Undergraduate(int ugstudentID, string ugfirstName, string ugmiddleName, string uglastName)
        {
            StudentID = ugstudentID;
            FirstName = ugfirstName;
            MiddleName = ugmiddleName;
            LastName = uglastName;
        }

        public override void DegreeType()
        {
            Console.WriteLine("Bachelor of Arts: B.A.");
            Console.WriteLine("Bachelor of Science: B.S.");
        }
    }
}
