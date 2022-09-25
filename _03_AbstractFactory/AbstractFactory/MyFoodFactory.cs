using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AbstractFactory.AbstractFactory;

public class MyFoodFactory : IFoodFactory
{
    public IShreddedPorkWithPotatoes MakeShreddedPorkWithPotatoes()
    {
        return new MyShreddedPorkWithPotatoes();
    }

    public ITomatoScrambledEggs MakeTomatoScrambledEggs()
    {
        return new CustomTomatoScrambledEggs();
    }
}