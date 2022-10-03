using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_BuilderPattern;

/// <summary>
/// 电脑类
/// </summary>
public class Computer
{
    /// <summary>
    /// 电脑的组成部分
    /// </summary>
    private IEnumerable<string> _computerParts;

    /// <summary>
    /// 初始化一台电脑，但是并没有任何组件
    /// </summary>
    public Computer()
    {
        _computerParts = Enumerable.Empty<string>();
    }

    /// <summary>
    /// 向电脑中添加不同的组件，开始组装电脑
    /// </summary>
    /// <param name="part"></param>
    public void AddPart(string part)
    {
        _computerParts = _computerParts.Append(part);
    }

    /// <summary>
    /// 组装并展示电脑
    /// </summary>
    public void Show()
    {
        Console.WriteLine("电脑开始组装...");
        foreach (var part in _computerParts)
        {
            Console.WriteLine($"组件{part}已经安装");
        }

        Console.WriteLine("电脑组装完毕");
    }
}