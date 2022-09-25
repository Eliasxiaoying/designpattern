using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StrategyPattern.Strategy;

public class InterestOperation
{
    private readonly ITaxStrategy _taxStrategy;

    public InterestOperation(ITaxStrategy taxStrategy)
    {
        _taxStrategy = taxStrategy ?? throw new ArgumentNullException(nameof(taxStrategy));
    }
        
    public decimal GetTax(decimal income)
    {
        return _taxStrategy.CalculateTax(income);
    }
}