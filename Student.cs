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
    /// This is where I set all of my private fields and public properties.
    /// Added validation to the properties just incase it gets passed the validation in the main body of logic.
    /// There is an abstract method for other classes to override and implement with their own specifications.
    /// </summary>
    internal abstract class Student
    {
        // Fields 
        private int _studentID;
        private string _firstName;
        private string _middleName = "";
        private string _lastName;

        /// <summary>
        /// Student ID property in order to manipulate the variable.
        /// </summary>
        public int StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        /// <summary>
        /// First Name property in order to manipulate the variable with validation.
        /// </summary>
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

        /// <summary>
        /// Middle Name property in order to manipulate the variable with validation.
        /// </summary>
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

        /// <summary>
        /// Last Name property in order to manipulate the variable with validation.
        /// </summary>
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

        /// <summary>
        /// An abstract method for other classes to use with similar functionalities.
        /// </summary>
        public abstract void DegreeType();
    
    }
}
