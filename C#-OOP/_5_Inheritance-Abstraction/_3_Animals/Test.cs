
using System;
using System.Collections.Generic;
using System.Linq;

class Test
{
    static void Main()
    {
        Kitten krisiKit = new Kitten("Krisi", 1.7);
        Kitten rosiKit = new Kitten("Rosi", 2);
        Kitten didiKit = new Kitten("Didi", 3.4);
        Kitten[] kittens = new Kitten[] { krisiKit, rosiKit, didiKit };        

        Frog ivanFrog = new Frog("Ivan", "male", 0.7);
        Frog petiaFrog = new Frog("Petia", "female", 0.5);
        Frog goshoFrog = new Frog("Gosho", "male", 2);
        Frog[] frogs = new Frog[] { ivanFrog, petiaFrog, goshoFrog };

        List<Animal[]> animalGroups = new List<Animal[]>() { kittens, frogs };

        foreach (var group in animalGroups)
        {
            var averageAge = Math.Round(group.Average(x => x.Age), 2);
            Console.WriteLine(string.Format("Average {0} age: {1}", group[0], averageAge));
        }

        krisiKit.ProduceSound();
        goshoFrog.ProduceSound();

    }
}
