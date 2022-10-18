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
    /// GoalBaseAllOf
    /// </summary>
    [DataContract]
    public partial class GoalBaseAllOf :  IEquatable<GoalBaseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoalBaseAllOf" /> class.
        /// </summary>
        /// <param name="name">The name of the goal..</param>
        /// <param name="htmlNotes">The notes of the goal with formatting as HTML..</param>
        /// <param name="notes">Free-form textual information associated with the goal (i.e. its description)..</param>
        /// <param name="dueOn">The localized day on which this goal is due. This takes a date with format &#x60;YYYY-MM-DD&#x60;..</param>
        /// <param name="startOn">The day on which work for this goal begins, or null if the goal has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format, and cannot be set unless there is an accompanying due date..</param>
        /// <param name="status">The current status of this goal. When the goal is open, its status can be &#x60;green&#x60;, &#x60;yellow&#x60;, and &#x60;red&#x60; to reflect \&quot;On Track\&quot;, \&quot;At Risk\&quot;, and \&quot;Off Track\&quot;, respectively. When the goal is closed, the value can be &#x60;missed&#x60;, &#x60;achieved&#x60;, &#x60;partial&#x60;, or &#x60;dropped&#x60;. *Note* you can only write to this property if &#x60;metric&#x60; is set..</param>
        /// <param name="isWorkspaceLevel">*Conditional*. This property is only present when the &#x60;workspace&#x60; provided is an organization. Whether the goal belongs to the &#x60;workspace&#x60; (and is listed as part of the workspace’s goals) or not. If it isn’t a workspace-level goal, it is a team-level goal, and is associated with the goal’s team..</param>
        /// <param name="liked">True if the goal is liked by the authorized user, false if not..</param>
        public GoalBaseAllOf(string name = default(string), string htmlNotes = default(string), string notes = default(string), string dueOn = default(string), string startOn = default(string), string status = default(string), bool isWorkspaceLevel = default(bool), bool liked = default(bool))
        {
            this.DueOn = dueOn;
            this.StartOn = startOn;
            this.Status = status;
            this.Name = name;
            this.HtmlNotes = htmlNotes;
            this.Notes = notes;
            this.DueOn = dueOn;
            this.StartOn = startOn;
            this.Status = status;
            this.IsWorkspaceLevel = isWorkspaceLevel;
            this.Liked = liked;
        }

        /// <summary>
        /// The name of the goal.
        /// </summary>
        /// <value>The name of the goal.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The notes of the goal with formatting as HTML.
        /// </summary>
        /// <value>The notes of the goal with formatting as HTML.</value>
        [DataMember(Name="html_notes", EmitDefaultValue=false)]
        public string HtmlNotes { get; set; }

        /// <summary>
        /// Free-form textual information associated with the goal (i.e. its description).
        /// </summary>
        /// <value>Free-form textual information associated with the goal (i.e. its description).</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// The localized day on which this goal is due. This takes a date with format &#x60;YYYY-MM-DD&#x60;.
        /// </summary>
        /// <value>The localized day on which this goal is due. This takes a date with format &#x60;YYYY-MM-DD&#x60;.</value>
        [DataMember(Name="due_on", EmitDefaultValue=true)]
        public string DueOn { get; set; }

        /// <summary>
        /// The day on which work for this goal begins, or null if the goal has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format, and cannot be set unless there is an accompanying due date.
        /// </summary>
        /// <value>The day on which work for this goal begins, or null if the goal has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format, and cannot be set unless there is an accompanying due date.</value>
        [DataMember(Name="start_on", EmitDefaultValue=true)]
        public string StartOn { get; set; }

        /// <summary>
        /// The current status of this goal. When the goal is open, its status can be &#x60;green&#x60;, &#x60;yellow&#x60;, and &#x60;red&#x60; to reflect \&quot;On Track\&quot;, \&quot;At Risk\&quot;, and \&quot;Off Track\&quot;, respectively. When the goal is closed, the value can be &#x60;missed&#x60;, &#x60;achieved&#x60;, &#x60;partial&#x60;, or &#x60;dropped&#x60;. *Note* you can only write to this property if &#x60;metric&#x60; is set.
        /// </summary>
        /// <value>The current status of this goal. When the goal is open, its status can be &#x60;green&#x60;, &#x60;yellow&#x60;, and &#x60;red&#x60; to reflect \&quot;On Track\&quot;, \&quot;At Risk\&quot;, and \&quot;Off Track\&quot;, respectively. When the goal is closed, the value can be &#x60;missed&#x60;, &#x60;achieved&#x60;, &#x60;partial&#x60;, or &#x60;dropped&#x60;. *Note* you can only write to this property if &#x60;metric&#x60; is set.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public string Status { get; set; }

        /// <summary>
        /// *Conditional*. This property is only present when the &#x60;workspace&#x60; provided is an organization. Whether the goal belongs to the &#x60;workspace&#x60; (and is listed as part of the workspace’s goals) or not. If it isn’t a workspace-level goal, it is a team-level goal, and is associated with the goal’s team.
        /// </summary>
        /// <value>*Conditional*. This property is only present when the &#x60;workspace&#x60; provided is an organization. Whether the goal belongs to the &#x60;workspace&#x60; (and is listed as part of the workspace’s goals) or not. If it isn’t a workspace-level goal, it is a team-level goal, and is associated with the goal’s team.</value>
        [DataMember(Name="is_workspace_level", EmitDefaultValue=false)]
        public bool IsWorkspaceLevel { get; set; }

        /// <summary>
        /// True if the goal is liked by the authorized user, false if not.
        /// </summary>
        /// <value>True if the goal is liked by the authorized user, false if not.</value>
        [DataMember(Name="liked", EmitDefaultValue=false)]
        public bool Liked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoalBaseAllOf {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HtmlNotes: ").Append(HtmlNotes).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  DueOn: ").Append(DueOn).Append("\n");
            sb.Append("  StartOn: ").Append(StartOn).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IsWorkspaceLevel: ").Append(IsWorkspaceLevel).Append("\n");
            sb.Append("  Liked: ").Append(Liked).Append("\n");
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
            return this.Equals(input as GoalBaseAllOf);
        }

        /// <summary>
        /// Returns true if GoalBaseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of GoalBaseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoalBaseAllOf input)
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
                    this.HtmlNotes == input.HtmlNotes ||
                    (this.HtmlNotes != null &&
                    this.HtmlNotes.Equals(input.HtmlNotes))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.IsWorkspaceLevel == input.IsWorkspaceLevel ||
                    (this.IsWorkspaceLevel != null &&
                    this.IsWorkspaceLevel.Equals(input.IsWorkspaceLevel))
                ) && 
                (
                    this.Liked == input.Liked ||
                    (this.Liked != null &&
                    this.Liked.Equals(input.Liked))
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
                if (this.HtmlNotes != null)
                    hashCode = hashCode * 59 + this.HtmlNotes.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.DueOn != null)
                    hashCode = hashCode * 59 + this.DueOn.GetHashCode();
                if (this.StartOn != null)
                    hashCode = hashCode * 59 + this.StartOn.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IsWorkspaceLevel != null)
                    hashCode = hashCode * 59 + this.IsWorkspaceLevel.GetHashCode();
                if (this.Liked != null)
                    hashCode = hashCode * 59 + this.Liked.GetHashCode();
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
