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
    /// CreateOutboundMessagingConversationRequest
    /// </summary>
    [DataContract]
    public partial class CreateOutboundMessagingConversationRequest :  IEquatable<CreateOutboundMessagingConversationRequest>
    {
        /// <summary>
        /// The messaging address messenger type.
        /// </summary>
        /// <value>The messaging address messenger type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ToAddressMessengerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sms for "sms"
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms
        }
        /// <summary>
        /// The messaging address messenger type.
        /// </summary>
        /// <value>The messaging address messenger type.</value>
        [DataMember(Name="toAddressMessengerType", EmitDefaultValue=false)]
        public ToAddressMessengerTypeEnum? ToAddressMessengerType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOutboundMessagingConversationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOutboundMessagingConversationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOutboundMessagingConversationRequest" /> class.
        /// </summary>
        /// <param name="QueueId">The ID of the queue to be associated with the message. This will determine the fromAddress of the message. (required).</param>
        /// <param name="ToAddress">The messaging address of the recipient of the message. For an SMS messenger type, the phone number address must be in E.164 format. E.g. +13175555555 or +34234234234 (required).</param>
        /// <param name="ToAddressMessengerType">The messaging address messenger type. (required).</param>
        /// <param name="UseExistingConversation">An override to use an existing conversation.  If set to true, an existing conversation will be used if there is one within the conversation window.  If set to false, create request fails if there is a conversation within the conversation window..</param>
        /// <param name="ExternalContactId">The external contact with which the message will be associated..</param>
        public CreateOutboundMessagingConversationRequest(string QueueId = null, string ToAddress = null, ToAddressMessengerTypeEnum? ToAddressMessengerType = null, bool? UseExistingConversation = null, string ExternalContactId = null)
        {
            this.QueueId = QueueId;
            this.ToAddress = ToAddress;
            this.ToAddressMessengerType = ToAddressMessengerType;
            this.UseExistingConversation = UseExistingConversation;
            this.ExternalContactId = ExternalContactId;
            
        }
        


        /// <summary>
        /// The ID of the queue to be associated with the message. This will determine the fromAddress of the message.
        /// </summary>
        /// <value>The ID of the queue to be associated with the message. This will determine the fromAddress of the message.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// The messaging address of the recipient of the message. For an SMS messenger type, the phone number address must be in E.164 format. E.g. +13175555555 or +34234234234
        /// </summary>
        /// <value>The messaging address of the recipient of the message. For an SMS messenger type, the phone number address must be in E.164 format. E.g. +13175555555 or +34234234234</value>
        [DataMember(Name="toAddress", EmitDefaultValue=false)]
        public string ToAddress { get; set; }





        /// <summary>
        /// An override to use an existing conversation.  If set to true, an existing conversation will be used if there is one within the conversation window.  If set to false, create request fails if there is a conversation within the conversation window.
        /// </summary>
        /// <value>An override to use an existing conversation.  If set to true, an existing conversation will be used if there is one within the conversation window.  If set to false, create request fails if there is a conversation within the conversation window.</value>
        [DataMember(Name="useExistingConversation", EmitDefaultValue=false)]
        public bool? UseExistingConversation { get; set; }



        /// <summary>
        /// The external contact with which the message will be associated.
        /// </summary>
        /// <value>The external contact with which the message will be associated.</value>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOutboundMessagingConversationRequest {\n");

            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  ToAddressMessengerType: ").Append(ToAddressMessengerType).Append("\n");
            sb.Append("  UseExistingConversation: ").Append(UseExistingConversation).Append("\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
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
            return this.Equals(obj as CreateOutboundMessagingConversationRequest);
        }

        /// <summary>
        /// Returns true if CreateOutboundMessagingConversationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateOutboundMessagingConversationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOutboundMessagingConversationRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.ToAddress == other.ToAddress ||
                    this.ToAddress != null &&
                    this.ToAddress.Equals(other.ToAddress)
                ) &&
                (
                    this.ToAddressMessengerType == other.ToAddressMessengerType ||
                    this.ToAddressMessengerType != null &&
                    this.ToAddressMessengerType.Equals(other.ToAddressMessengerType)
                ) &&
                (
                    this.UseExistingConversation == other.UseExistingConversation ||
                    this.UseExistingConversation != null &&
                    this.UseExistingConversation.Equals(other.UseExistingConversation)
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
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
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.ToAddress != null)
                    hash = hash * 59 + this.ToAddress.GetHashCode();

                if (this.ToAddressMessengerType != null)
                    hash = hash * 59 + this.ToAddressMessengerType.GetHashCode();

                if (this.UseExistingConversation != null)
                    hash = hash * 59 + this.UseExistingConversation.GetHashCode();

                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();

                return hash;
            }
        }
    }

}
