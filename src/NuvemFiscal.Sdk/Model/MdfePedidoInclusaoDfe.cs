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
    /// MdfePedidoInclusaoDfe
    /// </summary>
    [DataContract(Name = "MdfePedidoInclusaoDfe")]
    public partial class MdfePedidoInclusaoDfe : IEquatable<MdfePedidoInclusaoDfe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfePedidoInclusaoDfe" /> class.
        /// </summary>
        /// <param name="codigoMunicipioCarrega">Código do Município de carregamento..</param>
        /// <param name="municipioCarrega">Nome do Município de carregamento..</param>
        /// <param name="documentos">Informações dos documentos fiscais vinculados ao manifesto..</param>
        /// <param name="protocoloAutorizacao">protocoloAutorizacao.</param>
        public MdfePedidoInclusaoDfe(string codigoMunicipioCarrega = default(string), string municipioCarrega = default(string), List<MdfeDocumentoVinculado> documentos = default(List<MdfeDocumentoVinculado>), string protocoloAutorizacao = default(string))
        {
            this.codigo_municipio_carrega = codigoMunicipioCarrega;
            this.municipio_carrega = municipioCarrega;
            this.documentos = documentos;
            this.protocolo_autorizacao = protocoloAutorizacao;
        }

        /// <summary>
        /// Código do Município de carregamento.
        /// </summary>
        /// <value>Código do Município de carregamento.</value>
        [DataMember(Name = "codigo_municipio_carrega", EmitDefaultValue = false)]
        public string codigo_municipio_carrega { get; set; }

        /// <summary>
        /// Nome do Município de carregamento.
        /// </summary>
        /// <value>Nome do Município de carregamento.</value>
        [DataMember(Name = "municipio_carrega", EmitDefaultValue = false)]
        public string municipio_carrega { get; set; }

        /// <summary>
        /// Informações dos documentos fiscais vinculados ao manifesto.
        /// </summary>
        /// <value>Informações dos documentos fiscais vinculados ao manifesto.</value>
        [DataMember(Name = "documentos", EmitDefaultValue = false)]
        public List<MdfeDocumentoVinculado> documentos { get; set; }

        /// <summary>
        /// Gets or Sets protocolo_autorizacao
        /// </summary>
        [DataMember(Name = "protocolo_autorizacao", EmitDefaultValue = false)]
        public string protocolo_autorizacao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfePedidoInclusaoDfe {\n");
            sb.Append("  codigo_municipio_carrega: ").Append(codigo_municipio_carrega).Append("\n");
            sb.Append("  municipio_carrega: ").Append(municipio_carrega).Append("\n");
            sb.Append("  documentos: ").Append(documentos).Append("\n");
            sb.Append("  protocolo_autorizacao: ").Append(protocolo_autorizacao).Append("\n");
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
            return this.Equals(input as MdfePedidoInclusaoDfe);
        }

        /// <summary>
        /// Returns true if MdfePedidoInclusaoDfe instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfePedidoInclusaoDfe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfePedidoInclusaoDfe input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.codigo_municipio_carrega == input.codigo_municipio_carrega ||
                    (this.codigo_municipio_carrega != null &&
                    this.codigo_municipio_carrega.Equals(input.codigo_municipio_carrega))
                ) && 
                (
                    this.municipio_carrega == input.municipio_carrega ||
                    (this.municipio_carrega != null &&
                    this.municipio_carrega.Equals(input.municipio_carrega))
                ) && 
                (
                    this.documentos == input.documentos ||
                    this.documentos != null &&
                    input.documentos != null &&
                    this.documentos.SequenceEqual(input.documentos)
                ) && 
                (
                    this.protocolo_autorizacao == input.protocolo_autorizacao ||
                    (this.protocolo_autorizacao != null &&
                    this.protocolo_autorizacao.Equals(input.protocolo_autorizacao))
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
                if (this.codigo_municipio_carrega != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_municipio_carrega.GetHashCode();
                }
                if (this.municipio_carrega != null)
                {
                    hashCode = (hashCode * 59) + this.municipio_carrega.GetHashCode();
                }
                if (this.documentos != null)
                {
                    hashCode = (hashCode * 59) + this.documentos.GetHashCode();
                }
                if (this.protocolo_autorizacao != null)
                {
                    hashCode = (hashCode * 59) + this.protocolo_autorizacao.GetHashCode();
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
