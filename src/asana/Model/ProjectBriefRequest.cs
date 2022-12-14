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
    /// ProjectBriefRequest
    /// </summary>
    [DataContract]
    public partial class ProjectBriefRequest :  IEquatable<ProjectBriefRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBriefRequest" /> class.
        /// </summary>
        /// <param name="title">The title of the project brief..</param>
        /// <param name="htmlText">HTML formatted text for the project brief..</param>
        /// <param name="text">The plain text of the project brief. When writing to a project brief, you can specify either &#x60;html_text&#x60; (preferred) or &#x60;text&#x60;, but not both..</param>
        public ProjectBriefRequest(string title = default(string), string htmlText = default(string), string text = default(string))
        {
            this.Title = title;
            this.HtmlText = htmlText;
            this.Text = text;
        }

        /// <summary>
        /// Globally unique identifier of the resource, as a string.
        /// </summary>
        /// <value>Globally unique identifier of the resource, as a string.</value>
        [DataMember(Name="gid", EmitDefaultValue=false)]
        public string Gid { get; private set; }

        /// <summary>
        /// The base type of this resource.
        /// </summary>
        /// <value>The base type of this resource.</value>
        [DataMember(Name="resource_type", EmitDefaultValue=false)]
        public string ResourceType { get; private set; }

        /// <summary>
        /// The title of the project brief.
        /// </summary>
        /// <value>The title of the project brief.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// HTML formatted text for the project brief.
        /// </summary>
        /// <value>HTML formatted text for the project brief.</value>
        [DataMember(Name="html_text", EmitDefaultValue=false)]
        public string HtmlText { get; set; }

        /// <summary>
        /// The plain text of the project brief. When writing to a project brief, you can specify either &#x60;html_text&#x60; (preferred) or &#x60;text&#x60;, but not both.
        /// </summary>
        /// <value>The plain text of the project brief. When writing to a project brief, you can specify either &#x60;html_text&#x60; (preferred) or &#x60;text&#x60;, but not both.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectBriefRequest {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  HtmlText: ").Append(HtmlText).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as ProjectBriefRequest);
        }

        /// <summary>
        /// Returns true if ProjectBriefRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectBriefRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectBriefRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Gid == input.Gid ||
                    (this.Gid != null &&
                    this.Gid.Equals(input.Gid))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.HtmlText == input.HtmlText ||
                    (this.HtmlText != null &&
                    this.HtmlText.Equals(input.HtmlText))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.Gid != null)
                    hashCode = hashCode * 59 + this.Gid.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.HtmlText != null)
                    hashCode = hashCode * 59 + this.HtmlText.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
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
