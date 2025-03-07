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
    /// MdfeDocumentoVinculado
    /// </summary>
    [DataContract(Name = "MdfeDocumentoVinculado")]
    public partial class MdfeDocumentoVinculado : IEquatable<MdfeDocumentoVinculado>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeDocumentoVinculado" /> class.
        /// </summary>
        /// <param name="codigoMunicipioDescarga">Código do Município de descarregamento..</param>
        /// <param name="municipioDescarga">Nome do Município de descarregamento..</param>
        /// <param name="chaveAcessoNfe">Chave de acesso da NF-e..</param>
        public MdfeDocumentoVinculado(string codigoMunicipioDescarga = default(string), string municipioDescarga = default(string), string chaveAcessoNfe = default(string))
        {
            this.codigo_municipio_descarga = codigoMunicipioDescarga;
            this.municipio_descarga = municipioDescarga;
            this.chave_acesso_nfe = chaveAcessoNfe;
        }

        /// <summary>
        /// Código do Município de descarregamento.
        /// </summary>
        /// <value>Código do Município de descarregamento.</value>
        [DataMember(Name = "codigo_municipio_descarga", EmitDefaultValue = false)]
        public string codigo_municipio_descarga { get; set; }

        /// <summary>
        /// Nome do Município de descarregamento.
        /// </summary>
        /// <value>Nome do Município de descarregamento.</value>
        [DataMember(Name = "municipio_descarga", EmitDefaultValue = false)]
        public string municipio_descarga { get; set; }

        /// <summary>
        /// Chave de acesso da NF-e.
        /// </summary>
        /// <value>Chave de acesso da NF-e.</value>
        [DataMember(Name = "chave_acesso_nfe", EmitDefaultValue = false)]
        public string chave_acesso_nfe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeDocumentoVinculado {\n");
            sb.Append("  codigo_municipio_descarga: ").Append(codigo_municipio_descarga).Append("\n");
            sb.Append("  municipio_descarga: ").Append(municipio_descarga).Append("\n");
            sb.Append("  chave_acesso_nfe: ").Append(chave_acesso_nfe).Append("\n");
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
            return this.Equals(input as MdfeDocumentoVinculado);
        }

        /// <summary>
        /// Returns true if MdfeDocumentoVinculado instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeDocumentoVinculado to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeDocumentoVinculado input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.codigo_municipio_descarga == input.codigo_municipio_descarga ||
                    (this.codigo_municipio_descarga != null &&
                    this.codigo_municipio_descarga.Equals(input.codigo_municipio_descarga))
                ) && 
                (
                    this.municipio_descarga == input.municipio_descarga ||
                    (this.municipio_descarga != null &&
                    this.municipio_descarga.Equals(input.municipio_descarga))
                ) && 
                (
                    this.chave_acesso_nfe == input.chave_acesso_nfe ||
                    (this.chave_acesso_nfe != null &&
                    this.chave_acesso_nfe.Equals(input.chave_acesso_nfe))
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
                if (this.codigo_municipio_descarga != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_municipio_descarga.GetHashCode();
                }
                if (this.municipio_descarga != null)
                {
                    hashCode = (hashCode * 59) + this.municipio_descarga.GetHashCode();
                }
                if (this.chave_acesso_nfe != null)
                {
                    hashCode = (hashCode * 59) + this.chave_acesso_nfe.GetHashCode();
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
