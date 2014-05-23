﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("https://www.mycas.org.uk/service/notification/AcknowledgeNotificationService", ClrNamespace="www.mycas.org.uk.service.notification.AcknowledgeNotificationService")]

namespace MyGovScot.MyAccount.AcknowledgeNotificationService
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "https://www.mycas.org.uk/service/notification/AcknowledgeNotificationService", ConfigurationName = "AcknowledgeNotificationService")]
    public interface AcknowledgeNotificationService
    {

        // CODEGEN: Generating message contract since the operation acknowledgeNotification is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action = "https://www.mycas.org.uk/service/AcknowledgeNotificationService/acknowledgeNotifi" +
            "cation", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(www.mycas.org.uk.service.notification.AcknowledgeNotificationService.Exception), Action = "https://www.mycas.org.uk/service/AcknowledgeNotificationService/acknowledgeNotifi" +
            "cation", Name = "Exception")]
        [System.ServiceModel.FaultContractAttribute(typeof(www.mycas.org.uk.service.notification.AcknowledgeNotificationService.ServiceException), Action = "https://www.mycas.org.uk/service/AcknowledgeNotificationService/acknowledgeNotifi" +
            "cation", Name = "ServiceException")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        acknowledgeNotificationResponse1 acknowledgeNotification(acknowledgeNotificationRequest1 request);

        [System.ServiceModel.OperationContractAttribute(Action = "https://www.mycas.org.uk/service/AcknowledgeNotificationService/acknowledgeNotifi" +
            "cation", ReplyAction = "*")]
        System.Threading.Tasks.Task<acknowledgeNotificationResponse1> acknowledgeNotificationAsync(acknowledgeNotificationRequest1 request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/service/notification/AcknowledgeNotificationService")]
    public partial class acknowledgeNotification
    {

        private AcknowledgeNotificationRequest acknowledgeNotificationRequestField;

        private string callerTokenField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public AcknowledgeNotificationRequest acknowledgeNotificationRequest
        {
            get
            {
                return this.acknowledgeNotificationRequestField;
            }
            set
            {
                this.acknowledgeNotificationRequestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string CallerToken
        {
            get
            {
                return this.callerTokenField;
            }
            set
            {
                this.callerTokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/notifications/AcknowledgeNotificationTypes")]
    public partial class AcknowledgeNotificationRequest
    {

        private RequestBody requestBodyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public RequestBody RequestBody
        {
            get
            {
                return this.requestBodyField;
            }
            set
            {
                this.requestBodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/notifications/AcknowledgeNotificationTypes")]
    public partial class RequestBody
    {

        private Notification notificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Notification Notification
        {
            get
            {
                return this.notificationField;
            }
            set
            {
                this.notificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/notifications/CommonNotificationTypes")]
    public partial class Notification
    {

        private string notificationIDField;

        private NotificationTypeCode notificationTypeCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string NotificationID
        {
            get
            {
                return this.notificationIDField;
            }
            set
            {
                this.notificationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public NotificationTypeCode NotificationTypeCode
        {
            get
            {
                return this.notificationTypeCodeField;
            }
            set
            {
                this.notificationTypeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/notifications/CommonNotificationTypes")]
    public enum NotificationTypeCode
    {

        /// <remarks/>
        RegistrationNotification,

        /// <remarks/>
        ChangePersonalDetailsNotification,

        /// <remarks/>
        ChangeAddressNotification,

        /// <remarks/>
        DeathNotification,

        /// <remarks/>
        UCRNResolutionNotification,

        /// <remarks/>
        UPRNResolutionNotification,

        /// <remarks/>
        NECCardNotification,

        /// <remarks/>
        DeathCorrectionNotification,

        /// <remarks/>
        MergeUCRNNotification,

        /// <remarks/>
        SwapUCRNNotification,

        /// <remarks/>
        DeleteUCRNNotification,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class ResponseHead
    {

        private string responseCodeField;

        private string responseMessageField;

        private bool resultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string ResponseCode
        {
            get
            {
                return this.responseCodeField;
            }
            set
            {
                this.responseCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string ResponseMessage
        {
            get
            {
                return this.responseMessageField;
            }
            set
            {
                this.responseMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public bool Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/notifications/AcknowledgeNotificationTypes")]
    public partial class AcknowledgeNotificationResponse
    {

        private ResponseHead responseHeadField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public ResponseHead ResponseHead
        {
            get
            {
                return this.responseHeadField;
            }
            set
            {
                this.responseHeadField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/service/notification/AcknowledgeNotificationService")]
    public partial class acknowledgeNotificationResponse
    {

        private AcknowledgeNotificationResponse acknowledgeNotificationResponse1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("acknowledgeNotificationResponse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public AcknowledgeNotificationResponse acknowledgeNotificationResponse1
        {
            get
            {
                return this.acknowledgeNotificationResponse1Field;
            }
            set
            {
                this.acknowledgeNotificationResponse1Field = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class acknowledgeNotificationRequest1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "https://www.mycas.org.uk/service/notification/AcknowledgeNotificationService", Order = 0)]
        public acknowledgeNotification acknowledgeNotification;

        public acknowledgeNotificationRequest1()
        {
        }

        public acknowledgeNotificationRequest1(acknowledgeNotification acknowledgeNotification)
        {
            this.acknowledgeNotification = acknowledgeNotification;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class acknowledgeNotificationResponse1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "https://www.mycas.org.uk/service/notification/AcknowledgeNotificationService", Order = 0)]
        public acknowledgeNotificationResponse acknowledgeNotificationResponse;

        public acknowledgeNotificationResponse1()
        {
        }

        public acknowledgeNotificationResponse1(acknowledgeNotificationResponse acknowledgeNotificationResponse)
        {
            this.acknowledgeNotificationResponse = acknowledgeNotificationResponse;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AcknowledgeNotificationServiceChannel : AcknowledgeNotificationService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AcknowledgeNotificationServiceClient : System.ServiceModel.ClientBase<AcknowledgeNotificationService>, AcknowledgeNotificationService
    {

        public AcknowledgeNotificationServiceClient()
        {
        }

        public AcknowledgeNotificationServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public AcknowledgeNotificationServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public AcknowledgeNotificationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public AcknowledgeNotificationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        acknowledgeNotificationResponse1 AcknowledgeNotificationService.acknowledgeNotification(acknowledgeNotificationRequest1 request)
        {
            return base.Channel.acknowledgeNotification(request);
        }

        public acknowledgeNotificationResponse acknowledgeNotification(acknowledgeNotification acknowledgeNotification1)
        {
            acknowledgeNotificationRequest1 inValue = new acknowledgeNotificationRequest1();
            inValue.acknowledgeNotification = acknowledgeNotification1;
            acknowledgeNotificationResponse1 retVal = ((AcknowledgeNotificationService)(this)).acknowledgeNotification(inValue);
            return retVal.acknowledgeNotificationResponse;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<acknowledgeNotificationResponse1> AcknowledgeNotificationService.acknowledgeNotificationAsync(acknowledgeNotificationRequest1 request)
        {
            return base.Channel.acknowledgeNotificationAsync(request);
        }

        public System.Threading.Tasks.Task<acknowledgeNotificationResponse1> acknowledgeNotificationAsync(acknowledgeNotification acknowledgeNotification)
        {
            acknowledgeNotificationRequest1 inValue = new acknowledgeNotificationRequest1();
            inValue.acknowledgeNotification = acknowledgeNotification;
            return ((AcknowledgeNotificationService)(this)).acknowledgeNotificationAsync(inValue);
        }
    }
    namespace www.mycas.org.uk.service.notification.AcknowledgeNotificationService
    {


        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
        [System.Xml.Serialization.XmlRootAttribute(IsNullable = false)]
        public partial class Exception : object, System.Xml.Serialization.IXmlSerializable
        {

            private System.Xml.XmlNode[] nodesField;

            private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("Exception", "https://www.mycas.org.uk/service/notification/AcknowledgeNotificationService");

            public System.Xml.XmlNode[] Nodes
            {
                get
                {
                    return this.nodesField;
                }
                set
                {
                    this.nodesField = value;
                }
            }

            public void ReadXml(System.Xml.XmlReader reader)
            {
                this.nodesField = System.Runtime.Serialization.XmlSerializableServices.ReadNodes(reader);
            }

            public void WriteXml(System.Xml.XmlWriter writer)
            {
                System.Runtime.Serialization.XmlSerializableServices.WriteNodes(writer, this.Nodes);
            }

            public System.Xml.Schema.XmlSchema GetSchema()
            {
                return null;
            }

            public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
            {
                System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
                return typeName;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
        [System.Xml.Serialization.XmlRootAttribute(IsNullable = false)]
        public partial class ServiceException : object, System.Xml.Serialization.IXmlSerializable
        {

            private System.Xml.XmlNode[] nodesField;

            private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("ServiceException", "https://www.mycas.org.uk/service/notification/AcknowledgeNotificationService");

            public System.Xml.XmlNode[] Nodes
            {
                get
                {
                    return this.nodesField;
                }
                set
                {
                    this.nodesField = value;
                }
            }

            public void ReadXml(System.Xml.XmlReader reader)
            {
                this.nodesField = System.Runtime.Serialization.XmlSerializableServices.ReadNodes(reader);
            }

            public void WriteXml(System.Xml.XmlWriter writer)
            {
                System.Runtime.Serialization.XmlSerializableServices.WriteNodes(writer, this.Nodes);
            }

            public System.Xml.Schema.XmlSchema GetSchema()
            {
                return null;
            }

            public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
            {
                System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
                return typeName;
            }
        }
    }
}