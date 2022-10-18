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
    /// TaskRemoveProjectRequest
    /// </summary>
    [DataContract]
    public partial class TaskRemoveProjectRequest :  IEquatable<TaskRemoveProjectRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskRemoveProjectRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskRemoveProjectRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskRemoveProjectRequest" /> class.
        /// </summary>
        /// <param name="project">The project to remove the task from. (required).</param>
        public TaskRemoveProjectRequest(string project = default(string))
        {
            // to ensure "project" is required (not null)
            if (project == null)
            {
                throw new InvalidDataException("project is a required property for TaskRemoveProjectRequest and cannot be null");
            }
            else
            {
                this.Project = project;
            }

        }

        /// <summary>
        /// The project to remove the task from.
        /// </summary>
        /// <value>The project to remove the task from.</value>
        [DataMember(Name="project", EmitDefaultValue=true)]
        public string Project { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskRemoveProjectRequest {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
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
            return this.Equals(input as TaskRemoveProjectRequest);
        }

        /// <summary>
        /// Returns true if TaskRemoveProjectRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskRemoveProjectRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskRemoveProjectRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
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
