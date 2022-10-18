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
    /// UserBaseResponseAllOf
    /// </summary>
    [DataContract]
    public partial class UserBaseResponseAllOf :  IEquatable<UserBaseResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserBaseResponseAllOf" /> class.
        /// </summary>
        /// <param name="photo">photo.</param>
        public UserBaseResponseAllOf(UserBaseResponseAllOfPhoto photo = default(UserBaseResponseAllOfPhoto))
        {
            this.Photo = photo;
            this.Photo = photo;
        }

        /// <summary>
        /// The user&#39;s email address.
        /// </summary>
        /// <value>The user&#39;s email address.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; private set; }

        /// <summary>
        /// Gets or Sets Photo
        /// </summary>
        [DataMember(Name="photo", EmitDefaultValue=true)]
        public UserBaseResponseAllOfPhoto Photo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserBaseResponseAllOf {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Photo: ").Append(Photo).Append("\n");
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
            return this.Equals(input as UserBaseResponseAllOf);
        }

        /// <summary>
        /// Returns true if UserBaseResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of UserBaseResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserBaseResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Photo == input.Photo ||
                    (this.Photo != null &&
                    this.Photo.Equals(input.Photo))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Photo != null)
                    hashCode = hashCode * 59 + this.Photo.GetHashCode();
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
