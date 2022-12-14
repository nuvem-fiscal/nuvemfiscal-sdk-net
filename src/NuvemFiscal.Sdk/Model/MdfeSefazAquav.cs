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
    /// MdfeSefazAquav
    /// </summary>
    [DataContract(Name = "MdfeSefazAquav")]
    public partial class MdfeSefazAquav : IEquatable<MdfeSefazAquav>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazAquav" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazAquav() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazAquav" /> class.
        /// </summary>
        /// <param name="irin">Irin do navio sempre deverá ser informado. (required).</param>
        /// <param name="tpEmb">Código do tipo de embarcação.  Preencher com código da Tabela de Tipo de Embarcação definida no Ministério dos Transportes. (required).</param>
        /// <param name="cEmbar">Código da embarcação. (required).</param>
        /// <param name="xEmbar">Nome da embarcação. (required).</param>
        /// <param name="nViag">Número da Viagem. (required).</param>
        /// <param name="cPrtEmb">Código do Porto de Embarque.  Preencher de acordo com Tabela de Portos definida no Ministério dos Transportes. (required).</param>
        /// <param name="cPrtDest">Código do Porto de Destino.  Preencher de acordo com Tabela de Portos definida no Ministério dos Transportes. (required).</param>
        /// <param name="prtTrans">Porto de Transbordo..</param>
        /// <param name="tpNav">Tipo de Navegação.  Preencher com:         0 - Interior;        1 - Cabotagem..</param>
        /// <param name="infTermCarreg">Grupo de informações dos terminais de carregamento..</param>
        /// <param name="infTermDescarreg">Grupo de informações dos terminais de descarregamento..</param>
        /// <param name="infEmbComb">Informações das Embarcações do Comboio..</param>
        /// <param name="infUnidCargaVazia">Informações das Undades de Carga vazias..</param>
        /// <param name="infUnidTranspVazia">Informações das Undades de Transporte vazias..</param>
        public MdfeSefazAquav(string irin = default(string), string tpEmb = default(string), string cEmbar = default(string), string xEmbar = default(string), string nViag = default(string), string cPrtEmb = default(string), string cPrtDest = default(string), string prtTrans = default(string), int tpNav = default(int), List<MdfeSefazInfTermCarreg> infTermCarreg = default(List<MdfeSefazInfTermCarreg>), List<MdfeSefazInfTermDescarreg> infTermDescarreg = default(List<MdfeSefazInfTermDescarreg>), List<MdfeSefazInfEmbComb> infEmbComb = default(List<MdfeSefazInfEmbComb>), List<MdfeSefazInfUnidCargaVazia> infUnidCargaVazia = default(List<MdfeSefazInfUnidCargaVazia>), List<MdfeSefazInfUnidTranspVazia> infUnidTranspVazia = default(List<MdfeSefazInfUnidTranspVazia>))
        {
            // to ensure "irin" is required (not null)
            if (irin == null)
            {
                throw new ArgumentNullException("irin is a required property for MdfeSefazAquav and cannot be null");
            }
            this.irin = irin;
            // to ensure "tpEmb" is required (not null)
            if (tpEmb == null)
            {
                throw new ArgumentNullException("tpEmb is a required property for MdfeSefazAquav and cannot be null");
            }
            this.tpEmb = tpEmb;
            // to ensure "cEmbar" is required (not null)
            if (cEmbar == null)
            {
                throw new ArgumentNullException("cEmbar is a required property for MdfeSefazAquav and cannot be null");
            }
            this.cEmbar = cEmbar;
            // to ensure "xEmbar" is required (not null)
            if (xEmbar == null)
            {
                throw new ArgumentNullException("xEmbar is a required property for MdfeSefazAquav and cannot be null");
            }
            this.xEmbar = xEmbar;
            // to ensure "nViag" is required (not null)
            if (nViag == null)
            {
                throw new ArgumentNullException("nViag is a required property for MdfeSefazAquav and cannot be null");
            }
            this.nViag = nViag;
            // to ensure "cPrtEmb" is required (not null)
            if (cPrtEmb == null)
            {
                throw new ArgumentNullException("cPrtEmb is a required property for MdfeSefazAquav and cannot be null");
            }
            this.cPrtEmb = cPrtEmb;
            // to ensure "cPrtDest" is required (not null)
            if (cPrtDest == null)
            {
                throw new ArgumentNullException("cPrtDest is a required property for MdfeSefazAquav and cannot be null");
            }
            this.cPrtDest = cPrtDest;
            this.prtTrans = prtTrans;
            this.tpNav = tpNav;
            this.infTermCarreg = infTermCarreg;
            this.infTermDescarreg = infTermDescarreg;
            this.infEmbComb = infEmbComb;
            this.infUnidCargaVazia = infUnidCargaVazia;
            this.infUnidTranspVazia = infUnidTranspVazia;
        }

        /// <summary>
        /// Irin do navio sempre deverá ser informado.
        /// </summary>
        /// <value>Irin do navio sempre deverá ser informado.</value>
        [DataMember(Name = "irin", IsRequired = true, EmitDefaultValue = true)]
        public string irin { get; set; }

        /// <summary>
        /// Código do tipo de embarcação.  Preencher com código da Tabela de Tipo de Embarcação definida no Ministério dos Transportes.
        /// </summary>
        /// <value>Código do tipo de embarcação.  Preencher com código da Tabela de Tipo de Embarcação definida no Ministério dos Transportes.</value>
        [DataMember(Name = "tpEmb", IsRequired = true, EmitDefaultValue = true)]
        public string tpEmb { get; set; }

        /// <summary>
        /// Código da embarcação.
        /// </summary>
        /// <value>Código da embarcação.</value>
        [DataMember(Name = "cEmbar", IsRequired = true, EmitDefaultValue = true)]
        public string cEmbar { get; set; }

        /// <summary>
        /// Nome da embarcação.
        /// </summary>
        /// <value>Nome da embarcação.</value>
        [DataMember(Name = "xEmbar", IsRequired = true, EmitDefaultValue = true)]
        public string xEmbar { get; set; }

        /// <summary>
        /// Número da Viagem.
        /// </summary>
        /// <value>Número da Viagem.</value>
        [DataMember(Name = "nViag", IsRequired = true, EmitDefaultValue = true)]
        public string nViag { get; set; }

        /// <summary>
        /// Código do Porto de Embarque.  Preencher de acordo com Tabela de Portos definida no Ministério dos Transportes.
        /// </summary>
        /// <value>Código do Porto de Embarque.  Preencher de acordo com Tabela de Portos definida no Ministério dos Transportes.</value>
        [DataMember(Name = "cPrtEmb", IsRequired = true, EmitDefaultValue = true)]
        public string cPrtEmb { get; set; }

        /// <summary>
        /// Código do Porto de Destino.  Preencher de acordo com Tabela de Portos definida no Ministério dos Transportes.
        /// </summary>
        /// <value>Código do Porto de Destino.  Preencher de acordo com Tabela de Portos definida no Ministério dos Transportes.</value>
        [DataMember(Name = "cPrtDest", IsRequired = true, EmitDefaultValue = true)]
        public string cPrtDest { get; set; }

        /// <summary>
        /// Porto de Transbordo.
        /// </summary>
        /// <value>Porto de Transbordo.</value>
        [DataMember(Name = "prtTrans", EmitDefaultValue = false)]
        public string prtTrans { get; set; }

        /// <summary>
        /// Tipo de Navegação.  Preencher com:         0 - Interior;        1 - Cabotagem.
        /// </summary>
        /// <value>Tipo de Navegação.  Preencher com:         0 - Interior;        1 - Cabotagem.</value>
        [DataMember(Name = "tpNav", EmitDefaultValue = false)]
        public int tpNav { get; set; }

        /// <summary>
        /// Grupo de informações dos terminais de carregamento.
        /// </summary>
        /// <value>Grupo de informações dos terminais de carregamento.</value>
        [DataMember(Name = "infTermCarreg", EmitDefaultValue = false)]
        public List<MdfeSefazInfTermCarreg> infTermCarreg { get; set; }

        /// <summary>
        /// Grupo de informações dos terminais de descarregamento.
        /// </summary>
        /// <value>Grupo de informações dos terminais de descarregamento.</value>
        [DataMember(Name = "infTermDescarreg", EmitDefaultValue = false)]
        public List<MdfeSefazInfTermDescarreg> infTermDescarreg { get; set; }

        /// <summary>
        /// Informações das Embarcações do Comboio.
        /// </summary>
        /// <value>Informações das Embarcações do Comboio.</value>
        [DataMember(Name = "infEmbComb", EmitDefaultValue = false)]
        public List<MdfeSefazInfEmbComb> infEmbComb { get; set; }

        /// <summary>
        /// Informações das Undades de Carga vazias.
        /// </summary>
        /// <value>Informações das Undades de Carga vazias.</value>
        [DataMember(Name = "infUnidCargaVazia", EmitDefaultValue = false)]
        public List<MdfeSefazInfUnidCargaVazia> infUnidCargaVazia { get; set; }

        /// <summary>
        /// Informações das Undades de Transporte vazias.
        /// </summary>
        /// <value>Informações das Undades de Transporte vazias.</value>
        [DataMember(Name = "infUnidTranspVazia", EmitDefaultValue = false)]
        public List<MdfeSefazInfUnidTranspVazia> infUnidTranspVazia { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazAquav {\n");
            sb.Append("  irin: ").Append(irin).Append("\n");
            sb.Append("  tpEmb: ").Append(tpEmb).Append("\n");
            sb.Append("  cEmbar: ").Append(cEmbar).Append("\n");
            sb.Append("  xEmbar: ").Append(xEmbar).Append("\n");
            sb.Append("  nViag: ").Append(nViag).Append("\n");
            sb.Append("  cPrtEmb: ").Append(cPrtEmb).Append("\n");
            sb.Append("  cPrtDest: ").Append(cPrtDest).Append("\n");
            sb.Append("  prtTrans: ").Append(prtTrans).Append("\n");
            sb.Append("  tpNav: ").Append(tpNav).Append("\n");
            sb.Append("  infTermCarreg: ").Append(infTermCarreg).Append("\n");
            sb.Append("  infTermDescarreg: ").Append(infTermDescarreg).Append("\n");
            sb.Append("  infEmbComb: ").Append(infEmbComb).Append("\n");
            sb.Append("  infUnidCargaVazia: ").Append(infUnidCargaVazia).Append("\n");
            sb.Append("  infUnidTranspVazia: ").Append(infUnidTranspVazia).Append("\n");
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
            return this.Equals(input as MdfeSefazAquav);
        }

        /// <summary>
        /// Returns true if MdfeSefazAquav instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazAquav to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazAquav input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.irin == input.irin ||
                    (this.irin != null &&
                    this.irin.Equals(input.irin))
                ) && 
                (
                    this.tpEmb == input.tpEmb ||
                    (this.tpEmb != null &&
                    this.tpEmb.Equals(input.tpEmb))
                ) && 
                (
                    this.cEmbar == input.cEmbar ||
                    (this.cEmbar != null &&
                    this.cEmbar.Equals(input.cEmbar))
                ) && 
                (
                    this.xEmbar == input.xEmbar ||
                    (this.xEmbar != null &&
                    this.xEmbar.Equals(input.xEmbar))
                ) && 
                (
                    this.nViag == input.nViag ||
                    (this.nViag != null &&
                    this.nViag.Equals(input.nViag))
                ) && 
                (
                    this.cPrtEmb == input.cPrtEmb ||
                    (this.cPrtEmb != null &&
                    this.cPrtEmb.Equals(input.cPrtEmb))
                ) && 
                (
                    this.cPrtDest == input.cPrtDest ||
                    (this.cPrtDest != null &&
                    this.cPrtDest.Equals(input.cPrtDest))
                ) && 
                (
                    this.prtTrans == input.prtTrans ||
                    (this.prtTrans != null &&
                    this.prtTrans.Equals(input.prtTrans))
                ) && 
                (
                    this.tpNav == input.tpNav ||
                    this.tpNav.Equals(input.tpNav)
                ) && 
                (
                    this.infTermCarreg == input.infTermCarreg ||
                    this.infTermCarreg != null &&
                    input.infTermCarreg != null &&
                    this.infTermCarreg.SequenceEqual(input.infTermCarreg)
                ) && 
                (
                    this.infTermDescarreg == input.infTermDescarreg ||
                    this.infTermDescarreg != null &&
                    input.infTermDescarreg != null &&
                    this.infTermDescarreg.SequenceEqual(input.infTermDescarreg)
                ) && 
                (
                    this.infEmbComb == input.infEmbComb ||
                    this.infEmbComb != null &&
                    input.infEmbComb != null &&
                    this.infEmbComb.SequenceEqual(input.infEmbComb)
                ) && 
                (
                    this.infUnidCargaVazia == input.infUnidCargaVazia ||
                    this.infUnidCargaVazia != null &&
                    input.infUnidCargaVazia != null &&
                    this.infUnidCargaVazia.SequenceEqual(input.infUnidCargaVazia)
                ) && 
                (
                    this.infUnidTranspVazia == input.infUnidTranspVazia ||
                    this.infUnidTranspVazia != null &&
                    input.infUnidTranspVazia != null &&
                    this.infUnidTranspVazia.SequenceEqual(input.infUnidTranspVazia)
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
                if (this.irin != null)
                {
                    hashCode = (hashCode * 59) + this.irin.GetHashCode();
                }
                if (this.tpEmb != null)
                {
                    hashCode = (hashCode * 59) + this.tpEmb.GetHashCode();
                }
                if (this.cEmbar != null)
                {
                    hashCode = (hashCode * 59) + this.cEmbar.GetHashCode();
                }
                if (this.xEmbar != null)
                {
                    hashCode = (hashCode * 59) + this.xEmbar.GetHashCode();
                }
                if (this.nViag != null)
                {
                    hashCode = (hashCode * 59) + this.nViag.GetHashCode();
                }
                if (this.cPrtEmb != null)
                {
                    hashCode = (hashCode * 59) + this.cPrtEmb.GetHashCode();
                }
                if (this.cPrtDest != null)
                {
                    hashCode = (hashCode * 59) + this.cPrtDest.GetHashCode();
                }
                if (this.prtTrans != null)
                {
                    hashCode = (hashCode * 59) + this.prtTrans.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.tpNav.GetHashCode();
                if (this.infTermCarreg != null)
                {
                    hashCode = (hashCode * 59) + this.infTermCarreg.GetHashCode();
                }
                if (this.infTermDescarreg != null)
                {
                    hashCode = (hashCode * 59) + this.infTermDescarreg.GetHashCode();
                }
                if (this.infEmbComb != null)
                {
                    hashCode = (hashCode * 59) + this.infEmbComb.GetHashCode();
                }
                if (this.infUnidCargaVazia != null)
                {
                    hashCode = (hashCode * 59) + this.infUnidCargaVazia.GetHashCode();
                }
                if (this.infUnidTranspVazia != null)
                {
                    hashCode = (hashCode * 59) + this.infUnidTranspVazia.GetHashCode();
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
