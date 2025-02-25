using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// AuditQueryRequest
    /// </summary>
    [DataContract]
    public partial class AuditQueryRequest :  IEquatable<AuditQueryRequest>
    {
        /// <summary>
        /// Name of the service to query audits for.
        /// </summary>
        /// <value>Name of the service to query audits for.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ServiceNameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Analyticsreporting for "AnalyticsReporting"
            /// </summary>
            [EnumMember(Value = "AnalyticsReporting")]
            Analyticsreporting,
            
            /// <summary>
            /// Enum Architect for "Architect"
            /// </summary>
            [EnumMember(Value = "Architect")]
            Architect,
            
            /// <summary>
            /// Enum Coaching for "Coaching"
            /// </summary>
            [EnumMember(Value = "Coaching")]
            Coaching,
            
            /// <summary>
            /// Enum Contactcenter for "ContactCenter"
            /// </summary>
            [EnumMember(Value = "ContactCenter")]
            Contactcenter,
            
            /// <summary>
            /// Enum Contentmanagement for "ContentManagement"
            /// </summary>
            [EnumMember(Value = "ContentManagement")]
            Contentmanagement,
            
            /// <summary>
            /// Enum Datatables for "Datatables"
            /// </summary>
            [EnumMember(Value = "Datatables")]
            Datatables,
            
            /// <summary>
            /// Enum Directory for "Directory"
            /// </summary>
            [EnumMember(Value = "Directory")]
            Directory,
            
            /// <summary>
            /// Enum Dynamicschema for "DynamicSchema"
            /// </summary>
            [EnumMember(Value = "DynamicSchema")]
            Dynamicschema,
            
            /// <summary>
            /// Enum Gamification for "Gamification"
            /// </summary>
            [EnumMember(Value = "Gamification")]
            Gamification,
            
            /// <summary>
            /// Enum Groups for "Groups"
            /// </summary>
            [EnumMember(Value = "Groups")]
            Groups,
            
            /// <summary>
            /// Enum Integrations for "Integrations"
            /// </summary>
            [EnumMember(Value = "Integrations")]
            Integrations,
            
            /// <summary>
            /// Enum Knowledge for "Knowledge"
            /// </summary>
            [EnumMember(Value = "Knowledge")]
            Knowledge,
            
            /// <summary>
            /// Enum Languageunderstanding for "LanguageUnderstanding"
            /// </summary>
            [EnumMember(Value = "LanguageUnderstanding")]
            Languageunderstanding,
            
            /// <summary>
            /// Enum Learning for "Learning"
            /// </summary>
            [EnumMember(Value = "Learning")]
            Learning,
            
            /// <summary>
            /// Enum Limits for "Limits"
            /// </summary>
            [EnumMember(Value = "Limits")]
            Limits,
            
            /// <summary>
            /// Enum Outbound for "Outbound"
            /// </summary>
            [EnumMember(Value = "Outbound")]
            Outbound,
            
            /// <summary>
            /// Enum Peoplepermissions for "PeoplePermissions"
            /// </summary>
            [EnumMember(Value = "PeoplePermissions")]
            Peoplepermissions,
            
            /// <summary>
            /// Enum Employeeperformance for "EmployeePerformance"
            /// </summary>
            [EnumMember(Value = "EmployeePerformance")]
            Employeeperformance,
            
            /// <summary>
            /// Enum Predictiveengagement for "PredictiveEngagement"
            /// </summary>
            [EnumMember(Value = "PredictiveEngagement")]
            Predictiveengagement,
            
            /// <summary>
            /// Enum Presence for "Presence"
            /// </summary>
            [EnumMember(Value = "Presence")]
            Presence,
            
            /// <summary>
            /// Enum Quality for "Quality"
            /// </summary>
            [EnumMember(Value = "Quality")]
            Quality,
            
            /// <summary>
            /// Enum Responsemanagement for "ResponseManagement"
            /// </summary>
            [EnumMember(Value = "ResponseManagement")]
            Responsemanagement,
            
            /// <summary>
            /// Enum Routing for "Routing"
            /// </summary>
            [EnumMember(Value = "Routing")]
            Routing,
            
            /// <summary>
            /// Enum Speechandtextanalytics for "SpeechAndTextAnalytics"
            /// </summary>
            [EnumMember(Value = "SpeechAndTextAnalytics")]
            Speechandtextanalytics,
            
            /// <summary>
            /// Enum Telephony for "Telephony"
            /// </summary>
            [EnumMember(Value = "Telephony")]
            Telephony,
            
            /// <summary>
            /// Enum Topicsdefinitions for "TopicsDefinitions"
            /// </summary>
            [EnumMember(Value = "TopicsDefinitions")]
            Topicsdefinitions,
            
            /// <summary>
            /// Enum Triggers for "Triggers"
            /// </summary>
            [EnumMember(Value = "Triggers")]
            Triggers,
            
            /// <summary>
            /// Enum Processautomation for "ProcessAutomation"
            /// </summary>
            [EnumMember(Value = "ProcessAutomation")]
            Processautomation,
            
            /// <summary>
            /// Enum Voicemail for "Voicemail"
            /// </summary>
            [EnumMember(Value = "Voicemail")]
            Voicemail,
            
            /// <summary>
            /// Enum Webdeployments for "WebDeployments"
            /// </summary>
            [EnumMember(Value = "WebDeployments")]
            Webdeployments,
            
            /// <summary>
            /// Enum Webhooks for "Webhooks"
            /// </summary>
            [EnumMember(Value = "Webhooks")]
            Webhooks,
            
            /// <summary>
            /// Enum Workforcemanagement for "WorkforceManagement"
            /// </summary>
            [EnumMember(Value = "WorkforceManagement")]
            Workforcemanagement,
            
            /// <summary>
            /// Enum Messaging for "Messaging"
            /// </summary>
            [EnumMember(Value = "Messaging")]
            Messaging,
            
            /// <summary>
            /// Enum Supportability for "Supportability"
            /// </summary>
            [EnumMember(Value = "Supportability")]
            Supportability,
            
            /// <summary>
            /// Enum Callback for "Callback"
            /// </summary>
            [EnumMember(Value = "Callback")]
            Callback,
            
            /// <summary>
            /// Enum Workitems for "Workitems"
            /// </summary>
            [EnumMember(Value = "Workitems")]
            Workitems,
            
            /// <summary>
            /// Enum Scim for "SCIM"
            /// </summary>
            [EnumMember(Value = "SCIM")]
            Scim,
            
            /// <summary>
            /// Enum Numberpurchasing for "NumberPurchasing"
            /// </summary>
            [EnumMember(Value = "NumberPurchasing")]
            Numberpurchasing,
            
            /// <summary>
            /// Enum Marketplace for "Marketplace"
            /// </summary>
            [EnumMember(Value = "Marketplace")]
            Marketplace
        }
        /// <summary>
        /// Name of the service to query audits for.
        /// </summary>
        /// <value>Name of the service to query audits for.</value>
        [DataMember(Name="serviceName", EmitDefaultValue=false)]
        public ServiceNameEnum? ServiceName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditQueryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditQueryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditQueryRequest" /> class.
        /// </summary>
        /// <param name="Interval">Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ssZ/YYYY-MM-DDThh:mm:ssZ (required).</param>
        /// <param name="ServiceName">Name of the service to query audits for. (required).</param>
        /// <param name="Filters">Additional filters for the query..</param>
        /// <param name="Sort">Sort parameter for the query..</param>
        public AuditQueryRequest(string Interval = null, ServiceNameEnum? ServiceName = null, List<AuditQueryFilter> Filters = null, List<AuditQuerySort> Sort = null)
        {
            this.Interval = Interval;
            this.ServiceName = ServiceName;
            this.Filters = Filters;
            this.Sort = Sort;
            
        }
        


        /// <summary>
        /// Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ssZ/YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        /// <value>Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ssZ/YYYY-MM-DDThh:mm:ssZ</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }





        /// <summary>
        /// Additional filters for the query.
        /// </summary>
        /// <value>Additional filters for the query.</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<AuditQueryFilter> Filters { get; set; }



        /// <summary>
        /// Sort parameter for the query.
        /// </summary>
        /// <value>Sort parameter for the query.</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<AuditQuerySort> Sort { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditQueryRequest {\n");

            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AuditQueryRequest);
        }

        /// <summary>
        /// Returns true if AuditQueryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditQueryRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.ServiceName == other.ServiceName ||
                    this.ServiceName != null &&
                    this.ServiceName.Equals(other.ServiceName)
                ) &&
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
                ) &&
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.SequenceEqual(other.Sort)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();

                if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();

                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();

                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();

                return hash;
            }
        }
    }

}
