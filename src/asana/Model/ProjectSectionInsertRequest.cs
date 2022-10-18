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
    /// ProjectSectionInsertRequest
    /// </summary>
    [DataContract]
    public partial class ProjectSectionInsertRequest :  IEquatable<ProjectSectionInsertRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSectionInsertRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectSectionInsertRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSectionInsertRequest" /> class.
        /// </summary>
        /// <param name="project">The project in which to reorder the given section. (required).</param>
        /// <param name="section">The section to reorder. (required).</param>
        /// <param name="beforeSection">Insert the given section immediately before the section specified by this parameter..</param>
        /// <param name="afterSection">Insert the given section immediately after the section specified by this parameter..</param>
        public ProjectSectionInsertRequest(string project = default(string), string section = default(string), string beforeSection = default(string), string afterSection = default(string))
        {
            // to ensure "project" is required (not null)
            if (project == null)
            {
                throw new InvalidDataException("project is a required property for ProjectSectionInsertRequest and cannot be null");
            }
            else
            {
                this.Project = project;
            }

            // to ensure "section" is required (not null)
            if (section == null)
            {
                throw new InvalidDataException("section is a required property for ProjectSectionInsertRequest and cannot be null");
            }
            else
            {
                this.Section = section;
            }

            this.BeforeSection = beforeSection;
            this.AfterSection = afterSection;
        }

        /// <summary>
        /// The project in which to reorder the given section.
        /// </summary>
        /// <value>The project in which to reorder the given section.</value>
        [DataMember(Name="project", EmitDefaultValue=true)]
        public string Project { get; set; }

        /// <summary>
        /// The section to reorder.
        /// </summary>
        /// <value>The section to reorder.</value>
        [DataMember(Name="section", EmitDefaultValue=true)]
        public string Section { get; set; }

        /// <summary>
        /// Insert the given section immediately before the section specified by this parameter.
        /// </summary>
        /// <value>Insert the given section immediately before the section specified by this parameter.</value>
        [DataMember(Name="before_section", EmitDefaultValue=false)]
        public string BeforeSection { get; set; }

        /// <summary>
        /// Insert the given section immediately after the section specified by this parameter.
        /// </summary>
        /// <value>Insert the given section immediately after the section specified by this parameter.</value>
        [DataMember(Name="after_section", EmitDefaultValue=false)]
        public string AfterSection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectSectionInsertRequest {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Section: ").Append(Section).Append("\n");
            sb.Append("  BeforeSection: ").Append(BeforeSection).Append("\n");
            sb.Append("  AfterSection: ").Append(AfterSection).Append("\n");
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
            return this.Equals(input as ProjectSectionInsertRequest);
        }

        /// <summary>
        /// Returns true if ProjectSectionInsertRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectSectionInsertRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectSectionInsertRequest input)
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
                    this.Section == input.Section ||
                    (this.Section != null &&
                    this.Section.Equals(input.Section))
                ) && 
                (
                    this.BeforeSection == input.BeforeSection ||
                    (this.BeforeSection != null &&
                    this.BeforeSection.Equals(input.BeforeSection))
                ) && 
                (
                    this.AfterSection == input.AfterSection ||
                    (this.AfterSection != null &&
                    this.AfterSection.Equals(input.AfterSection))
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
                if (this.Section != null)
                    hashCode = hashCode * 59 + this.Section.GetHashCode();
                if (this.BeforeSection != null)
                    hashCode = hashCode * 59 + this.BeforeSection.GetHashCode();
                if (this.AfterSection != null)
                    hashCode = hashCode * 59 + this.AfterSection.GetHashCode();
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
