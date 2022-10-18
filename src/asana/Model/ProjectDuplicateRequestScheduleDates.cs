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
    /// A dictionary of options to auto-shift dates. &#x60;task_dates&#x60; must be included to use this option. Requires either &#x60;start_on&#x60; or &#x60;due_on&#x60;, but not both.
    /// </summary>
    [DataContract]
    public partial class ProjectDuplicateRequestScheduleDates :  IEquatable<ProjectDuplicateRequestScheduleDates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDuplicateRequestScheduleDates" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectDuplicateRequestScheduleDates() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDuplicateRequestScheduleDates" /> class.
        /// </summary>
        /// <param name="shouldSkipWeekends">Determines if the auto-shifted dates should skip weekends. (required).</param>
        /// <param name="dueOn">Sets the last due date in the duplicated project to the given date. The rest of the due dates will be offset by the same amount as the due dates in the original project..</param>
        /// <param name="startOn">Sets the first start date in the duplicated project to the given date. The rest of the start dates will be offset by the same amount as the start dates in the original project..</param>
        public ProjectDuplicateRequestScheduleDates(bool shouldSkipWeekends = default(bool), string dueOn = default(string), string startOn = default(string))
        {
            // to ensure "shouldSkipWeekends" is required (not null)
            if (shouldSkipWeekends == null)
            {
                throw new InvalidDataException("shouldSkipWeekends is a required property for ProjectDuplicateRequestScheduleDates and cannot be null");
            }
            else
            {
                this.ShouldSkipWeekends = shouldSkipWeekends;
            }

            this.DueOn = dueOn;
            this.StartOn = startOn;
        }

        /// <summary>
        /// Determines if the auto-shifted dates should skip weekends.
        /// </summary>
        /// <value>Determines if the auto-shifted dates should skip weekends.</value>
        [DataMember(Name="should_skip_weekends", EmitDefaultValue=true)]
        public bool ShouldSkipWeekends { get; set; }

        /// <summary>
        /// Sets the last due date in the duplicated project to the given date. The rest of the due dates will be offset by the same amount as the due dates in the original project.
        /// </summary>
        /// <value>Sets the last due date in the duplicated project to the given date. The rest of the due dates will be offset by the same amount as the due dates in the original project.</value>
        [DataMember(Name="due_on", EmitDefaultValue=false)]
        public string DueOn { get; set; }

        /// <summary>
        /// Sets the first start date in the duplicated project to the given date. The rest of the start dates will be offset by the same amount as the start dates in the original project.
        /// </summary>
        /// <value>Sets the first start date in the duplicated project to the given date. The rest of the start dates will be offset by the same amount as the start dates in the original project.</value>
        [DataMember(Name="start_on", EmitDefaultValue=false)]
        public string StartOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectDuplicateRequestScheduleDates {\n");
            sb.Append("  ShouldSkipWeekends: ").Append(ShouldSkipWeekends).Append("\n");
            sb.Append("  DueOn: ").Append(DueOn).Append("\n");
            sb.Append("  StartOn: ").Append(StartOn).Append("\n");
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
            return this.Equals(input as ProjectDuplicateRequestScheduleDates);
        }

        /// <summary>
        /// Returns true if ProjectDuplicateRequestScheduleDates instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectDuplicateRequestScheduleDates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectDuplicateRequestScheduleDates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShouldSkipWeekends == input.ShouldSkipWeekends ||
                    (this.ShouldSkipWeekends != null &&
                    this.ShouldSkipWeekends.Equals(input.ShouldSkipWeekends))
                ) && 
                (
                    this.DueOn == input.DueOn ||
                    (this.DueOn != null &&
                    this.DueOn.Equals(input.DueOn))
                ) && 
                (
                    this.StartOn == input.StartOn ||
                    (this.StartOn != null &&
                    this.StartOn.Equals(input.StartOn))
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
                if (this.ShouldSkipWeekends != null)
                    hashCode = hashCode * 59 + this.ShouldSkipWeekends.GetHashCode();
                if (this.DueOn != null)
                    hashCode = hashCode * 59 + this.DueOn.GetHashCode();
                if (this.StartOn != null)
                    hashCode = hashCode * 59 + this.StartOn.GetHashCode();
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
