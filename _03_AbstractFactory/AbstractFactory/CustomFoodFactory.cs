namespace _03_AbstractFactory.AbstractFactory;

/// <summary>
/// 一般家庭的Factory
/// </summary>
public class CustomFoodFactory : IFoodFactory
{
    public IShreddedPorkWithPotatoes MakeShreddedPorkWithPotatoes()
    {
        return new CustomShreddedPorkWithPotatoes();
    }

    public ITomatoScrambledEggs MakeTomatoScrambledEggs()
    {
        return new CustomTomatoScrambledEggs();
    }
}