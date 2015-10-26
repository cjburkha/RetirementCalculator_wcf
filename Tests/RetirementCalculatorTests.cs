using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class RetirementCalculatorTests
    {
        [TestMethod]
        public void TestNew()
        {

            //RetirementCalculator.RetiermentCalculator rc = new RetirementCalculator.RetiermentCalculator();
            calcService.CalculatorServiceClient csc = new calcService.CalculatorServiceClient();
        }
        [TestMethod]
        public void TestRetirement()
        {

            //RetirementCalculator.RetiermentCalculator rc = new RetirementCalculator.RetiermentCalculator();
            calcService.CalculatorServiceClient csc = new calcService.CalculatorServiceClient();
            csc.ValueAtRetirement(50, 20);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException))]
        public void TestExceptionNegativeValue()
        {

            calcService.CalculatorServiceClient csc = new calcService.CalculatorServiceClient();
            csc.ValueAtRetirement(-50, 50);

         }
        [TestMethod]
        public void TestExceptionNegativeMonthly()
        {
            calcService.CalculatorServiceClient csc = new calcService.CalculatorServiceClient();

            try
            {
                csc.ValueAtRetirement(50, -50);
                //Should not make it here because the service should throw ex
                throw new AssertFailedException("service did not throw exception");
            }
            //Catch our exception and rethrow to fail test
            catch (AssertFailedException aef)
            {
                throw aef;

            }
            //catch and swallow all others, they are what we want from service.
            catch (Exception ex)
            { }
        }

    }
}
