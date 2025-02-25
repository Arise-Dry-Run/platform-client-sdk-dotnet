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
    /// DialerCampaignConfigChangeRestErrorDetail
    /// </summary>
    [DataContract]
    public partial class DialerCampaignConfigChangeRestErrorDetail :  IEquatable<DialerCampaignConfigChangeRestErrorDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCampaignConfigChangeRestErrorDetail" /> class.
        /// </summary>
        /// <param name="Error">name of the error.</param>
        /// <param name="Details">additional information regarding the error.</param>
        public DialerCampaignConfigChangeRestErrorDetail(string Error = null, string Details = null)
        {
            this.Error = Error;
            this.Details = Details;
            
        }
        


        /// <summary>
        /// name of the error
        /// </summary>
        /// <value>name of the error</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }



        /// <summary>
        /// additional information regarding the error
        /// </summary>
        /// <value>additional information regarding the error</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerCampaignConfigChangeRestErrorDetail {\n");

            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(obj as DialerCampaignConfigChangeRestErrorDetail);
        }

        /// <summary>
        /// Returns true if DialerCampaignConfigChangeRestErrorDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerCampaignConfigChangeRestErrorDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCampaignConfigChangeRestErrorDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) &&
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
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
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();

                return hash;
            }
        }
    }

}
