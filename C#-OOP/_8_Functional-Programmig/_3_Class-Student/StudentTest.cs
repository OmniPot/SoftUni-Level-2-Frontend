namespace _3_Class_Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentTest
    {
        public static void Main()
        {
            // Problem 3
            List<Student> classStudents = new List<Student> 
            {
                new Student("Martin", "Kaloqnov", 16, "1301141059", "+3592 347 237", "azSymLud@abv.bg", new List<int> { 5, 2, 6, 7, 5 }, 3),
                new Student("Ivan", "Andreev", 21, "346234623", "+2346 234 662", "goshoZaba@gmail.com", new List<int> { 6, 3, 5, 5, 5 }, 2),
                new Student("Samuil", "Shefchev", 18, "642346246", "+359 5223 472", "imamnogopari@mail.bg", new List<int> { 3, 2, 3, 7, 4 }, 1),
                new Student("Gergin", "Iliev", 23, "23462346", "+3592312369", "nqkoiSi@abv.bg", new List<int> { 3, 5, 6, 2, 6 }, 1),
                new Student("Anton", "Indjev", 12, "62346234", "3324234661", "begaiFAST@abv.bg", new List<int> { 5, 5, 6, 5, 5 }, 3),
                new Student("Stoqn", "Nikiforov", 16, "787234635", "4575433311", "nEmAmRaVeN@gmail.com", new List<int> { 4, 4, 4, 5, 6 }, 2),
                new Student("Velizar", "Kadiev", 20, "234614247", "8734575754", "veli234@abv.bg", new List<int> { 6, 6, 6, 6, 6 }, 1),
                new Student("Asparuh", "Conkov", 14, "1271236626", "7345757754", "stigaSIWE@abv.bg", new List<int> { 5, 2, 6, 2, 4 }, 3),
                new Student("Demagog", "Petrov", 19, "1236146162", "088733325", "m1r7in@mail.bg", new List<int> { 6, 6, 6, 3, 3 }, 2)
            };

            Console.WriteLine("\nProblem 4");
            Methods.Problem4(classStudents);

            Console.WriteLine("\nProblem 5");
            Methods.Problem5(classStudents);

            Methods.Problem6(classStudents);

            Methods.Problem7_1(classStudents);

            Methods.Problem7_2(classStudents);

            Console.WriteLine("\nProblem 8");
            Methods.Problem8(classStudents);

            Console.WriteLine("\nProblem 9");
            Methods.Problem9(classStudents);

            Console.WriteLine("\nProblem 10");
            Methods.Problem10(classStudents);

            Console.WriteLine("\nProblem 11");
            Methods.Problem11(classStudents);

            Console.WriteLine("\nProblem 12");
            Methods.Problem12(classStudents);
        }
    }
}