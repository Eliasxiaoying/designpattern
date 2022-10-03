namespace _01_FactoryPattern.After
{
    public class FoodFactory
    {
        public static IFood MakeFood(string name) => name switch
        {
            "土豆肉丝" => new ShreddedPorkWithPotatoes(),
            "番茄炒蛋" => new TomatoScrambledEggs(),
            _ => throw new Exception("不会做啊")
        };
    }
}