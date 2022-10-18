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
    /// StatusUpdateCompact
    /// </summary>
    [DataContract]
    public partial class StatusUpdateCompact :  IEquatable<StatusUpdateCompact>, IValidatableObject
    {
        /// <summary>
        /// The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The &#x60;resource_subtype&#x60;s for &#x60;status&#x60; objects represent the type of their parent.
        /// </summary>
        /// <value>The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The &#x60;resource_subtype&#x60;s for &#x60;status&#x60; objects represent the type of their parent.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResourceSubtypeEnum
        {
            /// <summary>
            /// Enum Projectstatusupdate for value: project_status_update
            /// </summary>
            [EnumMember(Value = "project_status_update")]
            Projectstatusupdate = 1,

            /// <summary>
            /// Enum Portfoliostatusupdate for value: portfolio_status_update
            /// </summary>
            [EnumMember(Value = "portfolio_status_update")]
            Portfoliostatusupdate = 2,

            /// <summary>
            /// Enum Goalstatusupdate for value: goal_status_update
            /// </summary>
            [EnumMember(Value = "goal_status_update")]
            Goalstatusupdate = 3

        }

        /// <summary>
        /// The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The &#x60;resource_subtype&#x60;s for &#x60;status&#x60; objects represent the type of their parent.
        /// </summary>
        /// <value>The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The &#x60;resource_subtype&#x60;s for &#x60;status&#x60; objects represent the type of their parent.</value>
        [DataMember(Name="resource_subtype", EmitDefaultValue=false)]
        public ResourceSubtypeEnum? ResourceSubtype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusUpdateCompact" /> class.
        /// </summary>
        /// <param name="title">The title of the status update..</param>
        public StatusUpdateCompact(string title = default(string))
        {
            this.Title = title;
        }

        /// <summary>
        /// Globally unique identifier of the resource, as a string.
        /// </summary>
        /// <value>Globally unique identifier of the resource, as a string.</value>
        [DataMember(Name="gid", EmitDefaultValue=false)]
        public string Gid { get; private set; }

        /// <summary>
        /// The base type of this resource.
        /// </summary>
        /// <value>The base type of this resource.</value>
        [DataMember(Name="resource_type", EmitDefaultValue=false)]
        public string ResourceType { get; private set; }

        /// <summary>
        /// The title of the status update.
        /// </summary>
        /// <value>The title of the status update.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusUpdateCompact {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ResourceSubtype: ").Append(ResourceSubtype).Append("\n");
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
            return this.Equals(input as StatusUpdateCompact);
        }

        /// <summary>
        /// Returns true if StatusUpdateCompact instances are equal
        /// </summary>
        /// <param name="input">Instance of StatusUpdateCompact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusUpdateCompact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Gid == input.Gid ||
                    (this.Gid != null &&
                    this.Gid.Equals(input.Gid))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.ResourceSubtype == input.ResourceSubtype ||
                    (this.ResourceSubtype != null &&
                    this.ResourceSubtype.Equals(input.ResourceSubtype))
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
                if (this.Gid != null)
                    hashCode = hashCode * 59 + this.Gid.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.ResourceSubtype != null)
                    hashCode = hashCode * 59 + this.ResourceSubtype.GetHashCode();
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
