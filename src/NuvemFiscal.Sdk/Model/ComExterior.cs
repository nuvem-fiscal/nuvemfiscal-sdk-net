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
    /// Grupo de informações relativas à exportação/importação de serviço prestado.
    /// </summary>
    [DataContract(Name = "ComExterior")]
    public partial class ComExterior : IEquatable<ComExterior>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComExterior" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComExterior() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComExterior" /> class.
        /// </summary>
        /// <param name="mdPrestacao">Modo de Prestação:  * 0 - Desconhecido (tipo não informado na nota de origem)  * 1 - Transfronteiriço  * 2 - Consumo no Brasil  * 3 - Presença Comercial no Exterior  * 4 - Movimento Temporário de Pessoas Físicas (required).</param>
        /// <param name="vincPrest">Vínculo entre as partes no negócio:  * 0 - Sem vínculo com o tomador/ Prestador  * 1 - Controlada  * 2 - Controladora  * 3 - Coligada  * 4 - Matriz  * 5 - Filial ou sucursal  * 6 - Outro vínculo (required).</param>
        /// <param name="tpMoeda">Identifica a moeda da transação comercial. (required).</param>
        /// <param name="vServMoeda">Valor do serviço prestado expresso em moeda estrangeira especificada em tpmoeda. (required).</param>
        /// <param name="mecAFComexP">Mecanismo de apoio/fomento ao Comércio Exterior utilizado pelo prestador do serviço:  * 00 - Desconhecido (tipo não informado na nota de origem)  * 01 - Nenhum  * 02 - ACC - Adiantamento sobre Contrato de Câmbio - Redução a Zero do IR e do IOF  * 03 - ACE - Adiantamento sobre Cambiais Entregues - Redução a Zero do IR e do IOF  * 04 - BNDES-Exim Pós-Embarque - Serviços  * 05 - BNDES-Exim Pré-Embarque - Serviços  * 06 - FGE - Fundo de Garantia à Exportação  * 07 - PROEX - EQUALIZAÇÃO  * 08 - PROEX - Financiamento (required).</param>
        /// <param name="mecAFComexT">Mecanismo de apoio/fomento ao Comércio Exterior utilizado pelo tomador do serviço:  * 00 - Desconhecido (tipo não informado na nota de origem)  * 01 - Nenhum  * 02 - Adm. Pública e Repr. Internacional  * 03 - Alugueis e Arrend. Mercantil de maquinas, equip., embarc. e aeronaves  * 04 - Arrendamento Mercantil de aeronave para empresa de transporte aéreo público  * 05 - Comissão a agentes externos na exportação  * 06 - Despesas de armazenagem, mov. e transporte de carga no exterior  * 07 - Eventos FIFA (subsidiária)  * 08 - Eventos FIFA  * 09 - Fretes, arrendamentos de embarcações ou aeronaves e outros  * 10 - Material Aeronáutico  * 11 - Promoção de Bens no Exterior  * 12 - Promoção de Dest. Turísticos Brasileiros  * 13 - Promoção do Brasil no Exterior  * 14 - Promoção Serviços no Exterior  * 15 - RECINE  * 16 - RECOPA  * 17 - Registro e Manutenção de marcas, patentes e cultivares  * 18 - REICOMP  * 19 - REIDI  * 20 - REPENEC  * 21 - REPES  * 22 - RETAERO  * 23 - RETID  * 24 - Royalties, Assistência Técnica, Científica e Assemelhados  * 25 - Serviços de avaliação da conformidade vinculados aos Acordos da OMC  * 26 - ZPE (required).</param>
        /// <param name="movTempBens">Operação está vinculada à Movimentação Temporária de Bens:  * 0 - Desconhecido (tipo não informado na nota de origem)  * 1 - Não  * 2 - Vinculada - Declaração de Importação  * 3 - Vinculada - Declaração de Exportação (required).</param>
        /// <param name="nDI">Número da Declaração de Importação (DI/DSI/DA/DRI-E) averbado..</param>
        /// <param name="nRE">Número do Registro de Exportação (RE) averbado..</param>
        /// <param name="mdic">Compartilhar as informações da NFS-e gerada a partir desta DPS com a Secretaria de Comércio Exterior:  * 0 - Não enviar para o MDIC  * 1 - Enviar para o MDIC (required).</param>
        public ComExterior(int? mdPrestacao = default(int?), int? vincPrest = default(int?), string tpMoeda = default(string), decimal? vServMoeda = default(decimal?), string mecAFComexP = default(string), string mecAFComexT = default(string), int? movTempBens = default(int?), string nDI = default(string), string nRE = default(string), int? mdic = default(int?))
        {
            // to ensure "mdPrestacao" is required (not null)
            if (mdPrestacao == null)
            {
                throw new ArgumentNullException("mdPrestacao is a required property for ComExterior and cannot be null");
            }
            this.mdPrestacao = mdPrestacao;
            // to ensure "vincPrest" is required (not null)
            if (vincPrest == null)
            {
                throw new ArgumentNullException("vincPrest is a required property for ComExterior and cannot be null");
            }
            this.vincPrest = vincPrest;
            // to ensure "tpMoeda" is required (not null)
            if (tpMoeda == null)
            {
                throw new ArgumentNullException("tpMoeda is a required property for ComExterior and cannot be null");
            }
            this.tpMoeda = tpMoeda;
            // to ensure "vServMoeda" is required (not null)
            if (vServMoeda == null)
            {
                throw new ArgumentNullException("vServMoeda is a required property for ComExterior and cannot be null");
            }
            this.vServMoeda = vServMoeda;
            // to ensure "mecAFComexP" is required (not null)
            if (mecAFComexP == null)
            {
                throw new ArgumentNullException("mecAFComexP is a required property for ComExterior and cannot be null");
            }
            this.mecAFComexP = mecAFComexP;
            // to ensure "mecAFComexT" is required (not null)
            if (mecAFComexT == null)
            {
                throw new ArgumentNullException("mecAFComexT is a required property for ComExterior and cannot be null");
            }
            this.mecAFComexT = mecAFComexT;
            // to ensure "movTempBens" is required (not null)
            if (movTempBens == null)
            {
                throw new ArgumentNullException("movTempBens is a required property for ComExterior and cannot be null");
            }
            this.movTempBens = movTempBens;
            // to ensure "mdic" is required (not null)
            if (mdic == null)
            {
                throw new ArgumentNullException("mdic is a required property for ComExterior and cannot be null");
            }
            this.mdic = mdic;
            this.nDI = nDI;
            this.nRE = nRE;
        }

        /// <summary>
        /// Modo de Prestação:  * 0 - Desconhecido (tipo não informado na nota de origem)  * 1 - Transfronteiriço  * 2 - Consumo no Brasil  * 3 - Presença Comercial no Exterior  * 4 - Movimento Temporário de Pessoas Físicas
        /// </summary>
        /// <value>Modo de Prestação:  * 0 - Desconhecido (tipo não informado na nota de origem)  * 1 - Transfronteiriço  * 2 - Consumo no Brasil  * 3 - Presença Comercial no Exterior  * 4 - Movimento Temporário de Pessoas Físicas</value>
        [DataMember(Name = "mdPrestacao", IsRequired = true, EmitDefaultValue = true)]
        public int? mdPrestacao { get; set; }

        /// <summary>
        /// Vínculo entre as partes no negócio:  * 0 - Sem vínculo com o tomador/ Prestador  * 1 - Controlada  * 2 - Controladora  * 3 - Coligada  * 4 - Matriz  * 5 - Filial ou sucursal  * 6 - Outro vínculo
        /// </summary>
        /// <value>Vínculo entre as partes no negócio:  * 0 - Sem vínculo com o tomador/ Prestador  * 1 - Controlada  * 2 - Controladora  * 3 - Coligada  * 4 - Matriz  * 5 - Filial ou sucursal  * 6 - Outro vínculo</value>
        [DataMember(Name = "vincPrest", IsRequired = true, EmitDefaultValue = true)]
        public int? vincPrest { get; set; }

        /// <summary>
        /// Identifica a moeda da transação comercial.
        /// </summary>
        /// <value>Identifica a moeda da transação comercial.</value>
        [DataMember(Name = "tpMoeda", IsRequired = true, EmitDefaultValue = true)]
        public string tpMoeda { get; set; }

        /// <summary>
        /// Valor do serviço prestado expresso em moeda estrangeira especificada em tpmoeda.
        /// </summary>
        /// <value>Valor do serviço prestado expresso em moeda estrangeira especificada em tpmoeda.</value>
        [DataMember(Name = "vServMoeda", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vServMoeda { get; set; }

        /// <summary>
        /// Mecanismo de apoio/fomento ao Comércio Exterior utilizado pelo prestador do serviço:  * 00 - Desconhecido (tipo não informado na nota de origem)  * 01 - Nenhum  * 02 - ACC - Adiantamento sobre Contrato de Câmbio - Redução a Zero do IR e do IOF  * 03 - ACE - Adiantamento sobre Cambiais Entregues - Redução a Zero do IR e do IOF  * 04 - BNDES-Exim Pós-Embarque - Serviços  * 05 - BNDES-Exim Pré-Embarque - Serviços  * 06 - FGE - Fundo de Garantia à Exportação  * 07 - PROEX - EQUALIZAÇÃO  * 08 - PROEX - Financiamento
        /// </summary>
        /// <value>Mecanismo de apoio/fomento ao Comércio Exterior utilizado pelo prestador do serviço:  * 00 - Desconhecido (tipo não informado na nota de origem)  * 01 - Nenhum  * 02 - ACC - Adiantamento sobre Contrato de Câmbio - Redução a Zero do IR e do IOF  * 03 - ACE - Adiantamento sobre Cambiais Entregues - Redução a Zero do IR e do IOF  * 04 - BNDES-Exim Pós-Embarque - Serviços  * 05 - BNDES-Exim Pré-Embarque - Serviços  * 06 - FGE - Fundo de Garantia à Exportação  * 07 - PROEX - EQUALIZAÇÃO  * 08 - PROEX - Financiamento</value>
        [DataMember(Name = "mecAFComexP", IsRequired = true, EmitDefaultValue = true)]
        public string mecAFComexP { get; set; }

        /// <summary>
        /// Mecanismo de apoio/fomento ao Comércio Exterior utilizado pelo tomador do serviço:  * 00 - Desconhecido (tipo não informado na nota de origem)  * 01 - Nenhum  * 02 - Adm. Pública e Repr. Internacional  * 03 - Alugueis e Arrend. Mercantil de maquinas, equip., embarc. e aeronaves  * 04 - Arrendamento Mercantil de aeronave para empresa de transporte aéreo público  * 05 - Comissão a agentes externos na exportação  * 06 - Despesas de armazenagem, mov. e transporte de carga no exterior  * 07 - Eventos FIFA (subsidiária)  * 08 - Eventos FIFA  * 09 - Fretes, arrendamentos de embarcações ou aeronaves e outros  * 10 - Material Aeronáutico  * 11 - Promoção de Bens no Exterior  * 12 - Promoção de Dest. Turísticos Brasileiros  * 13 - Promoção do Brasil no Exterior  * 14 - Promoção Serviços no Exterior  * 15 - RECINE  * 16 - RECOPA  * 17 - Registro e Manutenção de marcas, patentes e cultivares  * 18 - REICOMP  * 19 - REIDI  * 20 - REPENEC  * 21 - REPES  * 22 - RETAERO  * 23 - RETID  * 24 - Royalties, Assistência Técnica, Científica e Assemelhados  * 25 - Serviços de avaliação da conformidade vinculados aos Acordos da OMC  * 26 - ZPE
        /// </summary>
        /// <value>Mecanismo de apoio/fomento ao Comércio Exterior utilizado pelo tomador do serviço:  * 00 - Desconhecido (tipo não informado na nota de origem)  * 01 - Nenhum  * 02 - Adm. Pública e Repr. Internacional  * 03 - Alugueis e Arrend. Mercantil de maquinas, equip., embarc. e aeronaves  * 04 - Arrendamento Mercantil de aeronave para empresa de transporte aéreo público  * 05 - Comissão a agentes externos na exportação  * 06 - Despesas de armazenagem, mov. e transporte de carga no exterior  * 07 - Eventos FIFA (subsidiária)  * 08 - Eventos FIFA  * 09 - Fretes, arrendamentos de embarcações ou aeronaves e outros  * 10 - Material Aeronáutico  * 11 - Promoção de Bens no Exterior  * 12 - Promoção de Dest. Turísticos Brasileiros  * 13 - Promoção do Brasil no Exterior  * 14 - Promoção Serviços no Exterior  * 15 - RECINE  * 16 - RECOPA  * 17 - Registro e Manutenção de marcas, patentes e cultivares  * 18 - REICOMP  * 19 - REIDI  * 20 - REPENEC  * 21 - REPES  * 22 - RETAERO  * 23 - RETID  * 24 - Royalties, Assistência Técnica, Científica e Assemelhados  * 25 - Serviços de avaliação da conformidade vinculados aos Acordos da OMC  * 26 - ZPE</value>
        [DataMember(Name = "mecAFComexT", IsRequired = true, EmitDefaultValue = true)]
        public string mecAFComexT { get; set; }

        /// <summary>
        /// Operação está vinculada à Movimentação Temporária de Bens:  * 0 - Desconhecido (tipo não informado na nota de origem)  * 1 - Não  * 2 - Vinculada - Declaração de Importação  * 3 - Vinculada - Declaração de Exportação
        /// </summary>
        /// <value>Operação está vinculada à Movimentação Temporária de Bens:  * 0 - Desconhecido (tipo não informado na nota de origem)  * 1 - Não  * 2 - Vinculada - Declaração de Importação  * 3 - Vinculada - Declaração de Exportação</value>
        [DataMember(Name = "movTempBens", IsRequired = true, EmitDefaultValue = true)]
        public int? movTempBens { get; set; }

        /// <summary>
        /// Número da Declaração de Importação (DI/DSI/DA/DRI-E) averbado.
        /// </summary>
        /// <value>Número da Declaração de Importação (DI/DSI/DA/DRI-E) averbado.</value>
        [DataMember(Name = "nDI", EmitDefaultValue = true)]
        public string nDI { get; set; }

        /// <summary>
        /// Número do Registro de Exportação (RE) averbado.
        /// </summary>
        /// <value>Número do Registro de Exportação (RE) averbado.</value>
        [DataMember(Name = "nRE", EmitDefaultValue = true)]
        public string nRE { get; set; }

        /// <summary>
        /// Compartilhar as informações da NFS-e gerada a partir desta DPS com a Secretaria de Comércio Exterior:  * 0 - Não enviar para o MDIC  * 1 - Enviar para o MDIC
        /// </summary>
        /// <value>Compartilhar as informações da NFS-e gerada a partir desta DPS com a Secretaria de Comércio Exterior:  * 0 - Não enviar para o MDIC  * 1 - Enviar para o MDIC</value>
        [DataMember(Name = "mdic", IsRequired = true, EmitDefaultValue = true)]
        public int? mdic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComExterior {\n");
            sb.Append("  mdPrestacao: ").Append(mdPrestacao).Append("\n");
            sb.Append("  vincPrest: ").Append(vincPrest).Append("\n");
            sb.Append("  tpMoeda: ").Append(tpMoeda).Append("\n");
            sb.Append("  vServMoeda: ").Append(vServMoeda).Append("\n");
            sb.Append("  mecAFComexP: ").Append(mecAFComexP).Append("\n");
            sb.Append("  mecAFComexT: ").Append(mecAFComexT).Append("\n");
            sb.Append("  movTempBens: ").Append(movTempBens).Append("\n");
            sb.Append("  nDI: ").Append(nDI).Append("\n");
            sb.Append("  nRE: ").Append(nRE).Append("\n");
            sb.Append("  mdic: ").Append(mdic).Append("\n");
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
            return this.Equals(input as ComExterior);
        }

        /// <summary>
        /// Returns true if ComExterior instances are equal
        /// </summary>
        /// <param name="input">Instance of ComExterior to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComExterior input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.mdPrestacao == input.mdPrestacao ||
                    (this.mdPrestacao != null &&
                    this.mdPrestacao.Equals(input.mdPrestacao))
                ) && 
                (
                    this.vincPrest == input.vincPrest ||
                    (this.vincPrest != null &&
                    this.vincPrest.Equals(input.vincPrest))
                ) && 
                (
                    this.tpMoeda == input.tpMoeda ||
                    (this.tpMoeda != null &&
                    this.tpMoeda.Equals(input.tpMoeda))
                ) && 
                (
                    this.vServMoeda == input.vServMoeda ||
                    (this.vServMoeda != null &&
                    this.vServMoeda.Equals(input.vServMoeda))
                ) && 
                (
                    this.mecAFComexP == input.mecAFComexP ||
                    (this.mecAFComexP != null &&
                    this.mecAFComexP.Equals(input.mecAFComexP))
                ) && 
                (
                    this.mecAFComexT == input.mecAFComexT ||
                    (this.mecAFComexT != null &&
                    this.mecAFComexT.Equals(input.mecAFComexT))
                ) && 
                (
                    this.movTempBens == input.movTempBens ||
                    (this.movTempBens != null &&
                    this.movTempBens.Equals(input.movTempBens))
                ) && 
                (
                    this.nDI == input.nDI ||
                    (this.nDI != null &&
                    this.nDI.Equals(input.nDI))
                ) && 
                (
                    this.nRE == input.nRE ||
                    (this.nRE != null &&
                    this.nRE.Equals(input.nRE))
                ) && 
                (
                    this.mdic == input.mdic ||
                    (this.mdic != null &&
                    this.mdic.Equals(input.mdic))
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
                if (this.mdPrestacao != null)
                {
                    hashCode = (hashCode * 59) + this.mdPrestacao.GetHashCode();
                }
                if (this.vincPrest != null)
                {
                    hashCode = (hashCode * 59) + this.vincPrest.GetHashCode();
                }
                if (this.tpMoeda != null)
                {
                    hashCode = (hashCode * 59) + this.tpMoeda.GetHashCode();
                }
                if (this.vServMoeda != null)
                {
                    hashCode = (hashCode * 59) + this.vServMoeda.GetHashCode();
                }
                if (this.mecAFComexP != null)
                {
                    hashCode = (hashCode * 59) + this.mecAFComexP.GetHashCode();
                }
                if (this.mecAFComexT != null)
                {
                    hashCode = (hashCode * 59) + this.mecAFComexT.GetHashCode();
                }
                if (this.movTempBens != null)
                {
                    hashCode = (hashCode * 59) + this.movTempBens.GetHashCode();
                }
                if (this.nDI != null)
                {
                    hashCode = (hashCode * 59) + this.nDI.GetHashCode();
                }
                if (this.nRE != null)
                {
                    hashCode = (hashCode * 59) + this.nRE.GetHashCode();
                }
                if (this.mdic != null)
                {
                    hashCode = (hashCode * 59) + this.mdic.GetHashCode();
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
            // tpMoeda (string) maxLength
            if (this.tpMoeda != null && this.tpMoeda.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for tpMoeda, length must be less than 3.", new [] { "tpMoeda" });
            }

            // nDI (string) maxLength
            if (this.nDI != null && this.nDI.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nDI, length must be less than 12.", new [] { "nDI" });
            }

            // nDI (string) minLength
            if (this.nDI != null && this.nDI.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nDI, length must be greater than 1.", new [] { "nDI" });
            }

            // nRE (string) maxLength
            if (this.nRE != null && this.nRE.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nRE, length must be less than 12.", new [] { "nRE" });
            }

            // nRE (string) minLength
            if (this.nRE != null && this.nRE.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nRE, length must be greater than 1.", new [] { "nRE" });
            }

            yield break;
        }
    }

}
