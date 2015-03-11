using System;
using System.Linq;

class Start
{
    static void Main()
    {

        Computer[] computers = new Computer[] {

            new Computer("Acer Aspire", 
                new Component("Processor", "Intel Core i5", 251),
                new Component("RAM", "8GB Kingston 1333 MHz", 108),
                new Component("Graphics Card","NVIDIA GEForce 710M", 198),
                new Component("Screen", "17\"7' LED LCD", 150)),

            new Computer("Dell Inspiron",
                new Component("Processor", "AMD Xeon", 293),
                new Component("RAM", "16GB Kingston 1333 MHz", 192),
                new Component("Graphics Card", "AMD RADEON RX270", 421),
                new Component("Screen", "17\"7' LED LCD", 150)),

            new Computer("Lenovo B540",
                new Component("Processor", "Intel Core i7", 357),
                new Component("RAM", "12GB Kingston 1333 MHz", 180),
                new Component("Graphics Card", "NVIDIA GEForce 810M", 250),
                new Component("Screen", "17\"7' LED LCD", 150))
        };

        var sortedComputers = from c in computers
                   orderby c.Price ascending
                   select c;

        foreach (var computer in sortedComputers)
        {
            Console.WriteLine(computer.ToString());
        }
    }
}

