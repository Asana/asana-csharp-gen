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
    /// GoalRemoveSubgoalRequest
    /// </summary>
    [DataContract]
    public partial class GoalRemoveSubgoalRequest :  IEquatable<GoalRemoveSubgoalRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoalRemoveSubgoalRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GoalRemoveSubgoalRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoalRemoveSubgoalRequest" /> class.
        /// </summary>
        /// <param name="subgoal">The goal gid to remove as subgoal from the parent goal (required).</param>
        public GoalRemoveSubgoalRequest(string subgoal = default(string))
        {
            // to ensure "subgoal" is required (not null)
            if (subgoal == null)
            {
                throw new InvalidDataException("subgoal is a required property for GoalRemoveSubgoalRequest and cannot be null");
            }
            else
            {
                this.Subgoal = subgoal;
            }

        }

        /// <summary>
        /// The goal gid to remove as subgoal from the parent goal
        /// </summary>
        /// <value>The goal gid to remove as subgoal from the parent goal</value>
        [DataMember(Name="subgoal", EmitDefaultValue=true)]
        public string Subgoal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoalRemoveSubgoalRequest {\n");
            sb.Append("  Subgoal: ").Append(Subgoal).Append("\n");
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
            return this.Equals(input as GoalRemoveSubgoalRequest);
        }

        /// <summary>
        /// Returns true if GoalRemoveSubgoalRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GoalRemoveSubgoalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoalRemoveSubgoalRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Subgoal == input.Subgoal ||
                    (this.Subgoal != null &&
                    this.Subgoal.Equals(input.Subgoal))
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
                if (this.Subgoal != null)
                    hashCode = hashCode * 59 + this.Subgoal.GetHashCode();
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
