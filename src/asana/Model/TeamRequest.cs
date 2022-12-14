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
    /// TeamRequest
    /// </summary>
    [DataContract]
    public partial class TeamRequest :  IEquatable<TeamRequest>, IValidatableObject
    {
        /// <summary>
        /// The visibility of the team to users in the same organization 
        /// </summary>
        /// <value>The visibility of the team to users in the same organization </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VisibilityEnum
        {
            /// <summary>
            /// Enum Secret for value: secret
            /// </summary>
            [EnumMember(Value = "secret")]
            Secret = 1,

            /// <summary>
            /// Enum Requesttojoin for value: request_to_join
            /// </summary>
            [EnumMember(Value = "request_to_join")]
            Requesttojoin = 2,

            /// <summary>
            /// Enum Public for value: public
            /// </summary>
            [EnumMember(Value = "public")]
            Public = 3

        }

        /// <summary>
        /// The visibility of the team to users in the same organization 
        /// </summary>
        /// <value>The visibility of the team to users in the same organization </value>
        [DataMember(Name="visibility", EmitDefaultValue=false)]
        public VisibilityEnum? Visibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRequest" /> class.
        /// </summary>
        /// <param name="name">The name of the team..</param>
        /// <param name="description">The description of the team. .</param>
        /// <param name="htmlDescription">The description of the team with formatting as HTML. .</param>
        /// <param name="organization">The organization/workspace the team belongs to. This must be the same organization you are in and cannot be changed once set. .</param>
        /// <param name="visibility">The visibility of the team to users in the same organization .</param>
        public TeamRequest(string name = default(string), string description = default(string), string htmlDescription = default(string), string organization = default(string), VisibilityEnum? visibility = default(VisibilityEnum?))
        {
            this.Name = name;
            this.Description = description;
            this.HtmlDescription = htmlDescription;
            this.Organization = organization;
            this.Visibility = visibility;
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
        /// The name of the team.
        /// </summary>
        /// <value>The name of the team.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the team. 
        /// </summary>
        /// <value>The description of the team. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The description of the team with formatting as HTML. 
        /// </summary>
        /// <value>The description of the team with formatting as HTML. </value>
        [DataMember(Name="html_description", EmitDefaultValue=false)]
        public string HtmlDescription { get; set; }

        /// <summary>
        /// The organization/workspace the team belongs to. This must be the same organization you are in and cannot be changed once set. 
        /// </summary>
        /// <value>The organization/workspace the team belongs to. This must be the same organization you are in and cannot be changed once set. </value>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public string Organization { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamRequest {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HtmlDescription: ").Append(HtmlDescription).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
            return this.Equals(input as TeamRequest);
        }

        /// <summary>
        /// Returns true if TeamRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamRequest input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.HtmlDescription == input.HtmlDescription ||
                    (this.HtmlDescription != null &&
                    this.HtmlDescription.Equals(input.HtmlDescription))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.HtmlDescription != null)
                    hashCode = hashCode * 59 + this.HtmlDescription.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
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
