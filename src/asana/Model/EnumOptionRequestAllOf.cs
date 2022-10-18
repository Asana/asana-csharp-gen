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
    /// EnumOptionRequestAllOf
    /// </summary>
    [DataContract]
    public partial class EnumOptionRequestAllOf :  IEquatable<EnumOptionRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumOptionRequestAllOf" /> class.
        /// </summary>
        /// <param name="insertBefore">An existing enum option within this custom field before which the new enum option should be inserted. Cannot be provided together with after_enum_option..</param>
        /// <param name="insertAfter">An existing enum option within this custom field after which the new enum option should be inserted. Cannot be provided together with before_enum_option..</param>
        public EnumOptionRequestAllOf(string insertBefore = default(string), string insertAfter = default(string))
        {
            this.InsertBefore = insertBefore;
            this.InsertAfter = insertAfter;
        }

        /// <summary>
        /// An existing enum option within this custom field before which the new enum option should be inserted. Cannot be provided together with after_enum_option.
        /// </summary>
        /// <value>An existing enum option within this custom field before which the new enum option should be inserted. Cannot be provided together with after_enum_option.</value>
        [DataMember(Name="insert_before", EmitDefaultValue=false)]
        public string InsertBefore { get; set; }

        /// <summary>
        /// An existing enum option within this custom field after which the new enum option should be inserted. Cannot be provided together with before_enum_option.
        /// </summary>
        /// <value>An existing enum option within this custom field after which the new enum option should be inserted. Cannot be provided together with before_enum_option.</value>
        [DataMember(Name="insert_after", EmitDefaultValue=false)]
        public string InsertAfter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnumOptionRequestAllOf {\n");
            sb.Append("  InsertBefore: ").Append(InsertBefore).Append("\n");
            sb.Append("  InsertAfter: ").Append(InsertAfter).Append("\n");
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
            return this.Equals(input as EnumOptionRequestAllOf);
        }

        /// <summary>
        /// Returns true if EnumOptionRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of EnumOptionRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnumOptionRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InsertBefore == input.InsertBefore ||
                    (this.InsertBefore != null &&
                    this.InsertBefore.Equals(input.InsertBefore))
                ) && 
                (
                    this.InsertAfter == input.InsertAfter ||
                    (this.InsertAfter != null &&
                    this.InsertAfter.Equals(input.InsertAfter))
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
                if (this.InsertBefore != null)
                    hashCode = hashCode * 59 + this.InsertBefore.GetHashCode();
                if (this.InsertAfter != null)
                    hashCode = hashCode * 59 + this.InsertAfter.GetHashCode();
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
