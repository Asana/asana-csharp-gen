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
    /// WorkspaceResponse
    /// </summary>
    [DataContract]
    public partial class WorkspaceResponse :  IEquatable<WorkspaceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceResponse" /> class.
        /// </summary>
        /// <param name="name">The name of the workspace..</param>
        /// <param name="emailDomains">The email domains that are associated with this workspace..</param>
        /// <param name="isOrganization">Whether the workspace is an *organization*..</param>
        public WorkspaceResponse(string name = default(string), List<string> emailDomains = default(List<string>), bool isOrganization = default(bool))
        {
            this.Name = name;
            this.EmailDomains = emailDomains;
            this.IsOrganization = isOrganization;
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
        /// The name of the workspace.
        /// </summary>
        /// <value>The name of the workspace.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The email domains that are associated with this workspace.
        /// </summary>
        /// <value>The email domains that are associated with this workspace.</value>
        [DataMember(Name="email_domains", EmitDefaultValue=false)]
        public List<string> EmailDomains { get; set; }

        /// <summary>
        /// Whether the workspace is an *organization*.
        /// </summary>
        /// <value>Whether the workspace is an *organization*.</value>
        [DataMember(Name="is_organization", EmitDefaultValue=false)]
        public bool IsOrganization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceResponse {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EmailDomains: ").Append(EmailDomains).Append("\n");
            sb.Append("  IsOrganization: ").Append(IsOrganization).Append("\n");
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
            return this.Equals(input as WorkspaceResponse);
        }

        /// <summary>
        /// Returns true if WorkspaceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceResponse input)
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
                    this.EmailDomains == input.EmailDomains ||
                    this.EmailDomains != null &&
                    input.EmailDomains != null &&
                    this.EmailDomains.SequenceEqual(input.EmailDomains)
                ) && 
                (
                    this.IsOrganization == input.IsOrganization ||
                    (this.IsOrganization != null &&
                    this.IsOrganization.Equals(input.IsOrganization))
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
                if (this.EmailDomains != null)
                    hashCode = hashCode * 59 + this.EmailDomains.GetHashCode();
                if (this.IsOrganization != null)
                    hashCode = hashCode * 59 + this.IsOrganization.GetHashCode();
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
