using System;

class Program
{
    static void Main()
    {
       List<Bird> birds = new List<Bird>
       {
           new Eagle { Name = "Eagle" },
           new Penguin { Name = "Penguin" },
           new Sparrow { Name = "Sparrow" }
       };

       foreach (var bird in birds)
        {
            bird.Eat();
            
        }

        List<IFlyable> flyableBirds = new List<IFlyable>
        {
            new Eagle { Name = "Eagle" },
            new Sparrow { Name = "Sparrow" }
        };

        foreach (var flyable in flyableBirds)
        {
            flyable.Fly();
        }
}



}
class Bird
{
    public string Name {get; set;}

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}
interface IFlyable
{
    void Fly()
    {
        Console.WriteLine("Flying...");
    }

}

class Eagle : Bird, IFlyable
{
    public void Fly()
    {
        Console.WriteLine($"{Name} is flying high!");
    }
}
class Sparrow : Bird, IFlyable
{
    public void Fly()
    {
        Console.WriteLine($"{Name} is flying low!");
    }
}
class Penguin : Bird
{
    
}