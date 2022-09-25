using _03_AbstractFactory.AbstractFactory;

namespace _03_AbstractFactory;

internal class Program
{
    public static void Main(string[] args)
    {
        // 抽象工厂模式：提供一个创建产品的接口来负责创建相关或依赖的对象，而不具体明确指定具体类

        // 抽象工厂允许客户使用抽象的接口来创建一组相关产品，而不需要知道或关心实际生产出的具体产品是什么。这样客户就可以从具体产品中被解耦。

        // 抽象工厂模式将具体产品的创建延迟到具体工厂的子类中，这样将对象的创建封装起来，可以减少客户端与具体产品类之间的依赖，从而使系统耦合度低，
        // 这样更有利于后期的维护和扩展

        IFoodFactory foodFactory1 = new MyFoodFactory();
        var myShreddedPorkWithPotatoes = foodFactory1.MakeShreddedPorkWithPotatoes();
        var myTomatoScrambledEggs = foodFactory1.MakeTomatoScrambledEggs();
        myTomatoScrambledEggs.Print();
        myShreddedPorkWithPotatoes.Print();

        // 抽象工厂模式很难支持新种类产品的变化。这是因为抽象工厂接口中已经确定了可以被创建的产品集合，如果需要添加新产品，此时就必须去修改抽象工厂的接口，
        // 这样就涉及到抽象工厂类的以及所有子类的改变，这样也就违背了“开放——封闭”原则。

        IFoodFactory foodFactory2 = new CustomFoodFactory();
        var customShreddedPorkWithPotatoes = foodFactory2.MakeShreddedPorkWithPotatoes();
        var customTomatoScrambledEggs = foodFactory2.MakeTomatoScrambledEggs();
        customTomatoScrambledEggs.Print();
        customShreddedPorkWithPotatoes.Print();

        // 一个系统不要求依赖产品类实例如何被创建、组合和表达的表达，这点也是所有工厂模式应用的前提。
        
        // 这个系统有多个系列产品，而系统中只消费其中某一系列产品

        // 系统要求提供一个产品类的库，所有产品以同样的接口出现，客户端不需要依赖具体实现。

        // 相比于工厂方法，抽象工厂将需要创建的对象进一步抽象，并将创建对象的实现放在各个不同的实现类中，如果需要添加新的功能只需要将自己需要的那部分实现即可
        // 然而正因为更多的抽象，当需要修改时，抽象工厂可能需要修改更多的代码，破坏了开放-封闭原则

        Console.ReadKey();
    }
}