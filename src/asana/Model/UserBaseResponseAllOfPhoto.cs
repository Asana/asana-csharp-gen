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
    /// A map of the user’s profile photo in various sizes, or null if no photo is set. Sizes provided are 21, 27, 36, 60, 128, and 1024. All images are in PNG format, except for 1024 (which is in JPEG format).
    /// </summary>
    [DataContract]
    public partial class UserBaseResponseAllOfPhoto :  IEquatable<UserBaseResponseAllOfPhoto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserBaseResponseAllOfPhoto" /> class.
        /// </summary>
        /// <param name="image21x21">image21x21.</param>
        /// <param name="image27x27">image27x27.</param>
        /// <param name="image36x36">image36x36.</param>
        /// <param name="image60x60">image60x60.</param>
        /// <param name="image128x128">image128x128.</param>
        /// <param name="image1024x1024">image1024x1024.</param>
        public UserBaseResponseAllOfPhoto(string image21x21 = default(string), string image27x27 = default(string), string image36x36 = default(string), string image60x60 = default(string), string image128x128 = default(string), string image1024x1024 = default(string))
        {
            this.Image21x21 = image21x21;
            this.Image27x27 = image27x27;
            this.Image36x36 = image36x36;
            this.Image60x60 = image60x60;
            this.Image128x128 = image128x128;
            this.Image1024x1024 = image1024x1024;
        }

        /// <summary>
        /// Gets or Sets Image21x21
        /// </summary>
        [DataMember(Name="image_21x21", EmitDefaultValue=false)]
        public string Image21x21 { get; set; }

        /// <summary>
        /// Gets or Sets Image27x27
        /// </summary>
        [DataMember(Name="image_27x27", EmitDefaultValue=false)]
        public string Image27x27 { get; set; }

        /// <summary>
        /// Gets or Sets Image36x36
        /// </summary>
        [DataMember(Name="image_36x36", EmitDefaultValue=false)]
        public string Image36x36 { get; set; }

        /// <summary>
        /// Gets or Sets Image60x60
        /// </summary>
        [DataMember(Name="image_60x60", EmitDefaultValue=false)]
        public string Image60x60 { get; set; }

        /// <summary>
        /// Gets or Sets Image128x128
        /// </summary>
        [DataMember(Name="image_128x128", EmitDefaultValue=false)]
        public string Image128x128 { get; set; }

        /// <summary>
        /// Gets or Sets Image1024x1024
        /// </summary>
        [DataMember(Name="image_1024x1024", EmitDefaultValue=false)]
        public string Image1024x1024 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserBaseResponseAllOfPhoto {\n");
            sb.Append("  Image21x21: ").Append(Image21x21).Append("\n");
            sb.Append("  Image27x27: ").Append(Image27x27).Append("\n");
            sb.Append("  Image36x36: ").Append(Image36x36).Append("\n");
            sb.Append("  Image60x60: ").Append(Image60x60).Append("\n");
            sb.Append("  Image128x128: ").Append(Image128x128).Append("\n");
            sb.Append("  Image1024x1024: ").Append(Image1024x1024).Append("\n");
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
            return this.Equals(input as UserBaseResponseAllOfPhoto);
        }

        /// <summary>
        /// Returns true if UserBaseResponseAllOfPhoto instances are equal
        /// </summary>
        /// <param name="input">Instance of UserBaseResponseAllOfPhoto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserBaseResponseAllOfPhoto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Image21x21 == input.Image21x21 ||
                    (this.Image21x21 != null &&
                    this.Image21x21.Equals(input.Image21x21))
                ) && 
                (
                    this.Image27x27 == input.Image27x27 ||
                    (this.Image27x27 != null &&
                    this.Image27x27.Equals(input.Image27x27))
                ) && 
                (
                    this.Image36x36 == input.Image36x36 ||
                    (this.Image36x36 != null &&
                    this.Image36x36.Equals(input.Image36x36))
                ) && 
                (
                    this.Image60x60 == input.Image60x60 ||
                    (this.Image60x60 != null &&
                    this.Image60x60.Equals(input.Image60x60))
                ) && 
                (
                    this.Image128x128 == input.Image128x128 ||
                    (this.Image128x128 != null &&
                    this.Image128x128.Equals(input.Image128x128))
                ) && 
                (
                    this.Image1024x1024 == input.Image1024x1024 ||
                    (this.Image1024x1024 != null &&
                    this.Image1024x1024.Equals(input.Image1024x1024))
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
                if (this.Image21x21 != null)
                    hashCode = hashCode * 59 + this.Image21x21.GetHashCode();
                if (this.Image27x27 != null)
                    hashCode = hashCode * 59 + this.Image27x27.GetHashCode();
                if (this.Image36x36 != null)
                    hashCode = hashCode * 59 + this.Image36x36.GetHashCode();
                if (this.Image60x60 != null)
                    hashCode = hashCode * 59 + this.Image60x60.GetHashCode();
                if (this.Image128x128 != null)
                    hashCode = hashCode * 59 + this.Image128x128.GetHashCode();
                if (this.Image1024x1024 != null)
                    hashCode = hashCode * 59 + this.Image1024x1024.GetHashCode();
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