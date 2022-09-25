using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AbstractFactory.AbstractFactory;

public interface IShreddedPorkWithPotatoes
{
    private string Name => "土豆肉丝";

    public virtual void Print() => Console.WriteLine($"一份香辣可口的{Name}");
}