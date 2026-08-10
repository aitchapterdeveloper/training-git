using System;
public abstract class Animal()
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; } = 0;
    public string Description { get; set; } = string.Empty;

    public virtual void Breathe()
    {
        Console.WriteLine(Name +" hufb hub hoek");
    }
}

public class Cat : Animal
{
    public string Breed { get; set; } = string.Empty;
    public void Meow()
    {
        Console.WriteLine(Name + "  Meng");
    }

    public void Dance()
    {
        Console.WriteLine("U iia iu iiai");
    }
}

public class Dog: Animal, Walk
{
    public override void Breathe()
    {
        Console.WriteLine(Name + "Ruff Ruff hrrrrrrrr");
    }
    public void Step()
    {
        Console.WriteLine("Busk busk");
    }
}

public interface Walk
{
    void Step();
}