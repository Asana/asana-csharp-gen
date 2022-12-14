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
    /// AddCustomFieldSettingRequest
    /// </summary>
    [DataContract]
    public partial class AddCustomFieldSettingRequest :  IEquatable<AddCustomFieldSettingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddCustomFieldSettingRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddCustomFieldSettingRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddCustomFieldSettingRequest" /> class.
        /// </summary>
        /// <param name="customField">The custom field to associate with this container. (required).</param>
        /// <param name="isImportant">Whether this field should be considered important to this container (for instance, to display in the list view of items in the container)..</param>
        /// <param name="insertBefore">A gid of a Custom Field Setting on this container, before which the new Custom Field Setting will be added.  &#x60;insert_before&#x60; and &#x60;insert_after&#x60; parameters cannot both be specified..</param>
        /// <param name="insertAfter">A gid of a Custom Field Setting on this container, after which the new Custom Field Setting will be added.  &#x60;insert_before&#x60; and &#x60;insert_after&#x60; parameters cannot both be specified..</param>
        public AddCustomFieldSettingRequest(string customField = default(string), bool isImportant = default(bool), string insertBefore = default(string), string insertAfter = default(string))
        {
            // to ensure "customField" is required (not null)
            if (customField == null)
            {
                throw new InvalidDataException("customField is a required property for AddCustomFieldSettingRequest and cannot be null");
            }
            else
            {
                this.CustomField = customField;
            }

            this.IsImportant = isImportant;
            this.InsertBefore = insertBefore;
            this.InsertAfter = insertAfter;
        }

        /// <summary>
        /// The custom field to associate with this container.
        /// </summary>
        /// <value>The custom field to associate with this container.</value>
        [DataMember(Name="custom_field", EmitDefaultValue=true)]
        public string CustomField { get; set; }

        /// <summary>
        /// Whether this field should be considered important to this container (for instance, to display in the list view of items in the container).
        /// </summary>
        /// <value>Whether this field should be considered important to this container (for instance, to display in the list view of items in the container).</value>
        [DataMember(Name="is_important", EmitDefaultValue=false)]
        public bool IsImportant { get; set; }

        /// <summary>
        /// A gid of a Custom Field Setting on this container, before which the new Custom Field Setting will be added.  &#x60;insert_before&#x60; and &#x60;insert_after&#x60; parameters cannot both be specified.
        /// </summary>
        /// <value>A gid of a Custom Field Setting on this container, before which the new Custom Field Setting will be added.  &#x60;insert_before&#x60; and &#x60;insert_after&#x60; parameters cannot both be specified.</value>
        [DataMember(Name="insert_before", EmitDefaultValue=false)]
        public string InsertBefore { get; set; }

        /// <summary>
        /// A gid of a Custom Field Setting on this container, after which the new Custom Field Setting will be added.  &#x60;insert_before&#x60; and &#x60;insert_after&#x60; parameters cannot both be specified.
        /// </summary>
        /// <value>A gid of a Custom Field Setting on this container, after which the new Custom Field Setting will be added.  &#x60;insert_before&#x60; and &#x60;insert_after&#x60; parameters cannot both be specified.</value>
        [DataMember(Name="insert_after", EmitDefaultValue=false)]
        public string InsertAfter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddCustomFieldSettingRequest {\n");
            sb.Append("  CustomField: ").Append(CustomField).Append("\n");
            sb.Append("  IsImportant: ").Append(IsImportant).Append("\n");
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
            return this.Equals(input as AddCustomFieldSettingRequest);
        }

        /// <summary>
        /// Returns true if AddCustomFieldSettingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddCustomFieldSettingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddCustomFieldSettingRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomField == input.CustomField ||
                    (this.CustomField != null &&
                    this.CustomField.Equals(input.CustomField))
                ) && 
                (
                    this.IsImportant == input.IsImportant ||
                    (this.IsImportant != null &&
                    this.IsImportant.Equals(input.IsImportant))
                ) && 
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
                if (this.CustomField != null)
                    hashCode = hashCode * 59 + this.CustomField.GetHashCode();
                if (this.IsImportant != null)
                    hashCode = hashCode * 59 + this.IsImportant.GetHashCode();
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
