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
    /// Produto predominante.  Informar a descrição do produto predominante.
    /// </summary>
    [DataContract(Name = "MdfeSefazProdPred")]
    public partial class MdfeSefazProdPred : IEquatable<MdfeSefazProdPred>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazProdPred" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazProdPred() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazProdPred" /> class.
        /// </summary>
        /// <param name="tpCarga">Tipo de Carga.  Conforme Resolução ANTT nº.  5.849/2019.  * 01 - Granel sólido  * 02 - Granel líquido  * 03 - Frigorificada  * 04 - Conteinerizada  * 05 - Carga Geral  * 06 - Neogranel  * 07 - Perigosa (granel sólido)  * 08 - Perigosa (granel líquido)  * 09 - Perigosa (carga frigorificada)  * 10 - Perigosa (conteinerizada)  * 11 - Perigosa (carga geral) (required).</param>
        /// <param name="xProd">Descrição do produto. (required).</param>
        /// <param name="cEAN">GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras..</param>
        /// <param name="nCM">Código NCM..</param>
        /// <param name="infLotacao">infLotacao.</param>
        public MdfeSefazProdPred(string tpCarga = default(string), string xProd = default(string), string cEAN = default(string), string nCM = default(string), MdfeSefazInfLotacao infLotacao = default(MdfeSefazInfLotacao))
        {
            // to ensure "tpCarga" is required (not null)
            if (tpCarga == null)
            {
                throw new ArgumentNullException("tpCarga is a required property for MdfeSefazProdPred and cannot be null");
            }
            this.tpCarga = tpCarga;
            // to ensure "xProd" is required (not null)
            if (xProd == null)
            {
                throw new ArgumentNullException("xProd is a required property for MdfeSefazProdPred and cannot be null");
            }
            this.xProd = xProd;
            this.cEAN = cEAN;
            this.NCM = nCM;
            this.infLotacao = infLotacao;
        }

        /// <summary>
        /// Tipo de Carga.  Conforme Resolução ANTT nº.  5.849/2019.  * 01 - Granel sólido  * 02 - Granel líquido  * 03 - Frigorificada  * 04 - Conteinerizada  * 05 - Carga Geral  * 06 - Neogranel  * 07 - Perigosa (granel sólido)  * 08 - Perigosa (granel líquido)  * 09 - Perigosa (carga frigorificada)  * 10 - Perigosa (conteinerizada)  * 11 - Perigosa (carga geral)
        /// </summary>
        /// <value>Tipo de Carga.  Conforme Resolução ANTT nº.  5.849/2019.  * 01 - Granel sólido  * 02 - Granel líquido  * 03 - Frigorificada  * 04 - Conteinerizada  * 05 - Carga Geral  * 06 - Neogranel  * 07 - Perigosa (granel sólido)  * 08 - Perigosa (granel líquido)  * 09 - Perigosa (carga frigorificada)  * 10 - Perigosa (conteinerizada)  * 11 - Perigosa (carga geral)</value>
        [DataMember(Name = "tpCarga", IsRequired = true, EmitDefaultValue = true)]
        public string tpCarga { get; set; }

        /// <summary>
        /// Descrição do produto.
        /// </summary>
        /// <value>Descrição do produto.</value>
        [DataMember(Name = "xProd", IsRequired = true, EmitDefaultValue = true)]
        public string xProd { get; set; }

        /// <summary>
        /// GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras.
        /// </summary>
        /// <value>GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras.</value>
        [DataMember(Name = "cEAN", EmitDefaultValue = true)]
        public string cEAN { get; set; }

        /// <summary>
        /// Código NCM.
        /// </summary>
        /// <value>Código NCM.</value>
        [DataMember(Name = "NCM", EmitDefaultValue = true)]
        public string NCM { get; set; }

        /// <summary>
        /// Gets or Sets infLotacao
        /// </summary>
        [DataMember(Name = "infLotacao", EmitDefaultValue = false)]
        public MdfeSefazInfLotacao infLotacao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazProdPred {\n");
            sb.Append("  tpCarga: ").Append(tpCarga).Append("\n");
            sb.Append("  xProd: ").Append(xProd).Append("\n");
            sb.Append("  cEAN: ").Append(cEAN).Append("\n");
            sb.Append("  NCM: ").Append(NCM).Append("\n");
            sb.Append("  infLotacao: ").Append(infLotacao).Append("\n");
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
            return this.Equals(input as MdfeSefazProdPred);
        }

        /// <summary>
        /// Returns true if MdfeSefazProdPred instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazProdPred to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazProdPred input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpCarga == input.tpCarga ||
                    (this.tpCarga != null &&
                    this.tpCarga.Equals(input.tpCarga))
                ) && 
                (
                    this.xProd == input.xProd ||
                    (this.xProd != null &&
                    this.xProd.Equals(input.xProd))
                ) && 
                (
                    this.cEAN == input.cEAN ||
                    (this.cEAN != null &&
                    this.cEAN.Equals(input.cEAN))
                ) && 
                (
                    this.NCM == input.NCM ||
                    (this.NCM != null &&
                    this.NCM.Equals(input.NCM))
                ) && 
                (
                    this.infLotacao == input.infLotacao ||
                    (this.infLotacao != null &&
                    this.infLotacao.Equals(input.infLotacao))
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
                if (this.tpCarga != null)
                {
                    hashCode = (hashCode * 59) + this.tpCarga.GetHashCode();
                }
                if (this.xProd != null)
                {
                    hashCode = (hashCode * 59) + this.xProd.GetHashCode();
                }
                if (this.cEAN != null)
                {
                    hashCode = (hashCode * 59) + this.cEAN.GetHashCode();
                }
                if (this.NCM != null)
                {
                    hashCode = (hashCode * 59) + this.NCM.GetHashCode();
                }
                if (this.infLotacao != null)
                {
                    hashCode = (hashCode * 59) + this.infLotacao.GetHashCode();
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
