using System;
using System.Collections.Generic;
using System.Text;

namespace _05_BuilderPattern.Builder;

public interface IComputerBuilder
{
    void AddCpu();

    void AddMemory();

    void AddMainBoard();

    Computer GetComputer();
}