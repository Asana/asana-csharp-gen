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
    /// A response object returned from a batch request.
    /// </summary>
    [DataContract]
    public partial class BatchResponse :  IEquatable<BatchResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResponse" /> class.
        /// </summary>
        /// <param name="statusCode">The HTTP status code that the invoked endpoint returned..</param>
        /// <param name="headers">A map of HTTP headers specific to this result. This is primarily used for returning a &#x60;Location&#x60; header to accompany a &#x60;201 Created&#x60; result.  The parent HTTP response will contain all common headers..</param>
        /// <param name="body">The JSON body that the invoked endpoint returned..</param>
        public BatchResponse(int statusCode = default(int), Object headers = default(Object), Object body = default(Object))
        {
            this.StatusCode = statusCode;
            this.Headers = headers;
            this.Body = body;
        }

        /// <summary>
        /// The HTTP status code that the invoked endpoint returned.
        /// </summary>
        /// <value>The HTTP status code that the invoked endpoint returned.</value>
        [DataMember(Name="status_code", EmitDefaultValue=false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// A map of HTTP headers specific to this result. This is primarily used for returning a &#x60;Location&#x60; header to accompany a &#x60;201 Created&#x60; result.  The parent HTTP response will contain all common headers.
        /// </summary>
        /// <value>A map of HTTP headers specific to this result. This is primarily used for returning a &#x60;Location&#x60; header to accompany a &#x60;201 Created&#x60; result.  The parent HTTP response will contain all common headers.</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Object Headers { get; set; }

        /// <summary>
        /// The JSON body that the invoked endpoint returned.
        /// </summary>
        /// <value>The JSON body that the invoked endpoint returned.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public Object Body { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchResponse {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
            return this.Equals(input as BatchResponse);
        }

        /// <summary>
        /// Returns true if BatchResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.Headers == input.Headers ||
                    (this.Headers != null &&
                    this.Headers.Equals(input.Headers))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
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
