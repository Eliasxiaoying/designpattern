namespace _01_FactoryPattern.After;

public class TomatoScrambledEggs : IFood
{
    public string Name => "番茄炒蛋";

    public void Print() => Console.WriteLine($"一道酸酸甜甜的{Name}");
}