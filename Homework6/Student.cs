using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public enum Specialty
    {
        Informatiks, Other
    };

    public enum University
    {
        NewBulgarian, Other
    };

    public enum Faculties
    {
        Mathematics, Other
    };

    class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanentAddress;
        private string email;
        private int course;
        Specialty specialty;
        University university;
        Faculties faculty;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string Ssn
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }

        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set { this.permanentAddress = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        public Specialty Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }

        public University University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public Faculties Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        

        public Student()
        {
            this.FirstName = "";
            this.MiddleName = "";
            this.LastName = "";
            this.Ssn = "";
            this.PermanentAddress = "";
            this.Email = "";
            this.Course = 0;
            this.Specialty = Specialty.Other;
            this.University = University.Other;
            this.Faculty = Faculties.Other;
        }

        public Student (string firstName, string middleName, string lastName, string SSN, string permanentAddress, string email, 
            int course, Specialty specialty, University university, Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = SSN;
            this.PermanentAddress = permanentAddress;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.MiddleName + " " + this.LastName + " " + this.Ssn + " " + this.PermanentAddress + " " +
                this.Email + " " + this.Course + " " + this.Specialty + " " + this.University + " " + this.Faculty;
            
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;
            if (param == null)
                return false;
            if (! Object.Equals (student.FirstName, this.FirstName))
                return false;
            if (!Object.Equals(student.MiddleName, this.MiddleName))
                return false;
            if (!Object.Equals(student.LastName, this.LastName))
                return false;
            if (!Object.Equals(student.Ssn, this.Ssn))
                return false;
            if (!Object.Equals(student.PermanentAddress, this.PermanentAddress))
                return false;
            if (!Object.Equals(student.Email, this.Email))
                return false;
            if (!Object.Equals(student.Course, this.Course))
                return false;
            if (!Object.Equals(student.Specialty, this.Specialty))
                return false;
            if (!Object.Equals(student.University, this.University))
                return false;
            if (!Object.Equals(student.Faculty, this.Faculty))
                return false;
            
             return true;


        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.Ssn.GetHashCode() ^
                this.PermanentAddress.GetHashCode() ^ this.Email.GetHashCode() ^ this.Course.GetHashCode() ^ this.Specialty.GetHashCode() ^
                this.University.GetHashCode() ^ this.Faculty.GetHashCode();
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return  !(Student.Equals(student1, student2));
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        
// zadacha 2
        public Student Clone()
        {
            Student original = this;
            Student result = new Student();
            result.FirstName = original.FirstName;
            result.MiddleName = original.MiddleName;
            result.LastName = original.LastName;
            result.Ssn = original.Ssn;
            result.PermanentAddress = original.PermanentAddress;
            result.Email = original.Email;
            result.Course = original.Course;
            result.Specialty = original.Specialty;
            result.University = original.University;
            result.Faculty = original.Faculty;

            return result;


        }
// zadacha 3
        public int CompareTo(Student student)
        {

            if (String.Compare(this.FirstName, student.FirstName) == 0)
            {
                if (String.Compare(this.MiddleName, student.MiddleName) == 0)
                {
                    if (String.Compare(this.LastName, student.LastName) == 0)
                    {
                        return String.Compare(this.Ssn, student.Ssn);
                    }
                    else
                    {
                        return String.Compare(this.LastName, student.LastName);
                    }
                }
                else
                {
                    return String.Compare(this.MiddleName, student.MiddleName);
                }
            }
            else
            {
                return String.Compare(this.FirstName, student.FirstName);
            }


        }
    }
}
