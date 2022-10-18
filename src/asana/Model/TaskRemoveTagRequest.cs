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
    /// TaskRemoveTagRequest
    /// </summary>
    [DataContract]
    public partial class TaskRemoveTagRequest :  IEquatable<TaskRemoveTagRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskRemoveTagRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskRemoveTagRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskRemoveTagRequest" /> class.
        /// </summary>
        /// <param name="tag">The tag to remove from the task. (required).</param>
        public TaskRemoveTagRequest(string tag = default(string))
        {
            // to ensure "tag" is required (not null)
            if (tag == null)
            {
                throw new InvalidDataException("tag is a required property for TaskRemoveTagRequest and cannot be null");
            }
            else
            {
                this.Tag = tag;
            }

        }

        /// <summary>
        /// The tag to remove from the task.
        /// </summary>
        /// <value>The tag to remove from the task.</value>
        [DataMember(Name="tag", EmitDefaultValue=true)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskRemoveTagRequest {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(input as TaskRemoveTagRequest);
        }

        /// <summary>
        /// Returns true if TaskRemoveTagRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskRemoveTagRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskRemoveTagRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
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