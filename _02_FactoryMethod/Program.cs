using _02_FactoryMethod.FactoryMethod;

namespace _02_FactoryMethod;

public class Program
{
    public static void Main(string[] args)
    {
        // 工厂方法模式之所以可以解决简单工厂的缺点，是因为它的实现把具体产品的创建推迟到子类中，
        // 此时工厂类不再负责所有产品的创建，而只是给出具体工厂必须实现的接口，
        // 这样工厂方法模式就可以允许系统不修改工厂类逻辑的情况下来添加新产品，这样也就克服了简单工厂模式中缺点。

        // 土豆肉丝工厂制作土豆肉丝
        IFoodMethod foodFactory1 = new ShreddedPorkWithPotatoesMethod();
        var shreddedPorkWithPotatoes = foodFactory1.MakeFood();
        shreddedPorkWithPotatoes.Print();

        // 使用工厂方法实现的系统，如果系统需要添加新产品时，我们可以利用多态性来完成系统的扩展，对于抽象工厂类和具体工厂中的代码都不需要做任何改动。
        
        // 番茄炒蛋工厂制作番茄炒蛋
        IFoodMethod foodFactory2 = new TomatoScrambledEggsMethod();
        var tomatoScrambledEggs = foodFactory2.MakeFood();
        tomatoScrambledEggs.Print();

        // 工厂方法模式通过面向对象编程中的多态性来将对象的创建延迟到具体工厂中，从而解决了简单工厂模式中存在的问题，
        // 也很好地符合了开放封闭原则（即对扩展开发，对修改封闭）。

        Console.ReadKey();
    }
}