using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        private string _middleName = "";
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
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("First name cannot be empty.");
                _firstName = value;
            }           
        }

        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Middle name cannot be null.");
                _middleName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Last Name cannot be empty.");
                _lastName = value;
            }
        }

        // Method overriding
        public abstract void DegreeType();
    
    }
}
