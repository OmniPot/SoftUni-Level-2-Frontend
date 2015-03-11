using System;
using System.Collections.Generic;
using System.Linq;

class Test
{
    static void Main()
    {
        Student s1 = new Student("Remi", "Lalov", "584638563");
        Student s2 = new Student("Martin", "A", "474932659");
        Student s3 = new Student("Kiril", "Bobev", "432353466");
        Student s4 = new Student("Aleksandar", "Stambolov", "396573952");
        Student s5 = new Student("Ivan", "Vazov", "234273727");
        Student s6 = new Student("Georgi", "Boradjiev", "327258228");
        Student s7 = new Student("Petar", "Beron", "234723474");
        Student s8 = new Student("Samuil", "Car", "962346234");
        Student s9 = new Student("Asparuh", "Han", "735245724");
        Student s10 = new Student("Leonardo", "Davinci", "234836847");
        Student s11 = new Student("Iliq", "Stankov", "232375282");
        Student s12 = new Student("Krum", "Savov", "746532853");

        Worker w1 = new Worker("Dimitar", "Rangelov", 1125, 8);
        Worker w2 = new Worker("Angel", "Petrov", 1252, 7);
        Worker w3 = new Worker("Antoan", "Semerdjiev", 800, 6);
        Worker w4 = new Worker("Iliqn", "Nenov", 400, 5);
        Worker w5 = new Worker("Nenko", "Nenkov", 872, 7);
        Worker w6 = new Worker("Stoqn", "Zahariev", 1500, 5);
        Worker w7 = new Worker("Stanislav", "Aramazov", 964, 6);
        Worker w8 = new Worker("Teodora", "Petrova", 1020, 7);
        Worker w9 = new Worker("Daniela", "Samodivkina", 1315, 8);
        Worker w10 = new Worker("Kuna", "Buna", 1125, 5);
        Worker w11 = new Worker("Rosen", "Dakov", 1451, 7);
        Worker w12 = new Worker("Grigor", "Dimitrov", 1956, 8);

        Student[] students = new Student[] { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12 };
        var sortedStudents = from s in students
                             orderby s.FaultyNumber
                             select s;

        Worker[] workers = new Worker[] { w1, w2, w3, w4, w5, w6, w7, w8, w9, w10, w11, w12 };
        var sortedWorkers = from w in workers
                            orderby w.MoneyPerHour() ascending
                            select w;

        Console.WriteLine("Faculty Numbers:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student.FaultyNumber);
        }
        Console.WriteLine();

        Console.WriteLine("Wages per hour:");
        foreach (var worker in sortedWorkers)
        {
            Console.WriteLine(Math.Round(worker.MoneyPerHour(), 2) + " lv.");
        }
        Console.WriteLine();

        var humans = students.Cast<Human>().Concat(workers.Cast<Human>());

        var sortedHumans = from h in humans
                           orderby h.FirstName, h.LastName
                           select h;

        foreach (var human in sortedHumans)
        {
            Console.WriteLine(string.Format("{0,-10} {1}",human.FirstName, human.LastName));
        }
    }
}

