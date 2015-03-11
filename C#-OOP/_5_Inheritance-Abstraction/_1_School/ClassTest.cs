using System;
using System.Collections.Generic;
public class ClassTest
{
    static void Main()
    {
        Student martin = new Student("Martin", 17, "pendel");
        Student georgi = new Student("Georgi", 30, "manekenche");
        Student sasho = new Student("Aleksandyr", 2, "gei");
        Student penka = new Student("Penka", 1, "kurva");

        List<Student> mathStudents = new List<Student>() { martin, georgi };
        List<Student> physicsStudents = new List<Student>() { sasho, penka };

        Discipline maths = new Discipline("Mathematics", 6, mathStudents, "math students");
        Discipline physics = new Discipline("Physics", 20, physicsStudents, "physics students");

        List<Discipline> disciplines = new List<Discipline>() { maths, physics };

        Teacher gergin = new Teacher("Gergin", disciplines, "nai-gadniq prepodavatel EVER!");

        List<Teacher> teachers = new List<Teacher>() { gergin };

        Class class1 = new Class("7b", teachers, mathStudents, "Mnogo zle sa tiq momcheta i momicheta.");

        Console.WriteLine(class1.Students[0].Name);
    }
}
