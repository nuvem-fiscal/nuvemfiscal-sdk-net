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
    /// NfeSefazComb
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
        public NfeSefazComb(int cProdANP = default(int), string descANP = default(string), decimal pGLP = default(decimal), decimal pGNn = default(decimal), decimal pGNi = default(decimal), decimal vPart = default(decimal), string cODIF = default(string), decimal qTemp = default(decimal), string uFCons = default(string), NfeSefazCIDE cIDE = default(NfeSefazCIDE), NfeSefazEncerrante encerrante = default(NfeSefazEncerrante))
        {
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
        }

        /// <summary>
        /// Código de produto da ANP. codificação de produtos do SIMP (http://www.anp.gov.br).
        /// </summary>
        /// <value>Código de produto da ANP. codificação de produtos do SIMP (http://www.anp.gov.br).</value>
        [DataMember(Name = "cProdANP", IsRequired = true, EmitDefaultValue = false)]
        public int cProdANP { get; set; }

        /// <summary>
        /// Descrição do Produto conforme ANP. Utilizar a descrição de produtos do Sistema de Informações de Movimentação de Produtos - SIMP (http://www.anp.gov.br/simp/).
        /// </summary>
        /// <value>Descrição do Produto conforme ANP. Utilizar a descrição de produtos do Sistema de Informações de Movimentação de Produtos - SIMP (http://www.anp.gov.br/simp/).</value>
        [DataMember(Name = "descANP", IsRequired = true, EmitDefaultValue = false)]
        public string descANP { get; set; }

        /// <summary>
        /// Percentual do GLP derivado do petróleo no produto GLP (cProdANP&#x3D;210203001). Informar em número decimal o percentual do GLP derivado de petróleo no produto GLP. Valores 0 a 100.
        /// </summary>
        /// <value>Percentual do GLP derivado do petróleo no produto GLP (cProdANP&#x3D;210203001). Informar em número decimal o percentual do GLP derivado de petróleo no produto GLP. Valores 0 a 100.</value>
        [DataMember(Name = "pGLP", EmitDefaultValue = false)]
        public decimal pGLP { get; set; }

        /// <summary>
        /// Percentual de gás natural nacional - GLGNn para o produto GLP (cProdANP&#x3D;210203001). Informar em número decimal o percentual do Gás Natural Nacional - GLGNn para o produto GLP. Valores de 0 a 100.
        /// </summary>
        /// <value>Percentual de gás natural nacional - GLGNn para o produto GLP (cProdANP&#x3D;210203001). Informar em número decimal o percentual do Gás Natural Nacional - GLGNn para o produto GLP. Valores de 0 a 100.</value>
        [DataMember(Name = "pGNn", EmitDefaultValue = false)]
        public decimal pGNn { get; set; }

        /// <summary>
        /// Percentual de gás natural importado GLGNi para o produto GLP (cProdANP&#x3D;210203001). Informar em número deciaml o percentual do Gás Natural Importado - GLGNi para o produto GLP. Valores de 0 a 100.
        /// </summary>
        /// <value>Percentual de gás natural importado GLGNi para o produto GLP (cProdANP&#x3D;210203001). Informar em número deciaml o percentual do Gás Natural Importado - GLGNi para o produto GLP. Valores de 0 a 100.</value>
        [DataMember(Name = "pGNi", EmitDefaultValue = false)]
        public decimal pGNi { get; set; }

        /// <summary>
        /// Valor de partida (cProdANP&#x3D;210203001). Deve ser informado neste campo o valor por quilograma sem ICMS.
        /// </summary>
        /// <value>Valor de partida (cProdANP&#x3D;210203001). Deve ser informado neste campo o valor por quilograma sem ICMS.</value>
        [DataMember(Name = "vPart", EmitDefaultValue = false)]
        public decimal vPart { get; set; }

        /// <summary>
        /// Código de autorização / registro do CODIF. Informar apenas quando a UF utilizar o CODIF (Sistema de Controle do    Diferimento do Imposto nas Operações com AEAC - Álcool Etílico Anidro Combustível).
        /// </summary>
        /// <value>Código de autorização / registro do CODIF. Informar apenas quando a UF utilizar o CODIF (Sistema de Controle do    Diferimento do Imposto nas Operações com AEAC - Álcool Etílico Anidro Combustível).</value>
        [DataMember(Name = "CODIF", EmitDefaultValue = false)]
        public string CODIF { get; set; }

        /// <summary>
        /// Quantidade de combustível  faturada à temperatura ambiente.  Informar quando a quantidade  faturada informada no campo  qCom (I10) tiver sido ajustada para  uma temperatura diferente da  ambiente.
        /// </summary>
        /// <value>Quantidade de combustível  faturada à temperatura ambiente.  Informar quando a quantidade  faturada informada no campo  qCom (I10) tiver sido ajustada para  uma temperatura diferente da  ambiente.</value>
        [DataMember(Name = "qTemp", EmitDefaultValue = false)]
        public decimal qTemp { get; set; }

        /// <summary>
        /// Sigla da UF de Consumo.
        /// </summary>
        /// <value>Sigla da UF de Consumo.</value>
        [DataMember(Name = "UFCons", IsRequired = true, EmitDefaultValue = false)]
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
                    this.cProdANP.Equals(input.cProdANP)
                ) && 
                (
                    this.descANP == input.descANP ||
                    (this.descANP != null &&
                    this.descANP.Equals(input.descANP))
                ) && 
                (
                    this.pGLP == input.pGLP ||
                    this.pGLP.Equals(input.pGLP)
                ) && 
                (
                    this.pGNn == input.pGNn ||
                    this.pGNn.Equals(input.pGNn)
                ) && 
                (
                    this.pGNi == input.pGNi ||
                    this.pGNi.Equals(input.pGNi)
                ) && 
                (
                    this.vPart == input.vPart ||
                    this.vPart.Equals(input.vPart)
                ) && 
                (
                    this.CODIF == input.CODIF ||
                    (this.CODIF != null &&
                    this.CODIF.Equals(input.CODIF))
                ) && 
                (
                    this.qTemp == input.qTemp ||
                    this.qTemp.Equals(input.qTemp)
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
                hashCode = (hashCode * 59) + this.cProdANP.GetHashCode();
                if (this.descANP != null)
                {
                    hashCode = (hashCode * 59) + this.descANP.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.pGLP.GetHashCode();
                hashCode = (hashCode * 59) + this.pGNn.GetHashCode();
                hashCode = (hashCode * 59) + this.pGNi.GetHashCode();
                hashCode = (hashCode * 59) + this.vPart.GetHashCode();
                if (this.CODIF != null)
                {
                    hashCode = (hashCode * 59) + this.CODIF.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.qTemp.GetHashCode();
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
