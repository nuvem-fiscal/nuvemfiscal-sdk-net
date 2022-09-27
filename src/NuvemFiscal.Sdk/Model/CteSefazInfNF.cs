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
    /// CteSefazInfNF
    /// </summary>
    [DataContract(Name = "CteSefazInfNF")]
    public partial class CteSefazInfNF : IEquatable<CteSefazInfNF>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfNF" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazInfNF() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfNF" /> class.
        /// </summary>
        /// <param name="nRoma">Número do Romaneio da NF..</param>
        /// <param name="nPed">Número do Pedido da NF..</param>
        /// <param name="mod">Modelo da Nota Fiscal.  Preencher com:  01 - NF Modelo 01/1A e Avulsa;  04 - NF de Produtor. (required).</param>
        /// <param name="serie">Série. (required).</param>
        /// <param name="nDoc">Número. (required).</param>
        /// <param name="dEmi">Data de Emissão.  Formato AAAA-MM-DD. (required).</param>
        /// <param name="vBC">Valor da Base de Cálculo do ICMS. (required).</param>
        /// <param name="vICMS">Valor Total do ICMS. (required).</param>
        /// <param name="vBCST">Valor da Base de Cálculo do ICMS ST. (required).</param>
        /// <param name="vST">Valor Total do ICMS ST. (required).</param>
        /// <param name="vProd">Valor Total dos Produtos. (required).</param>
        /// <param name="vNF">Valor Total da NF. (required).</param>
        /// <param name="nCFOP">CFOP Predominante.  CFOP da NF ou, na existência de mais de um, predominância pelo critério de valor econômico. (required).</param>
        /// <param name="nPeso">Peso total em Kg..</param>
        /// <param name="pIN">PIN SUFRAMA.  PIN atribuído pela SUFRAMA para a operação..</param>
        /// <param name="dPrev">Data prevista de entrega.  Formato AAAA-MM-DD..</param>
        /// <param name="infUnidCarga">Informações das Unidades de Carga (Containeres/ULD/Outros).  Dispositivo de carga utilizada (Unit Load Device - ULD) significa todo tipo de contêiner de carga, vagão, contêiner de avião, palete de aeronave com rede ou palete de aeronave com rede sobre um iglu..</param>
        /// <param name="infUnidTransp">Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas..</param>
        public CteSefazInfNF(string nRoma = default(string), string nPed = default(string), string mod = default(string), string serie = default(string), string nDoc = default(string), DateTime dEmi = default(DateTime), decimal vBC = default(decimal), decimal vICMS = default(decimal), decimal vBCST = default(decimal), decimal vST = default(decimal), decimal vProd = default(decimal), decimal vNF = default(decimal), int nCFOP = default(int), decimal nPeso = default(decimal), string pIN = default(string), DateTime dPrev = default(DateTime), List<CteSefazUnidCarga> infUnidCarga = default(List<CteSefazUnidCarga>), List<CteSefazUnidadeTransp> infUnidTransp = default(List<CteSefazUnidadeTransp>))
        {
            // to ensure "mod" is required (not null)
            if (mod == null)
            {
                throw new ArgumentNullException("mod is a required property for CteSefazInfNF and cannot be null");
            }
            this.mod = mod;
            // to ensure "serie" is required (not null)
            if (serie == null)
            {
                throw new ArgumentNullException("serie is a required property for CteSefazInfNF and cannot be null");
            }
            this.serie = serie;
            // to ensure "nDoc" is required (not null)
            if (nDoc == null)
            {
                throw new ArgumentNullException("nDoc is a required property for CteSefazInfNF and cannot be null");
            }
            this.nDoc = nDoc;
            this.dEmi = dEmi;
            this.vBC = vBC;
            this.vICMS = vICMS;
            this.vBCST = vBCST;
            this.vST = vST;
            this.vProd = vProd;
            this.vNF = vNF;
            this.nCFOP = nCFOP;
            this.nRoma = nRoma;
            this.nPed = nPed;
            this.nPeso = nPeso;
            this.PIN = pIN;
            this.dPrev = dPrev;
            this.infUnidCarga = infUnidCarga;
            this.infUnidTransp = infUnidTransp;
        }

        /// <summary>
        /// Número do Romaneio da NF.
        /// </summary>
        /// <value>Número do Romaneio da NF.</value>
        [DataMember(Name = "nRoma", EmitDefaultValue = false)]
        public string nRoma { get; set; }

        /// <summary>
        /// Número do Pedido da NF.
        /// </summary>
        /// <value>Número do Pedido da NF.</value>
        [DataMember(Name = "nPed", EmitDefaultValue = false)]
        public string nPed { get; set; }

        /// <summary>
        /// Modelo da Nota Fiscal.  Preencher com:  01 - NF Modelo 01/1A e Avulsa;  04 - NF de Produtor.
        /// </summary>
        /// <value>Modelo da Nota Fiscal.  Preencher com:  01 - NF Modelo 01/1A e Avulsa;  04 - NF de Produtor.</value>
        [DataMember(Name = "mod", IsRequired = true, EmitDefaultValue = true)]
        public string mod { get; set; }

        /// <summary>
        /// Série.
        /// </summary>
        /// <value>Série.</value>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = true)]
        public string serie { get; set; }

        /// <summary>
        /// Número.
        /// </summary>
        /// <value>Número.</value>
        [DataMember(Name = "nDoc", IsRequired = true, EmitDefaultValue = true)]
        public string nDoc { get; set; }

        /// <summary>
        /// Data de Emissão.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data de Emissão.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dEmi", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dEmi { get; set; }

        /// <summary>
        /// Valor da Base de Cálculo do ICMS.
        /// </summary>
        /// <value>Valor da Base de Cálculo do ICMS.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal vBC { get; set; }

        /// <summary>
        /// Valor Total do ICMS.
        /// </summary>
        /// <value>Valor Total do ICMS.</value>
        [DataMember(Name = "vICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal vICMS { get; set; }

        /// <summary>
        /// Valor da Base de Cálculo do ICMS ST.
        /// </summary>
        /// <value>Valor da Base de Cálculo do ICMS ST.</value>
        [DataMember(Name = "vBCST", IsRequired = true, EmitDefaultValue = true)]
        public decimal vBCST { get; set; }

        /// <summary>
        /// Valor Total do ICMS ST.
        /// </summary>
        /// <value>Valor Total do ICMS ST.</value>
        [DataMember(Name = "vST", IsRequired = true, EmitDefaultValue = true)]
        public decimal vST { get; set; }

        /// <summary>
        /// Valor Total dos Produtos.
        /// </summary>
        /// <value>Valor Total dos Produtos.</value>
        [DataMember(Name = "vProd", IsRequired = true, EmitDefaultValue = true)]
        public decimal vProd { get; set; }

        /// <summary>
        /// Valor Total da NF.
        /// </summary>
        /// <value>Valor Total da NF.</value>
        [DataMember(Name = "vNF", IsRequired = true, EmitDefaultValue = true)]
        public decimal vNF { get; set; }

        /// <summary>
        /// CFOP Predominante.  CFOP da NF ou, na existência de mais de um, predominância pelo critério de valor econômico.
        /// </summary>
        /// <value>CFOP Predominante.  CFOP da NF ou, na existência de mais de um, predominância pelo critério de valor econômico.</value>
        [DataMember(Name = "nCFOP", IsRequired = true, EmitDefaultValue = true)]
        public int nCFOP { get; set; }

        /// <summary>
        /// Peso total em Kg.
        /// </summary>
        /// <value>Peso total em Kg.</value>
        [DataMember(Name = "nPeso", EmitDefaultValue = false)]
        public decimal nPeso { get; set; }

        /// <summary>
        /// PIN SUFRAMA.  PIN atribuído pela SUFRAMA para a operação.
        /// </summary>
        /// <value>PIN SUFRAMA.  PIN atribuído pela SUFRAMA para a operação.</value>
        [DataMember(Name = "PIN", EmitDefaultValue = false)]
        public string PIN { get; set; }

        /// <summary>
        /// Data prevista de entrega.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data prevista de entrega.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dPrev", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dPrev { get; set; }

        /// <summary>
        /// Informações das Unidades de Carga (Containeres/ULD/Outros).  Dispositivo de carga utilizada (Unit Load Device - ULD) significa todo tipo de contêiner de carga, vagão, contêiner de avião, palete de aeronave com rede ou palete de aeronave com rede sobre um iglu.
        /// </summary>
        /// <value>Informações das Unidades de Carga (Containeres/ULD/Outros).  Dispositivo de carga utilizada (Unit Load Device - ULD) significa todo tipo de contêiner de carga, vagão, contêiner de avião, palete de aeronave com rede ou palete de aeronave com rede sobre um iglu.</value>
        [DataMember(Name = "infUnidCarga", EmitDefaultValue = false)]
        public List<CteSefazUnidCarga> infUnidCarga { get; set; }

        /// <summary>
        /// Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas.
        /// </summary>
        /// <value>Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas.</value>
        [DataMember(Name = "infUnidTransp", EmitDefaultValue = false)]
        public List<CteSefazUnidadeTransp> infUnidTransp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazInfNF {\n");
            sb.Append("  nRoma: ").Append(nRoma).Append("\n");
            sb.Append("  nPed: ").Append(nPed).Append("\n");
            sb.Append("  mod: ").Append(mod).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  nDoc: ").Append(nDoc).Append("\n");
            sb.Append("  dEmi: ").Append(dEmi).Append("\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  vICMS: ").Append(vICMS).Append("\n");
            sb.Append("  vBCST: ").Append(vBCST).Append("\n");
            sb.Append("  vST: ").Append(vST).Append("\n");
            sb.Append("  vProd: ").Append(vProd).Append("\n");
            sb.Append("  vNF: ").Append(vNF).Append("\n");
            sb.Append("  nCFOP: ").Append(nCFOP).Append("\n");
            sb.Append("  nPeso: ").Append(nPeso).Append("\n");
            sb.Append("  PIN: ").Append(PIN).Append("\n");
            sb.Append("  dPrev: ").Append(dPrev).Append("\n");
            sb.Append("  infUnidCarga: ").Append(infUnidCarga).Append("\n");
            sb.Append("  infUnidTransp: ").Append(infUnidTransp).Append("\n");
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
            return this.Equals(input as CteSefazInfNF);
        }

        /// <summary>
        /// Returns true if CteSefazInfNF instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazInfNF to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazInfNF input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nRoma == input.nRoma ||
                    (this.nRoma != null &&
                    this.nRoma.Equals(input.nRoma))
                ) && 
                (
                    this.nPed == input.nPed ||
                    (this.nPed != null &&
                    this.nPed.Equals(input.nPed))
                ) && 
                (
                    this.mod == input.mod ||
                    (this.mod != null &&
                    this.mod.Equals(input.mod))
                ) && 
                (
                    this.serie == input.serie ||
                    (this.serie != null &&
                    this.serie.Equals(input.serie))
                ) && 
                (
                    this.nDoc == input.nDoc ||
                    (this.nDoc != null &&
                    this.nDoc.Equals(input.nDoc))
                ) && 
                (
                    this.dEmi == input.dEmi ||
                    (this.dEmi != null &&
                    this.dEmi.Equals(input.dEmi))
                ) && 
                (
                    this.vBC == input.vBC ||
                    this.vBC.Equals(input.vBC)
                ) && 
                (
                    this.vICMS == input.vICMS ||
                    this.vICMS.Equals(input.vICMS)
                ) && 
                (
                    this.vBCST == input.vBCST ||
                    this.vBCST.Equals(input.vBCST)
                ) && 
                (
                    this.vST == input.vST ||
                    this.vST.Equals(input.vST)
                ) && 
                (
                    this.vProd == input.vProd ||
                    this.vProd.Equals(input.vProd)
                ) && 
                (
                    this.vNF == input.vNF ||
                    this.vNF.Equals(input.vNF)
                ) && 
                (
                    this.nCFOP == input.nCFOP ||
                    this.nCFOP.Equals(input.nCFOP)
                ) && 
                (
                    this.nPeso == input.nPeso ||
                    this.nPeso.Equals(input.nPeso)
                ) && 
                (
                    this.PIN == input.PIN ||
                    (this.PIN != null &&
                    this.PIN.Equals(input.PIN))
                ) && 
                (
                    this.dPrev == input.dPrev ||
                    (this.dPrev != null &&
                    this.dPrev.Equals(input.dPrev))
                ) && 
                (
                    this.infUnidCarga == input.infUnidCarga ||
                    this.infUnidCarga != null &&
                    input.infUnidCarga != null &&
                    this.infUnidCarga.SequenceEqual(input.infUnidCarga)
                ) && 
                (
                    this.infUnidTransp == input.infUnidTransp ||
                    this.infUnidTransp != null &&
                    input.infUnidTransp != null &&
                    this.infUnidTransp.SequenceEqual(input.infUnidTransp)
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
                if (this.nRoma != null)
                {
                    hashCode = (hashCode * 59) + this.nRoma.GetHashCode();
                }
                if (this.nPed != null)
                {
                    hashCode = (hashCode * 59) + this.nPed.GetHashCode();
                }
                if (this.mod != null)
                {
                    hashCode = (hashCode * 59) + this.mod.GetHashCode();
                }
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                if (this.nDoc != null)
                {
                    hashCode = (hashCode * 59) + this.nDoc.GetHashCode();
                }
                if (this.dEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dEmi.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMS.GetHashCode();
                hashCode = (hashCode * 59) + this.vBCST.GetHashCode();
                hashCode = (hashCode * 59) + this.vST.GetHashCode();
                hashCode = (hashCode * 59) + this.vProd.GetHashCode();
                hashCode = (hashCode * 59) + this.vNF.GetHashCode();
                hashCode = (hashCode * 59) + this.nCFOP.GetHashCode();
                hashCode = (hashCode * 59) + this.nPeso.GetHashCode();
                if (this.PIN != null)
                {
                    hashCode = (hashCode * 59) + this.PIN.GetHashCode();
                }
                if (this.dPrev != null)
                {
                    hashCode = (hashCode * 59) + this.dPrev.GetHashCode();
                }
                if (this.infUnidCarga != null)
                {
                    hashCode = (hashCode * 59) + this.infUnidCarga.GetHashCode();
                }
                if (this.infUnidTransp != null)
                {
                    hashCode = (hashCode * 59) + this.infUnidTransp.GetHashCode();
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
