/*
 * Nuvem Fiscal - SDK para .NET
 * https://www.nuvemfiscal.com.br
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = NuvemFiscal.Sdk.Client.FileParameter;
using OpenAPIDateConverter = NuvemFiscal.Sdk.Client.OpenAPIDateConverter;

namespace NuvemFiscal.Sdk.Model
{
    /// <summary>
    /// Grupo de informações de NF ou NFS (Modelo não eletrônico).
    /// </summary>
    [DataContract(Name = "DocNFNFS")]
    public partial class DocNFNFS : IEquatable<DocNFNFS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocNFNFS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocNFNFS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocNFNFS" /> class.
        /// </summary>
        /// <param name="nNFS">Número da Nota Fiscal NF ou NFS. (required).</param>
        /// <param name="modNFS">Modelo da Nota Fiscal NF ou NFS. (required).</param>
        /// <param name="serieNFS">Série Nota Fiscal NF ou NFS. (required).</param>
        public DocNFNFS(int nNFS = default(int), int modNFS = default(int), string serieNFS = default(string))
        {
            this.nNFS = nNFS;
            this.modNFS = modNFS;
            // to ensure "serieNFS" is required (not null)
            if (serieNFS == null)
            {
                throw new ArgumentNullException("serieNFS is a required property for DocNFNFS and cannot be null");
            }
            this.serieNFS = serieNFS;
        }

        /// <summary>
        /// Número da Nota Fiscal NF ou NFS.
        /// </summary>
        /// <value>Número da Nota Fiscal NF ou NFS.</value>
        [DataMember(Name = "nNFS", IsRequired = true, EmitDefaultValue = true)]
        public int nNFS { get; set; }

        /// <summary>
        /// Modelo da Nota Fiscal NF ou NFS.
        /// </summary>
        /// <value>Modelo da Nota Fiscal NF ou NFS.</value>
        [DataMember(Name = "modNFS", IsRequired = true, EmitDefaultValue = true)]
        public int modNFS { get; set; }

        /// <summary>
        /// Série Nota Fiscal NF ou NFS.
        /// </summary>
        /// <value>Série Nota Fiscal NF ou NFS.</value>
        [DataMember(Name = "serieNFS", IsRequired = true, EmitDefaultValue = true)]
        public string serieNFS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocNFNFS {\n");
            sb.Append("  nNFS: ").Append(nNFS).Append("\n");
            sb.Append("  modNFS: ").Append(modNFS).Append("\n");
            sb.Append("  serieNFS: ").Append(serieNFS).Append("\n");
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
            return this.Equals(input as DocNFNFS);
        }

        /// <summary>
        /// Returns true if DocNFNFS instances are equal
        /// </summary>
        /// <param name="input">Instance of DocNFNFS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocNFNFS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nNFS == input.nNFS ||
                    this.nNFS.Equals(input.nNFS)
                ) && 
                (
                    this.modNFS == input.modNFS ||
                    this.modNFS.Equals(input.modNFS)
                ) && 
                (
                    this.serieNFS == input.serieNFS ||
                    (this.serieNFS != null &&
                    this.serieNFS.Equals(input.serieNFS))
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
                hashCode = (hashCode * 59) + this.nNFS.GetHashCode();
                hashCode = (hashCode * 59) + this.modNFS.GetHashCode();
                if (this.serieNFS != null)
                {
                    hashCode = (hashCode * 59) + this.serieNFS.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
