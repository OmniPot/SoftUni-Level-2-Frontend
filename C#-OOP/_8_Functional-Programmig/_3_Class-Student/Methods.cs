namespace _3_Class_Student
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public static class Methods
    {
        public static IEnumerable Problem12(List<Student> classStudents)
        {
            var collection =
                from student in classStudents
                where student.FacultyNumber.Substring(4, 2).Equals("14")
                select string.Join(", ", student.Marks.ConvertAll(s => s.ToString()).ToArray());

            collection.ToList().ForEach(Console.WriteLine);
            return collection;
        }

        public static IEnumerable Problem11(List<Student> classStudents)
        {
            var collection =
                from student in classStudents
                where student.Marks.Count(mark => mark == 2) == 2
                select student;

            collection.ToList().ForEach(Console.WriteLine);
            return collection;
        }

        public static IEnumerable Problem10(List<Student> classStudents)
        {
            var collection =
                from student in classStudents
                where student.Marks.Contains(6)
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    Marks = string.Join(", ", student.Marks.ConvertAll(mark => mark.ToString()).ToArray())
                };

            collection.ToList().ForEach(Console.WriteLine);
            return collection;
        }

        public static IEnumerable Problem9(List<Student> classStudents)
        {
            var collection = classStudents
                .FindAll(s => s.Phone.Contains("+3592") ||
                                s.Phone.Contains("02") ||
                                s.Phone.Contains("+359 2"));

            collection.ToList().ForEach(Console.WriteLine);
            return collection;
        }

        public static IEnumerable Problem8(List<Student> classStudents)
        {
            var collection = classStudents.FindAll(s => s.Email.EndsWith("abv.bg"));

            collection.ToList().ForEach(Console.WriteLine);
            return collection;
        }

        public static IEnumerable Problem7_2(List<Student> classStudents)
        {
            var collection =
                from student in classStudents
                orderby student.FirstName descending
                orderby student.LastName descending
                select student;

            return collection;
        }

        public static IEnumerable Problem7_1(List<Student> classStudents)
        {
            var collection = classStudents
                .OrderBy(s => s.FirstName)
                .ThenBy(s => s.LastName);

            return collection;
        }

        public static IEnumerable Problem6(List<Student> classStudents)
        {
            var collection =
                from student in classStudents
                where student.Age > 18 && student.Age < 24
                select new
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Age = student.Age
                };

            return collection;
        }

        public static IEnumerable Problem5(List<Student> classStudents)
        {
            var collection =
                from student in classStudents
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            collection.ToList().ForEach(Console.WriteLine);
            return collection;
        }

        public static IEnumerable Problem4(List<Student> classStudents)
        {
            var collection =
                from student in classStudents
                where student.GroupNumber == 2
                orderby student.FirstName ascending
                select student;

            collection.ToList().ForEach(Console.WriteLine);
            return collection;
        }
    }
}
