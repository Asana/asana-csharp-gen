/*
 * Asana
 *
 * This is the interface for interacting with the [Asana Platform](https://developers.asana.com). Our API reference is generated from our [OpenAPI spec] (https://raw.githubusercontent.com/Asana/developer-docs/master/defs/asana_oas.yaml).
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = asana.Client.OpenAPIDateConverter;

namespace asana.Model
{
    /// <summary>
    /// Webhook objects represent the state of an active subscription for a server to be updated with information from Asana. This schema represents the subscription itself, not the objects that are sent to the server. For information on those please refer to the [Event](/docs/tocS_Event) schema.
    /// </summary>
    [DataContract]
    public partial class WebhookCompactAllOf :  IEquatable<WebhookCompactAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCompactAllOf" /> class.
        /// </summary>
        /// <param name="resource">resource.</param>
        public WebhookCompactAllOf(AsanaNamedResource resource = default(AsanaNamedResource))
        {
            this.Resource = resource;
        }

        /// <summary>
        /// If true, the webhook will send events - if false it is considered inactive and will not generate events.
        /// </summary>
        /// <value>If true, the webhook will send events - if false it is considered inactive and will not generate events.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; private set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name="resource", EmitDefaultValue=false)]
        public AsanaNamedResource Resource { get; set; }

        /// <summary>
        /// The URL to receive the HTTP POST.
        /// </summary>
        /// <value>The URL to receive the HTTP POST.</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public string Target { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookCompactAllOf {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebhookCompactAllOf);
        }

        /// <summary>
        /// Returns true if WebhookCompactAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookCompactAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookCompactAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
