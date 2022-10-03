using System;
using System.Collections.Generic;
using System.Text;

namespace _05_BuilderPattern.Builder;

public class ComputerBuilderDirector
{
    public string Name { get; }

    public ComputerBuilderDirector(string name)
    {
        Name = name;
    }

    public void BuildComputer(IComputerBuilder builder)
    {
        builder.AddCpu();
        builder.AddMainBoard();
        builder.AddMemory();
    }
}