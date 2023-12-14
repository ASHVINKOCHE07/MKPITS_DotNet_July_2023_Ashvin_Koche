/*
 * C# Program to Demonstrate IDumpable Interface
 */
using System;
interface IDumpable
{
    string Name { get; set; }
    void Dump();
}
 
class Fraction : IDumpable
{
    int z, n;
    string name;
 
    public Fraction(int z, int n)
    {
        this.z = z; this.n = n;
    }
 
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
 
    public void Dump()
    {
        Console.WriteLine("Fraction : " + z + "/" + n);
    }
}