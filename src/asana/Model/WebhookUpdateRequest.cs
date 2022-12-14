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
    /// WebhookUpdateRequest
    /// </summary>
    [DataContract]
    public partial class WebhookUpdateRequest :  IEquatable<WebhookUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUpdateRequest" /> class.
        /// </summary>
        /// <param name="filters">An array of WebhookFilter objects to specify a whitelist of filters to apply to events from this webhook. If a webhook event passes any of the filters the event will be delivered; otherwise no event will be sent to the receiving server..</param>
        public WebhookUpdateRequest(List<WebhookRequestFiltersInner> filters = default(List<WebhookRequestFiltersInner>))
        {
            this.Filters = filters;
        }

        /// <summary>
        /// An array of WebhookFilter objects to specify a whitelist of filters to apply to events from this webhook. If a webhook event passes any of the filters the event will be delivered; otherwise no event will be sent to the receiving server.
        /// </summary>
        /// <value>An array of WebhookFilter objects to specify a whitelist of filters to apply to events from this webhook. If a webhook event passes any of the filters the event will be delivered; otherwise no event will be sent to the receiving server.</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<WebhookRequestFiltersInner> Filters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookUpdateRequest {\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
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
            return this.Equals(input as WebhookUpdateRequest);
        }

        /// <summary>
        /// Returns true if WebhookUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    input.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
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
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
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
