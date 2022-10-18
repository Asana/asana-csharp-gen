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
    /// AuditLogEventContext
    /// </summary>
    [DataContract]
    public partial class AuditLogEventContext :  IEquatable<AuditLogEventContext>, IValidatableObject
    {
        /// <summary>
        /// The type of context. Can be one of &#x60;web&#x60;, &#x60;desktop&#x60;, &#x60;mobile&#x60;, &#x60;asana_support&#x60;, &#x60;asana&#x60;, &#x60;email&#x60;, or &#x60;api&#x60;.
        /// </summary>
        /// <value>The type of context. Can be one of &#x60;web&#x60;, &#x60;desktop&#x60;, &#x60;mobile&#x60;, &#x60;asana_support&#x60;, &#x60;asana&#x60;, &#x60;email&#x60;, or &#x60;api&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContextTypeEnum
        {
            /// <summary>
            /// Enum Web for value: web
            /// </summary>
            [EnumMember(Value = "web")]
            Web = 1,

            /// <summary>
            /// Enum Desktop for value: desktop
            /// </summary>
            [EnumMember(Value = "desktop")]
            Desktop = 2,

            /// <summary>
            /// Enum Mobile for value: mobile
            /// </summary>
            [EnumMember(Value = "mobile")]
            Mobile = 3,

            /// <summary>
            /// Enum Asanasupport for value: asana_support
            /// </summary>
            [EnumMember(Value = "asana_support")]
            Asanasupport = 4,

            /// <summary>
            /// Enum Asana for value: asana
            /// </summary>
            [EnumMember(Value = "asana")]
            Asana = 5,

            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 6,

            /// <summary>
            /// Enum Api for value: api
            /// </summary>
            [EnumMember(Value = "api")]
            Api = 7

        }

        /// <summary>
        /// The type of context. Can be one of &#x60;web&#x60;, &#x60;desktop&#x60;, &#x60;mobile&#x60;, &#x60;asana_support&#x60;, &#x60;asana&#x60;, &#x60;email&#x60;, or &#x60;api&#x60;.
        /// </summary>
        /// <value>The type of context. Can be one of &#x60;web&#x60;, &#x60;desktop&#x60;, &#x60;mobile&#x60;, &#x60;asana_support&#x60;, &#x60;asana&#x60;, &#x60;email&#x60;, or &#x60;api&#x60;.</value>
        [DataMember(Name="context_type", EmitDefaultValue=false)]
        public ContextTypeEnum? ContextType { get; set; }
        /// <summary>
        /// The authentication method used in the context of an API request. Only present if the &#x60;context_type&#x60; is &#x60;api&#x60;. Can be one of &#x60;cookie&#x60;, &#x60;oauth&#x60;, &#x60;personal_access_token&#x60;, or &#x60;service_account&#x60;.
        /// </summary>
        /// <value>The authentication method used in the context of an API request. Only present if the &#x60;context_type&#x60; is &#x60;api&#x60;. Can be one of &#x60;cookie&#x60;, &#x60;oauth&#x60;, &#x60;personal_access_token&#x60;, or &#x60;service_account&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApiAuthenticationMethodEnum
        {
            /// <summary>
            /// Enum Cookie for value: cookie
            /// </summary>
            [EnumMember(Value = "cookie")]
            Cookie = 1,

            /// <summary>
            /// Enum Oauth for value: oauth
            /// </summary>
            [EnumMember(Value = "oauth")]
            Oauth = 2,

            /// <summary>
            /// Enum Personalaccesstoken for value: personal_access_token
            /// </summary>
            [EnumMember(Value = "personal_access_token")]
            Personalaccesstoken = 3,

            /// <summary>
            /// Enum Serviceaccount for value: service_account
            /// </summary>
            [EnumMember(Value = "service_account")]
            Serviceaccount = 4

        }

        /// <summary>
        /// The authentication method used in the context of an API request. Only present if the &#x60;context_type&#x60; is &#x60;api&#x60;. Can be one of &#x60;cookie&#x60;, &#x60;oauth&#x60;, &#x60;personal_access_token&#x60;, or &#x60;service_account&#x60;.
        /// </summary>
        /// <value>The authentication method used in the context of an API request. Only present if the &#x60;context_type&#x60; is &#x60;api&#x60;. Can be one of &#x60;cookie&#x60;, &#x60;oauth&#x60;, &#x60;personal_access_token&#x60;, or &#x60;service_account&#x60;.</value>
        [DataMember(Name="api_authentication_method", EmitDefaultValue=false)]
        public ApiAuthenticationMethodEnum? ApiAuthenticationMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventContext" /> class.
        /// </summary>
        /// <param name="contextType">The type of context. Can be one of &#x60;web&#x60;, &#x60;desktop&#x60;, &#x60;mobile&#x60;, &#x60;asana_support&#x60;, &#x60;asana&#x60;, &#x60;email&#x60;, or &#x60;api&#x60;..</param>
        /// <param name="apiAuthenticationMethod">The authentication method used in the context of an API request. Only present if the &#x60;context_type&#x60; is &#x60;api&#x60;. Can be one of &#x60;cookie&#x60;, &#x60;oauth&#x60;, &#x60;personal_access_token&#x60;, or &#x60;service_account&#x60;..</param>
        /// <param name="clientIpAddress">The IP address of the client that initiated the event, if applicable..</param>
        /// <param name="userAgent">The user agent of the client that initiated the event, if applicable..</param>
        /// <param name="oauthAppName">The name of the OAuth App that initiated the event. Only present if the &#x60;api_authentication_method&#x60; is &#x60;oauth&#x60;..</param>
        public AuditLogEventContext(ContextTypeEnum? contextType = default(ContextTypeEnum?), ApiAuthenticationMethodEnum? apiAuthenticationMethod = default(ApiAuthenticationMethodEnum?), string clientIpAddress = default(string), string userAgent = default(string), string oauthAppName = default(string))
        {
            this.ContextType = contextType;
            this.ApiAuthenticationMethod = apiAuthenticationMethod;
            this.ClientIpAddress = clientIpAddress;
            this.UserAgent = userAgent;
            this.OauthAppName = oauthAppName;
        }



        /// <summary>
        /// The IP address of the client that initiated the event, if applicable.
        /// </summary>
        /// <value>The IP address of the client that initiated the event, if applicable.</value>
        [DataMember(Name="client_ip_address", EmitDefaultValue=false)]
        public string ClientIpAddress { get; set; }

        /// <summary>
        /// The user agent of the client that initiated the event, if applicable.
        /// </summary>
        /// <value>The user agent of the client that initiated the event, if applicable.</value>
        [DataMember(Name="user_agent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// The name of the OAuth App that initiated the event. Only present if the &#x60;api_authentication_method&#x60; is &#x60;oauth&#x60;.
        /// </summary>
        /// <value>The name of the OAuth App that initiated the event. Only present if the &#x60;api_authentication_method&#x60; is &#x60;oauth&#x60;.</value>
        [DataMember(Name="oauth_app_name", EmitDefaultValue=false)]
        public string OauthAppName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditLogEventContext {\n");
            sb.Append("  ContextType: ").Append(ContextType).Append("\n");
            sb.Append("  ApiAuthenticationMethod: ").Append(ApiAuthenticationMethod).Append("\n");
            sb.Append("  ClientIpAddress: ").Append(ClientIpAddress).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  OauthAppName: ").Append(OauthAppName).Append("\n");
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
            return this.Equals(input as AuditLogEventContext);
        }

        /// <summary>
        /// Returns true if AuditLogEventContext instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditLogEventContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditLogEventContext input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContextType == input.ContextType ||
                    (this.ContextType != null &&
                    this.ContextType.Equals(input.ContextType))
                ) && 
                (
                    this.ApiAuthenticationMethod == input.ApiAuthenticationMethod ||
                    (this.ApiAuthenticationMethod != null &&
                    this.ApiAuthenticationMethod.Equals(input.ApiAuthenticationMethod))
                ) && 
                (
                    this.ClientIpAddress == input.ClientIpAddress ||
                    (this.ClientIpAddress != null &&
                    this.ClientIpAddress.Equals(input.ClientIpAddress))
                ) && 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
                ) && 
                (
                    this.OauthAppName == input.OauthAppName ||
                    (this.OauthAppName != null &&
                    this.OauthAppName.Equals(input.OauthAppName))
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
                if (this.ContextType != null)
                    hashCode = hashCode * 59 + this.ContextType.GetHashCode();
                if (this.ApiAuthenticationMethod != null)
                    hashCode = hashCode * 59 + this.ApiAuthenticationMethod.GetHashCode();
                if (this.ClientIpAddress != null)
                    hashCode = hashCode * 59 + this.ClientIpAddress.GetHashCode();
                if (this.UserAgent != null)
                    hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
                if (this.OauthAppName != null)
                    hashCode = hashCode * 59 + this.OauthAppName.GetHashCode();
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
