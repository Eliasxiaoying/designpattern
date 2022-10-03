namespace _01_FactoryPattern.Before;

public class ShreddedPorkWithPotatoes : IFood
{
    public string Name => "土豆肉丝";

    public void Print() => Console.WriteLine($"一道香辣可口的{Name}");
}