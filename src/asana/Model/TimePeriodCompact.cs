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
    /// TimePeriodCompact
    /// </summary>
    [DataContract]
    public partial class TimePeriodCompact :  IEquatable<TimePeriodCompact>, IValidatableObject
    {
        /// <summary>
        /// The cadence and index of the time period. The value is one of: &#x60;FY&#x60;, &#x60;H1&#x60;, &#x60;H2&#x60;, &#x60;Q1&#x60;, &#x60;Q2&#x60;, &#x60;Q3&#x60;, or &#x60;Q4&#x60;.
        /// </summary>
        /// <value>The cadence and index of the time period. The value is one of: &#x60;FY&#x60;, &#x60;H1&#x60;, &#x60;H2&#x60;, &#x60;Q1&#x60;, &#x60;Q2&#x60;, &#x60;Q3&#x60;, or &#x60;Q4&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodEnum
        {
            /// <summary>
            /// Enum FY for value: FY
            /// </summary>
            [EnumMember(Value = "FY")]
            FY = 1,

            /// <summary>
            /// Enum H1 for value: H1
            /// </summary>
            [EnumMember(Value = "H1")]
            H1 = 2,

            /// <summary>
            /// Enum H2 for value: H2
            /// </summary>
            [EnumMember(Value = "H2")]
            H2 = 3,

            /// <summary>
            /// Enum Q1 for value: Q1
            /// </summary>
            [EnumMember(Value = "Q1")]
            Q1 = 4,

            /// <summary>
            /// Enum Q2 for value: Q2
            /// </summary>
            [EnumMember(Value = "Q2")]
            Q2 = 5,

            /// <summary>
            /// Enum Q3 for value: Q3
            /// </summary>
            [EnumMember(Value = "Q3")]
            Q3 = 6,

            /// <summary>
            /// Enum Q4 for value: Q4
            /// </summary>
            [EnumMember(Value = "Q4")]
            Q4 = 7

        }

        /// <summary>
        /// The cadence and index of the time period. The value is one of: &#x60;FY&#x60;, &#x60;H1&#x60;, &#x60;H2&#x60;, &#x60;Q1&#x60;, &#x60;Q2&#x60;, &#x60;Q3&#x60;, or &#x60;Q4&#x60;.
        /// </summary>
        /// <value>The cadence and index of the time period. The value is one of: &#x60;FY&#x60;, &#x60;H1&#x60;, &#x60;H2&#x60;, &#x60;Q1&#x60;, &#x60;Q2&#x60;, &#x60;Q3&#x60;, or &#x60;Q4&#x60;.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public PeriodEnum? Period { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimePeriodCompact" /> class.
        /// </summary>
        /// <param name="endOn">The localized end date of the time period in &#x60;YYYY-MM-DD&#x60; format..</param>
        /// <param name="startOn">The localized start date of the time period in &#x60;YYYY-MM-DD&#x60; format..</param>
        /// <param name="period">The cadence and index of the time period. The value is one of: &#x60;FY&#x60;, &#x60;H1&#x60;, &#x60;H2&#x60;, &#x60;Q1&#x60;, &#x60;Q2&#x60;, &#x60;Q3&#x60;, or &#x60;Q4&#x60;..</param>
        /// <param name="displayName">A string representing the cadence code and the fiscal year..</param>
        public TimePeriodCompact(string endOn = default(string), string startOn = default(string), PeriodEnum? period = default(PeriodEnum?), string displayName = default(string))
        {
            this.EndOn = endOn;
            this.StartOn = startOn;
            this.Period = period;
            this.DisplayName = displayName;
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
        /// The localized end date of the time period in &#x60;YYYY-MM-DD&#x60; format.
        /// </summary>
        /// <value>The localized end date of the time period in &#x60;YYYY-MM-DD&#x60; format.</value>
        [DataMember(Name="end_on", EmitDefaultValue=false)]
        public string EndOn { get; set; }

        /// <summary>
        /// The localized start date of the time period in &#x60;YYYY-MM-DD&#x60; format.
        /// </summary>
        /// <value>The localized start date of the time period in &#x60;YYYY-MM-DD&#x60; format.</value>
        [DataMember(Name="start_on", EmitDefaultValue=false)]
        public string StartOn { get; set; }


        /// <summary>
        /// A string representing the cadence code and the fiscal year.
        /// </summary>
        /// <value>A string representing the cadence code and the fiscal year.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimePeriodCompact {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  EndOn: ").Append(EndOn).Append("\n");
            sb.Append("  StartOn: ").Append(StartOn).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            return this.Equals(input as TimePeriodCompact);
        }

        /// <summary>
        /// Returns true if TimePeriodCompact instances are equal
        /// </summary>
        /// <param name="input">Instance of TimePeriodCompact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimePeriodCompact input)
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
                    this.EndOn == input.EndOn ||
                    (this.EndOn != null &&
                    this.EndOn.Equals(input.EndOn))
                ) && 
                (
                    this.StartOn == input.StartOn ||
                    (this.StartOn != null &&
                    this.StartOn.Equals(input.StartOn))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                if (this.EndOn != null)
                    hashCode = hashCode * 59 + this.EndOn.GetHashCode();
                if (this.StartOn != null)
                    hashCode = hashCode * 59 + this.StartOn.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
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
