using System;

namespace _07_AdapterPattern.Adapter;

public class TwoHolePower : ITwoHole
{
    public void Request()
    {
        Console.WriteLine("双口电源提供电力");
    }
}