using _04_StrategyPattern.Strategy;

namespace _04_StrategyPattern;

public class Program
{
    public static void Main(string[] args)
    {
        // 策略模式是针对一组算法，将每个算法封装到具有公共接口的独立的类中，从而使它们可以相互替换。
        // 策略模式使得算法可以在不影响到客户端的情况下发生变化。

        // 策略模式是对算法的包装，是把使用算法的责任和算法本身分割开，委派给不同的对象负责。策略模式通常把一系列的算法包装到一系列的策略类里面。
        // 用一句话慨括策略模式就是——“将每个算法封装到不同的策略类中，使得它们可以互换”。

        // 优点：
        // 策略类之间可以自由切换。由于策略类都实现同一个接口，所以使它们之间可以自由切换。
        // 易于扩展。增加一个新的策略只需要添加一个具体的策略类即可，基本不需要改变原有的代码。
        // 避免使用多重条件选择语句，充分体现面向对象设计思想。
        
        // 个人所得税方式
        InterestOperation operation = new(new PersonalTaxStrategy());
        Console.WriteLine("个人支付的税为：{0}", operation.GetTax(5000.00M));

        // 缺点：
        // 客户端必须知道所有的策略类，并自行决定使用哪一个策略类。 （这点可以考虑使用IOC容器和依赖注入的方式来解决）
        // 策略模式会造成很多的策略类。
        
        // 企业所得税
        operation = new InterestOperation(new EnterpriseTaxStrategy());
        Console.WriteLine("企业支付的税为：{0}", operation.GetTax(50000.00M));

        // 一个系统需要动态地在几种算法中选择一种的情况下。那么这些算法可以包装到一个个具体的算法类里面，并为这些具体的算法类提供一个统一的接口。

        // 如果一个对象有很多的行为，如果不使用合适的模式，这些行为就只好使用多重的if-else语句来实现，
        // 此时，可以使用策略模式，把这些行为转移到相应的具体策略类里面，就可以避免使用难以维护的多重条件选择语句，并体现面向对象涉及的概念。

        Console.Read();
    }
}