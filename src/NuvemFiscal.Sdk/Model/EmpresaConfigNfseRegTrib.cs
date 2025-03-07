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
    /// Grupo de informações relativas aos regimes de tributação do prestador de serviços.
    /// </summary>
    [DataContract(Name = "EmpresaConfigNfseRegTrib")]
    public partial class EmpresaConfigNfseRegTrib : IEquatable<EmpresaConfigNfseRegTrib>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaConfigNfseRegTrib" /> class.
        /// </summary>
        /// <param name="opSimpNac">Situação perante o Simples Nacional:  * 1 - Não Optante;  * 2 - Optante - Microempreendedor Individual (MEI);  * 3 - Optante - Microempresa ou Empresa de Pequeno Porte (ME/EPP)..</param>
        /// <param name="regApTribSN">Opção para que o contribuinte optante pelo Simples Nacional ME/EPP (opSimpNac &#x3D; 3) possa indicar, ao emitir o documento fiscal, em qual regime de apuração os tributos federais e municipal estão inseridos, caso tenha ultrapassado algum sublimite ou limite definido para o Simples Nacional.  * 1 – Regime de apuração dos tributos federais e municipal pelo SN;  * 2 – Regime de apuração dos tributos federais pelo SN e ISSQN  por fora do SN conforme respectiva legislação municipal do tributo;  * 3 – Regime de apuração dos tributos federais e municipal por fora do SN conforme respectivas legilações federal e municipal de cada tributo..</param>
        /// <param name="regEspTrib">Tipos de Regimes Especiais de Tributação:  * 0 - Nenhum;  * 1 - Ato Cooperado (Cooperativa);  * 2 - Estimativa;  * 3 - Microempresa Municipal;  * 4 - Notário ou Registrador;  * 5 - Profissional Autônomo;  * 6 - Sociedade de Profissionais..</param>
        public EmpresaConfigNfseRegTrib(int? opSimpNac = default(int?), int? regApTribSN = default(int?), int? regEspTrib = default(int?))
        {
            this.opSimpNac = opSimpNac;
            this.regApTribSN = regApTribSN;
            this.regEspTrib = regEspTrib;
        }

        /// <summary>
        /// Situação perante o Simples Nacional:  * 1 - Não Optante;  * 2 - Optante - Microempreendedor Individual (MEI);  * 3 - Optante - Microempresa ou Empresa de Pequeno Porte (ME/EPP).
        /// </summary>
        /// <value>Situação perante o Simples Nacional:  * 1 - Não Optante;  * 2 - Optante - Microempreendedor Individual (MEI);  * 3 - Optante - Microempresa ou Empresa de Pequeno Porte (ME/EPP).</value>
        [DataMember(Name = "opSimpNac", EmitDefaultValue = true)]
        public int? opSimpNac { get; set; }

        /// <summary>
        /// Opção para que o contribuinte optante pelo Simples Nacional ME/EPP (opSimpNac &#x3D; 3) possa indicar, ao emitir o documento fiscal, em qual regime de apuração os tributos federais e municipal estão inseridos, caso tenha ultrapassado algum sublimite ou limite definido para o Simples Nacional.  * 1 – Regime de apuração dos tributos federais e municipal pelo SN;  * 2 – Regime de apuração dos tributos federais pelo SN e ISSQN  por fora do SN conforme respectiva legislação municipal do tributo;  * 3 – Regime de apuração dos tributos federais e municipal por fora do SN conforme respectivas legilações federal e municipal de cada tributo.
        /// </summary>
        /// <value>Opção para que o contribuinte optante pelo Simples Nacional ME/EPP (opSimpNac &#x3D; 3) possa indicar, ao emitir o documento fiscal, em qual regime de apuração os tributos federais e municipal estão inseridos, caso tenha ultrapassado algum sublimite ou limite definido para o Simples Nacional.  * 1 – Regime de apuração dos tributos federais e municipal pelo SN;  * 2 – Regime de apuração dos tributos federais pelo SN e ISSQN  por fora do SN conforme respectiva legislação municipal do tributo;  * 3 – Regime de apuração dos tributos federais e municipal por fora do SN conforme respectivas legilações federal e municipal de cada tributo.</value>
        [DataMember(Name = "regApTribSN", EmitDefaultValue = true)]
        public int? regApTribSN { get; set; }

        /// <summary>
        /// Tipos de Regimes Especiais de Tributação:  * 0 - Nenhum;  * 1 - Ato Cooperado (Cooperativa);  * 2 - Estimativa;  * 3 - Microempresa Municipal;  * 4 - Notário ou Registrador;  * 5 - Profissional Autônomo;  * 6 - Sociedade de Profissionais.
        /// </summary>
        /// <value>Tipos de Regimes Especiais de Tributação:  * 0 - Nenhum;  * 1 - Ato Cooperado (Cooperativa);  * 2 - Estimativa;  * 3 - Microempresa Municipal;  * 4 - Notário ou Registrador;  * 5 - Profissional Autônomo;  * 6 - Sociedade de Profissionais.</value>
        [DataMember(Name = "regEspTrib", EmitDefaultValue = true)]
        public int? regEspTrib { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmpresaConfigNfseRegTrib {\n");
            sb.Append("  opSimpNac: ").Append(opSimpNac).Append("\n");
            sb.Append("  regApTribSN: ").Append(regApTribSN).Append("\n");
            sb.Append("  regEspTrib: ").Append(regEspTrib).Append("\n");
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
            return this.Equals(input as EmpresaConfigNfseRegTrib);
        }

        /// <summary>
        /// Returns true if EmpresaConfigNfseRegTrib instances are equal
        /// </summary>
        /// <param name="input">Instance of EmpresaConfigNfseRegTrib to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmpresaConfigNfseRegTrib input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.opSimpNac == input.opSimpNac ||
                    (this.opSimpNac != null &&
                    this.opSimpNac.Equals(input.opSimpNac))
                ) && 
                (
                    this.regApTribSN == input.regApTribSN ||
                    (this.regApTribSN != null &&
                    this.regApTribSN.Equals(input.regApTribSN))
                ) && 
                (
                    this.regEspTrib == input.regEspTrib ||
                    (this.regEspTrib != null &&
                    this.regEspTrib.Equals(input.regEspTrib))
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
                if (this.opSimpNac != null)
                {
                    hashCode = (hashCode * 59) + this.opSimpNac.GetHashCode();
                }
                if (this.regApTribSN != null)
                {
                    hashCode = (hashCode * 59) + this.regApTribSN.GetHashCode();
                }
                if (this.regEspTrib != null)
                {
                    hashCode = (hashCode * 59) + this.regEspTrib.GetHashCode();
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
            yield break;
        }
    }

}
