using System;
using _06_PrototypePattern.Prototype;

namespace _06_PrototypePattern;

/// <summary>
/// 
/// </summary>
public class Program
{
    // 在软件系统中，当创建一个类的实例的过程很昂贵或很复杂，并且我们需要创建多个这样类的实例时，
    // 如果我们用new操作符去创建这样的类实例，这未免会增加创建类的复杂度和耗费更多的内存空间，因为这样在内存中分配了多个一样的类实例对象，
    // 然后如果采用工厂模式来创建这样的系统的话，随着产品类的不断增加，导致子类的数量不断增多，反而增加了系统复杂程度，所以在这里使用工厂模式来封装类创建过程并不合适，
    // 然而原型模式可以很好地解决这个问题，因为每个类实例都是相同的，当我们需要多个相同的类实例时，没必要每次都使用new运算符去创建相同的类实例对象，
    // 此时我们一般思路就是想——只创建一个类实例对象，如果后面需要更多这样的实例，可以通过对原来对象拷贝一份来完成创建，
    // 这样在内存中不需要创建多个相同的类实例，从而减少内存的消耗和达到类实例的复用。

    public static void Main(string[] args)
    {
        MonkeyKingPrototype monkeyKing = new ConcretePrototype("MonkeyKing");

        // 优点：
        // 原型模式向客户隐藏了创建新实例的复杂性
        // 原型模式允许动态增加或较少产品类
        // 原型模式简化了实例的创建结构，工厂方法模式需要有一个与产品类等级结构相同的等级结构，而原型模式不需要这样
        // 产品类不需要事先确定产品的等级结构，因为原型模式适用于任何的等级结构
        var monkeyKingCloned1 = monkeyKing.Clone() as ConcretePrototype;

        var monkeyKingCloned2 = monkeyKing.Clone() as ConcretePrototype;
        // 缺点:
        // 每个类必须配备一个克隆方法
        // 配备克隆方法需要对类的功能进行通盘考虑，这对于全新的类不是很难，但对于已有的类不一定很容易
        // 特别当一个类引用不支持串行化的间接对象，或者引用含有循环结构的时候。

        Console.WriteLine($"MonkeyKing:{monkeyKing.Id}");

        Console.WriteLine($"MonkeyKingCloned1:{monkeyKingCloned1?.Id}");

        Console.WriteLine($"MonkeyKingCloned2:{monkeyKingCloned2?.Id}");
    }
}