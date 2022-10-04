using System;
using System.Collections.Generic;
using System.Text;

namespace _06_PrototypePattern.Prototype;

public class ConcretePrototype : MonkeyKingPrototype
{
    public ConcretePrototype(string id) : base(id) { }

    public override MonkeyKingPrototype Clone()
    {
        // 调用MemberwiseClone方法实现的是浅拷贝 浅拷贝是指当对象的字段值被拷贝时，字段引用的对象不会被拷贝。
        return (MonkeyKingPrototype)this.MemberwiseClone();
    }
}