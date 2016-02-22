using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseWPF
{
    public class Student : IComparable<Student>
    {
        private int studentID; 
        private string firstName;
        private string lastName;

        public Student(int studentID, string firstName, string lastName)
        { 
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + studentID;
        }

        public int CompareTo(Student otherStudent)
        {
            if (this.lastName.CompareTo(otherStudent.LastName) > 0)
            {
                return 1;
            }
            else if (this.lastName.CompareTo(otherStudent.LastName) == 0 &&
                    this.firstName.CompareTo(otherStudent.FirstName) > 0)
            {
                return 1;
            }
            else if (this.lastName.CompareTo(otherStudent.LastName) == 0 &&
                    this.firstName.CompareTo(otherStudent.FirstName) == 0 &&
                    this.studentID > otherStudent.StudentID)
            {
                return 1;
            }
            else if (this.lastName.CompareTo(otherStudent.LastName) == 0 &&
                    this.firstName.CompareTo(otherStudent.FirstName) == 0 &&
                    this.studentID == otherStudent.StudentID)
            {
                return 0;
            }
            else
            {
                return -1;
            }

        }

            public override bool Equals(object obj)
            {
                if (obj == null) return base.Equals(obj);
                if (!(obj is Student))
                    throw new InvalidCastException("The Object isn't of Type Student.");
                else
                    return Equals(obj as Student);
            }

            public bool Equals(Student otherPerson)
            {
                if (StudentID == otherPerson.StudentID)
                    return true;
                else
                    return false;
            }

            public override int GetHashCode()
            {
                return StudentID.GetHashCode();
            }
    }
}
