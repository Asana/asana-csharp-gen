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
    /// TaskAddProjectRequest
    /// </summary>
    [DataContract]
    public partial class TaskAddProjectRequest :  IEquatable<TaskAddProjectRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskAddProjectRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskAddProjectRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskAddProjectRequest" /> class.
        /// </summary>
        /// <param name="project">The project to add the task to. (required).</param>
        /// <param name="insertAfter">A task in the project to insert the task after, or &#x60;null&#x60; to insert at the beginning of the list..</param>
        /// <param name="insertBefore">A task in the project to insert the task before, or &#x60;null&#x60; to insert at the end of the list..</param>
        /// <param name="section">A section in the project to insert the task into. The task will be inserted at the bottom of the section..</param>
        public TaskAddProjectRequest(string project = default(string), string insertAfter = default(string), string insertBefore = default(string), string section = default(string))
        {
            // to ensure "project" is required (not null)
            if (project == null)
            {
                throw new InvalidDataException("project is a required property for TaskAddProjectRequest and cannot be null");
            }
            else
            {
                this.Project = project;
            }

            this.InsertAfter = insertAfter;
            this.InsertBefore = insertBefore;
            this.Section = section;
            this.InsertAfter = insertAfter;
            this.InsertBefore = insertBefore;
            this.Section = section;
        }

        /// <summary>
        /// The project to add the task to.
        /// </summary>
        /// <value>The project to add the task to.</value>
        [DataMember(Name="project", EmitDefaultValue=true)]
        public string Project { get; set; }

        /// <summary>
        /// A task in the project to insert the task after, or &#x60;null&#x60; to insert at the beginning of the list.
        /// </summary>
        /// <value>A task in the project to insert the task after, or &#x60;null&#x60; to insert at the beginning of the list.</value>
        [DataMember(Name="insert_after", EmitDefaultValue=true)]
        public string InsertAfter { get; set; }

        /// <summary>
        /// A task in the project to insert the task before, or &#x60;null&#x60; to insert at the end of the list.
        /// </summary>
        /// <value>A task in the project to insert the task before, or &#x60;null&#x60; to insert at the end of the list.</value>
        [DataMember(Name="insert_before", EmitDefaultValue=true)]
        public string InsertBefore { get; set; }

        /// <summary>
        /// A section in the project to insert the task into. The task will be inserted at the bottom of the section.
        /// </summary>
        /// <value>A section in the project to insert the task into. The task will be inserted at the bottom of the section.</value>
        [DataMember(Name="section", EmitDefaultValue=true)]
        public string Section { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskAddProjectRequest {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  InsertAfter: ").Append(InsertAfter).Append("\n");
            sb.Append("  InsertBefore: ").Append(InsertBefore).Append("\n");
            sb.Append("  Section: ").Append(Section).Append("\n");
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
            return this.Equals(input as TaskAddProjectRequest);
        }

        /// <summary>
        /// Returns true if TaskAddProjectRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskAddProjectRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskAddProjectRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.InsertAfter == input.InsertAfter ||
                    (this.InsertAfter != null &&
                    this.InsertAfter.Equals(input.InsertAfter))
                ) && 
                (
                    this.InsertBefore == input.InsertBefore ||
                    (this.InsertBefore != null &&
                    this.InsertBefore.Equals(input.InsertBefore))
                ) && 
                (
                    this.Section == input.Section ||
                    (this.Section != null &&
                    this.Section.Equals(input.Section))
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
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.InsertAfter != null)
                    hashCode = hashCode * 59 + this.InsertAfter.GetHashCode();
                if (this.InsertBefore != null)
                    hashCode = hashCode * 59 + this.InsertBefore.GetHashCode();
                if (this.Section != null)
                    hashCode = hashCode * 59 + this.Section.GetHashCode();
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
