﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSauto.ProdReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProdReference.ProductsSoap")]
    public interface ProductsSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WSauto.ProdReference.HelloWorldResponse HelloWorld(WSauto.ProdReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WSauto.ProdReference.HelloWorldResponse> HelloWorldAsync(WSauto.ProdReference.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name prefix from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/names", ReplyAction="*")]
        WSauto.ProdReference.namesResponse names(WSauto.ProdReference.namesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/names", ReplyAction="*")]
        System.Threading.Tasks.Task<WSauto.ProdReference.namesResponse> namesAsync(WSauto.ProdReference.namesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WSauto.ProdReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WSauto.ProdReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSauto.ProdReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WSauto.ProdReference.HelloWorldResponseBody Body) {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class namesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="names", Namespace="http://tempuri.org/", Order=0)]
        public WSauto.ProdReference.namesRequestBody Body;
        
        public namesRequest() {
        }
        
        public namesRequest(WSauto.ProdReference.namesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class namesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string prefix;
        
        public namesRequestBody() {
        }
        
        public namesRequestBody(string prefix) {
            this.prefix = prefix;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class namesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="namesResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSauto.ProdReference.namesResponseBody Body;
        
        public namesResponse() {
        }
        
        public namesResponse(WSauto.ProdReference.namesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class namesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WSauto.ProdReference.ArrayOfString namesResult;
        
        public namesResponseBody() {
        }
        
        public namesResponseBody(WSauto.ProdReference.ArrayOfString namesResult) {
            this.namesResult = namesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProductsSoapChannel : WSauto.ProdReference.ProductsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsSoapClient : System.ServiceModel.ClientBase<WSauto.ProdReference.ProductsSoap>, WSauto.ProdReference.ProductsSoap {
        
        public ProductsSoapClient() {
        }
        
        public ProductsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSauto.ProdReference.HelloWorldResponse WSauto.ProdReference.ProductsSoap.HelloWorld(WSauto.ProdReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WSauto.ProdReference.HelloWorldRequest inValue = new WSauto.ProdReference.HelloWorldRequest();
            inValue.Body = new WSauto.ProdReference.HelloWorldRequestBody();
            WSauto.ProdReference.HelloWorldResponse retVal = ((WSauto.ProdReference.ProductsSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSauto.ProdReference.HelloWorldResponse> WSauto.ProdReference.ProductsSoap.HelloWorldAsync(WSauto.ProdReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSauto.ProdReference.HelloWorldResponse> HelloWorldAsync() {
            WSauto.ProdReference.HelloWorldRequest inValue = new WSauto.ProdReference.HelloWorldRequest();
            inValue.Body = new WSauto.ProdReference.HelloWorldRequestBody();
            return ((WSauto.ProdReference.ProductsSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSauto.ProdReference.namesResponse WSauto.ProdReference.ProductsSoap.names(WSauto.ProdReference.namesRequest request) {
            return base.Channel.names(request);
        }
        
        public WSauto.ProdReference.ArrayOfString names(string prefix) {
            WSauto.ProdReference.namesRequest inValue = new WSauto.ProdReference.namesRequest();
            inValue.Body = new WSauto.ProdReference.namesRequestBody();
            inValue.Body.prefix = prefix;
            WSauto.ProdReference.namesResponse retVal = ((WSauto.ProdReference.ProductsSoap)(this)).names(inValue);
            return retVal.Body.namesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSauto.ProdReference.namesResponse> WSauto.ProdReference.ProductsSoap.namesAsync(WSauto.ProdReference.namesRequest request) {
            return base.Channel.namesAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSauto.ProdReference.namesResponse> namesAsync(string prefix) {
            WSauto.ProdReference.namesRequest inValue = new WSauto.ProdReference.namesRequest();
            inValue.Body = new WSauto.ProdReference.namesRequestBody();
            inValue.Body.prefix = prefix;
            return ((WSauto.ProdReference.ProductsSoap)(this)).namesAsync(inValue);
        }
    }
}
