using System;

interface IAnimal
{
    void MakeSound();
}

class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAnimal[] animals = new IAnimal[] { new Dog(), new Cat() };

        foreach (IAnimal animal in animals)
        {
            animal.MakeSound();
        }
    }
}
