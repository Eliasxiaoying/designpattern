using System;
using System.Collections.Generic;
using System.Text;

namespace _07_AdapterPattern.Adapter
{
    public class ThreeHolePower : IThreeHole
    {
        public virtual void Request()
        {
            Console.WriteLine("三口电源提供电力");
        }
    }
}