using System;

static class HTMLDispatcher
{
    public static string CreateImage(string source, string alt, string title){
        ElementBuilder image = new ElementBuilder("img");
        image.AddAttribute("src", source);
        image.AddAttribute("alt", alt);
        image.AddAttribute("title", title);
        return image.Tag;
    }
    public static string CreateURL(string url, string title, string text)
    {
        ElementBuilder link = new ElementBuilder("a");
        link.AddAttribute("href", url);
        link.AddAttribute("title", title);
        link.AddContent(text);
        return link.Tag;
    }
    public static string CreateInput(string type, string name, string value)
    {
        ElementBuilder input = new ElementBuilder("input");
        input.AddAttribute("type", type);
        input.AddAttribute("name", name);
        input.AddAttribute("value", value);
        return input.Tag;
    }
}

