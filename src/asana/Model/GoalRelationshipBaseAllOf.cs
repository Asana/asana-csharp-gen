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
    /// GoalRelationshipBaseAllOf
    /// </summary>
    [DataContract]
    public partial class GoalRelationshipBaseAllOf :  IEquatable<GoalRelationshipBaseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoalRelationshipBaseAllOf" /> class.
        /// </summary>
        /// <param name="supportedGoal">supportedGoal.</param>
        public GoalRelationshipBaseAllOf(GoalCompact supportedGoal = default(GoalCompact))
        {
            this.SupportedGoal = supportedGoal;
        }

        /// <summary>
        /// Gets or Sets SupportedGoal
        /// </summary>
        [DataMember(Name="supported_goal", EmitDefaultValue=false)]
        public GoalCompact SupportedGoal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoalRelationshipBaseAllOf {\n");
            sb.Append("  SupportedGoal: ").Append(SupportedGoal).Append("\n");
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
            return this.Equals(input as GoalRelationshipBaseAllOf);
        }

        /// <summary>
        /// Returns true if GoalRelationshipBaseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of GoalRelationshipBaseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoalRelationshipBaseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SupportedGoal == input.SupportedGoal ||
                    (this.SupportedGoal != null &&
                    this.SupportedGoal.Equals(input.SupportedGoal))
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
                if (this.SupportedGoal != null)
                    hashCode = hashCode * 59 + this.SupportedGoal.GetHashCode();
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