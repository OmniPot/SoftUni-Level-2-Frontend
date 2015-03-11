using System;

class Start
{
    static void Main()
    {
        string tag = HTMLDispatcher.CreateImage("image", "image here", "title here");
        Console.WriteLine(tag + "\n");
        
        string tag1 = HTMLDispatcher.CreateURL("url", "title", "text");
        Console.WriteLine(tag1 + "\n");

        string tag2 = HTMLDispatcher.CreateInput("text", "field", "Some text");
        Console.WriteLine(tag2 + "\n");

        ElementBuilder eb = new ElementBuilder("a");
        eb.AddAttribute("href", "softuni.com");

        Console.WriteLine(eb * 3);
    }   
}

