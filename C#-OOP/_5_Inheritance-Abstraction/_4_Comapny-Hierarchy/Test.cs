using System;
using System.Collections.Generic;

public class Test
{
    static void Main()
    {
        Project minecraft = new Project("Minecraft", new DateTime(2009, 3, 25), "Pretty good game.", ProjectState.Open);
        Sale doom = new Sale("Doom", new DateTime(2000, 11, 3), 29.99);

        Developer petar = new Developer(13, "Petar", "Petrov", 1250, Department.Production, new List<Project> { minecraft });
        SalesEmployee anton = new SalesEmployee(21, "Anton", "Iliev", 1330, Department.Sales, new List<Sale> { doom });

        List<IEmployee> production = new List<IEmployee>() { petar };
        List<IEmployee> sales = new List<IEmployee>() { anton };

        Manager vladimir = new Manager(3, "Vladimir", "Ivanov", 1500.00d, Department.Production, production);
        Manager stoqn = new Manager(5, "Stoqn", "Georgiev", 1800.00d, Department.Sales, sales);

        List<Employee> employees = new List<Employee>() { petar, anton, stoqn };

        foreach (var person in employees)
        {
            Console.WriteLine(person.ToString() + "\n");
        }

        Customer jojo = new Customer(300, "Georgi", "Djurov", 372.99m);
        Console.WriteLine(jojo.ToString() + "\n");

        Console.WriteLine(minecraft.ToString() + "\n");
        Console.WriteLine(doom.ToString());
    }
}

