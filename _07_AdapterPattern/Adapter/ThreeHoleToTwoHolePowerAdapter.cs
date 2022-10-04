using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _07_AdapterPattern.Adapter;

/// <summary>
/// 三口插座到两口插座电源适配器
/// </summary>
public class ThreeHoleToTwoHolePowerAdapter : ITwoHole
{
    private readonly IThreeHole _power;

    /// <summary>
    /// 对象适配器
    /// </summary>
    /// <param name="power"></param>
    public ThreeHoleToTwoHolePowerAdapter(IThreeHole power)
    {
        _power = power;
    }

    public void Request()
    {
        _power.Request();
        Console.WriteLine("双口电源提供电力");
    }
}

/// <summary>
/// 基于类的适配器
/// </summary>
public class ClassAdapter : ThreeHolePower, ITwoHole
{
    void ITwoHole.Request()
    {
        this.Request();
    }
}