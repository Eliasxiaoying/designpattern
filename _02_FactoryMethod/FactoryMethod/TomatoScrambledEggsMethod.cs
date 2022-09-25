using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FactoryMethod.FactoryMethod;

/// <summary>
/// 番茄炒蛋工厂
/// </summary>
public class TomatoScrambledEggsMethod : IFoodMethod
{
    public IFood MakeFood()
    {
        return new TomatoScrambledEggs();
    }
}