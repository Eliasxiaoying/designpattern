namespace _03_AbstractFactory.AbstractFactory
{
    public interface ITomatoScrambledEggs
    {
        private string Name => "番茄炒蛋";

        public virtual void Print() => Console.WriteLine($"一份酸酸甜甜的{Name}");
    }
}