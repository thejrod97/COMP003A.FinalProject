using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    /// <summary>
    /// Implementing an abstract class/base class so the derived classes can use similar functions.
    /// </summary>
    internal abstract class Student
    {
        // Fields 
        private int _studentID;
        private string _firstName;
        private string _middleName;
        private string _lastName;

        // Properties
        public int StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        // Method overriding
        public abstract void DegreeType();
    
    }
}
