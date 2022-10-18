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
    /// The *task* is the basic object around which many operations in Asana are centered.
    /// </summary>
    [DataContract]
    public partial class TaskCompactAllOf :  IEquatable<TaskCompactAllOf>, IValidatableObject
    {
        /// <summary>
        /// The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The resource_subtype &#x60;milestone&#x60; represent a single moment in time. This means tasks with this subtype cannot have a start_date.
        /// </summary>
        /// <value>The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The resource_subtype &#x60;milestone&#x60; represent a single moment in time. This means tasks with this subtype cannot have a start_date.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResourceSubtypeEnum
        {
            /// <summary>
            /// Enum Defaulttask for value: default_task
            /// </summary>
            [EnumMember(Value = "default_task")]
            Defaulttask = 1,

            /// <summary>
            /// Enum Milestone for value: milestone
            /// </summary>
            [EnumMember(Value = "milestone")]
            Milestone = 2,

            /// <summary>
            /// Enum Section for value: section
            /// </summary>
            [EnumMember(Value = "section")]
            Section = 3,

            /// <summary>
            /// Enum Approval for value: approval
            /// </summary>
            [EnumMember(Value = "approval")]
            Approval = 4

        }

        /// <summary>
        /// The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The resource_subtype &#x60;milestone&#x60; represent a single moment in time. This means tasks with this subtype cannot have a start_date.
        /// </summary>
        /// <value>The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The resource_subtype &#x60;milestone&#x60; represent a single moment in time. This means tasks with this subtype cannot have a start_date.</value>
        [DataMember(Name="resource_subtype", EmitDefaultValue=false)]
        public ResourceSubtypeEnum? ResourceSubtype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskCompactAllOf" /> class.
        /// </summary>
        /// <param name="name">The name of the task..</param>
        /// <param name="resourceSubtype">The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The resource_subtype &#x60;milestone&#x60; represent a single moment in time. This means tasks with this subtype cannot have a start_date..</param>
        public TaskCompactAllOf(string name = default(string), ResourceSubtypeEnum? resourceSubtype = default(ResourceSubtypeEnum?))
        {
            this.Name = name;
            this.ResourceSubtype = resourceSubtype;
        }

        /// <summary>
        /// The name of the task.
        /// </summary>
        /// <value>The name of the task.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskCompactAllOf {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ResourceSubtype: ").Append(ResourceSubtype).Append("\n");
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
            return this.Equals(input as TaskCompactAllOf);
        }

        /// <summary>
        /// Returns true if TaskCompactAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskCompactAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskCompactAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ResourceSubtype == input.ResourceSubtype ||
                    (this.ResourceSubtype != null &&
                    this.ResourceSubtype.Equals(input.ResourceSubtype))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ResourceSubtype != null)
                    hashCode = hashCode * 59 + this.ResourceSubtype.GetHashCode();
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