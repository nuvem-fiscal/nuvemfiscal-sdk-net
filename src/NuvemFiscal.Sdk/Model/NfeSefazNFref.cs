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
    /// Grupo de infromações da NF referenciada.
    /// </summary>
    [DataContract(Name = "NfeSefazNFref")]
    public partial class NfeSefazNFref : IEquatable<NfeSefazNFref>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazNFref" /> class.
        /// </summary>
        /// <param name="refNFe">Chave de acesso das NF-e referenciadas. Chave de acesso compostas por Código da UF (tabela do IBGE) + AAMM da emissão + CNPJ do Emitente + modelo, série e número da NF-e Referenciada + Código Numérico + DV..</param>
        /// <param name="refNFeSig">Referencia uma NF-e (modelo 55) emitida anteriormente pela sua Chave de Acesso com código numérico zerado, permitindo manter o sigilo da NF-e referenciada..</param>
        /// <param name="refNF">refNF.</param>
        /// <param name="refNFP">refNFP.</param>
        /// <param name="refCTe">Utilizar esta TAG para referenciar um CT-e emitido anteriormente, vinculada a NF-e atual..</param>
        /// <param name="refECF">refECF.</param>
        public NfeSefazNFref(string refNFe = default(string), string refNFeSig = default(string), NfeSefazRefNF refNF = default(NfeSefazRefNF), NfeSefazRefNFP refNFP = default(NfeSefazRefNFP), string refCTe = default(string), NfeSefazRefECF refECF = default(NfeSefazRefECF))
        {
            this.refNFe = refNFe;
            this.refNFeSig = refNFeSig;
            this.refNF = refNF;
            this.refNFP = refNFP;
            this.refCTe = refCTe;
            this.refECF = refECF;
        }

        /// <summary>
        /// Chave de acesso das NF-e referenciadas. Chave de acesso compostas por Código da UF (tabela do IBGE) + AAMM da emissão + CNPJ do Emitente + modelo, série e número da NF-e Referenciada + Código Numérico + DV.
        /// </summary>
        /// <value>Chave de acesso das NF-e referenciadas. Chave de acesso compostas por Código da UF (tabela do IBGE) + AAMM da emissão + CNPJ do Emitente + modelo, série e número da NF-e Referenciada + Código Numérico + DV.</value>
        [DataMember(Name = "refNFe", EmitDefaultValue = true)]
        public string refNFe { get; set; }

        /// <summary>
        /// Referencia uma NF-e (modelo 55) emitida anteriormente pela sua Chave de Acesso com código numérico zerado, permitindo manter o sigilo da NF-e referenciada.
        /// </summary>
        /// <value>Referencia uma NF-e (modelo 55) emitida anteriormente pela sua Chave de Acesso com código numérico zerado, permitindo manter o sigilo da NF-e referenciada.</value>
        [DataMember(Name = "refNFeSig", EmitDefaultValue = true)]
        public string refNFeSig { get; set; }

        /// <summary>
        /// Gets or Sets refNF
        /// </summary>
        [DataMember(Name = "refNF", EmitDefaultValue = false)]
        public NfeSefazRefNF refNF { get; set; }

        /// <summary>
        /// Gets or Sets refNFP
        /// </summary>
        [DataMember(Name = "refNFP", EmitDefaultValue = false)]
        public NfeSefazRefNFP refNFP { get; set; }

        /// <summary>
        /// Utilizar esta TAG para referenciar um CT-e emitido anteriormente, vinculada a NF-e atual.
        /// </summary>
        /// <value>Utilizar esta TAG para referenciar um CT-e emitido anteriormente, vinculada a NF-e atual.</value>
        [DataMember(Name = "refCTe", EmitDefaultValue = true)]
        public string refCTe { get; set; }

        /// <summary>
        /// Gets or Sets refECF
        /// </summary>
        [DataMember(Name = "refECF", EmitDefaultValue = false)]
        public NfeSefazRefECF refECF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazNFref {\n");
            sb.Append("  refNFe: ").Append(refNFe).Append("\n");
            sb.Append("  refNFeSig: ").Append(refNFeSig).Append("\n");
            sb.Append("  refNF: ").Append(refNF).Append("\n");
            sb.Append("  refNFP: ").Append(refNFP).Append("\n");
            sb.Append("  refCTe: ").Append(refCTe).Append("\n");
            sb.Append("  refECF: ").Append(refECF).Append("\n");
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
            return this.Equals(input as NfeSefazNFref);
        }

        /// <summary>
        /// Returns true if NfeSefazNFref instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazNFref to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazNFref input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.refNFe == input.refNFe ||
                    (this.refNFe != null &&
                    this.refNFe.Equals(input.refNFe))
                ) && 
                (
                    this.refNFeSig == input.refNFeSig ||
                    (this.refNFeSig != null &&
                    this.refNFeSig.Equals(input.refNFeSig))
                ) && 
                (
                    this.refNF == input.refNF ||
                    (this.refNF != null &&
                    this.refNF.Equals(input.refNF))
                ) && 
                (
                    this.refNFP == input.refNFP ||
                    (this.refNFP != null &&
                    this.refNFP.Equals(input.refNFP))
                ) && 
                (
                    this.refCTe == input.refCTe ||
                    (this.refCTe != null &&
                    this.refCTe.Equals(input.refCTe))
                ) && 
                (
                    this.refECF == input.refECF ||
                    (this.refECF != null &&
                    this.refECF.Equals(input.refECF))
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
                if (this.refNFe != null)
                {
                    hashCode = (hashCode * 59) + this.refNFe.GetHashCode();
                }
                if (this.refNFeSig != null)
                {
                    hashCode = (hashCode * 59) + this.refNFeSig.GetHashCode();
                }
                if (this.refNF != null)
                {
                    hashCode = (hashCode * 59) + this.refNF.GetHashCode();
                }
                if (this.refNFP != null)
                {
                    hashCode = (hashCode * 59) + this.refNFP.GetHashCode();
                }
                if (this.refCTe != null)
                {
                    hashCode = (hashCode * 59) + this.refCTe.GetHashCode();
                }
                if (this.refECF != null)
                {
                    hashCode = (hashCode * 59) + this.refECF.GetHashCode();
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
