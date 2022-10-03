namespace _01_FactoryPattern.After;

public class MakeFood
{
    public static void Make()
    {
        // 将判断的逻辑统一，以后需要变化时只需要修改一处代码就可以实现功能，但还是需要修改判断的逻辑
        var food1 = FoodFactory.MakeFood("土豆肉丝");
        food1.Print();

        var food2 = FoodFactory.MakeFood("番茄炒蛋");
        food2.Print();
    }
}