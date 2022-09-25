namespace _04_StrategyPattern.Strategy;

/// <summary>
/// 企业所得税计算
/// </summary>
internal class EnterpriseTaxStrategy : ITaxStrategy
{
    public decimal CalculateTax(decimal income)
    {
        return (income - 3500) > 0 ? (income - 3500) * (decimal)0.045 : (decimal)0.0;
    }
}