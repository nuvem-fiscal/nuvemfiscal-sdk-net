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
    /// Informar apenas para operações com combustíveis líquidos.
    /// </summary>
    [DataContract(Name = "NfeSefazComb")]
    public partial class NfeSefazComb : IEquatable<NfeSefazComb>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazComb" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazComb() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazComb" /> class.
        /// </summary>
        /// <param name="cProdANP">Código de produto da ANP. codificação de produtos do SIMP (http://www.anp.gov.br). (required).</param>
        /// <param name="descANP">Descrição do Produto conforme ANP. Utilizar a descrição de produtos do Sistema de Informações de Movimentação de Produtos - SIMP (http://www.anp.gov.br/simp/). (required).</param>
        /// <param name="pGLP">Percentual do GLP derivado do petróleo no produto GLP (cProdANP&#x3D;210203001). Informar em número decimal o percentual do GLP derivado de petróleo no produto GLP. Valores 0 a 100..</param>
        /// <param name="pGNn">Percentual de gás natural nacional - GLGNn para o produto GLP (cProdANP&#x3D;210203001). Informar em número decimal o percentual do Gás Natural Nacional - GLGNn para o produto GLP. Valores de 0 a 100..</param>
        /// <param name="pGNi">Percentual de gás natural importado GLGNi para o produto GLP (cProdANP&#x3D;210203001). Informar em número deciaml o percentual do Gás Natural Importado - GLGNi para o produto GLP. Valores de 0 a 100..</param>
        /// <param name="vPart">Valor de partida (cProdANP&#x3D;210203001). Deve ser informado neste campo o valor por quilograma sem ICMS..</param>
        /// <param name="cODIF">Código de autorização / registro do CODIF. Informar apenas quando a UF utilizar o CODIF (Sistema de Controle do    Diferimento do Imposto nas Operações com AEAC - Álcool Etílico Anidro Combustível)..</param>
        /// <param name="qTemp">Quantidade de combustível  faturada à temperatura ambiente.  Informar quando a quantidade  faturada informada no campo  qCom (I10) tiver sido ajustada para  uma temperatura diferente da  ambiente..</param>
        /// <param name="uFCons">Sigla da UF de Consumo. (required).</param>
        /// <param name="cIDE">cIDE.</param>
        /// <param name="encerrante">encerrante.</param>
        /// <param name="pBio">Percentual do índice de mistura do Biodiesel (B100) no Óleo Diesel B instituído pelo órgão regulamentador..</param>
        /// <param name="origComb">origComb.</param>
        public NfeSefazComb(int? cProdANP = default(int?), string descANP = default(string), decimal? pGLP = default(decimal?), decimal? pGNn = default(decimal?), decimal? pGNi = default(decimal?), decimal? vPart = default(decimal?), string cODIF = default(string), decimal? qTemp = default(decimal?), string uFCons = default(string), NfeSefazCIDE cIDE = default(NfeSefazCIDE), NfeSefazEncerrante encerrante = default(NfeSefazEncerrante), decimal? pBio = default(decimal?), List<NfeSefazOrigComb> origComb = default(List<NfeSefazOrigComb>))
        {
            // to ensure "cProdANP" is required (not null)
            if (cProdANP == null)
            {
                throw new ArgumentNullException("cProdANP is a required property for NfeSefazComb and cannot be null");
            }
            this.cProdANP = cProdANP;
            // to ensure "descANP" is required (not null)
            if (descANP == null)
            {
                throw new ArgumentNullException("descANP is a required property for NfeSefazComb and cannot be null");
            }
            this.descANP = descANP;
            // to ensure "uFCons" is required (not null)
            if (uFCons == null)
            {
                throw new ArgumentNullException("uFCons is a required property for NfeSefazComb and cannot be null");
            }
            this.UFCons = uFCons;
            this.pGLP = pGLP;
            this.pGNn = pGNn;
            this.pGNi = pGNi;
            this.vPart = vPart;
            this.CODIF = cODIF;
            this.qTemp = qTemp;
            this.CIDE = cIDE;
            this.encerrante = encerrante;
            this.pBio = pBio;
            this.origComb = origComb;
        }

        /// <summary>
        /// Código de produto da ANP. codificação de produtos do SIMP (http://www.anp.gov.br).
        /// </summary>
        /// <value>Código de produto da ANP. codificação de produtos do SIMP (http://www.anp.gov.br).</value>
        [DataMember(Name = "cProdANP", IsRequired = true, EmitDefaultValue = true)]
        public int? cProdANP { get; set; }

        /// <summary>
        /// Descrição do Produto conforme ANP. Utilizar a descrição de produtos do Sistema de Informações de Movimentação de Produtos - SIMP (http://www.anp.gov.br/simp/).
        /// </summary>
        /// <value>Descrição do Produto conforme ANP. Utilizar a descrição de produtos do Sistema de Informações de Movimentação de Produtos - SIMP (http://www.anp.gov.br/simp/).</value>
        [DataMember(Name = "descANP", IsRequired = true, EmitDefaultValue = true)]
        public string descANP { get; set; }

        /// <summary>
        /// Percentual do GLP derivado do petróleo no produto GLP (cProdANP&#x3D;210203001). Informar em número decimal o percentual do GLP derivado de petróleo no produto GLP. Valores 0 a 100.
        /// </summary>
        /// <value>Percentual do GLP derivado do petróleo no produto GLP (cProdANP&#x3D;210203001). Informar em número decimal o percentual do GLP derivado de petróleo no produto GLP. Valores 0 a 100.</value>
        [DataMember(Name = "pGLP", EmitDefaultValue = true)]
        public decimal? pGLP { get; set; }

        /// <summary>
        /// Percentual de gás natural nacional - GLGNn para o produto GLP (cProdANP&#x3D;210203001). Informar em número decimal o percentual do Gás Natural Nacional - GLGNn para o produto GLP. Valores de 0 a 100.
        /// </summary>
        /// <value>Percentual de gás natural nacional - GLGNn para o produto GLP (cProdANP&#x3D;210203001). Informar em número decimal o percentual do Gás Natural Nacional - GLGNn para o produto GLP. Valores de 0 a 100.</value>
        [DataMember(Name = "pGNn", EmitDefaultValue = true)]
        public decimal? pGNn { get; set; }

        /// <summary>
        /// Percentual de gás natural importado GLGNi para o produto GLP (cProdANP&#x3D;210203001). Informar em número deciaml o percentual do Gás Natural Importado - GLGNi para o produto GLP. Valores de 0 a 100.
        /// </summary>
        /// <value>Percentual de gás natural importado GLGNi para o produto GLP (cProdANP&#x3D;210203001). Informar em número deciaml o percentual do Gás Natural Importado - GLGNi para o produto GLP. Valores de 0 a 100.</value>
        [DataMember(Name = "pGNi", EmitDefaultValue = true)]
        public decimal? pGNi { get; set; }

        /// <summary>
        /// Valor de partida (cProdANP&#x3D;210203001). Deve ser informado neste campo o valor por quilograma sem ICMS.
        /// </summary>
        /// <value>Valor de partida (cProdANP&#x3D;210203001). Deve ser informado neste campo o valor por quilograma sem ICMS.</value>
        [DataMember(Name = "vPart", EmitDefaultValue = true)]
        public decimal? vPart { get; set; }

        /// <summary>
        /// Código de autorização / registro do CODIF. Informar apenas quando a UF utilizar o CODIF (Sistema de Controle do    Diferimento do Imposto nas Operações com AEAC - Álcool Etílico Anidro Combustível).
        /// </summary>
        /// <value>Código de autorização / registro do CODIF. Informar apenas quando a UF utilizar o CODIF (Sistema de Controle do    Diferimento do Imposto nas Operações com AEAC - Álcool Etílico Anidro Combustível).</value>
        [DataMember(Name = "CODIF", EmitDefaultValue = true)]
        public string CODIF { get; set; }

        /// <summary>
        /// Quantidade de combustível  faturada à temperatura ambiente.  Informar quando a quantidade  faturada informada no campo  qCom (I10) tiver sido ajustada para  uma temperatura diferente da  ambiente.
        /// </summary>
        /// <value>Quantidade de combustível  faturada à temperatura ambiente.  Informar quando a quantidade  faturada informada no campo  qCom (I10) tiver sido ajustada para  uma temperatura diferente da  ambiente.</value>
        [DataMember(Name = "qTemp", EmitDefaultValue = true)]
        public decimal? qTemp { get; set; }

        /// <summary>
        /// Sigla da UF de Consumo.
        /// </summary>
        /// <value>Sigla da UF de Consumo.</value>
        [DataMember(Name = "UFCons", IsRequired = true, EmitDefaultValue = true)]
        public string UFCons { get; set; }

        /// <summary>
        /// Gets or Sets CIDE
        /// </summary>
        [DataMember(Name = "CIDE", EmitDefaultValue = false)]
        public NfeSefazCIDE CIDE { get; set; }

        /// <summary>
        /// Gets or Sets encerrante
        /// </summary>
        [DataMember(Name = "encerrante", EmitDefaultValue = false)]
        public NfeSefazEncerrante encerrante { get; set; }

        /// <summary>
        /// Percentual do índice de mistura do Biodiesel (B100) no Óleo Diesel B instituído pelo órgão regulamentador.
        /// </summary>
        /// <value>Percentual do índice de mistura do Biodiesel (B100) no Óleo Diesel B instituído pelo órgão regulamentador.</value>
        [DataMember(Name = "pBio", EmitDefaultValue = true)]
        public decimal? pBio { get; set; }

        /// <summary>
        /// Gets or Sets origComb
        /// </summary>
        [DataMember(Name = "origComb", EmitDefaultValue = false)]
        public List<NfeSefazOrigComb> origComb { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazComb {\n");
            sb.Append("  cProdANP: ").Append(cProdANP).Append("\n");
            sb.Append("  descANP: ").Append(descANP).Append("\n");
            sb.Append("  pGLP: ").Append(pGLP).Append("\n");
            sb.Append("  pGNn: ").Append(pGNn).Append("\n");
            sb.Append("  pGNi: ").Append(pGNi).Append("\n");
            sb.Append("  vPart: ").Append(vPart).Append("\n");
            sb.Append("  CODIF: ").Append(CODIF).Append("\n");
            sb.Append("  qTemp: ").Append(qTemp).Append("\n");
            sb.Append("  UFCons: ").Append(UFCons).Append("\n");
            sb.Append("  CIDE: ").Append(CIDE).Append("\n");
            sb.Append("  encerrante: ").Append(encerrante).Append("\n");
            sb.Append("  pBio: ").Append(pBio).Append("\n");
            sb.Append("  origComb: ").Append(origComb).Append("\n");
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
            return this.Equals(input as NfeSefazComb);
        }

        /// <summary>
        /// Returns true if NfeSefazComb instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazComb to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazComb input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cProdANP == input.cProdANP ||
                    (this.cProdANP != null &&
                    this.cProdANP.Equals(input.cProdANP))
                ) && 
                (
                    this.descANP == input.descANP ||
                    (this.descANP != null &&
                    this.descANP.Equals(input.descANP))
                ) && 
                (
                    this.pGLP == input.pGLP ||
                    (this.pGLP != null &&
                    this.pGLP.Equals(input.pGLP))
                ) && 
                (
                    this.pGNn == input.pGNn ||
                    (this.pGNn != null &&
                    this.pGNn.Equals(input.pGNn))
                ) && 
                (
                    this.pGNi == input.pGNi ||
                    (this.pGNi != null &&
                    this.pGNi.Equals(input.pGNi))
                ) && 
                (
                    this.vPart == input.vPart ||
                    (this.vPart != null &&
                    this.vPart.Equals(input.vPart))
                ) && 
                (
                    this.CODIF == input.CODIF ||
                    (this.CODIF != null &&
                    this.CODIF.Equals(input.CODIF))
                ) && 
                (
                    this.qTemp == input.qTemp ||
                    (this.qTemp != null &&
                    this.qTemp.Equals(input.qTemp))
                ) && 
                (
                    this.UFCons == input.UFCons ||
                    (this.UFCons != null &&
                    this.UFCons.Equals(input.UFCons))
                ) && 
                (
                    this.CIDE == input.CIDE ||
                    (this.CIDE != null &&
                    this.CIDE.Equals(input.CIDE))
                ) && 
                (
                    this.encerrante == input.encerrante ||
                    (this.encerrante != null &&
                    this.encerrante.Equals(input.encerrante))
                ) && 
                (
                    this.pBio == input.pBio ||
                    (this.pBio != null &&
                    this.pBio.Equals(input.pBio))
                ) && 
                (
                    this.origComb == input.origComb ||
                    this.origComb != null &&
                    input.origComb != null &&
                    this.origComb.SequenceEqual(input.origComb)
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
                if (this.cProdANP != null)
                {
                    hashCode = (hashCode * 59) + this.cProdANP.GetHashCode();
                }
                if (this.descANP != null)
                {
                    hashCode = (hashCode * 59) + this.descANP.GetHashCode();
                }
                if (this.pGLP != null)
                {
                    hashCode = (hashCode * 59) + this.pGLP.GetHashCode();
                }
                if (this.pGNn != null)
                {
                    hashCode = (hashCode * 59) + this.pGNn.GetHashCode();
                }
                if (this.pGNi != null)
                {
                    hashCode = (hashCode * 59) + this.pGNi.GetHashCode();
                }
                if (this.vPart != null)
                {
                    hashCode = (hashCode * 59) + this.vPart.GetHashCode();
                }
                if (this.CODIF != null)
                {
                    hashCode = (hashCode * 59) + this.CODIF.GetHashCode();
                }
                if (this.qTemp != null)
                {
                    hashCode = (hashCode * 59) + this.qTemp.GetHashCode();
                }
                if (this.UFCons != null)
                {
                    hashCode = (hashCode * 59) + this.UFCons.GetHashCode();
                }
                if (this.CIDE != null)
                {
                    hashCode = (hashCode * 59) + this.CIDE.GetHashCode();
                }
                if (this.encerrante != null)
                {
                    hashCode = (hashCode * 59) + this.encerrante.GetHashCode();
                }
                if (this.pBio != null)
                {
                    hashCode = (hashCode * 59) + this.pBio.GetHashCode();
                }
                if (this.origComb != null)
                {
                    hashCode = (hashCode * 59) + this.origComb.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // cProdANP (int?) maximum
            if (this.cProdANP > (int?)999999999)
            {
                yield return new ValidationResult("Invalid value for cProdANP, must be a value less than or equal to 999999999.", new [] { "cProdANP" });
            }

            // cProdANP (int?) minimum
            if (this.cProdANP < (int?)0)
            {
                yield return new ValidationResult("Invalid value for cProdANP, must be a value greater than or equal to 0.", new [] { "cProdANP" });
            }

            // descANP (string) maxLength
            if (this.descANP != null && this.descANP.Length > 95)
            {
                yield return new ValidationResult("Invalid value for descANP, length must be less than 95.", new [] { "descANP" });
            }

            // descANP (string) minLength
            if (this.descANP != null && this.descANP.Length < 2)
            {
                yield return new ValidationResult("Invalid value for descANP, length must be greater than 2.", new [] { "descANP" });
            }

            // pGLP (decimal?) maximum
            if (this.pGLP > (decimal?)1E+2)
            {
                yield return new ValidationResult("Invalid value for pGLP, must be a value less than or equal to 1E+2.", new [] { "pGLP" });
            }

            // pGLP (decimal?) minimum
            if (this.pGLP < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pGLP, must be a value greater than or equal to 0.", new [] { "pGLP" });
            }

            // pGNn (decimal?) maximum
            if (this.pGNn > (decimal?)1E+2)
            {
                yield return new ValidationResult("Invalid value for pGNn, must be a value less than or equal to 1E+2.", new [] { "pGNn" });
            }

            // pGNn (decimal?) minimum
            if (this.pGNn < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pGNn, must be a value greater than or equal to 0.", new [] { "pGNn" });
            }

            // pGNi (decimal?) maximum
            if (this.pGNi > (decimal?)1E+2)
            {
                yield return new ValidationResult("Invalid value for pGNi, must be a value less than or equal to 1E+2.", new [] { "pGNi" });
            }

            // pGNi (decimal?) minimum
            if (this.pGNi < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pGNi, must be a value greater than or equal to 0.", new [] { "pGNi" });
            }

            // vPart (decimal?) minimum
            if (this.vPart < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vPart, must be a value greater than or equal to 0.", new [] { "vPart" });
            }

            // qTemp (decimal?) minimum
            if (this.qTemp < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qTemp, must be a value greater than or equal to 0.", new [] { "qTemp" });
            }

            // pBio (decimal?) maximum
            if (this.pBio > (decimal?)1E+2)
            {
                yield return new ValidationResult("Invalid value for pBio, must be a value less than or equal to 1E+2.", new [] { "pBio" });
            }

            // pBio (decimal?) minimum
            if (this.pBio < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pBio, must be a value greater than or equal to 0.", new [] { "pBio" });
            }

            yield break;
        }
    }

}
