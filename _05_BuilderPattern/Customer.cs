using _05_BuilderPattern.Builder;
using System;
using System.Collections.Generic;

namespace _05_BuilderPattern;

public class Customer
{
    public IEnumerable<Computer> GetComputers(ComputerBuilderDirector boss)
    {
        Console.WriteLine($"{boss.Name}老板的店铺开始装电脑");

        // TODO: 这里不应该将两个Builder放在Customer类中，而是应该放在Director类中

        var builder = new List<IComputerBuilder>
        {
            new CheapComputerBuilder(),
            new ExpensiveComputerBuilder()
        };

        foreach (var item in builder)
        {
            // 老板告诉组装人员组装电脑 并直接返回组装好的电脑
            boss.BuildComputer(item);
            yield return item.GetComputer();
        }
    }
}