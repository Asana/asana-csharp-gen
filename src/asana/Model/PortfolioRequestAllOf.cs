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
    /// PortfolioRequestAllOf
    /// </summary>
    [DataContract]
    public partial class PortfolioRequestAllOf :  IEquatable<PortfolioRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioRequestAllOf" /> class.
        /// </summary>
        /// <param name="workspace">Gid of an object..</param>
        /// <param name="_public">True if the portfolio is public to its workspace members..</param>
        public PortfolioRequestAllOf(string workspace = default(string), bool _public = default(bool))
        {
            this.Workspace = workspace;
            this.Public = _public;
        }

        /// <summary>
        /// An array of strings identifying users. These can either be the string \&quot;me\&quot;, an email, or the gid of a user.
        /// </summary>
        /// <value>An array of strings identifying users. These can either be the string \&quot;me\&quot;, an email, or the gid of a user.</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<string> Members { get; private set; }

        /// <summary>
        /// Gid of an object.
        /// </summary>
        /// <value>Gid of an object.</value>
        [DataMember(Name="workspace", EmitDefaultValue=false)]
        public string Workspace { get; set; }

        /// <summary>
        /// True if the portfolio is public to its workspace members.
        /// </summary>
        /// <value>True if the portfolio is public to its workspace members.</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        public bool Public { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortfolioRequestAllOf {\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
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
            return this.Equals(input as PortfolioRequestAllOf);
        }

        /// <summary>
        /// Returns true if PortfolioRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PortfolioRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortfolioRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
                ) && 
                (
                    this.Workspace == input.Workspace ||
                    (this.Workspace != null &&
                    this.Workspace.Equals(input.Workspace))
                ) && 
                (
                    this.Public == input.Public ||
                    (this.Public != null &&
                    this.Public.Equals(input.Public))
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
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.Workspace != null)
                    hashCode = hashCode * 59 + this.Workspace.GetHashCode();
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
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
