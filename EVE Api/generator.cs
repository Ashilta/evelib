﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class eveapi {
    
    private string currentTimeField;
    
    private eveapiResult resultField;
    
    private string cachedUntilField;
    
    private byte versionField;
    
    /// <remarks/>
    public string currentTime {
        get {
            return this.currentTimeField;
        }
        set {
            this.currentTimeField = value;
        }
    }
    
    /// <remarks/>
    public eveapiResult result {
        get {
            return this.resultField;
        }
        set {
            this.resultField = value;
        }
    }
    
    /// <remarks/>
    public string cachedUntil {
        get {
            return this.cachedUntilField;
        }
        set {
            this.cachedUntilField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class eveapiResult {
    
    private eveapiResultRowset rowsetField;
    
    /// <remarks/>
    public eveapiResultRowset rowset {
        get {
            return this.rowsetField;
        }
        set {
            this.rowsetField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class eveapiResultRowset {
    
    private eveapiResultRowsetRow[] rowField;
    
    private string nameField;
    
    private string keyField;
    
    private string columnsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("row")]
    public eveapiResultRowsetRow[] row {
        get {
            return this.rowField;
        }
        set {
            this.rowField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string key {
        get {
            return this.keyField;
        }
        set {
            this.keyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string columns {
        get {
            return this.columnsField;
        }
        set {
            this.columnsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class eveapiResultRowsetRow {
    
    private string transactionDateTimeField;
    
    private uint transactionIDField;
    
    private byte quantityField;
    
    private string typeNameField;
    
    private ushort typeIDField;
    
    private decimal priceField;
    
    private uint clientIDField;
    
    private string clientNameField;
    
    private uint stationIDField;
    
    private string stationNameField;
    
    private string transactionTypeField;
    
    private string transactionForField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string transactionDateTime {
        get {
            return this.transactionDateTimeField;
        }
        set {
            this.transactionDateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint transactionID {
        get {
            return this.transactionIDField;
        }
        set {
            this.transactionIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string typeName {
        get {
            return this.typeNameField;
        }
        set {
            this.typeNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort typeID {
        get {
            return this.typeIDField;
        }
        set {
            this.typeIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal price {
        get {
            return this.priceField;
        }
        set {
            this.priceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint clientID {
        get {
            return this.clientIDField;
        }
        set {
            this.clientIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string clientName {
        get {
            return this.clientNameField;
        }
        set {
            this.clientNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint stationID {
        get {
            return this.stationIDField;
        }
        set {
            this.stationIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string stationName {
        get {
            return this.stationNameField;
        }
        set {
            this.stationNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string transactionType {
        get {
            return this.transactionTypeField;
        }
        set {
            this.transactionTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string transactionFor {
        get {
            return this.transactionForField;
        }
        set {
            this.transactionForField = value;
        }
    }
}