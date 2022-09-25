namespace _01_Factory.Before
{
    public class TomatoScrambledEggs : IFood
    {
        private static string Name => "番茄炒蛋";

        public void Print() => Console.WriteLine($"一道酸酸甜甜的{Name}");
    }
}