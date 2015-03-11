using System;

class Start
{
    static void Main()
    {
        Laptop laptop = new Laptop("Aspire V3", "Acer", "Intel Core i5", 8, "NVIDIA GFORCE 710M", 1000,"15.6\"",1200.00);
        Laptop laptop2 = new Laptop("B5400", "Lenovo", "Intel Core i7", 12, "NVIDIA GFORCE 820M", 750, 1400.99);
        Laptop laptop3 = new Laptop("B5400", "Lenovo", "Intel Core i7", 12, 1400.99);
        Console.WriteLine(laptop.ToString());
        Console.WriteLine(laptop2.ToString());
        Console.WriteLine(laptop3.ToString());
    }
}

