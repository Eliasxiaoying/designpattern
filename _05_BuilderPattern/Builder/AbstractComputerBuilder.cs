using System;
using System.Collections.Generic;
using System.Text;

namespace _05_BuilderPattern.Builder;

/// <summary>
/// 抽象电脑构造者
/// </summary>
public abstract class AbstractComputerBuilder : IComputerBuilder
{
    protected readonly Computer _computer = new();

    public abstract void AddCpu();

    public abstract void AddMemory();

    public abstract void AddMainBoard();

    public Computer GetComputer()
    {
        return _computer;
    }
}