using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FactoryMethod.FactoryMethod;

/// <summary>
/// 土豆肉丝工厂
/// </summary>
public class ShreddedPorkWithPotatoesMethod : IFoodMethod
{
    public IFood MakeFood()
    {
        return new ShreddedPorkWithPotatoes();
    }
}