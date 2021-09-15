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
    /// ReportingTurnAction
    /// </summary>
    [DataContract]
    public partial class ReportingTurnAction :  IEquatable<ReportingTurnAction>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ActionType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Askfornluintentaction for "AskForNLUIntentAction"
            /// </summary>
            [EnumMember(Value = "AskForNLUIntentAction")]
            Askfornluintentaction,
            
            /// <summary>
            /// Enum Askforbooleanaction for "AskForBooleanAction"
            /// </summary>
            [EnumMember(Value = "AskForBooleanAction")]
            Askforbooleanaction,
            
            /// <summary>
            /// Enum Askforslotaction for "AskForSlotAction"
            /// </summary>
            [EnumMember(Value = "AskForSlotAction")]
            Askforslotaction,
            
            /// <summary>
            /// Enum Askfornlunextintentaction for "AskForNLUNextIntentAction"
            /// </summary>
            [EnumMember(Value = "AskForNLUNextIntentAction")]
            Askfornlunextintentaction,
            
            /// <summary>
            /// Enum Botstate for "BotState"
            /// </summary>
            [EnumMember(Value = "BotState")]
            Botstate,
            
            /// <summary>
            /// Enum Disconnectaction for "DisconnectAction"
            /// </summary>
            [EnumMember(Value = "DisconnectAction")]
            Disconnectaction,
            
            /// <summary>
            /// Enum Exitbotflowaction for "ExitBotFlowAction"
            /// </summary>
            [EnumMember(Value = "ExitBotFlowAction")]
            Exitbotflowaction,
            
            /// <summary>
            /// Enum Calltaskaction for "CallTaskAction"
            /// </summary>
            [EnumMember(Value = "CallTaskAction")]
            Calltaskaction,
            
            /// <summary>
            /// Enum Endtaskaction for "EndTaskAction"
            /// </summary>
            [EnumMember(Value = "EndTaskAction")]
            Endtaskaction,
            
            /// <summary>
            /// Enum Updatevariableaction for "UpdateVariableAction"
            /// </summary>
            [EnumMember(Value = "UpdateVariableAction")]
            Updatevariableaction,
            
            /// <summary>
            /// Enum Communicateaction for "CommunicateAction"
            /// </summary>
            [EnumMember(Value = "CommunicateAction")]
            Communicateaction,
            
            /// <summary>
            /// Enum Decisionaction for "DecisionAction"
            /// </summary>
            [EnumMember(Value = "DecisionAction")]
            Decisionaction,
            
            /// <summary>
            /// Enum Switchaction for "SwitchAction"
            /// </summary>
            [EnumMember(Value = "SwitchAction")]
            Switchaction,
            
            /// <summary>
            /// Enum Dataaction for "DataAction"
            /// </summary>
            [EnumMember(Value = "DataAction")]
            Dataaction,
            
            /// <summary>
            /// Enum Datatablelookupaction for "DataTableLookupAction"
            /// </summary>
            [EnumMember(Value = "DataTableLookupAction")]
            Datatablelookupaction,
            
            /// <summary>
            /// Enum Getexternalcontactaction for "GetExternalContactAction"
            /// </summary>
            [EnumMember(Value = "GetExternalContactAction")]
            Getexternalcontactaction,
            
            /// <summary>
            /// Enum Getexternalorganizationaction for "GetExternalOrganizationAction"
            /// </summary>
            [EnumMember(Value = "GetExternalOrganizationAction")]
            Getexternalorganizationaction,
            
            /// <summary>
            /// Enum Loopaction for "LoopAction"
            /// </summary>
            [EnumMember(Value = "LoopAction")]
            Loopaction,
            
            /// <summary>
            /// Enum Exitloopaction for "ExitLoopAction"
            /// </summary>
            [EnumMember(Value = "ExitLoopAction")]
            Exitloopaction,
            
            /// <summary>
            /// Enum Nextloopaction for "NextLoopAction"
            /// </summary>
            [EnumMember(Value = "NextLoopAction")]
            Nextloopaction,
            
            /// <summary>
            /// Enum Loopuntilaction for "LoopUntilAction"
            /// </summary>
            [EnumMember(Value = "LoopUntilAction")]
            Loopuntilaction,
            
            /// <summary>
            /// Enum Setactiveintentaction for "SetActiveIntentAction"
            /// </summary>
            [EnumMember(Value = "SetActiveIntentAction")]
            Setactiveintentaction,
            
            /// <summary>
            /// Enum Clearslotaction for "ClearSlotAction"
            /// </summary>
            [EnumMember(Value = "ClearSlotAction")]
            Clearslotaction,
            
            /// <summary>
            /// Enum Setflowoutcomeaction for "SetFlowOutcomeAction"
            /// </summary>
            [EnumMember(Value = "SetFlowOutcomeAction")]
            Setflowoutcomeaction,
            
            /// <summary>
            /// Enum Initializeflowoutcomeaction for "InitializeFlowOutcomeAction"
            /// </summary>
            [EnumMember(Value = "InitializeFlowOutcomeAction")]
            Initializeflowoutcomeaction,
            
            /// <summary>
            /// Enum Addflowmilestoneaction for "AddFlowMilestoneAction"
            /// </summary>
            [EnumMember(Value = "AddFlowMilestoneAction")]
            Addflowmilestoneaction,
            
            /// <summary>
            /// Enum Askforstringaction for "AskForStringAction"
            /// </summary>
            [EnumMember(Value = "AskForStringAction")]
            Askforstringaction,
            
            /// <summary>
            /// Enum Sendresponseaction for "SendResponseAction"
            /// </summary>
            [EnumMember(Value = "SendResponseAction")]
            Sendresponseaction,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ActionType
        /// </summary>
        [DataMember(Name="actionType", EmitDefaultValue=false)]
        public ActionTypeEnum? ActionType { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingTurnAction" /> class.
        /// </summary>
        /// <param name="ActionId">The ID of the action in the bot flow..</param>
        /// <param name="ActionName">The name of the action in the bot flow..</param>
        /// <param name="ActionNumber">The number of the action in the bot flow..</param>
        /// <param name="ActionType">ActionType.</param>
        public ReportingTurnAction(string ActionId = null, string ActionName = null, int? ActionNumber = null, ActionTypeEnum? ActionType = null)
        {
            this.ActionId = ActionId;
            this.ActionName = ActionName;
            this.ActionNumber = ActionNumber;
            this.ActionType = ActionType;
            
        }
        
        
        
        /// <summary>
        /// The ID of the action in the bot flow.
        /// </summary>
        /// <value>The ID of the action in the bot flow.</value>
        [DataMember(Name="actionId", EmitDefaultValue=false)]
        public string ActionId { get; set; }
        
        
        
        /// <summary>
        /// The name of the action in the bot flow.
        /// </summary>
        /// <value>The name of the action in the bot flow.</value>
        [DataMember(Name="actionName", EmitDefaultValue=false)]
        public string ActionName { get; set; }
        
        
        
        /// <summary>
        /// The number of the action in the bot flow.
        /// </summary>
        /// <value>The number of the action in the bot flow.</value>
        [DataMember(Name="actionNumber", EmitDefaultValue=false)]
        public int? ActionNumber { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingTurnAction {\n");
            
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
            sb.Append("  ActionName: ").Append(ActionName).Append("\n");
            sb.Append("  ActionNumber: ").Append(ActionNumber).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
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
            return this.Equals(obj as ReportingTurnAction);
        }

        /// <summary>
        /// Returns true if ReportingTurnAction instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingTurnAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingTurnAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActionId == other.ActionId ||
                    this.ActionId != null &&
                    this.ActionId.Equals(other.ActionId)
                ) &&
                (
                    this.ActionName == other.ActionName ||
                    this.ActionName != null &&
                    this.ActionName.Equals(other.ActionName)
                ) &&
                (
                    this.ActionNumber == other.ActionNumber ||
                    this.ActionNumber != null &&
                    this.ActionNumber.Equals(other.ActionNumber)
                ) &&
                (
                    this.ActionType == other.ActionType ||
                    this.ActionType != null &&
                    this.ActionType.Equals(other.ActionType)
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
                
                if (this.ActionId != null)
                    hash = hash * 59 + this.ActionId.GetHashCode();
                
                if (this.ActionName != null)
                    hash = hash * 59 + this.ActionName.GetHashCode();
                
                if (this.ActionNumber != null)
                    hash = hash * 59 + this.ActionNumber.GetHashCode();
                
                if (this.ActionType != null)
                    hash = hash * 59 + this.ActionType.GetHashCode();
                
                return hash;
            }
        }
    }

}
