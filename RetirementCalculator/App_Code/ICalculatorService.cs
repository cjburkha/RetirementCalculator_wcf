using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


[ServiceContract]
public interface ICalculatorService
{

	

    [OperationContract]
    Double ValueAtRetirement(Double StartingBalance, Double MonthlyDeposit);

	// TODO: Add your service operations here
}


