using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FactoryMethod.FactoryMethod;

public class TomatoScrambledEggs : IFood
{
    private static string Name => "番茄炒蛋";

    public void Print() => Console.WriteLine($"一道酸酸甜甜的{Name}");
}