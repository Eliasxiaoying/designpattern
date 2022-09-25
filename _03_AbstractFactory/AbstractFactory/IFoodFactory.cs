namespace _03_AbstractFactory.AbstractFactory;

public interface IFoodFactory
{
    /// <summary>
    /// 制作土豆肉丝
    /// </summary>
    /// <returns></returns>
    IShreddedPorkWithPotatoes MakeShreddedPorkWithPotatoes();

    /// <summary>
    /// 制作番茄炒蛋
    /// </summary>
    /// <returns></returns>
    ITomatoScrambledEggs MakeTomatoScrambledEggs();
}