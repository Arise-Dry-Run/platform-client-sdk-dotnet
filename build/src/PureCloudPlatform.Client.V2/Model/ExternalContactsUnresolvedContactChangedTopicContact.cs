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
    /// ExternalContactsUnresolvedContactChangedTopicContact
    /// </summary>
    [DataContract]
    public partial class ExternalContactsUnresolvedContactChangedTopicContact :  IEquatable<ExternalContactsUnresolvedContactChangedTopicContact>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ephemeral for "Ephemeral"
            /// </summary>
            [EnumMember(Value = "Ephemeral")]
            Ephemeral,
            
            /// <summary>
            /// Enum Identified for "Identified"
            /// </summary>
            [EnumMember(Value = "Identified")]
            Identified,
            
            /// <summary>
            /// Enum Curated for "Curated"
            /// </summary>
            [EnumMember(Value = "Curated")]
            Curated
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsUnresolvedContactChangedTopicContact" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Type">Type.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="MiddleName">MiddleName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="Salutation">Salutation.</param>
        /// <param name="Title">Title.</param>
        /// <param name="WorkPhone">WorkPhone.</param>
        /// <param name="CellPhone">CellPhone.</param>
        /// <param name="HomePhone">HomePhone.</param>
        /// <param name="OtherPhone">OtherPhone.</param>
        /// <param name="WorkEmail">WorkEmail.</param>
        /// <param name="PersonalEmail">PersonalEmail.</param>
        /// <param name="OtherEmail">OtherEmail.</param>
        /// <param name="Address">Address.</param>
        /// <param name="SurveyOptOut">SurveyOptOut.</param>
        /// <param name="ExternalSystemUrl">ExternalSystemUrl.</param>
        /// <param name="TwitterId">TwitterId.</param>
        /// <param name="LineId">LineId.</param>
        /// <param name="WhatsAppId">WhatsAppId.</param>
        /// <param name="FacebookId">FacebookId.</param>
        public ExternalContactsUnresolvedContactChangedTopicContact(string Id = null, TypeEnum? Type = null, string FirstName = null, string MiddleName = null, string LastName = null, string Salutation = null, string Title = null, ExternalContactsUnresolvedContactChangedTopicPhoneNumber WorkPhone = null, ExternalContactsUnresolvedContactChangedTopicPhoneNumber CellPhone = null, ExternalContactsUnresolvedContactChangedTopicPhoneNumber HomePhone = null, ExternalContactsUnresolvedContactChangedTopicPhoneNumber OtherPhone = null, string WorkEmail = null, string PersonalEmail = null, string OtherEmail = null, ExternalContactsUnresolvedContactChangedTopicContactAddress Address = null, bool? SurveyOptOut = null, string ExternalSystemUrl = null, ExternalContactsUnresolvedContactChangedTopicTwitterId TwitterId = null, ExternalContactsUnresolvedContactChangedTopicLineId LineId = null, ExternalContactsUnresolvedContactChangedTopicWhatsAppId WhatsAppId = null, ExternalContactsUnresolvedContactChangedTopicFacebookId FacebookId = null)
        {
            this.Id = Id;
            this.Type = Type;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Salutation = Salutation;
            this.Title = Title;
            this.WorkPhone = WorkPhone;
            this.CellPhone = CellPhone;
            this.HomePhone = HomePhone;
            this.OtherPhone = OtherPhone;
            this.WorkEmail = WorkEmail;
            this.PersonalEmail = PersonalEmail;
            this.OtherEmail = OtherEmail;
            this.Address = Address;
            this.SurveyOptOut = SurveyOptOut;
            this.ExternalSystemUrl = ExternalSystemUrl;
            this.TwitterId = TwitterId;
            this.LineId = LineId;
            this.WhatsAppId = WhatsAppId;
            this.FacebookId = FacebookId;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }



        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }



        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }



        /// <summary>
        /// Gets or Sets Salutation
        /// </summary>
        [DataMember(Name="salutation", EmitDefaultValue=false)]
        public string Salutation { get; set; }



        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Gets or Sets WorkPhone
        /// </summary>
        [DataMember(Name="workPhone", EmitDefaultValue=false)]
        public ExternalContactsUnresolvedContactChangedTopicPhoneNumber WorkPhone { get; set; }



        /// <summary>
        /// Gets or Sets CellPhone
        /// </summary>
        [DataMember(Name="cellPhone", EmitDefaultValue=false)]
        public ExternalContactsUnresolvedContactChangedTopicPhoneNumber CellPhone { get; set; }



        /// <summary>
        /// Gets or Sets HomePhone
        /// </summary>
        [DataMember(Name="homePhone", EmitDefaultValue=false)]
        public ExternalContactsUnresolvedContactChangedTopicPhoneNumber HomePhone { get; set; }



        /// <summary>
        /// Gets or Sets OtherPhone
        /// </summary>
        [DataMember(Name="otherPhone", EmitDefaultValue=false)]
        public ExternalContactsUnresolvedContactChangedTopicPhoneNumber OtherPhone { get; set; }



        /// <summary>
        /// Gets or Sets WorkEmail
        /// </summary>
        [DataMember(Name="workEmail", EmitDefaultValue=false)]
        public string WorkEmail { get; set; }



        /// <summary>
        /// Gets or Sets PersonalEmail
        /// </summary>
        [DataMember(Name="personalEmail", EmitDefaultValue=false)]
        public string PersonalEmail { get; set; }



        /// <summary>
        /// Gets or Sets OtherEmail
        /// </summary>
        [DataMember(Name="otherEmail", EmitDefaultValue=false)]
        public string OtherEmail { get; set; }



        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public ExternalContactsUnresolvedContactChangedTopicContactAddress Address { get; set; }



        /// <summary>
        /// Gets or Sets SurveyOptOut
        /// </summary>
        [DataMember(Name="surveyOptOut", EmitDefaultValue=false)]
        public bool? SurveyOptOut { get; set; }



        /// <summary>
        /// Gets or Sets ExternalSystemUrl
        /// </summary>
        [DataMember(Name="externalSystemUrl", EmitDefaultValue=false)]
        public string ExternalSystemUrl { get; set; }



        /// <summary>
        /// Gets or Sets TwitterId
        /// </summary>
        [DataMember(Name="twitterId", EmitDefaultValue=false)]
        public ExternalContactsUnresolvedContactChangedTopicTwitterId TwitterId { get; set; }



        /// <summary>
        /// Gets or Sets LineId
        /// </summary>
        [DataMember(Name="lineId", EmitDefaultValue=false)]
        public ExternalContactsUnresolvedContactChangedTopicLineId LineId { get; set; }



        /// <summary>
        /// Gets or Sets WhatsAppId
        /// </summary>
        [DataMember(Name="whatsAppId", EmitDefaultValue=false)]
        public ExternalContactsUnresolvedContactChangedTopicWhatsAppId WhatsAppId { get; set; }



        /// <summary>
        /// Gets or Sets FacebookId
        /// </summary>
        [DataMember(Name="facebookId", EmitDefaultValue=false)]
        public ExternalContactsUnresolvedContactChangedTopicFacebookId FacebookId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalContactsUnresolvedContactChangedTopicContact {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Salutation: ").Append(Salutation).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
            sb.Append("  CellPhone: ").Append(CellPhone).Append("\n");
            sb.Append("  HomePhone: ").Append(HomePhone).Append("\n");
            sb.Append("  OtherPhone: ").Append(OtherPhone).Append("\n");
            sb.Append("  WorkEmail: ").Append(WorkEmail).Append("\n");
            sb.Append("  PersonalEmail: ").Append(PersonalEmail).Append("\n");
            sb.Append("  OtherEmail: ").Append(OtherEmail).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  SurveyOptOut: ").Append(SurveyOptOut).Append("\n");
            sb.Append("  ExternalSystemUrl: ").Append(ExternalSystemUrl).Append("\n");
            sb.Append("  TwitterId: ").Append(TwitterId).Append("\n");
            sb.Append("  LineId: ").Append(LineId).Append("\n");
            sb.Append("  WhatsAppId: ").Append(WhatsAppId).Append("\n");
            sb.Append("  FacebookId: ").Append(FacebookId).Append("\n");
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
            return this.Equals(obj as ExternalContactsUnresolvedContactChangedTopicContact);
        }

        /// <summary>
        /// Returns true if ExternalContactsUnresolvedContactChangedTopicContact instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalContactsUnresolvedContactChangedTopicContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalContactsUnresolvedContactChangedTopicContact other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) &&
                (
                    this.MiddleName == other.MiddleName ||
                    this.MiddleName != null &&
                    this.MiddleName.Equals(other.MiddleName)
                ) &&
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) &&
                (
                    this.Salutation == other.Salutation ||
                    this.Salutation != null &&
                    this.Salutation.Equals(other.Salutation)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.WorkPhone == other.WorkPhone ||
                    this.WorkPhone != null &&
                    this.WorkPhone.Equals(other.WorkPhone)
                ) &&
                (
                    this.CellPhone == other.CellPhone ||
                    this.CellPhone != null &&
                    this.CellPhone.Equals(other.CellPhone)
                ) &&
                (
                    this.HomePhone == other.HomePhone ||
                    this.HomePhone != null &&
                    this.HomePhone.Equals(other.HomePhone)
                ) &&
                (
                    this.OtherPhone == other.OtherPhone ||
                    this.OtherPhone != null &&
                    this.OtherPhone.Equals(other.OtherPhone)
                ) &&
                (
                    this.WorkEmail == other.WorkEmail ||
                    this.WorkEmail != null &&
                    this.WorkEmail.Equals(other.WorkEmail)
                ) &&
                (
                    this.PersonalEmail == other.PersonalEmail ||
                    this.PersonalEmail != null &&
                    this.PersonalEmail.Equals(other.PersonalEmail)
                ) &&
                (
                    this.OtherEmail == other.OtherEmail ||
                    this.OtherEmail != null &&
                    this.OtherEmail.Equals(other.OtherEmail)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.SurveyOptOut == other.SurveyOptOut ||
                    this.SurveyOptOut != null &&
                    this.SurveyOptOut.Equals(other.SurveyOptOut)
                ) &&
                (
                    this.ExternalSystemUrl == other.ExternalSystemUrl ||
                    this.ExternalSystemUrl != null &&
                    this.ExternalSystemUrl.Equals(other.ExternalSystemUrl)
                ) &&
                (
                    this.TwitterId == other.TwitterId ||
                    this.TwitterId != null &&
                    this.TwitterId.Equals(other.TwitterId)
                ) &&
                (
                    this.LineId == other.LineId ||
                    this.LineId != null &&
                    this.LineId.Equals(other.LineId)
                ) &&
                (
                    this.WhatsAppId == other.WhatsAppId ||
                    this.WhatsAppId != null &&
                    this.WhatsAppId.Equals(other.WhatsAppId)
                ) &&
                (
                    this.FacebookId == other.FacebookId ||
                    this.FacebookId != null &&
                    this.FacebookId.Equals(other.FacebookId)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();

                if (this.MiddleName != null)
                    hash = hash * 59 + this.MiddleName.GetHashCode();

                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();

                if (this.Salutation != null)
                    hash = hash * 59 + this.Salutation.GetHashCode();

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.WorkPhone != null)
                    hash = hash * 59 + this.WorkPhone.GetHashCode();

                if (this.CellPhone != null)
                    hash = hash * 59 + this.CellPhone.GetHashCode();

                if (this.HomePhone != null)
                    hash = hash * 59 + this.HomePhone.GetHashCode();

                if (this.OtherPhone != null)
                    hash = hash * 59 + this.OtherPhone.GetHashCode();

                if (this.WorkEmail != null)
                    hash = hash * 59 + this.WorkEmail.GetHashCode();

                if (this.PersonalEmail != null)
                    hash = hash * 59 + this.PersonalEmail.GetHashCode();

                if (this.OtherEmail != null)
                    hash = hash * 59 + this.OtherEmail.GetHashCode();

                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();

                if (this.SurveyOptOut != null)
                    hash = hash * 59 + this.SurveyOptOut.GetHashCode();

                if (this.ExternalSystemUrl != null)
                    hash = hash * 59 + this.ExternalSystemUrl.GetHashCode();

                if (this.TwitterId != null)
                    hash = hash * 59 + this.TwitterId.GetHashCode();

                if (this.LineId != null)
                    hash = hash * 59 + this.LineId.GetHashCode();

                if (this.WhatsAppId != null)
                    hash = hash * 59 + this.WhatsAppId.GetHashCode();

                if (this.FacebookId != null)
                    hash = hash * 59 + this.FacebookId.GetHashCode();

                return hash;
            }
        }
    }

}
