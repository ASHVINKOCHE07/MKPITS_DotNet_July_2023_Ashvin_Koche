using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
interface IReadable
{
    string ReadData();
}

interface IWritable
{
    void WriteData(string data);
}

class FileHandler : IReadable, IWritable
{
    private string _data;

    public string ReadData()
    {
        return _data;
    }

    public void WriteData(string data)
    {
        _data = data;
    }
}

class Program
{
    static void Main(string[] args)
    {
        FileHandler fileHandler = new FileHandler();

        // Read data from the file
        string data = fileHandler.ReadData();
        Console.WriteLine("Data read from file: " + data);

        // Write data to the file
        fileHandler.WriteData("Hello, world!");
        Console.WriteLine("Data written to file.");
    }
}