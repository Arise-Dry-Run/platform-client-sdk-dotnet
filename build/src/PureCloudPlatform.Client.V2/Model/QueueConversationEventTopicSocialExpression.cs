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
    /// QueueConversationEventTopicSocialExpression
    /// </summary>
    [DataContract]
    public partial class QueueConversationEventTopicSocialExpression :  IEquatable<QueueConversationEventTopicSocialExpression>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Alerting for "alerting"
            /// </summary>
            [EnumMember(Value = "alerting")]
            Alerting,
            
            /// <summary>
            /// Enum Dialing for "dialing"
            /// </summary>
            [EnumMember(Value = "dialing")]
            Dialing,
            
            /// <summary>
            /// Enum Contacting for "contacting"
            /// </summary>
            [EnumMember(Value = "contacting")]
            Contacting,
            
            /// <summary>
            /// Enum Offering for "offering"
            /// </summary>
            [EnumMember(Value = "offering")]
            Offering,
            
            /// <summary>
            /// Enum Connected for "connected"
            /// </summary>
            [EnumMember(Value = "connected")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "disconnected"
            /// </summary>
            [EnumMember(Value = "disconnected")]
            Disconnected,
            
            /// <summary>
            /// Enum Terminated for "terminated"
            /// </summary>
            [EnumMember(Value = "terminated")]
            Terminated,
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None
        }
        /// <summary>
        /// Gets or Sets InitialState
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum InitialStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Alerting for "alerting"
            /// </summary>
            [EnumMember(Value = "alerting")]
            Alerting,
            
            /// <summary>
            /// Enum Dialing for "dialing"
            /// </summary>
            [EnumMember(Value = "dialing")]
            Dialing,
            
            /// <summary>
            /// Enum Contacting for "contacting"
            /// </summary>
            [EnumMember(Value = "contacting")]
            Contacting,
            
            /// <summary>
            /// Enum Offering for "offering"
            /// </summary>
            [EnumMember(Value = "offering")]
            Offering,
            
            /// <summary>
            /// Enum Connected for "connected"
            /// </summary>
            [EnumMember(Value = "connected")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "disconnected"
            /// </summary>
            [EnumMember(Value = "disconnected")]
            Disconnected,
            
            /// <summary>
            /// Enum Terminated for "terminated"
            /// </summary>
            [EnumMember(Value = "terminated")]
            Terminated,
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None
        }
        /// <summary>
        /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
        /// </summary>
        /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DisconnectTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Endpoint for "endpoint"
            /// </summary>
            [EnumMember(Value = "endpoint")]
            Endpoint,
            
            /// <summary>
            /// Enum Client for "client"
            /// </summary>
            [EnumMember(Value = "client")]
            Client,
            
            /// <summary>
            /// Enum System for "system"
            /// </summary>
            [EnumMember(Value = "system")]
            System,
            
            /// <summary>
            /// Enum Timeout for "timeout"
            /// </summary>
            [EnumMember(Value = "timeout")]
            Timeout,
            
            /// <summary>
            /// Enum Transfer for "transfer"
            /// </summary>
            [EnumMember(Value = "transfer")]
            Transfer,
            
            /// <summary>
            /// Enum Transferconference for "transfer.conference"
            /// </summary>
            [EnumMember(Value = "transfer.conference")]
            Transferconference,
            
            /// <summary>
            /// Enum Transferconsult for "transfer.consult"
            /// </summary>
            [EnumMember(Value = "transfer.consult")]
            Transferconsult,
            
            /// <summary>
            /// Enum Transferforward for "transfer.forward"
            /// </summary>
            [EnumMember(Value = "transfer.forward")]
            Transferforward,
            
            /// <summary>
            /// Enum Transfernoanswer for "transfer.noanswer"
            /// </summary>
            [EnumMember(Value = "transfer.noanswer")]
            Transfernoanswer,
            
            /// <summary>
            /// Enum Transfernotavailable for "transfer.notavailable"
            /// </summary>
            [EnumMember(Value = "transfer.notavailable")]
            Transfernotavailable,
            
            /// <summary>
            /// Enum Transportfailure for "transport.failure"
            /// </summary>
            [EnumMember(Value = "transport.failure")]
            Transportfailure,
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error,
            
            /// <summary>
            /// Enum Peer for "peer"
            /// </summary>
            [EnumMember(Value = "peer")]
            Peer,
            
            /// <summary>
            /// Enum Other for "other"
            /// </summary>
            [EnumMember(Value = "other")]
            Other,
            
            /// <summary>
            /// Enum Spam for "spam"
            /// </summary>
            [EnumMember(Value = "spam")]
            Spam,
            
            /// <summary>
            /// Enum Uncallable for "uncallable"
            /// </summary>
            [EnumMember(Value = "uncallable")]
            Uncallable
        }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Gets or Sets InitialState
        /// </summary>
        [DataMember(Name="initialState", EmitDefaultValue=false)]
        public InitialStateEnum? InitialState { get; set; }
        /// <summary>
        /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
        /// </summary>
        /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationEventTopicSocialExpression" /> class.
        /// </summary>
        /// <param name="State">State.</param>
        /// <param name="InitialState">InitialState.</param>
        /// <param name="Id">A globally unique identifier for this communication..</param>
        /// <param name="SocialMediaId">A globally unique identifier for the social media..</param>
        /// <param name="SocialMediaHub">The social network of the communication.</param>
        /// <param name="SocialUserName">The social media user name of the communication.</param>
        /// <param name="PreviewText">The text preview of the communication contents.</param>
        /// <param name="RecordingId">A globally unique identifier for the recording associated with this chat..</param>
        /// <param name="Held">True if this call is held and the person on this side hears silence..</param>
        /// <param name="Provider">The source provider of the social expression..</param>
        /// <param name="ScriptId">The UUID of the script to use..</param>
        /// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
        /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
        /// <param name="StartHoldTime">The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold..</param>
        /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock..</param>
        /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock..</param>
        /// <param name="Wrapup">Call wrap up or disposition data..</param>
        /// <param name="AfterCallWork">A communication's after-call work data..</param>
        /// <param name="AfterCallWorkRequired">Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested..</param>
        public QueueConversationEventTopicSocialExpression(StateEnum? State = null, InitialStateEnum? InitialState = null, string Id = null, string SocialMediaId = null, string SocialMediaHub = null, string SocialUserName = null, string PreviewText = null, string RecordingId = null, bool? Held = null, string Provider = null, string ScriptId = null, string PeerId = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, QueueConversationEventTopicWrapup Wrapup = null, QueueConversationEventTopicAfterCallWork AfterCallWork = null, bool? AfterCallWorkRequired = null)
        {
            this.State = State;
            this.InitialState = InitialState;
            this.Id = Id;
            this.SocialMediaId = SocialMediaId;
            this.SocialMediaHub = SocialMediaHub;
            this.SocialUserName = SocialUserName;
            this.PreviewText = PreviewText;
            this.RecordingId = RecordingId;
            this.Held = Held;
            this.Provider = Provider;
            this.ScriptId = ScriptId;
            this.PeerId = PeerId;
            this.DisconnectType = DisconnectType;
            this.StartHoldTime = StartHoldTime;
            this.ConnectedTime = ConnectedTime;
            this.DisconnectedTime = DisconnectedTime;
            this.Wrapup = Wrapup;
            this.AfterCallWork = AfterCallWork;
            this.AfterCallWorkRequired = AfterCallWorkRequired;
            
        }
        






        /// <summary>
        /// A globally unique identifier for this communication.
        /// </summary>
        /// <value>A globally unique identifier for this communication.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// A globally unique identifier for the social media.
        /// </summary>
        /// <value>A globally unique identifier for the social media.</value>
        [DataMember(Name="socialMediaId", EmitDefaultValue=false)]
        public string SocialMediaId { get; set; }



        /// <summary>
        /// The social network of the communication
        /// </summary>
        /// <value>The social network of the communication</value>
        [DataMember(Name="socialMediaHub", EmitDefaultValue=false)]
        public string SocialMediaHub { get; set; }



        /// <summary>
        /// The social media user name of the communication
        /// </summary>
        /// <value>The social media user name of the communication</value>
        [DataMember(Name="socialUserName", EmitDefaultValue=false)]
        public string SocialUserName { get; set; }



        /// <summary>
        /// The text preview of the communication contents
        /// </summary>
        /// <value>The text preview of the communication contents</value>
        [DataMember(Name="previewText", EmitDefaultValue=false)]
        public string PreviewText { get; set; }



        /// <summary>
        /// A globally unique identifier for the recording associated with this chat.
        /// </summary>
        /// <value>A globally unique identifier for the recording associated with this chat.</value>
        [DataMember(Name="recordingId", EmitDefaultValue=false)]
        public string RecordingId { get; set; }



        /// <summary>
        /// True if this call is held and the person on this side hears silence.
        /// </summary>
        /// <value>True if this call is held and the person on this side hears silence.</value>
        [DataMember(Name="held", EmitDefaultValue=false)]
        public bool? Held { get; set; }



        /// <summary>
        /// The source provider of the social expression.
        /// </summary>
        /// <value>The source provider of the social expression.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }



        /// <summary>
        /// The UUID of the script to use.
        /// </summary>
        /// <value>The UUID of the script to use.</value>
        [DataMember(Name="scriptId", EmitDefaultValue=false)]
        public string ScriptId { get; set; }



        /// <summary>
        /// The id of the peer communication corresponding to a matching leg for this communication.
        /// </summary>
        /// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
        [DataMember(Name="peerId", EmitDefaultValue=false)]
        public string PeerId { get; set; }





        /// <summary>
        /// The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold.
        /// </summary>
        /// <value>The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold.</value>
        [DataMember(Name="startHoldTime", EmitDefaultValue=false)]
        public DateTime? StartHoldTime { get; set; }



        /// <summary>
        /// The timestamp when this communication was connected in the cloud clock.
        /// </summary>
        /// <value>The timestamp when this communication was connected in the cloud clock.</value>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }



        /// <summary>
        /// The timestamp when this communication disconnected from the conversation in the provider clock.
        /// </summary>
        /// <value>The timestamp when this communication disconnected from the conversation in the provider clock.</value>
        [DataMember(Name="disconnectedTime", EmitDefaultValue=false)]
        public DateTime? DisconnectedTime { get; set; }



        /// <summary>
        /// Call wrap up or disposition data.
        /// </summary>
        /// <value>Call wrap up or disposition data.</value>
        [DataMember(Name="wrapup", EmitDefaultValue=false)]
        public QueueConversationEventTopicWrapup Wrapup { get; set; }



        /// <summary>
        /// A communication's after-call work data.
        /// </summary>
        /// <value>A communication's after-call work data.</value>
        [DataMember(Name="afterCallWork", EmitDefaultValue=false)]
        public QueueConversationEventTopicAfterCallWork AfterCallWork { get; set; }



        /// <summary>
        /// Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.
        /// </summary>
        /// <value>Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
        [DataMember(Name="afterCallWorkRequired", EmitDefaultValue=false)]
        public bool? AfterCallWorkRequired { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationEventTopicSocialExpression {\n");

            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  InitialState: ").Append(InitialState).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SocialMediaId: ").Append(SocialMediaId).Append("\n");
            sb.Append("  SocialMediaHub: ").Append(SocialMediaHub).Append("\n");
            sb.Append("  SocialUserName: ").Append(SocialUserName).Append("\n");
            sb.Append("  PreviewText: ").Append(PreviewText).Append("\n");
            sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
            sb.Append("  Held: ").Append(Held).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  PeerId: ").Append(PeerId).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
            sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
            sb.Append("  AfterCallWork: ").Append(AfterCallWork).Append("\n");
            sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
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
            return this.Equals(obj as QueueConversationEventTopicSocialExpression);
        }

        /// <summary>
        /// Returns true if QueueConversationEventTopicSocialExpression instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationEventTopicSocialExpression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationEventTopicSocialExpression other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.InitialState == other.InitialState ||
                    this.InitialState != null &&
                    this.InitialState.Equals(other.InitialState)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.SocialMediaId == other.SocialMediaId ||
                    this.SocialMediaId != null &&
                    this.SocialMediaId.Equals(other.SocialMediaId)
                ) &&
                (
                    this.SocialMediaHub == other.SocialMediaHub ||
                    this.SocialMediaHub != null &&
                    this.SocialMediaHub.Equals(other.SocialMediaHub)
                ) &&
                (
                    this.SocialUserName == other.SocialUserName ||
                    this.SocialUserName != null &&
                    this.SocialUserName.Equals(other.SocialUserName)
                ) &&
                (
                    this.PreviewText == other.PreviewText ||
                    this.PreviewText != null &&
                    this.PreviewText.Equals(other.PreviewText)
                ) &&
                (
                    this.RecordingId == other.RecordingId ||
                    this.RecordingId != null &&
                    this.RecordingId.Equals(other.RecordingId)
                ) &&
                (
                    this.Held == other.Held ||
                    this.Held != null &&
                    this.Held.Equals(other.Held)
                ) &&
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) &&
                (
                    this.ScriptId == other.ScriptId ||
                    this.ScriptId != null &&
                    this.ScriptId.Equals(other.ScriptId)
                ) &&
                (
                    this.PeerId == other.PeerId ||
                    this.PeerId != null &&
                    this.PeerId.Equals(other.PeerId)
                ) &&
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.StartHoldTime == other.StartHoldTime ||
                    this.StartHoldTime != null &&
                    this.StartHoldTime.Equals(other.StartHoldTime)
                ) &&
                (
                    this.ConnectedTime == other.ConnectedTime ||
                    this.ConnectedTime != null &&
                    this.ConnectedTime.Equals(other.ConnectedTime)
                ) &&
                (
                    this.DisconnectedTime == other.DisconnectedTime ||
                    this.DisconnectedTime != null &&
                    this.DisconnectedTime.Equals(other.DisconnectedTime)
                ) &&
                (
                    this.Wrapup == other.Wrapup ||
                    this.Wrapup != null &&
                    this.Wrapup.Equals(other.Wrapup)
                ) &&
                (
                    this.AfterCallWork == other.AfterCallWork ||
                    this.AfterCallWork != null &&
                    this.AfterCallWork.Equals(other.AfterCallWork)
                ) &&
                (
                    this.AfterCallWorkRequired == other.AfterCallWorkRequired ||
                    this.AfterCallWorkRequired != null &&
                    this.AfterCallWorkRequired.Equals(other.AfterCallWorkRequired)
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
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.InitialState != null)
                    hash = hash * 59 + this.InitialState.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.SocialMediaId != null)
                    hash = hash * 59 + this.SocialMediaId.GetHashCode();

                if (this.SocialMediaHub != null)
                    hash = hash * 59 + this.SocialMediaHub.GetHashCode();

                if (this.SocialUserName != null)
                    hash = hash * 59 + this.SocialUserName.GetHashCode();

                if (this.PreviewText != null)
                    hash = hash * 59 + this.PreviewText.GetHashCode();

                if (this.RecordingId != null)
                    hash = hash * 59 + this.RecordingId.GetHashCode();

                if (this.Held != null)
                    hash = hash * 59 + this.Held.GetHashCode();

                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();

                if (this.ScriptId != null)
                    hash = hash * 59 + this.ScriptId.GetHashCode();

                if (this.PeerId != null)
                    hash = hash * 59 + this.PeerId.GetHashCode();

                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();

                if (this.StartHoldTime != null)
                    hash = hash * 59 + this.StartHoldTime.GetHashCode();

                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();

                if (this.DisconnectedTime != null)
                    hash = hash * 59 + this.DisconnectedTime.GetHashCode();

                if (this.Wrapup != null)
                    hash = hash * 59 + this.Wrapup.GetHashCode();

                if (this.AfterCallWork != null)
                    hash = hash * 59 + this.AfterCallWork.GetHashCode();

                if (this.AfterCallWorkRequired != null)
                    hash = hash * 59 + this.AfterCallWorkRequired.GetHashCode();

                return hash;
            }
        }
    }

}
