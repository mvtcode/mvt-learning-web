

using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Taking data from Main Thread\n->");
        string message = Console.ReadLine();

        ThreadStart newThread = new ThreadStart(delegate { Write(message); });

        Thread myThread = new Thread(newThread);

    }

    public static void Write(string msg)
    {
        Console.WriteLine(msg);
        Console.Read();
    }
}
}

