using System;
using System.Collections.Generic;
using System.Text;

namespace _06_PrototypePattern.Prototype;

public abstract class MonkeyKingPrototype
{
    public string Id { get; set; }

    protected MonkeyKingPrototype(string id)
    {
        Id = id;
    }

    public abstract MonkeyKingPrototype Clone();
}