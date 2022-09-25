using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StrategyPattern.Strategy;

/// <summary>
/// 个人所得税
/// </summary>
public class PersonalTaxStrategy : ITaxStrategy
{
    /// <summary>
    /// 根据2021最新个人所得税税率表计算
    /// </summary>
    /// <param name="income"></param>
    /// <returns></returns>
    public decimal CalculateTax(decimal income)
    {
        return income * (decimal)0.12;
    }
}