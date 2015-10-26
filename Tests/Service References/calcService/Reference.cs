﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tests.calcService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="calcService.ICalculatorService")]
    public interface ICalculatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/ValueAtRetirement", ReplyAction="http://tempuri.org/ICalculatorService/ValueAtRetirementResponse")]
        double ValueAtRetirement(double StartingBalance, double MonthlyDeposit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/ValueAtRetirement", ReplyAction="http://tempuri.org/ICalculatorService/ValueAtRetirementResponse")]
        System.Threading.Tasks.Task<double> ValueAtRetirementAsync(double StartingBalance, double MonthlyDeposit);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorServiceChannel : Tests.calcService.ICalculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceClient : System.ServiceModel.ClientBase<Tests.calcService.ICalculatorService>, Tests.calcService.ICalculatorService {
        
        public CalculatorServiceClient() {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double ValueAtRetirement(double StartingBalance, double MonthlyDeposit) {
            return base.Channel.ValueAtRetirement(StartingBalance, MonthlyDeposit);
        }
        
        public System.Threading.Tasks.Task<double> ValueAtRetirementAsync(double StartingBalance, double MonthlyDeposit) {
            return base.Channel.ValueAtRetirementAsync(StartingBalance, MonthlyDeposit);
        }
    }
}
