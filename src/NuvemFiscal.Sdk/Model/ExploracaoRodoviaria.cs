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
    /// Grupo de informações relativas a pedágio.
    /// </summary>
    [DataContract(Name = "ExploracaoRodoviaria")]
    public partial class ExploracaoRodoviaria : IEquatable<ExploracaoRodoviaria>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExploracaoRodoviaria" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExploracaoRodoviaria() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExploracaoRodoviaria" /> class.
        /// </summary>
        /// <param name="categVeic">Categorias de veículos para cobrança:  * 00 - Categoria de veículos (tipo não informado na nota de origem)  * 01 - Automóvel, caminhonete e furgão  * 02 - Caminhão leve, ônibus, caminhão trator e furgão  * 03 - Automóvel e caminhonete com semireboque  * 04 - Caminhão, caminhão-trator, caminhão-trator com semi-reboque e ônibus  * 05 - Automóvel e caminhonete com reboque  * 06 - Caminhão com reboque  * 07 - Caminhão trator com semi-reboque  * 08 - Motocicletas, motonetas e bicicletas motorizadas  * 09 - Veículo especial  * 10 - Veículo Isento (required).</param>
        /// <param name="nEixos">Número de eixos para fins de cobrança. (required).</param>
        /// <param name="rodagem">Tipo de rodagem. (required).</param>
        /// <param name="sentido">Placa do veículo. (required).</param>
        /// <param name="placa">Placa do veículo. (required).</param>
        /// <param name="codAcessoPed">Código de acesso gerado automaticamente pelo sistema emissor da concessionária. (required).</param>
        /// <param name="codContrato">Código de contrato gerado automaticamente pelo sistema nacional no cadastro da concessionária. (required).</param>
        public ExploracaoRodoviaria(string categVeic = default(string), string nEixos = default(string), int? rodagem = default(int?), string sentido = default(string), string placa = default(string), string codAcessoPed = default(string), string codContrato = default(string))
        {
            // to ensure "categVeic" is required (not null)
            if (categVeic == null)
            {
                throw new ArgumentNullException("categVeic is a required property for ExploracaoRodoviaria and cannot be null");
            }
            this.categVeic = categVeic;
            // to ensure "nEixos" is required (not null)
            if (nEixos == null)
            {
                throw new ArgumentNullException("nEixos is a required property for ExploracaoRodoviaria and cannot be null");
            }
            this.nEixos = nEixos;
            // to ensure "rodagem" is required (not null)
            if (rodagem == null)
            {
                throw new ArgumentNullException("rodagem is a required property for ExploracaoRodoviaria and cannot be null");
            }
            this.rodagem = rodagem;
            // to ensure "sentido" is required (not null)
            if (sentido == null)
            {
                throw new ArgumentNullException("sentido is a required property for ExploracaoRodoviaria and cannot be null");
            }
            this.sentido = sentido;
            // to ensure "placa" is required (not null)
            if (placa == null)
            {
                throw new ArgumentNullException("placa is a required property for ExploracaoRodoviaria and cannot be null");
            }
            this.placa = placa;
            // to ensure "codAcessoPed" is required (not null)
            if (codAcessoPed == null)
            {
                throw new ArgumentNullException("codAcessoPed is a required property for ExploracaoRodoviaria and cannot be null");
            }
            this.codAcessoPed = codAcessoPed;
            // to ensure "codContrato" is required (not null)
            if (codContrato == null)
            {
                throw new ArgumentNullException("codContrato is a required property for ExploracaoRodoviaria and cannot be null");
            }
            this.codContrato = codContrato;
        }

        /// <summary>
        /// Categorias de veículos para cobrança:  * 00 - Categoria de veículos (tipo não informado na nota de origem)  * 01 - Automóvel, caminhonete e furgão  * 02 - Caminhão leve, ônibus, caminhão trator e furgão  * 03 - Automóvel e caminhonete com semireboque  * 04 - Caminhão, caminhão-trator, caminhão-trator com semi-reboque e ônibus  * 05 - Automóvel e caminhonete com reboque  * 06 - Caminhão com reboque  * 07 - Caminhão trator com semi-reboque  * 08 - Motocicletas, motonetas e bicicletas motorizadas  * 09 - Veículo especial  * 10 - Veículo Isento
        /// </summary>
        /// <value>Categorias de veículos para cobrança:  * 00 - Categoria de veículos (tipo não informado na nota de origem)  * 01 - Automóvel, caminhonete e furgão  * 02 - Caminhão leve, ônibus, caminhão trator e furgão  * 03 - Automóvel e caminhonete com semireboque  * 04 - Caminhão, caminhão-trator, caminhão-trator com semi-reboque e ônibus  * 05 - Automóvel e caminhonete com reboque  * 06 - Caminhão com reboque  * 07 - Caminhão trator com semi-reboque  * 08 - Motocicletas, motonetas e bicicletas motorizadas  * 09 - Veículo especial  * 10 - Veículo Isento</value>
        [DataMember(Name = "categVeic", IsRequired = true, EmitDefaultValue = true)]
        public string categVeic { get; set; }

        /// <summary>
        /// Número de eixos para fins de cobrança.
        /// </summary>
        /// <value>Número de eixos para fins de cobrança.</value>
        [DataMember(Name = "nEixos", IsRequired = true, EmitDefaultValue = true)]
        public string nEixos { get; set; }

        /// <summary>
        /// Tipo de rodagem.
        /// </summary>
        /// <value>Tipo de rodagem.</value>
        [DataMember(Name = "rodagem", IsRequired = true, EmitDefaultValue = true)]
        public int? rodagem { get; set; }

        /// <summary>
        /// Placa do veículo.
        /// </summary>
        /// <value>Placa do veículo.</value>
        [DataMember(Name = "sentido", IsRequired = true, EmitDefaultValue = true)]
        public string sentido { get; set; }

        /// <summary>
        /// Placa do veículo.
        /// </summary>
        /// <value>Placa do veículo.</value>
        [DataMember(Name = "placa", IsRequired = true, EmitDefaultValue = true)]
        public string placa { get; set; }

        /// <summary>
        /// Código de acesso gerado automaticamente pelo sistema emissor da concessionária.
        /// </summary>
        /// <value>Código de acesso gerado automaticamente pelo sistema emissor da concessionária.</value>
        [DataMember(Name = "codAcessoPed", IsRequired = true, EmitDefaultValue = true)]
        public string codAcessoPed { get; set; }

        /// <summary>
        /// Código de contrato gerado automaticamente pelo sistema nacional no cadastro da concessionária.
        /// </summary>
        /// <value>Código de contrato gerado automaticamente pelo sistema nacional no cadastro da concessionária.</value>
        [DataMember(Name = "codContrato", IsRequired = true, EmitDefaultValue = true)]
        public string codContrato { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExploracaoRodoviaria {\n");
            sb.Append("  categVeic: ").Append(categVeic).Append("\n");
            sb.Append("  nEixos: ").Append(nEixos).Append("\n");
            sb.Append("  rodagem: ").Append(rodagem).Append("\n");
            sb.Append("  sentido: ").Append(sentido).Append("\n");
            sb.Append("  placa: ").Append(placa).Append("\n");
            sb.Append("  codAcessoPed: ").Append(codAcessoPed).Append("\n");
            sb.Append("  codContrato: ").Append(codContrato).Append("\n");
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
            return this.Equals(input as ExploracaoRodoviaria);
        }

        /// <summary>
        /// Returns true if ExploracaoRodoviaria instances are equal
        /// </summary>
        /// <param name="input">Instance of ExploracaoRodoviaria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExploracaoRodoviaria input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.categVeic == input.categVeic ||
                    (this.categVeic != null &&
                    this.categVeic.Equals(input.categVeic))
                ) && 
                (
                    this.nEixos == input.nEixos ||
                    (this.nEixos != null &&
                    this.nEixos.Equals(input.nEixos))
                ) && 
                (
                    this.rodagem == input.rodagem ||
                    (this.rodagem != null &&
                    this.rodagem.Equals(input.rodagem))
                ) && 
                (
                    this.sentido == input.sentido ||
                    (this.sentido != null &&
                    this.sentido.Equals(input.sentido))
                ) && 
                (
                    this.placa == input.placa ||
                    (this.placa != null &&
                    this.placa.Equals(input.placa))
                ) && 
                (
                    this.codAcessoPed == input.codAcessoPed ||
                    (this.codAcessoPed != null &&
                    this.codAcessoPed.Equals(input.codAcessoPed))
                ) && 
                (
                    this.codContrato == input.codContrato ||
                    (this.codContrato != null &&
                    this.codContrato.Equals(input.codContrato))
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
                if (this.categVeic != null)
                {
                    hashCode = (hashCode * 59) + this.categVeic.GetHashCode();
                }
                if (this.nEixos != null)
                {
                    hashCode = (hashCode * 59) + this.nEixos.GetHashCode();
                }
                if (this.rodagem != null)
                {
                    hashCode = (hashCode * 59) + this.rodagem.GetHashCode();
                }
                if (this.sentido != null)
                {
                    hashCode = (hashCode * 59) + this.sentido.GetHashCode();
                }
                if (this.placa != null)
                {
                    hashCode = (hashCode * 59) + this.placa.GetHashCode();
                }
                if (this.codAcessoPed != null)
                {
                    hashCode = (hashCode * 59) + this.codAcessoPed.GetHashCode();
                }
                if (this.codContrato != null)
                {
                    hashCode = (hashCode * 59) + this.codContrato.GetHashCode();
                }
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
