﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples")]
public interface ICalculatorSession
{

    [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculatorSession/Clear", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculatorSession/ClearResponse")]
    void Clear();

    [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculatorSession/AddTo", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculatorSession/AddToResponse")]
    void AddTo(double n);

    [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculatorSession/SubtractFrom", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculatorSession/SubtractFromResponse")]
    void SubtractFrom(double n);

    [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculatorSession/MultiplyBy", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculatorSession/MultiplyByResponse")]
    void MultiplyBy(double n);

    [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculatorSession/DivideBy", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculatorSession/DivideByResponse")]
    void DivideBy(double n);

    [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculatorSession/Equals", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculatorSession/EqualsResponse")]
    double Equals();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface ICalculatorSessionChannel : ICalculatorSession, System.ServiceModel.IClientChannel
{
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class CalculatorSessionClient : System.ServiceModel.ClientBase<ICalculatorSession>, ICalculatorSession
{

    public CalculatorSessionClient()
    {
    }

    public CalculatorSessionClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
    {
    }

    public CalculatorSessionClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public CalculatorSessionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public CalculatorSessionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    public void Clear()
    {
        base.Channel.Clear();
    }

    public void AddTo(double n)
    {
        base.Channel.AddTo(n);
    }

    public void SubtractFrom(double n)
    {
        base.Channel.SubtractFrom(n);
    }

    public void MultiplyBy(double n)
    {
        base.Channel.MultiplyBy(n);
    }

    public void DivideBy(double n)
    {
        base.Channel.DivideBy(n);
    }

    public double Equals()
    {
        return base.Channel.Equals();
    }
}
