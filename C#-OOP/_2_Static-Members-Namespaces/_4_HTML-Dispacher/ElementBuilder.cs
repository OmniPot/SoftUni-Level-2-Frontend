using System;
using System.Text;

class ElementBuilder
{
    private string tag;
    private StringBuilder builder = new StringBuilder();

    public ElementBuilder(string tagName)
    {
        this.Tag = tagName;
    }

    public string Tag
    {
        get { return this.tag; }
        private set
        {
            if (value == string.Empty)
            {
                throw new ArgumentNullException("Element's name cannot be empty.");
            }

            if (value == "img" || value == "input")
            {
                this.tag = string.Format("<{0}/>", value);
            }
            else
            {
                this.tag = string.Format("<{0}></{0}>", value);
            }
        }
    }

    public void AddAttribute(string attribute, string value)
    {
        if (this.tag.IndexOf("img") > 0 || this.tag.IndexOf("input") > 0)
        {
            this.builder.Append(this.tag.Substring(0, this.tag.IndexOf("/>")));
            this.builder.Append(" " + attribute + "=\"" + value + "\"");
            this.builder.Append(this.tag.Substring(this.tag.IndexOf("/>")));
        }
        else
        {
            this.builder.Append(this.tag.Substring(0, this.tag.IndexOf(">")));
            this.builder.Append(" " + attribute + "=\"" + value + "\"");
            this.builder.Append(this.tag.Substring(this.tag.IndexOf(">")));
        }
        this.tag = this.builder.ToString();
        this.builder.Remove(0, builder.Length);
    }

    public void AddContent(string content)
    {
        this.builder.Append(this.tag.Substring(0, this.tag.IndexOf(">") + 1));
        this.builder.Append(content);
        this.builder.Append(this.tag.Substring(this.tag.LastIndexOf("<")));

        this.tag = this.builder.ToString();
        this.builder.Remove(0, builder.Length);
    }

    public static ElementBuilder operator *(ElementBuilder eb, int times)
    {
        for (int i = 0; i < times; i++)
        {
            eb.builder.Append(eb.Tag);
        }

        eb.tag = eb.builder.ToString();
        return eb;
    }

    public override string ToString()
    {
        return this.Tag;
    }
}

