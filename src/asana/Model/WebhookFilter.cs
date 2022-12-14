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
    /// A WebhookFilter can be passed on creation of a webhook in order to filter the types of actions that trigger delivery of an [Event](/docs/tocS_Event)
    /// </summary>
    [DataContract]
    public partial class WebhookFilter :  IEquatable<WebhookFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookFilter" /> class.
        /// </summary>
        /// <param name="resourceType">The type of the resource which created the event when modified; for example, to filter to changes on regular tasks this field should be set to &#x60;task&#x60;..</param>
        /// <param name="resourceSubtype">The resource subtype of the resource that the filter applies to. This should be set to the same value as is returned on the &#x60;resource_subtype&#x60; field on the resources themselves..</param>
        /// <param name="action">The type of change on the **resource** to pass through the filter. For more information refer to &#x60;Event.action&#x60; in the [Event](/docs/tocS_Event) schema. This can be one of &#x60;changed&#x60;, &#x60;added&#x60;, &#x60;removed&#x60;, &#x60;deleted&#x60;, and &#x60;undeleted&#x60; depending on the nature of what has occurred on the resource..</param>
        /// <param name="fields">*Conditional.* A whitelist of fields for events which will pass the filter when the resource is changed. These can be any combination of the fields on the resources themselves. This field is only valid for &#x60;action&#x60; of type &#x60;changed&#x60;.</param>
        public WebhookFilter(string resourceType = default(string), string resourceSubtype = default(string), string action = default(string), List<string> fields = default(List<string>))
        {
            this.ResourceType = resourceType;
            this.ResourceSubtype = resourceSubtype;
            this.Action = action;
            this.Fields = fields;
        }

        /// <summary>
        /// The type of the resource which created the event when modified; for example, to filter to changes on regular tasks this field should be set to &#x60;task&#x60;.
        /// </summary>
        /// <value>The type of the resource which created the event when modified; for example, to filter to changes on regular tasks this field should be set to &#x60;task&#x60;.</value>
        [DataMember(Name="resource_type", EmitDefaultValue=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The resource subtype of the resource that the filter applies to. This should be set to the same value as is returned on the &#x60;resource_subtype&#x60; field on the resources themselves.
        /// </summary>
        /// <value>The resource subtype of the resource that the filter applies to. This should be set to the same value as is returned on the &#x60;resource_subtype&#x60; field on the resources themselves.</value>
        [DataMember(Name="resource_subtype", EmitDefaultValue=false)]
        public string ResourceSubtype { get; set; }

        /// <summary>
        /// The type of change on the **resource** to pass through the filter. For more information refer to &#x60;Event.action&#x60; in the [Event](/docs/tocS_Event) schema. This can be one of &#x60;changed&#x60;, &#x60;added&#x60;, &#x60;removed&#x60;, &#x60;deleted&#x60;, and &#x60;undeleted&#x60; depending on the nature of what has occurred on the resource.
        /// </summary>
        /// <value>The type of change on the **resource** to pass through the filter. For more information refer to &#x60;Event.action&#x60; in the [Event](/docs/tocS_Event) schema. This can be one of &#x60;changed&#x60;, &#x60;added&#x60;, &#x60;removed&#x60;, &#x60;deleted&#x60;, and &#x60;undeleted&#x60; depending on the nature of what has occurred on the resource.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// *Conditional.* A whitelist of fields for events which will pass the filter when the resource is changed. These can be any combination of the fields on the resources themselves. This field is only valid for &#x60;action&#x60; of type &#x60;changed&#x60;
        /// </summary>
        /// <value>*Conditional.* A whitelist of fields for events which will pass the filter when the resource is changed. These can be any combination of the fields on the resources themselves. This field is only valid for &#x60;action&#x60; of type &#x60;changed&#x60;</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookFilter {\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  ResourceSubtype: ").Append(ResourceSubtype).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as WebhookFilter);
        }

        /// <summary>
        /// Returns true if WebhookFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.ResourceSubtype == input.ResourceSubtype ||
                    (this.ResourceSubtype != null &&
                    this.ResourceSubtype.Equals(input.ResourceSubtype))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceSubtype != null)
                    hashCode = hashCode * 59 + this.ResourceSubtype.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
