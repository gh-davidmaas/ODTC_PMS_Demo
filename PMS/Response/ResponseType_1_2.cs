﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 
namespace PMS.Response {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Value", Namespace="", IsNullable=true)]
    public partial class Parameter {
        
        private object itemField;
        
        private ItemChoiceType itemElementNameField;
        
        private string nameField;
        
        private AllowedType parameterTypeField;
        
        private bool parameterTypeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Boolean", typeof(bool), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("Byte", typeof(sbyte), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("DateTime", typeof(System.DateTime), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("Duration", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="duration")]
        [System.Xml.Serialization.XmlElementAttribute("Float32", typeof(float), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("Float64", typeof(double), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("Int32", typeof(int), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("Int64", typeof(long), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("Short", typeof(short), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("String", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("unsignedByte", typeof(byte), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("unsignedInt", typeof(uint), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("unsignedLong", typeof(ulong), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("unsignedShort", typeof(ushort), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
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
        public AllowedType parameterType {
            get {
                return this.parameterTypeField;
            }
            set {
                this.parameterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parameterTypeSpecified {
            get {
                return this.parameterTypeFieldSpecified;
            }
            set {
                this.parameterTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public enum ItemChoiceType {
        
        /// <remarks/>
        Boolean,
        
        /// <remarks/>
        Byte,
        
        /// <remarks/>
        DateTime,
        
        /// <remarks/>
        Duration,
        
        /// <remarks/>
        Float32,
        
        /// <remarks/>
        Float64,
        
        /// <remarks/>
        Int32,
        
        /// <remarks/>
        Int64,
        
        /// <remarks/>
        Short,
        
        /// <remarks/>
        String,
        
        /// <remarks/>
        unsignedByte,
        
        /// <remarks/>
        unsignedInt,
        
        /// <remarks/>
        unsignedLong,
        
        /// <remarks/>
        unsignedShort,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    public enum AllowedType {
        
        /// <remarks/>
        Boolean,
        
        /// <remarks/>
        DateTime,
        
        /// <remarks/>
        Float32,
        
        /// <remarks/>
        Float64,
        
        /// <remarks/>
        Byte,
        
        /// <remarks/>
        Short,
        
        /// <remarks/>
        Int32,
        
        /// <remarks/>
        Int64,
        
        /// <remarks/>
        unsignedByte,
        
        /// <remarks/>
        unsignedShort,
        
        /// <remarks/>
        unsignedInt,
        
        /// <remarks/>
        unsignedLong,
        
        /// <remarks/>
        String,
        
        /// <remarks/>
        Duration,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class ParameterSet {
        
        private Parameter[] parameterField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Parameter[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class ResponseData {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnyData", typeof(object), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("Parameter", typeof(Parameter), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("ParameterSet", typeof(ParameterSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}
