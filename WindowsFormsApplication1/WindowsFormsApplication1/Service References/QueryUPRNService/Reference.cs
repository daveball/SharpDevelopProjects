﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.QueryUPRNService {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/QueryUPRNService")]
    public partial class Exception : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class AddressLine : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string addressLine1Field;
        
        private string addressLine2Field;
        
        private string addressLine3Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string AddressLine1 {
            get {
                return this.addressLine1Field;
            }
            set {
                this.addressLine1Field = value;
                this.RaisePropertyChanged("AddressLine1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string AddressLine2 {
            get {
                return this.addressLine2Field;
            }
            set {
                this.addressLine2Field = value;
                this.RaisePropertyChanged("AddressLine2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string AddressLine3 {
            get {
                return this.addressLine3Field;
            }
            set {
                this.addressLine3Field = value;
                this.RaisePropertyChanged("AddressLine3");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class AddressDetails : object, System.ComponentModel.INotifyPropertyChanged {
        
        private AddressLine addressLineField;
        
        private string townField;
        
        private string postCodeField;
        
        private long lACodeField;
        
        private bool lACodeFieldSpecified;
        
        private string addressProviderField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public AddressLine AddressLine {
            get {
                return this.addressLineField;
            }
            set {
                this.addressLineField = value;
                this.RaisePropertyChanged("AddressLine");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Town {
            get {
                return this.townField;
            }
            set {
                this.townField = value;
                this.RaisePropertyChanged("Town");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string PostCode {
            get {
                return this.postCodeField;
            }
            set {
                this.postCodeField = value;
                this.RaisePropertyChanged("PostCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public long LACode {
            get {
                return this.lACodeField;
            }
            set {
                this.lACodeField = value;
                this.RaisePropertyChanged("LACode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LACodeSpecified {
            get {
                return this.lACodeFieldSpecified;
            }
            set {
                this.lACodeFieldSpecified = value;
                this.RaisePropertyChanged("LACodeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string AddressProvider {
            get {
                return this.addressProviderField;
            }
            set {
                this.addressProviderField = value;
                this.RaisePropertyChanged("AddressProvider");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="Address", Namespace="https://www.mycas.org.uk/schemas/QueryUPRNTypes")]
    public partial class Address1 : object, System.ComponentModel.INotifyPropertyChanged {
        
        private AddressDetails addressDetailsField;
        
        private string addressStringField;
        
        private UPRNType uPRNField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public AddressDetails AddressDetails {
            get {
                return this.addressDetailsField;
            }
            set {
                this.addressDetailsField = value;
                this.RaisePropertyChanged("AddressDetails");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string AddressString {
            get {
                return this.addressStringField;
            }
            set {
                this.addressStringField = value;
                this.RaisePropertyChanged("AddressString");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public UPRNType UPRN {
            get {
                return this.uPRNField;
            }
            set {
                this.uPRNField = value;
                this.RaisePropertyChanged("UPRN");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class UPRNType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private UPRNTypeUPRNType uPRNType1Field;
        
        private bool uPRNType1FieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("UPRNType")]
        public UPRNTypeUPRNType UPRNType1 {
            get {
                return this.uPRNType1Field;
            }
            set {
                this.uPRNType1Field = value;
                this.RaisePropertyChanged("UPRNType1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UPRNType1Specified {
            get {
                return this.uPRNType1FieldSpecified;
            }
            set {
                this.uPRNType1FieldSpecified = value;
                this.RaisePropertyChanged("UPRNType1Specified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public enum UPRNTypeUPRNType {
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        T,
        
        /// <remarks/>
        PU,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/QueryUPRNTypes")]
    public partial class ResponseBody : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Address1[] matchedAddressDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Address1[] MatchedAddressDetails {
            get {
                return this.matchedAddressDetailsField;
            }
            set {
                this.matchedAddressDetailsField = value;
                this.RaisePropertyChanged("MatchedAddressDetails");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class ResponseHead : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string responseCodeField;
        
        private string responseMessageField;
        
        private bool resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ResponseCode {
            get {
                return this.responseCodeField;
            }
            set {
                this.responseCodeField = value;
                this.RaisePropertyChanged("ResponseCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ResponseMessage {
            get {
                return this.responseMessageField;
            }
            set {
                this.responseMessageField = value;
                this.RaisePropertyChanged("ResponseMessage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public bool Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
                this.RaisePropertyChanged("Result");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/QueryUPRNTypes")]
    public partial class QueryUPRNResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ResponseHead responseHeadField;
        
        private ResponseBody responseBodyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public ResponseHead ResponseHead {
            get {
                return this.responseHeadField;
            }
            set {
                this.responseHeadField = value;
                this.RaisePropertyChanged("ResponseHead");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public ResponseBody ResponseBody {
            get {
                return this.responseBodyField;
            }
            set {
                this.responseBodyField = value;
                this.RaisePropertyChanged("ResponseBody");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/QueryUPRNService")]
    public partial class queryUPRNResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private QueryUPRNResponse queryUPRNResponse1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("queryUPRNResponse", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public QueryUPRNResponse queryUPRNResponse1 {
            get {
                return this.queryUPRNResponse1Field;
            }
            set {
                this.queryUPRNResponse1Field = value;
                this.RaisePropertyChanged("queryUPRNResponse1");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class Address : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string postCodeField;
        
        private string addressStringField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string PostCode {
            get {
                return this.postCodeField;
            }
            set {
                this.postCodeField = value;
                this.RaisePropertyChanged("PostCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string AddressString {
            get {
                return this.addressStringField;
            }
            set {
                this.addressStringField = value;
                this.RaisePropertyChanged("AddressString");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/QueryUPRNTypes")]
    public partial class RequestBody : object, System.ComponentModel.INotifyPropertyChanged {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Address", typeof(Address), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("UPRN", typeof(UPRNType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/QueryUPRNTypes")]
    public partial class QueryUPRNRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private RequestBody requestBodyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public RequestBody RequestBody {
            get {
                return this.requestBodyField;
            }
            set {
                this.requestBodyField = value;
                this.RaisePropertyChanged("RequestBody");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/QueryUPRNService")]
    public partial class queryUPRN : object, System.ComponentModel.INotifyPropertyChanged {
        
        private QueryUPRNRequest queryUPRNRequestField;
        
        private string callerTokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public QueryUPRNRequest queryUPRNRequest {
            get {
                return this.queryUPRNRequestField;
            }
            set {
                this.queryUPRNRequestField = value;
                this.RaisePropertyChanged("queryUPRNRequest");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string CallerToken {
            get {
                return this.callerTokenField;
            }
            set {
                this.callerTokenField = value;
                this.RaisePropertyChanged("CallerToken");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/QueryUPRNService")]
    public partial class ServiceException : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string exceptionStackTraceField;
        
        private string messageField;
        
        private string messageIdField;
        
        private string[] placeHolderValuesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string exceptionStackTrace {
            get {
                return this.exceptionStackTraceField;
            }
            set {
                this.exceptionStackTraceField = value;
                this.RaisePropertyChanged("exceptionStackTrace");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string messageId {
            get {
                return this.messageIdField;
            }
            set {
                this.messageIdField = value;
                this.RaisePropertyChanged("messageId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("placeHolderValues", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string[] placeHolderValues {
            get {
                return this.placeHolderValuesField;
            }
            set {
                this.placeHolderValuesField = value;
                this.RaisePropertyChanged("placeHolderValues");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://www.mycas.org.uk/services/QueryUPRNService", ConfigurationName="QueryUPRNService.QueryUPRNService")]
    public interface QueryUPRNService {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.mycas.org.uk/services/queryUPRN", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsApplication1.QueryUPRNService.Exception), Action="https://www.mycas.org.uk/services/queryUPRN", Name="Exception")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsApplication1.QueryUPRNService.ServiceException), Action="https://www.mycas.org.uk/services/queryUPRN", Name="ServiceException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WindowsFormsApplication1.QueryUPRNService.queryUPRNResponse1 queryUPRN(WindowsFormsApplication1.QueryUPRNService.queryUPRNRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.mycas.org.uk/services/queryUPRN", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.QueryUPRNService.queryUPRNResponse1> queryUPRNAsync(WindowsFormsApplication1.QueryUPRNService.queryUPRNRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class queryUPRNRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www.mycas.org.uk/services/QueryUPRNService", Order=0)]
        public WindowsFormsApplication1.QueryUPRNService.queryUPRN queryUPRN;
        
        public queryUPRNRequest1() {
        }
        
        public queryUPRNRequest1(WindowsFormsApplication1.QueryUPRNService.queryUPRN queryUPRN) {
            this.queryUPRN = queryUPRN;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class queryUPRNResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www.mycas.org.uk/services/QueryUPRNService", Order=0)]
        public WindowsFormsApplication1.QueryUPRNService.queryUPRNResponse queryUPRNResponse;
        
        public queryUPRNResponse1() {
        }
        
        public queryUPRNResponse1(WindowsFormsApplication1.QueryUPRNService.queryUPRNResponse queryUPRNResponse) {
            this.queryUPRNResponse = queryUPRNResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface QueryUPRNServiceChannel : WindowsFormsApplication1.QueryUPRNService.QueryUPRNService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QueryUPRNServiceClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.QueryUPRNService.QueryUPRNService>, WindowsFormsApplication1.QueryUPRNService.QueryUPRNService {
        
        public QueryUPRNServiceClient() {
        }
        
        public QueryUPRNServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QueryUPRNServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QueryUPRNServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QueryUPRNServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsApplication1.QueryUPRNService.queryUPRNResponse1 queryUPRN(WindowsFormsApplication1.QueryUPRNService.queryUPRNRequest1 request) {
            return base.Channel.queryUPRN(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.QueryUPRNService.queryUPRNResponse1> queryUPRNAsync(WindowsFormsApplication1.QueryUPRNService.queryUPRNRequest1 request) {
            return base.Channel.queryUPRNAsync(request);
        }
    }
}