// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>TechnoLogica.Eservices.InformationObjects</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>ASCII</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace TechnoLogica.Eservices.InformationObjects {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/0009-000001")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/0009-000001", IsNullable=true)]
    public partial class DocumentURI : InformationObject<DocumentURI> {
        
        private string registerIndexField;
        
        private string sequenceNumberField;
        
        private System.DateTime receiptOrSigningDateField;
        
        private bool receiptOrSigningDateFieldSpecified;
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=0)]
        public string RegisterIndex {
            get {
                return this.registerIndexField;
            }
            set {
                if ((this.registerIndexField != null)) {
                    if ((registerIndexField.Equals(value) != true)) {
                        this.registerIndexField = value;
                        this.OnPropertyChanged("RegisterIndex");
                    }
                }
                else {
                    this.registerIndexField = value;
                    this.OnPropertyChanged("RegisterIndex");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=1)]
        public string SequenceNumber {
            get {
                return this.sequenceNumberField;
            }
            set {
                if ((this.sequenceNumberField != null)) {
                    if ((sequenceNumberField.Equals(value) != true)) {
                        this.sequenceNumberField = value;
                        this.OnPropertyChanged("SequenceNumber");
                    }
                }
                else {
                    this.sequenceNumberField = value;
                    this.OnPropertyChanged("SequenceNumber");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime ReceiptOrSigningDate {
            get {
                return this.receiptOrSigningDateField;
            }
            set {
                if ((receiptOrSigningDateField.Equals(value) != true)) {
                    this.receiptOrSigningDateField = value;
                    this.OnPropertyChanged("ReceiptOrSigningDate");
                }
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReceiptOrSigningDateSpecified {
            get {
                return this.receiptOrSigningDateFieldSpecified;
            }
            set {
                if ((receiptOrSigningDateFieldSpecified.Equals(value) != true)) {
                    this.receiptOrSigningDateFieldSpecified = value;
                    this.OnPropertyChanged("ReceiptOrSigningDateSpecified");
                }
            }
        }
    }
}
