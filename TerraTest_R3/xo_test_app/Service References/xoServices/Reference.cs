﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace xo_test_app.xoServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="xoServices.xoServiceSoap")]
    public interface xoServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getReverseAddressXML", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress2[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(terraFeature[]))]
        xo_test_app.xoServices.webResponse getReverseAddressXML(int countryCode, double x, double y, int SRID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getReverseAddressXML2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress2[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(terraFeature[]))]
        xo_test_app.xoServices.webResponse getReverseAddressXML2(int countryCode, double x, double y, int SRID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDrivingTimesForGeometries", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress2[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(terraFeature[]))]
        xo_test_app.xoServices.webResponse getDrivingTimesForGeometries(string code, string machineID, byte[][] wkb, string time, int countryCode, int SRID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getRoute_CAR_json", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress2[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(terraFeature[]))]
        string getRoute_CAR_json(int lang, string authorization, string routeStopsJSON, bool pedestrian, bool findBestSequence, bool preserveFirstStop, bool preserverLastStop, bool allowDaktilio, bool allowATTIKHOdos, bool allowCHARGERoads, bool allowFerry, bool allowUnpaved, bool fastest, string extraParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getRoute_MMM_json", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress2[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(terraFeature[]))]
        string getRoute_MMM_json(int lang, string authorization, string routeStopsJSON, string vehicles, int dayofweek, bool useonevehicle, int extraparam1, int extraparam2, string extraParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sea_getAvaliablePorts_json", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress2[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(terraFeature[]))]
        string sea_getAvaliablePorts_json(int lang, string authorization);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sea_getAvaliableCompanies_json", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress2[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(terraFeature[]))]
        string sea_getAvaliableCompanies_json(int lang, string authorization);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sea_getAvaliableSchedules_json", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress2[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(terraFeature[]))]
        string sea_getAvaliableSchedules_json(int lang, string authorization, int departPortId, int arrivePortId, string dateString, int daysWindow);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sea_tripPlanner_json", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(geoAddress2[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(terraFeature[]))]
        string sea_tripPlanner_json(int lang, string authorization, string routeStopsJSON, string departTime, string arriveTime, int waitTimeBeforeSail, int maxHoursInPort);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class webResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private webResponseType resTypeField;
        
        private string resDescriptionField;
        
        private object resObjectField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public webResponseType resType {
            get {
                return this.resTypeField;
            }
            set {
                this.resTypeField = value;
                this.RaisePropertyChanged("resType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string resDescription {
            get {
                return this.resDescriptionField;
            }
            set {
                this.resDescriptionField = value;
                this.RaisePropertyChanged("resDescription");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public object resObject {
            get {
                return this.resObjectField;
            }
            set {
                this.resObjectField = value;
                this.RaisePropertyChanged("resObject");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum webResponseType {
        
        /// <remarks/>
        Unknown,
        
        /// <remarks/>
        Ok,
        
        /// <remarks/>
        Error,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class geoAddress : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int addTypeField;
        
        private int addIdField;
        
        private string addZipField;
        
        private string addStreetField;
        
        private string addMunicipField;
        
        private int addNumbField;
        
        private simplePoint addPointField;
        
        private simplePoint addPointWGS84Field;
        
        private string addFormatedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int addType {
            get {
                return this.addTypeField;
            }
            set {
                this.addTypeField = value;
                this.RaisePropertyChanged("addType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int addId {
            get {
                return this.addIdField;
            }
            set {
                this.addIdField = value;
                this.RaisePropertyChanged("addId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string addZip {
            get {
                return this.addZipField;
            }
            set {
                this.addZipField = value;
                this.RaisePropertyChanged("addZip");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string addStreet {
            get {
                return this.addStreetField;
            }
            set {
                this.addStreetField = value;
                this.RaisePropertyChanged("addStreet");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string addMunicip {
            get {
                return this.addMunicipField;
            }
            set {
                this.addMunicipField = value;
                this.RaisePropertyChanged("addMunicip");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int addNumb {
            get {
                return this.addNumbField;
            }
            set {
                this.addNumbField = value;
                this.RaisePropertyChanged("addNumb");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public simplePoint addPoint {
            get {
                return this.addPointField;
            }
            set {
                this.addPointField = value;
                this.RaisePropertyChanged("addPoint");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public simplePoint addPointWGS84 {
            get {
                return this.addPointWGS84Field;
            }
            set {
                this.addPointWGS84Field = value;
                this.RaisePropertyChanged("addPointWGS84");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string addFormated {
            get {
                return this.addFormatedField;
            }
            set {
                this.addFormatedField = value;
                this.RaisePropertyChanged("addFormated");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class simplePoint : object, System.ComponentModel.INotifyPropertyChanged {
        
        private double xField;
        
        private double yField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public double x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
                this.RaisePropertyChanged("x");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public double y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
                this.RaisePropertyChanged("y");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class geoAddress2 : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int addTypeField;
        
        private int addIdField;
        
        private string addZipField;
        
        private string addStreetField;
        
        private string addMunicipField;
        
        private string addNomosField;
        
        private string extra1Field;
        
        private string extra2Field;
        
        private int addNumbField;
        
        private simplePoint addPointField;
        
        private simplePoint addPointWGS84Field;
        
        private string addFormatedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int addType {
            get {
                return this.addTypeField;
            }
            set {
                this.addTypeField = value;
                this.RaisePropertyChanged("addType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int addId {
            get {
                return this.addIdField;
            }
            set {
                this.addIdField = value;
                this.RaisePropertyChanged("addId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string addZip {
            get {
                return this.addZipField;
            }
            set {
                this.addZipField = value;
                this.RaisePropertyChanged("addZip");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string addStreet {
            get {
                return this.addStreetField;
            }
            set {
                this.addStreetField = value;
                this.RaisePropertyChanged("addStreet");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string addMunicip {
            get {
                return this.addMunicipField;
            }
            set {
                this.addMunicipField = value;
                this.RaisePropertyChanged("addMunicip");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string addNomos {
            get {
                return this.addNomosField;
            }
            set {
                this.addNomosField = value;
                this.RaisePropertyChanged("addNomos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string extra1 {
            get {
                return this.extra1Field;
            }
            set {
                this.extra1Field = value;
                this.RaisePropertyChanged("extra1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string extra2 {
            get {
                return this.extra2Field;
            }
            set {
                this.extra2Field = value;
                this.RaisePropertyChanged("extra2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public int addNumb {
            get {
                return this.addNumbField;
            }
            set {
                this.addNumbField = value;
                this.RaisePropertyChanged("addNumb");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public simplePoint addPoint {
            get {
                return this.addPointField;
            }
            set {
                this.addPointField = value;
                this.RaisePropertyChanged("addPoint");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public simplePoint addPointWGS84 {
            get {
                return this.addPointWGS84Field;
            }
            set {
                this.addPointWGS84Field = value;
                this.RaisePropertyChanged("addPointWGS84");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string addFormated {
            get {
                return this.addFormatedField;
            }
            set {
                this.addFormatedField = value;
                this.RaisePropertyChanged("addFormated");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class terraFeatureAttribute : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string fieldField;
        
        private string fieldNameField;
        
        private int fieldTypeField;
        
        private object fieldValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
                this.RaisePropertyChanged("field");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string fieldName {
            get {
                return this.fieldNameField;
            }
            set {
                this.fieldNameField = value;
                this.RaisePropertyChanged("fieldName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int fieldType {
            get {
                return this.fieldTypeField;
            }
            set {
                this.fieldTypeField = value;
                this.RaisePropertyChanged("fieldType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public object fieldValue {
            get {
                return this.fieldValueField;
            }
            set {
                this.fieldValueField = value;
                this.RaisePropertyChanged("fieldValue");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class terraFeature : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int featureIDField;
        
        private terraFeatureAttribute[] attributesField;
        
        private string descriptionField;
        
        private byte[] geometryWKBField;
        
        private string geometryWKTField;
        
        private string htmlSummaryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int featureID {
            get {
                return this.featureIDField;
            }
            set {
                this.featureIDField = value;
                this.RaisePropertyChanged("featureID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        public terraFeatureAttribute[] attributes {
            get {
                return this.attributesField;
            }
            set {
                this.attributesField = value;
                this.RaisePropertyChanged("attributes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=3)]
        public byte[] geometryWKB {
            get {
                return this.geometryWKBField;
            }
            set {
                this.geometryWKBField = value;
                this.RaisePropertyChanged("geometryWKB");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string geometryWKT {
            get {
                return this.geometryWKTField;
            }
            set {
                this.geometryWKTField = value;
                this.RaisePropertyChanged("geometryWKT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string htmlSummary {
            get {
                return this.htmlSummaryField;
            }
            set {
                this.htmlSummaryField = value;
                this.RaisePropertyChanged("htmlSummary");
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
    public interface xoServiceSoapChannel : xo_test_app.xoServices.xoServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class xoServiceSoapClient : System.ServiceModel.ClientBase<xo_test_app.xoServices.xoServiceSoap>, xo_test_app.xoServices.xoServiceSoap {
        
        public xoServiceSoapClient() {
        }
        
        public xoServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public xoServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public xoServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public xoServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public xo_test_app.xoServices.webResponse getReverseAddressXML(int countryCode, double x, double y, int SRID) {
            return base.Channel.getReverseAddressXML(countryCode, x, y, SRID);
        }
        
        public xo_test_app.xoServices.webResponse getReverseAddressXML2(int countryCode, double x, double y, int SRID) {
            return base.Channel.getReverseAddressXML2(countryCode, x, y, SRID);
        }
        
        public xo_test_app.xoServices.webResponse getDrivingTimesForGeometries(string code, string machineID, byte[][] wkb, string time, int countryCode, int SRID) {
            return base.Channel.getDrivingTimesForGeometries(code, machineID, wkb, time, countryCode, SRID);
        }
        
        public string getRoute_CAR_json(int lang, string authorization, string routeStopsJSON, bool pedestrian, bool findBestSequence, bool preserveFirstStop, bool preserverLastStop, bool allowDaktilio, bool allowATTIKHOdos, bool allowCHARGERoads, bool allowFerry, bool allowUnpaved, bool fastest, string extraParams) {
            return base.Channel.getRoute_CAR_json(lang, authorization, routeStopsJSON, pedestrian, findBestSequence, preserveFirstStop, preserverLastStop, allowDaktilio, allowATTIKHOdos, allowCHARGERoads, allowFerry, allowUnpaved, fastest, extraParams);
        }
        
        public string getRoute_MMM_json(int lang, string authorization, string routeStopsJSON, string vehicles, int dayofweek, bool useonevehicle, int extraparam1, int extraparam2, string extraParams) {
            return base.Channel.getRoute_MMM_json(lang, authorization, routeStopsJSON, vehicles, dayofweek, useonevehicle, extraparam1, extraparam2, extraParams);
        }
        
        public string sea_getAvaliablePorts_json(int lang, string authorization) {
            return base.Channel.sea_getAvaliablePorts_json(lang, authorization);
        }
        
        public string sea_getAvaliableCompanies_json(int lang, string authorization) {
            return base.Channel.sea_getAvaliableCompanies_json(lang, authorization);
        }
        
        public string sea_getAvaliableSchedules_json(int lang, string authorization, int departPortId, int arrivePortId, string dateString, int daysWindow) {
            return base.Channel.sea_getAvaliableSchedules_json(lang, authorization, departPortId, arrivePortId, dateString, daysWindow);
        }
        
        public string sea_tripPlanner_json(int lang, string authorization, string routeStopsJSON, string departTime, string arriveTime, int waitTimeBeforeSail, int maxHoursInPort) {
            return base.Channel.sea_tripPlanner_json(lang, authorization, routeStopsJSON, departTime, arriveTime, waitTimeBeforeSail, maxHoursInPort);
        }
    }
}
