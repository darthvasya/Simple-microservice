﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dev.Solver.WebInterface.Calculation {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Calculation.CalculationWCFServiceSoap")]
    public interface CalculationWCFServiceSoap {
        
        // CODEGEN: Generating message contract since element name input from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        dev.Solver.WebInterface.Calculation.HelloWorldResponse HelloWorld(dev.Solver.WebInterface.Calculation.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<dev.Solver.WebInterface.Calculation.HelloWorldResponse> HelloWorldAsync(dev.Solver.WebInterface.Calculation.HelloWorldRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public dev.Solver.WebInterface.Calculation.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(dev.Solver.WebInterface.Calculation.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string input;
        
        public HelloWorldRequestBody() {
        }
        
        public HelloWorldRequestBody(string input) {
            this.input = input;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public dev.Solver.WebInterface.Calculation.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(dev.Solver.WebInterface.Calculation.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculationWCFServiceSoapChannel : dev.Solver.WebInterface.Calculation.CalculationWCFServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculationWCFServiceSoapClient : System.ServiceModel.ClientBase<dev.Solver.WebInterface.Calculation.CalculationWCFServiceSoap>, dev.Solver.WebInterface.Calculation.CalculationWCFServiceSoap {
        
        public CalculationWCFServiceSoapClient() {
        }
        
        public CalculationWCFServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculationWCFServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculationWCFServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculationWCFServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        dev.Solver.WebInterface.Calculation.HelloWorldResponse dev.Solver.WebInterface.Calculation.CalculationWCFServiceSoap.HelloWorld(dev.Solver.WebInterface.Calculation.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld(string input) {
            dev.Solver.WebInterface.Calculation.HelloWorldRequest inValue = new dev.Solver.WebInterface.Calculation.HelloWorldRequest();
            inValue.Body = new dev.Solver.WebInterface.Calculation.HelloWorldRequestBody();
            inValue.Body.input = input;
            dev.Solver.WebInterface.Calculation.HelloWorldResponse retVal = ((dev.Solver.WebInterface.Calculation.CalculationWCFServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<dev.Solver.WebInterface.Calculation.HelloWorldResponse> dev.Solver.WebInterface.Calculation.CalculationWCFServiceSoap.HelloWorldAsync(dev.Solver.WebInterface.Calculation.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<dev.Solver.WebInterface.Calculation.HelloWorldResponse> HelloWorldAsync(string input) {
            dev.Solver.WebInterface.Calculation.HelloWorldRequest inValue = new dev.Solver.WebInterface.Calculation.HelloWorldRequest();
            inValue.Body = new dev.Solver.WebInterface.Calculation.HelloWorldRequestBody();
            inValue.Body.input = input;
            return ((dev.Solver.WebInterface.Calculation.CalculationWCFServiceSoap)(this)).HelloWorldAsync(inValue);
        }
    }
}