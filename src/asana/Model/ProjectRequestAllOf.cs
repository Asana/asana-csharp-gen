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
    /// ProjectRequestAllOf
    /// </summary>
    [DataContract]
    public partial class ProjectRequestAllOf :  IEquatable<ProjectRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRequestAllOf" /> class.
        /// </summary>
        /// <param name="customFields">An object where each key is a Custom Field GID and each value is an enum GID, string, number, or object..</param>
        /// <param name="followers">*Create-only*. Comma separated string of users. Followers are a subset of members who have opted in to receive \&quot;tasks added\&quot; notifications for a project..</param>
        /// <param name="owner">The current owner of the project, may be null..</param>
        /// <param name="team">The team that this project is shared with..</param>
        public ProjectRequestAllOf(Dictionary<string, string> customFields = default(Dictionary<string, string>), string followers = default(string), string owner = default(string), string team = default(string))
        {
            this.Owner = owner;
            this.CustomFields = customFields;
            this.Followers = followers;
            this.Owner = owner;
            this.Team = team;
        }

        /// <summary>
        /// An object where each key is a Custom Field GID and each value is an enum GID, string, number, or object.
        /// </summary>
        /// <value>An object where each key is a Custom Field GID and each value is an enum GID, string, number, or object.</value>
        [DataMember(Name="custom_fields", EmitDefaultValue=false)]
        public Dictionary<string, string> CustomFields { get; set; }

        /// <summary>
        /// *Create-only*. Comma separated string of users. Followers are a subset of members who have opted in to receive \&quot;tasks added\&quot; notifications for a project.
        /// </summary>
        /// <value>*Create-only*. Comma separated string of users. Followers are a subset of members who have opted in to receive \&quot;tasks added\&quot; notifications for a project.</value>
        [DataMember(Name="followers", EmitDefaultValue=false)]
        public string Followers { get; set; }

        /// <summary>
        /// The current owner of the project, may be null.
        /// </summary>
        /// <value>The current owner of the project, may be null.</value>
        [DataMember(Name="owner", EmitDefaultValue=true)]
        public string Owner { get; set; }

        /// <summary>
        /// The team that this project is shared with.
        /// </summary>
        /// <value>The team that this project is shared with.</value>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectRequestAllOf {\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Followers: ").Append(Followers).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
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
            return this.Equals(input as ProjectRequestAllOf);
        }

        /// <summary>
        /// Returns true if ProjectRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.Followers == input.Followers ||
                    (this.Followers != null &&
                    this.Followers.Equals(input.Followers))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
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
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Followers != null)
                    hashCode = hashCode * 59 + this.Followers.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
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