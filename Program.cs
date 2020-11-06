using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using Newtonsoft.Json;

class Program
{
    public static void Main(string[] args)
    {
        uint bin = 0b0000;

        for(int i = -7; i < 8; i ++)
        {
            Console.WriteLine($"{i} | {Convert.ToString(bin, 2)}: " + -Function(i));
            bin++;
        }
        Console.ReadKey();
    }

    private static double Function(int x) =>
        (0.2 * (x * x * x) + 0.1 * (x * x) - 8 * x);
}