//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Microsoft.CloudForFSI.Tables
{
    using Microsoft.CloudForFSI.OptionSets;

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum msfsi_applicationState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msfsi_application")]
    public partial class msfsi_application : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public msfsi_application() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "msfsi_application";

        public const string EntitySchemaName = "msfsi_application";

        public const string PrimaryIdAttribute = "msfsi_applicationid";

        public const string PrimaryNameAttribute = "msfsi_name";

        public const string EntityLogicalCollectionName = "msfsi_applications";

        public const string EntitySetName = "msfsi_applications";

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        [System.Diagnostics.DebuggerNonUserCode()]
        private void OnPropertyChanged(string propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        private void OnPropertyChanging(string propertyName)
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
            }
        }

        /// <summary>
        /// Date and time when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CreatedOnBehalfBy");
                this.SetAttributeValue("createdonbehalfby", value);
                this.OnPropertyChanged("CreatedOnBehalfBy");
            }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the entity with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
            }
        }

        /// <summary>
        /// Sequence number of the import that created this record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ImportSequenceNumber");
                this.SetAttributeValue("importsequencenumber", value);
                this.OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        /// Unique identifier of the user who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
            }
        }

        /// <summary>
        /// Date and time when the record was modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ModifiedOnBehalfBy");
                this.SetAttributeValue("modifiedonbehalfby", value);
                this.OnPropertyChanged("ModifiedOnBehalfBy");
            }
        }

        /// <summary>
        /// Placeholder for onboarding application app
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_applicantlistplaceholder")]
        public string msfsi_applicantlistplaceholder
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("msfsi_applicantlistplaceholder");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_applicantlistplaceholder");
                this.SetAttributeValue("msfsi_applicantlistplaceholder", value);
                this.OnPropertyChanged("msfsi_applicantlistplaceholder");
            }
        }

        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_applicationid")]
        public System.Nullable<System.Guid> msfsi_applicationId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("msfsi_applicationid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_applicationId");
                this.SetAttributeValue("msfsi_applicationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("msfsi_applicationId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_applicationid")]
        public override System.Guid Id
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return base.Id;
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.msfsi_applicationId = value;
            }
        }

        /// <summary>
        /// Optional additional comment about the archived application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_archivecomment")]
        public string msfsi_archivecomment
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("msfsi_archivecomment");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_archivecomment");
                this.SetAttributeValue("msfsi_archivecomment", value);
                this.OnPropertyChanged("msfsi_archivecomment");
            }
        }

        /// <summary>
        /// The date when the application was archived.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_archivedate")]
        public System.Nullable<System.DateTime> msfsi_archivedate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("msfsi_archivedate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_archivedate");
                this.SetAttributeValue("msfsi_archivedate", value);
                this.OnPropertyChanged("msfsi_archivedate");
            }
        }

        /// <summary>
        /// Indicates the reason for archiving an application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_archivereason")]
        public Microsoft.Xrm.Sdk.EntityReference msfsi_archivereason
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msfsi_archivereason");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_archivereason");
                this.SetAttributeValue("msfsi_archivereason", value);
                this.OnPropertyChanged("msfsi_archivereason");
            }
        }

        /// <summary>
        /// The category of the product being applied for.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_category")]
        public Microsoft.Xrm.Sdk.EntityReference msfsi_category
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msfsi_category");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_category");
                this.SetAttributeValue("msfsi_category", value);
                this.OnPropertyChanged("msfsi_category");
            }
        }

        /// <summary>
        /// The deposit amount of the account application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_depositamount")]
        public Microsoft.Xrm.Sdk.Money msfsi_depositamount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msfsi_depositamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_depositamount");
                this.SetAttributeValue("msfsi_depositamount", value);
                this.OnPropertyChanged("msfsi_depositamount");
            }
        }

        /// <summary>
        /// Value of the Deposit amount in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_depositamount_base")]
        public Microsoft.Xrm.Sdk.Money msfsi_depositamount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msfsi_depositamount_base");
            }
        }

        /// <summary>
        /// Description of the application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_description")]
        public string msfsi_description
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("msfsi_description");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_description");
                this.SetAttributeValue("msfsi_description", value);
                this.OnPropertyChanged("msfsi_description");
            }
        }

        /// <summary>
        /// The extended data table of the application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_detailsid")]
        public Microsoft.Xrm.Sdk.EntityReference msfsi_detailsid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msfsi_detailsid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_detailsid");
                this.SetAttributeValue("msfsi_detailsid", value);
                this.OnPropertyChanged("msfsi_detailsid");
            }
        }

        /// <summary>
        /// The interest rate of the account application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_interestrate")]
        public System.Nullable<decimal> msfsi_interestrate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("msfsi_interestrate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_interestrate");
                this.SetAttributeValue("msfsi_interestrate", value);
                this.OnPropertyChanged("msfsi_interestrate");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_loanterm")]
        public System.Nullable<int> msfsi_loanterm
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("msfsi_loanterm");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_loanterm");
                this.SetAttributeValue("msfsi_loanterm", value);
                this.OnPropertyChanged("msfsi_loanterm");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_name")]
        public string msfsi_Name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("msfsi_name");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_Name");
                this.SetAttributeValue("msfsi_name", value);
                this.OnPropertyChanged("msfsi_Name");
            }
        }

        /// <summary>
        /// The overdraft of the account application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_overdraftrate")]
        public System.Nullable<decimal> msfsi_overdraftrate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("msfsi_overdraftrate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_overdraftrate");
                this.SetAttributeValue("msfsi_overdraftrate", value);
                this.OnPropertyChanged("msfsi_overdraftrate");
            }
        }

        /// <summary>
        /// The primary application contact of the .
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_primaryapplicant")]
        public Microsoft.Xrm.Sdk.EntityReference msfsi_primaryapplicant
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msfsi_primaryapplicant");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_primaryapplicant");
                this.SetAttributeValue("msfsi_primaryapplicant", value);
                this.OnPropertyChanged("msfsi_primaryapplicant");
            }
        }

        /// <summary>
        /// A calculated field helping determine if a related party contract is the primary member of the application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_primarymemberhelper")]
        public string msfsi_primarymemberhelper
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("msfsi_primarymemberhelper");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_primarymemberhelper");
                this.SetAttributeValue("msfsi_primarymemberhelper", value);
                this.OnPropertyChanged("msfsi_primarymemberhelper");
            }
        }

        /// <summary>
        /// Amount of money borrowed for the loan.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_principalamount")]
        public Microsoft.Xrm.Sdk.Money msfsi_principalamount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msfsi_principalamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_principalamount");
                this.SetAttributeValue("msfsi_principalamount", value);
                this.OnPropertyChanged("msfsi_principalamount");
            }
        }

        /// <summary>
        /// Value of the Principal amount in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_principalamount_base")]
        public Microsoft.Xrm.Sdk.Money msfsi_principalamount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msfsi_principalamount_base");
            }
        }

        /// <summary>
        /// Placeholder for selected tasks group
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_selectedtasksgroupplaceholder")]
        public string msfsi_selectedtasksgroupplaceholder
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("msfsi_selectedtasksgroupplaceholder");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_selectedtasksgroupplaceholder");
                this.SetAttributeValue("msfsi_selectedtasksgroupplaceholder", value);
                this.OnPropertyChanged("msfsi_selectedtasksgroupplaceholder");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_textplaceholder")]
        public string msfsi_textplaceholder
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("msfsi_textplaceholder");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_textplaceholder");
                this.SetAttributeValue("msfsi_textplaceholder", value);
                this.OnPropertyChanged("msfsi_textplaceholder");
            }
        }

        /// <summary>
        /// Date and time that the record was migrated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OverriddenCreatedOn");
                this.SetAttributeValue("overriddencreatedon", value);
                this.OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        /// Owner Id
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwnerId");
                this.SetAttributeValue("ownerid", value);
                this.OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        /// Unique identifier for the business unit that owns the record
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
            }
        }

        /// <summary>
        /// Unique identifier for the team that owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
            }
        }

        /// <summary>
        /// Unique identifier for the user that owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
            }
        }

        /// <summary>
        /// Contains the id of the process associated with the entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public System.Nullable<System.Guid> processid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("processid");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("processid");
            }
        }

        /// <summary>
        /// Contains the id of the stage where the entity is located.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        public System.Nullable<System.Guid> stageid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("stageid");
                this.SetAttributeValue("stageid", value);
                this.OnPropertyChanged("stageid");
            }
        }

        /// <summary>
        /// Status of the Application
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Microsoft.CloudForFSI.Tables.msfsi_applicationState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Microsoft.CloudForFSI.Tables.msfsi_applicationState)(System.Enum.ToObject(typeof(Microsoft.CloudForFSI.Tables.msfsi_applicationState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StateCode");
                if ((value == null))
                {
                    this.SetAttributeValue("statecode", null);
                }
                else
                {
                    this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
                }
                this.OnPropertyChanged("StateCode");
            }
        }

        /// <summary>
        /// Reason for the status of the Application
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual msfsi_application_StatusCode? StatusCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((msfsi_application_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TimeZoneRuleVersionNumber");
                this.SetAttributeValue("timezoneruleversionnumber", value);
                this.OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TransactionCurrencyId");
                this.SetAttributeValue("transactioncurrencyid", value);
                this.OnPropertyChanged("TransactionCurrencyId");
            }
        }

        /// <summary>
        /// A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
        public string traversedpath
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("traversedpath");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("traversedpath");
                this.SetAttributeValue("traversedpath", value);
                this.OnPropertyChanged("traversedpath");
            }
        }

        /// <summary>
        /// Time zone code that was in use when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("UTCConversionTimeZoneCode");
                this.SetAttributeValue("utcconversiontimezonecode", value);
                this.OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        /// Version Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
            }
        }

        /// <summary>
        /// 1:N msfsi_msfsi_relatedpartycontract_application_msfsi_ap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msfsi_msfsi_relatedpartycontract_application_msfsi_ap")]
        public System.Collections.Generic.IEnumerable<Microsoft.CloudForFSI.Tables.msfsi_relatedpartycontract> msfsi_msfsi_relatedpartycontract_application_msfsi_ap
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Microsoft.CloudForFSI.Tables.msfsi_relatedpartycontract>("msfsi_msfsi_relatedpartycontract_application_msfsi_ap", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_msfsi_relatedpartycontract_application_msfsi_ap");
                this.SetRelatedEntities<Microsoft.CloudForFSI.Tables.msfsi_relatedpartycontract>("msfsi_msfsi_relatedpartycontract_application_msfsi_ap", null, value);
                this.OnPropertyChanged("msfsi_msfsi_relatedpartycontract_application_msfsi_ap");
            }
        }

        /// <summary>
        /// N:1 msfsi_msfsi_application_primaryapplicant_msfsi_appl
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_primaryapplicant")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msfsi_msfsi_application_primaryapplicant_msfsi_appl")]
        public Microsoft.CloudForFSI.Tables.msfsi_relatedpartycontract msfsi_msfsi_application_primaryapplicant_msfsi_appl
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Microsoft.CloudForFSI.Tables.msfsi_relatedpartycontract>("msfsi_msfsi_application_primaryapplicant_msfsi_appl", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msfsi_msfsi_application_primaryapplicant_msfsi_appl");
                this.SetRelatedEntity<Microsoft.CloudForFSI.Tables.msfsi_relatedpartycontract>("msfsi_msfsi_application_primaryapplicant_msfsi_appl", null, value);
                this.OnPropertyChanged("msfsi_msfsi_application_primaryapplicant_msfsi_appl");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public msfsi_application(object anonymousType) :
                this()
        {
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();

                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int)value);
                    name = name.Remove(name.Length - "enum".Length);
                }

                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["msfsi_applicationid"] = base.Id;
                        break;
                    case "msfsi_applicationid":
                        var id = (System.Nullable<System.Guid>)value;
                        if (id == null)
                        { continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
        }
    }
}