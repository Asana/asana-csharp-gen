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
    /// ProjectMembershipResponse
    /// </summary>
    [DataContract]
    public partial class ProjectMembershipResponse :  IEquatable<ProjectMembershipResponse>, IValidatableObject
    {
        /// <summary>
        /// Whether the user has full access to the project or has comment-only access.
        /// </summary>
        /// <value>Whether the user has full access to the project or has comment-only access.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WriteAccessEnum
        {
            /// <summary>
            /// Enum Fullwrite for value: full_write
            /// </summary>
            [EnumMember(Value = "full_write")]
            Fullwrite = 1,

            /// <summary>
            /// Enum Commentonly for value: comment_only
            /// </summary>
            [EnumMember(Value = "comment_only")]
            Commentonly = 2

        }

        /// <summary>
        /// Whether the user has full access to the project or has comment-only access.
        /// </summary>
        /// <value>Whether the user has full access to the project or has comment-only access.</value>
        [DataMember(Name="write_access", EmitDefaultValue=false)]
        public WriteAccessEnum? WriteAccess { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMembershipResponse" /> class.
        /// </summary>
        /// <param name="user">user.</param>
        /// <param name="project">project.</param>
        public ProjectMembershipResponse(UserCompact user = default(UserCompact), ProjectCompact project = default(ProjectCompact))
        {
            this.User = user;
            this.Project = project;
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
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserCompact User { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public ProjectCompact Project { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectMembershipResponse {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  WriteAccess: ").Append(WriteAccess).Append("\n");
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
            return this.Equals(input as ProjectMembershipResponse);
        }

        /// <summary>
        /// Returns true if ProjectMembershipResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectMembershipResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectMembershipResponse input)
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
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.WriteAccess == input.WriteAccess ||
                    (this.WriteAccess != null &&
                    this.WriteAccess.Equals(input.WriteAccess))
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
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.WriteAccess != null)
                    hashCode = hashCode * 59 + this.WriteAccess.GetHashCode();
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