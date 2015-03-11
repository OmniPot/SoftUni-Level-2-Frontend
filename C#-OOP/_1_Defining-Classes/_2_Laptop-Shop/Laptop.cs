using System;

class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private int hd;
    private string screen;
    private Battery battery;
    private double price;

    public Laptop(string model, string manufacturer, string processor,
        int ram, string graphicsCard, int hd, string screen, string batModel, double hours, double price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.RAM = ram;
        this.GraphicsCard = graphicsCard;
        this.HD = hd;
        this.Screen = screen;
        this.battery = new Battery(batModel, hours);
        this.Price = price;
    }
    public Laptop(string model, double price) :
        this(model, null, null, 0, null, 0, null, null, 0, price) { }
    public Laptop(string model, string manufacturer, double price) :
        this(model, manufacturer, null, 0, null, 0, null, null, 0, price) { } 
    public Laptop(string model, string manufacturer, string processor, double price) :
        this(model, manufacturer, processor, 0, null, 0, null, null, 0, price) { }
    public Laptop(string model, string manufacturer, string processor, int ram, double price) :
        this(model, manufacturer, processor, ram, null, 0, null, null, 0, price) { }
    public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, double price) :
        this(model, manufacturer, processor, ram, graphicsCard, 0, null, null, 0, price) { }
    public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, int hd, double price) :
        this(model, manufacturer, processor, ram, graphicsCard, hd, null, null, 0, price) { }
    public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, int hd, string screen, double price) :
        this(model, manufacturer, processor, ram, graphicsCard, hd, screen, null, 0, price) { }
    public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, int hd, string screen, string batModel, double price) :
        this(model, manufacturer, processor, ram, graphicsCard, hd, screen, batModel, 0, price) { }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Please enter laptop MODEL.");
            this.model = value;
        }
    }
    public double Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Price cannot be NEGATIVE.");
            this.price = value;
        }
    }
    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (value == String.Empty)
                throw new ArgumentException("Laptop MANUFACTURER cannot be empty.");
            this.manufacturer = value;
        }
    }
    public string Processor
    {
        get { return this.processor; }
        set
        {
            if (value == String.Empty)
                throw new ArgumentException("Laptop PROCESSOR cannot be empty.");
            this.processor = value;
        }
    }
    public int RAM
    {
        get { return this.ram; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Laptop RAM cannot be less than 0.");
            this.ram = value;
        }
    }
    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            if (value == String.Empty)
                throw new ArgumentException("Laptop GRAPHICS CARD cannot be empty.");
            this.graphicsCard = value;
        }
    }
    public int HD
    {
        get { return this.hd; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Laptop HARD DRIVE cannot be less than 0.");
            this.hd = value;
        }
    }
    public string Screen
    {
        get { return this.screen; }
        set
        {
            if (value == String.Empty)
                throw new ArgumentException("Laptop SCREEN cannot be empty.");
            this.screen = value;
        }
    }

    public override string ToString()
    {
        string model, manufacturer, processor, ram, graphics, hd, screen, batModel, batHours, price;

        model = string.Format("{0,15} - {1,-20}\n", "Model", this.model);

        if (this.manufacturer != null)
            manufacturer = string.Format("{0,15} - {1,-20}\n", "Manufacturer", this.manufacturer);
        else
            manufacturer = string.Format("{0,15} - {1,-20}\n", "Manufacturer", "N/A");

        if (this.processor != null)
            processor = string.Format("{0,15} - {1,-20}\n", "Processor", this.processor);
        else
            processor = string.Format("{0,15} - {1,-20}\n", "Processor", "N/A");

        if (this.ram != 0)
            ram = string.Format("{0,15} - {1,-20}\n", "RAM", this.ram + " GB");
        else
            ram = string.Format("{0,15} - {1,-20}\n", "RAM", "N/A");

        if (this.graphicsCard != null)
            graphics = string.Format("{0,15} - {1,-20}\n", "Graphics Card", this.graphicsCard);
        else
            graphics = string.Format("{0,15} - {1,-20}\n", "Graphics Card", "N/A");

        if (this.hd != 0)
            hd = string.Format("{0,15} - {1,-20}\n", "Hard Drive", this.hd + " GB");
        else
            hd = string.Format("{0,15} - {1,-20}\n", "Hard Drive", "N/A");

        if (this.screen != null)
            screen = string.Format("{0,15} - {1,-20}\n", "Screen", this.screen);
        else
            screen = string.Format("{0,15} - {1,-20}\n", "Screen", "N/A");

        if (battery.Model != null)
            batModel = string.Format("{0,15} - {1,-20}\n", "Battery Model", battery.Model);
        else
            batModel = string.Format("{0,15} - {1,-20}\n", "Battery Model", "N/A");

        if (battery.Hours != 0)
            batHours = string.Format("{0,15} - Up to {1,-20}\n", "Battery Hours", this.battery.Hours + " hours");
        else
            batHours = string.Format("{0,15} - {1,-20}\n", "Battery Hours", "N/A");
        
        price = string.Format("{0,15} - {1,-20:0.00}\n", "Price", this.price + ".lv");

        return model + manufacturer + processor + ram + graphics + hd + screen + price + batModel + batHours;
    }
}
