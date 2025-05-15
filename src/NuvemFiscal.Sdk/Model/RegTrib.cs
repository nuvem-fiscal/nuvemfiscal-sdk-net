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
    [DataContract(Name = "RegTrib")]
    public partial class RegTrib : IEquatable<RegTrib>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegTrib" /> class.
        /// </summary>
        /// <param name="regEspTrib">Regime Especial de Tributação da Prefeitura.    Campo opcional utilizado no momento da emissão da NFS-e para informar  diretamente o código de regime especial de tributação esperado pela  prefeitura.    **Comportamento:**  - Ao preencher este campo, o valor será inserido diretamente no XML    da NFS-e, sem qualquer conversão pela Nuvem Fiscal.  - Esse campo sobrescreve o valor configurado previamente nas    configurações de NFS-e da empresa.  - É especialmente útil quando a prefeitura utiliza códigos próprios que    não existem no padrão nacional (como valores diferentes dos listados    de 0 a 6).    **Cenários de uso:**  - Quando a prefeitura exige um código que não pode ser representado    pelos valores do padrão nacional.  - Quando houver necessidade de enviar o código exato esperado pela    prefeitura, sem depender da lógica de conversão automática da Nuvem Fiscal.    **Atenção**: Para emissões pelo Sistema Nacional NFS-e, esse campo é ignorado..</param>
        public RegTrib(int? regEspTrib = default(int?))
        {
            this.regEspTrib = regEspTrib;
        }

        /// <summary>
        /// Regime Especial de Tributação da Prefeitura.    Campo opcional utilizado no momento da emissão da NFS-e para informar  diretamente o código de regime especial de tributação esperado pela  prefeitura.    **Comportamento:**  - Ao preencher este campo, o valor será inserido diretamente no XML    da NFS-e, sem qualquer conversão pela Nuvem Fiscal.  - Esse campo sobrescreve o valor configurado previamente nas    configurações de NFS-e da empresa.  - É especialmente útil quando a prefeitura utiliza códigos próprios que    não existem no padrão nacional (como valores diferentes dos listados    de 0 a 6).    **Cenários de uso:**  - Quando a prefeitura exige um código que não pode ser representado    pelos valores do padrão nacional.  - Quando houver necessidade de enviar o código exato esperado pela    prefeitura, sem depender da lógica de conversão automática da Nuvem Fiscal.    **Atenção**: Para emissões pelo Sistema Nacional NFS-e, esse campo é ignorado.
        /// </summary>
        /// <value>Regime Especial de Tributação da Prefeitura.    Campo opcional utilizado no momento da emissão da NFS-e para informar  diretamente o código de regime especial de tributação esperado pela  prefeitura.    **Comportamento:**  - Ao preencher este campo, o valor será inserido diretamente no XML    da NFS-e, sem qualquer conversão pela Nuvem Fiscal.  - Esse campo sobrescreve o valor configurado previamente nas    configurações de NFS-e da empresa.  - É especialmente útil quando a prefeitura utiliza códigos próprios que    não existem no padrão nacional (como valores diferentes dos listados    de 0 a 6).    **Cenários de uso:**  - Quando a prefeitura exige um código que não pode ser representado    pelos valores do padrão nacional.  - Quando houver necessidade de enviar o código exato esperado pela    prefeitura, sem depender da lógica de conversão automática da Nuvem Fiscal.    **Atenção**: Para emissões pelo Sistema Nacional NFS-e, esse campo é ignorado.</value>
        [DataMember(Name = "regEspTrib", EmitDefaultValue = true)]
        public int? regEspTrib { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegTrib {\n");
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
            return this.Equals(input as RegTrib);
        }

        /// <summary>
        /// Returns true if RegTrib instances are equal
        /// </summary>
        /// <param name="input">Instance of RegTrib to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegTrib input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
