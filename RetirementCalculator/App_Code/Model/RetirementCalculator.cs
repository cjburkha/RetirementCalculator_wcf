using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RetirementCalculator
/// </summary>
public class RetirementCalculator
{
    public Double StartingBalance { get; set; }
    public Double MonthlyIncrease { get; set; }
    public RetirementCalculator()
    {
    }

    public RetirementCalculator(Double startingBalance, Double monthlyIncrease)
    {
        this.StartingBalance = startingBalance;
        this.MonthlyIncrease = monthlyIncrease;
    }

    public Double valueAtRetierment(Double startingBalance, Double monthlyIncrease)
    {
        return CalculateValueAtRetierment(startingBalance, monthlyIncrease);
    }

    public Double valueAtRetierment()
    {
        return CalculateValueAtRetierment(this.StartingBalance, this.MonthlyIncrease);
    }

    private Double CalculateValueAtRetierment(Double startingBalanace, Double monthlyIncrease)
    {
        return startingBalanace + monthlyIncrease;
    }
}