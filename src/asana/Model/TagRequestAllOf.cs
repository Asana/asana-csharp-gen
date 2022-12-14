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
    /// TagRequestAllOf
    /// </summary>
    [DataContract]
    public partial class TagRequestAllOf :  IEquatable<TagRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagRequestAllOf" /> class.
        /// </summary>
        /// <param name="followers">An array of strings identifying users. These can either be the string \&quot;me\&quot;, an email, or the gid of a user..</param>
        /// <param name="workspace">Gid of an object..</param>
        public TagRequestAllOf(List<string> followers = default(List<string>), string workspace = default(string))
        {
            this.Followers = followers;
            this.Workspace = workspace;
        }

        /// <summary>
        /// An array of strings identifying users. These can either be the string \&quot;me\&quot;, an email, or the gid of a user.
        /// </summary>
        /// <value>An array of strings identifying users. These can either be the string \&quot;me\&quot;, an email, or the gid of a user.</value>
        [DataMember(Name="followers", EmitDefaultValue=false)]
        public List<string> Followers { get; set; }

        /// <summary>
        /// Gid of an object.
        /// </summary>
        /// <value>Gid of an object.</value>
        [DataMember(Name="workspace", EmitDefaultValue=false)]
        public string Workspace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagRequestAllOf {\n");
            sb.Append("  Followers: ").Append(Followers).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
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
            return this.Equals(input as TagRequestAllOf);
        }

        /// <summary>
        /// Returns true if TagRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of TagRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Followers == input.Followers ||
                    this.Followers != null &&
                    input.Followers != null &&
                    this.Followers.SequenceEqual(input.Followers)
                ) && 
                (
                    this.Workspace == input.Workspace ||
                    (this.Workspace != null &&
                    this.Workspace.Equals(input.Workspace))
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
                if (this.Followers != null)
                    hashCode = hashCode * 59 + this.Followers.GetHashCode();
                if (this.Workspace != null)
                    hashCode = hashCode * 59 + this.Workspace.GetHashCode();
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
