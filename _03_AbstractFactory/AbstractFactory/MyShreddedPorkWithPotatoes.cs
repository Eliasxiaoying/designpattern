using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AbstractFactory.AbstractFactory
{
    public class MyShreddedPorkWithPotatoes : IShreddedPorkWithPotatoes
    {
        public void Print()
        {
            Console.WriteLine("土豆肉丝但是酸酸的");
        }
    }
}