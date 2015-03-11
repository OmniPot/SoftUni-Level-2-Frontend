namespace _3_Class_Student
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string facultyNumber;
        private string phone;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public Student(
            string firstName,
            string lastName,
            int age,
            string facultyNumber,
            string phone,
            string email,
            List<int> marks,
            int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set { this.facultyNumber = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public List<int> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

        public override string ToString()
        {
            return string.Format(
                "Name: {0} {1}; Age: {2}; Faculty N: {3}; Phone: {4}; Email: {5}; Marks: [ {6} ]; Group N: {7}\n",
                this.FirstName,
                this.LastName,
                this.Age,
                this.FacultyNumber,
                this.Phone,
                this.Email,
                string.Join(", ", this.Marks.ConvertAll(m => m.ToString()).ToArray()),
                this.GroupNumber);
        }
    }
}