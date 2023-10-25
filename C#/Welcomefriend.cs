using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UserDefinedFunction
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Write name : ");
string name = Console.ReadLine();
Greet(name);
}

static void Greet(string name)
    {
        Console.WriteLine("Welcome friend " + name + "!");
        Console.WriteLine("Have a nice day!");
    }
}
}