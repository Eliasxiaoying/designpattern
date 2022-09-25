using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StrategyPattern.Strategy;

/// <summary>
/// 收税策略
/// </summary>
public interface ITaxStrategy
{
    /// <summary>
    /// 计算税额
    /// </summary>
    /// <param name="income">收入</param>
    /// <returns></returns>
    decimal CalculateTax(decimal income);
}