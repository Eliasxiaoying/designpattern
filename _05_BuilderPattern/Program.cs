using _05_BuilderPattern.Builder;
using System;

namespace _05_BuilderPattern;

internal class Program
{
    public static void Main(string[] args)
    {
        // 在软件系统中，有时需要创建一个复杂对象，并且这个复杂对象由其各部分子对象通过一定的步骤组合而成。
        // 但是不应该由客户端直接与需要的复杂对象直接交流以降低耦合

        // 假设一位顾客去采购两台电脑
        var customer = new Customer();
        
        // 顾客不会直接与需要自己组装电脑，只需要告诉老板自己需要的电脑是什么样子
        var boss = new ComputerBuilderDirector("应文浩");

        // 老板自然会安排组装人员组装好电脑后给顾客
        var computers = customer.GetComputers(boss);
        foreach (var computer in computers)
        {
            computer.Show();
            Console.WriteLine("...\n");
        }
    }
}