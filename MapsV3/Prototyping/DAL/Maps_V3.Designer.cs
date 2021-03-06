﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3615
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 13/9/2010 11:59:59 πμ
namespace MapsV3.Prototyping.DAL
{
    
    /// <summary>
    /// There are no comments for MapsDevEntities in the schema.
    /// </summary>
    public partial class MapsDevEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new MapsDevEntities object using the connection string found in the 'MapsDevEntities' section of the application configuration file.
        /// </summary>
        public MapsDevEntities() : 
                base("name=MapsDevEntities", "MapsDevEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new MapsDevEntities object.
        /// </summary>
        public MapsDevEntities(string connectionString) : 
                base(connectionString, "MapsDevEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new MapsDevEntities object.
        /// </summary>
        public MapsDevEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "MapsDevEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for POISet in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<POI> POISet
        {
            get
            {
                if ((this._POISet == null))
                {
                    this._POISet = base.CreateQuery<POI>("[POISet]");
                }
                return this._POISet;
            }
        }
        private global::System.Data.Objects.ObjectQuery<POI> _POISet;
        /// <summary>
        /// There are no comments for poi_category in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<poi_category> poi_category
        {
            get
            {
                if ((this._poi_category == null))
                {
                    this._poi_category = base.CreateQuery<poi_category>("[poi_category]");
                }
                return this._poi_category;
            }
        }
        private global::System.Data.Objects.ObjectQuery<poi_category> _poi_category;
        /// <summary>
        /// There are no comments for POISet in the schema.
        /// </summary>
        public void AddToPOISet(POI pOI)
        {
            base.AddObject("POISet", pOI);
        }
        /// <summary>
        /// There are no comments for poi_category in the schema.
        /// </summary>
        public void AddTopoi_category(poi_category poi_category)
        {
            base.AddObject("poi_category", poi_category);
        }
    }
    /// <summary>
    /// There are no comments for Maps.v3.Model.POI in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AutoPoiID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="Maps.v3.Model", Name="POI")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class POI : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new POI object.
        /// </summary>
        /// <param name="autoPoiID">Initial value of AutoPoiID.</param>
        /// <param name="poiId">Initial value of PoiId.</param>
        /// <param name="poiName">Initial value of PoiName.</param>
        public static POI CreatePOI(int autoPoiID, int poiId, string poiName)
        {
            POI pOI = new POI();
            pOI.AutoPoiID = autoPoiID;
            pOI.PoiId = poiId;
            pOI.PoiName = poiName;
            return pOI;
        }
        /// <summary>
        /// There are no comments for Property AutoPoiID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int AutoPoiID
        {
            get
            {
                return this._AutoPoiID;
            }
            set
            {
                this.OnAutoPoiIDChanging(value);
                this.ReportPropertyChanging("AutoPoiID");
                this._AutoPoiID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("AutoPoiID");
                this.OnAutoPoiIDChanged();
            }
        }
        private int _AutoPoiID;
        partial void OnAutoPoiIDChanging(int value);
        partial void OnAutoPoiIDChanged();
        /// <summary>
        /// There are no comments for Property PoiId in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int PoiId
        {
            get
            {
                return this._PoiId;
            }
            set
            {
                this.OnPoiIdChanging(value);
                this.ReportPropertyChanging("PoiId");
                this._PoiId = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("PoiId");
                this.OnPoiIdChanged();
            }
        }
        private int _PoiId;
        partial void OnPoiIdChanging(int value);
        partial void OnPoiIdChanged();
        /// <summary>
        /// There are no comments for Property PoiName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string PoiName
        {
            get
            {
                return this._PoiName;
            }
            set
            {
                this.OnPoiNameChanging(value);
                this.ReportPropertyChanging("PoiName");
                this._PoiName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("PoiName");
                this.OnPoiNameChanged();
            }
        }
        private string _PoiName;
        partial void OnPoiNameChanging(string value);
        partial void OnPoiNameChanged();
        /// <summary>
        /// There are no comments for Property CategoryId in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<int> CategoryId
        {
            get
            {
                return this._CategoryId;
            }
            set
            {
                this.OnCategoryIdChanging(value);
                this.ReportPropertyChanging("CategoryId");
                this._CategoryId = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("CategoryId");
                this.OnCategoryIdChanged();
            }
        }
        private global::System.Nullable<int> _CategoryId;
        partial void OnCategoryIdChanging(global::System.Nullable<int> value);
        partial void OnCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property AddressLine1 in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string AddressLine1
        {
            get
            {
                return this._AddressLine1;
            }
            set
            {
                this.OnAddressLine1Changing(value);
                this.ReportPropertyChanging("AddressLine1");
                this._AddressLine1 = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("AddressLine1");
                this.OnAddressLine1Changed();
            }
        }
        private string _AddressLine1;
        partial void OnAddressLine1Changing(string value);
        partial void OnAddressLine1Changed();
        /// <summary>
        /// There are no comments for Property AddressLine2 in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string AddressLine2
        {
            get
            {
                return this._AddressLine2;
            }
            set
            {
                this.OnAddressLine2Changing(value);
                this.ReportPropertyChanging("AddressLine2");
                this._AddressLine2 = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("AddressLine2");
                this.OnAddressLine2Changed();
            }
        }
        private string _AddressLine2;
        partial void OnAddressLine2Changing(string value);
        partial void OnAddressLine2Changed();
        /// <summary>
        /// There are no comments for Property AddressLine3 in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string AddressLine3
        {
            get
            {
                return this._AddressLine3;
            }
            set
            {
                this.OnAddressLine3Changing(value);
                this.ReportPropertyChanging("AddressLine3");
                this._AddressLine3 = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("AddressLine3");
                this.OnAddressLine3Changed();
            }
        }
        private string _AddressLine3;
        partial void OnAddressLine3Changing(string value);
        partial void OnAddressLine3Changed();
        /// <summary>
        /// There are no comments for Property Municipality in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Municipality
        {
            get
            {
                return this._Municipality;
            }
            set
            {
                this.OnMunicipalityChanging(value);
                this.ReportPropertyChanging("Municipality");
                this._Municipality = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Municipality");
                this.OnMunicipalityChanged();
            }
        }
        private string _Municipality;
        partial void OnMunicipalityChanging(string value);
        partial void OnMunicipalityChanged();
        /// <summary>
        /// There are no comments for Property PostCode in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string PostCode
        {
            get
            {
                return this._PostCode;
            }
            set
            {
                this.OnPostCodeChanging(value);
                this.ReportPropertyChanging("PostCode");
                this._PostCode = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("PostCode");
                this.OnPostCodeChanged();
            }
        }
        private string _PostCode;
        partial void OnPostCodeChanging(string value);
        partial void OnPostCodeChanged();
        /// <summary>
        /// There are no comments for Property ContactPhone in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactPhone
        {
            get
            {
                return this._ContactPhone;
            }
            set
            {
                this.OnContactPhoneChanging(value);
                this.ReportPropertyChanging("ContactPhone");
                this._ContactPhone = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("ContactPhone");
                this.OnContactPhoneChanged();
            }
        }
        private string _ContactPhone;
        partial void OnContactPhoneChanging(string value);
        partial void OnContactPhoneChanged();
        /// <summary>
        /// There are no comments for Property CoordX in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<decimal> CoordX
        {
            get
            {
                return this._CoordX;
            }
            set
            {
                this.OnCoordXChanging(value);
                this.ReportPropertyChanging("CoordX");
                this._CoordX = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("CoordX");
                this.OnCoordXChanged();
            }
        }
        private global::System.Nullable<decimal> _CoordX;
        partial void OnCoordXChanging(global::System.Nullable<decimal> value);
        partial void OnCoordXChanged();
        /// <summary>
        /// There are no comments for Property CoordY in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<decimal> CoordY
        {
            get
            {
                return this._CoordY;
            }
            set
            {
                this.OnCoordYChanging(value);
                this.ReportPropertyChanging("CoordY");
                this._CoordY = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("CoordY");
                this.OnCoordYChanged();
            }
        }
        private global::System.Nullable<decimal> _CoordY;
        partial void OnCoordYChanging(global::System.Nullable<decimal> value);
        partial void OnCoordYChanged();
    }
    /// <summary>
    /// There are no comments for Maps.v3.Model.poi_category in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AutoCategId
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="Maps.v3.Model", Name="poi_category")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class poi_category : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new poi_category object.
        /// </summary>
        /// <param name="autoCategId">Initial value of AutoCategId.</param>
        /// <param name="categId">Initial value of CategId.</param>
        /// <param name="categName">Initial value of CategName.</param>
        public static poi_category Createpoi_category(int autoCategId, int categId, string categName)
        {
            poi_category poi_category = new poi_category();
            poi_category.AutoCategId = autoCategId;
            poi_category.CategId = categId;
            poi_category.CategName = categName;
            return poi_category;
        }
        /// <summary>
        /// There are no comments for Property AutoCategId in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int AutoCategId
        {
            get
            {
                return this._AutoCategId;
            }
            set
            {
                this.OnAutoCategIdChanging(value);
                this.ReportPropertyChanging("AutoCategId");
                this._AutoCategId = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("AutoCategId");
                this.OnAutoCategIdChanged();
            }
        }
        private int _AutoCategId;
        partial void OnAutoCategIdChanging(int value);
        partial void OnAutoCategIdChanged();
        /// <summary>
        /// There are no comments for Property CategId in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int CategId
        {
            get
            {
                return this._CategId;
            }
            set
            {
                this.OnCategIdChanging(value);
                this.ReportPropertyChanging("CategId");
                this._CategId = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("CategId");
                this.OnCategIdChanged();
            }
        }
        private int _CategId;
        partial void OnCategIdChanging(int value);
        partial void OnCategIdChanged();
        /// <summary>
        /// There are no comments for Property CategName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string CategName
        {
            get
            {
                return this._CategName;
            }
            set
            {
                this.OnCategNameChanging(value);
                this.ReportPropertyChanging("CategName");
                this._CategName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("CategName");
                this.OnCategNameChanged();
            }
        }
        private string _CategName;
        partial void OnCategNameChanging(string value);
        partial void OnCategNameChanged();
    }
}
