using System;
public class Animal()
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Description { get; set; }

    public void Breathe()
    {
        Console.WriteLine(Name +" hufb hub hoek");
    }
}

public class Cat : Animal
{
    public string Breed { get; set; }
    public void Meow()
    {
        Console.WriteLine(Name + "  Meng");
    }

    public void Dance()
    {
        Console.WriteLine("Uiiaiuiiai");
    }
}  