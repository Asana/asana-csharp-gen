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
    /// This object represents a user&#39;s connection to a team.
    /// </summary>
    [DataContract]
    public partial class TeamMembershipCompactAllOf :  IEquatable<TeamMembershipCompactAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembershipCompactAllOf" /> class.
        /// </summary>
        /// <param name="user">user.</param>
        /// <param name="team">team.</param>
        /// <param name="isGuest">Describes if the user is a guest in the team..</param>
        public TeamMembershipCompactAllOf(UserCompact user = default(UserCompact), TeamCompact team = default(TeamCompact), bool isGuest = default(bool))
        {
            this.User = user;
            this.Team = team;
            this.IsGuest = isGuest;
        }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserCompact User { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public TeamCompact Team { get; set; }

        /// <summary>
        /// Describes if the user is a guest in the team.
        /// </summary>
        /// <value>Describes if the user is a guest in the team.</value>
        [DataMember(Name="is_guest", EmitDefaultValue=false)]
        public bool IsGuest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamMembershipCompactAllOf {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  IsGuest: ").Append(IsGuest).Append("\n");
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
            return this.Equals(input as TeamMembershipCompactAllOf);
        }

        /// <summary>
        /// Returns true if TeamMembershipCompactAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamMembershipCompactAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamMembershipCompactAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.IsGuest == input.IsGuest ||
                    (this.IsGuest != null &&
                    this.IsGuest.Equals(input.IsGuest))
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
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.IsGuest != null)
                    hashCode = hashCode * 59 + this.IsGuest.GetHashCode();
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
