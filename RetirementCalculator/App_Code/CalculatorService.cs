using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


public class CalculatorService : ICalculatorService
{
    
    private RetirementCalculator _myCalc = new  RetirementCalculator();

    public RetirementCalculator MyCalc
    {
        get { return _myCalc; }
        set { _myCalc = value; }
    }
    
	
    public Double ValueAtRetirement(Double StartingBalance, Double MonthlyAddition)
	{
        if (StartingBalance < 0)
            throw new Exception("Starting Balance cannot be less than 0");
        if (MonthlyAddition < 0)
            throw new Exception("MonthlyAddition cannot be less than 0");
        return MyCalc.valueAtRetierment(StartingBalance, MonthlyAddition);
	}
}
