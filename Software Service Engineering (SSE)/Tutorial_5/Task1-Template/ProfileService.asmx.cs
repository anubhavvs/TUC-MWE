﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Web.Services.WebServiceAttribute(Namespace="urn:vsr")]
[System.Web.Services.WebServiceBindingAttribute(Name="SoapOverHttpBinding", Namespace="urn:vsr")]
public partial class ProfileService : System.Web.Services.WebService {
    
    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:vsr/PrintProfile", RequestNamespace="urn:vsr", ResponseNamespace="urn:vsr", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("result")]
    public string PrintProfile(string FirstName, string SecondName) {
        return FirstName + " " + SecondName;
    }
}
