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
    /// ProjectStatusResponseAllOf
    /// </summary>
    [DataContract]
    public partial class ProjectStatusResponseAllOf :  IEquatable<ProjectStatusResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatusResponseAllOf" /> class.
        /// </summary>
        /// <param name="author">author.</param>
        /// <param name="createdBy">createdBy.</param>
        public ProjectStatusResponseAllOf(UserCompact author = default(UserCompact), UserCompact createdBy = default(UserCompact))
        {
            this.Author = author;
            this.CreatedBy = createdBy;
        }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public UserCompact Author { get; set; }

        /// <summary>
        /// The time at which this resource was created.
        /// </summary>
        /// <value>The time at which this resource was created.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="created_by", EmitDefaultValue=false)]
        public UserCompact CreatedBy { get; set; }

        /// <summary>
        /// The time at which this project status was last modified. *Note: This does not currently reflect any changes in associations such as comments that may have been added or removed from the project status.*
        /// </summary>
        /// <value>The time at which this project status was last modified. *Note: This does not currently reflect any changes in associations such as comments that may have been added or removed from the project status.*</value>
        [DataMember(Name="modified_at", EmitDefaultValue=false)]
        public DateTime ModifiedAt { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectStatusResponseAllOf {\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
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
            return this.Equals(input as ProjectStatusResponseAllOf);
        }

        /// <summary>
        /// Returns true if ProjectStatusResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectStatusResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectStatusResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
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
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
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
