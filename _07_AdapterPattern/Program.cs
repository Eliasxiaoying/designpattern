using System;
using _07_AdapterPattern.Adapter;

namespace _07_AdapterPattern;


public class Program
{
    // 在实际的开发过程中，由于应用环境的变化（例如使用语言的变化），我们需要的实现在新的环境中没有现存对象可以满足，但是其他环境却存在这样现存的对象。

    // 我们就可以使用适配器模式——使得新环境中不需要去重复实现已经存在了的实现而很好地把现有对象（指原来环境中的现有对象）加入到新环境来使用。
    public static void Main(string[] args)
    {
        // 需要适配的三口电源
        var threeHolePower = new ThreeHolePower();

        // 客户端需要一个双孔的电源插座，但是现在只有三孔电源插座。
        // 这个时候可以使用双孔的电源适配器类，将三孔转换成双孔，它实现了双孔的接口，并在内部对三孔电源插座进行适配，我们可以直接将适配器当作一个双孔插座来进行使用


        // 优点：
        // 可以在不修改原有代码的基础上来复用现有类，很好地符合 “开闭原则”（这点是两种实现方式都具有的）
        // 采用 “对象组合”的方式，更符合松耦合。

        // 缺点:
        // 使得重定义Adaptee的行为较困难，这就需要生成Adaptee的子类并且使得Adapter引用这个子类而不是引用Adaptee本身。


        // 给三口电源添加适配器
        var adapter = new ThreeHoleToTwoHolePowerAdapter(threeHolePower);

        // 利用适配器提供电力
        adapter.Request();

        // 类适配器：直接将需要适配的对象和需要适配的接口进行继承整合，减少了需要new的对象的个数
        // 但是相较于对象适配器而言灵活性降低
        var classAdapter = new ClassAdapter();

        // 优点：
        // 可以在不修改原有代码的基础上来复用现有类，很好地符合 “开闭原则”
        
        // 可以重新定义Adaptee(被适配的类)的部分行为，因为在类适配器模式中，Adapter是Adaptee的子类

        // 仅仅引入一个对象，并不需要额外的字段来引用Adaptee实例（这个即是优点也是缺点）。

        // 缺点：
        // 用一个具体的Adapter类对Adaptee和Target进行匹配，当如果想要匹配一个类以及所有它的子类时，类的适配器模式就不能胜任了。
        // 因为类的适配器模式中没有引入Adaptee的实例，光调用this.SpecificRequest方法并不能去调用它对应子类的SpecificRequest方法。

        // 采用了 “多继承”的实现方式，带来了不良的高耦合。

        classAdapter.Request();
    }
}