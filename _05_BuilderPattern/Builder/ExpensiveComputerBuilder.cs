using System;
using System.Collections.Generic;
using System.Text;

namespace _05_BuilderPattern.Builder;

public class ExpensiveComputerBuilder : AbstractComputerBuilder
{
    public override void AddCpu()
    {
        _computer.AddPart("i9-13900K");
    }

    public override void AddMemory()
    {
        _computer.AddPart("32G*2");
    }

    public override void AddMainBoard()
    {
        _computer.AddPart("Z690");
    }
}