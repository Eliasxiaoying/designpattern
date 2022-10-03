using System;
using System.Collections.Generic;
using System.Text;

namespace _05_BuilderPattern.Builder;

public class CheapComputerBuilder : AbstractComputerBuilder
{
    public override void AddCpu()
    {
        _computer.AddPart("速龙CPU");
    }

    public override void AddMemory()
    {
        _computer.AddPart("4G*2");
    }

    public override void AddMainBoard()
    {
        _computer.AddPart("军工级（垃圾）主板");
    }
}