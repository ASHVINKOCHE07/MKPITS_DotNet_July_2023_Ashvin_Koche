using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public Person(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Person class
        Person person = new Person(
            Convert.ToString(Console.ReadLine()), // Name
            Convert.ToInt32(Console.ReadLine()), // Age
            Convert.ToString(Console.ReadLine()) // Address
        );

        // Display the information of the person
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);
        Console.WriteLine("Address: " + person.Address);
    }
}