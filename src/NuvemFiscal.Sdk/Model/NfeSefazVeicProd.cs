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
    /// Veículos novos.
    /// </summary>
    [DataContract(Name = "NfeSefazVeicProd")]
    public partial class NfeSefazVeicProd : IEquatable<NfeSefazVeicProd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazVeicProd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazVeicProd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazVeicProd" /> class.
        /// </summary>
        /// <param name="tpOp">Tipo da Operação (1 - Venda concessionária; 2 - Faturamento direto; 3 - Venda direta; 0 - Outros). (required).</param>
        /// <param name="chassi">Chassi do veículo - VIN (código-identificação-veículo). (required).</param>
        /// <param name="cCor">Cor do veículo (código de cada montadora). (required).</param>
        /// <param name="xCor">Descrição da cor. (required).</param>
        /// <param name="pot">Potência máxima do motor do veículo em cavalo vapor (CV). (potência-veículo). (required).</param>
        /// <param name="cilin">Capacidade voluntária do motor expressa em centímetros cúbicos (CC). (cilindradas). (required).</param>
        /// <param name="pesoL">Peso líquido. (required).</param>
        /// <param name="pesoB">Peso bruto. (required).</param>
        /// <param name="nSerie">Serial (série). (required).</param>
        /// <param name="tpComb">Tipo de combustível-Tabela RENAVAM: 01-Álcool  * 02 - Gasolina  * 03 - Diesel  * 16 - Álcool/Gas  * 17 - Gas./Álcool/GNV  * 18 - Gasolina/Elétrico (required).</param>
        /// <param name="nMotor">Número do motor. (required).</param>
        /// <param name="cMT">CMT-Capacidade Máxima de Tração - em Toneladas 4 casas decimais. (required).</param>
        /// <param name="dist">Distância entre eixos. (required).</param>
        /// <param name="anoMod">Ano Modelo de Fabricação. (required).</param>
        /// <param name="anoFab">Ano de Fabricação. (required).</param>
        /// <param name="tpPint">Tipo de pintura. (required).</param>
        /// <param name="tpVeic">Tipo de veículo (utilizar tabela RENAVAM). (required).</param>
        /// <param name="espVeic">Espécie de veículo (utilizar tabela RENAVAM). (required).</param>
        /// <param name="vIN">Informa-se o veículo tem VIN (chassi) remarcado.  * R-Remarcado  * N-NormalVIN (required).</param>
        /// <param name="condVeic">Condição do veículo (1 - acabado; 2 - inacabado; 3 - semi-acabado). (required).</param>
        /// <param name="cMod">Código Marca Modelo (utilizar tabela RENAVAM). (required).</param>
        /// <param name="cCorDENATRAN">Código da Cor Segundo as regras de pré-cadastro do DENATRAN: 01-AMARELO  * 02 - AZUL  * 03 - BEGE  * 04 - BRANCA  * 05 - CINZA  * 06 - DOURADA  * 07 - GRENA  * 08 - LARANJA  * 09 - MARROM  * 10 - PRATA  * 11 - PRETA  * 12 - ROSA  * 13 - ROXA  * 14 - VERDE  * 15 - VERMELHA  * 16 - FANTASIA (required).</param>
        /// <param name="lota">Quantidade máxima de permitida de passageiros sentados, inclusive motorista. (required).</param>
        /// <param name="tpRest">Restrição  * 0 - Não há  * 1 - Alienação Fiduciária  * 2 - Arrendamento Mercantil  * 3 - Reserva de Domínio  * 4 - Penhor de Veículos  * 9 - outras (required).</param>
        public NfeSefazVeicProd(int? tpOp = default(int?), string chassi = default(string), string cCor = default(string), string xCor = default(string), string pot = default(string), string cilin = default(string), string pesoL = default(string), string pesoB = default(string), string nSerie = default(string), string tpComb = default(string), string nMotor = default(string), string cMT = default(string), string dist = default(string), int? anoMod = default(int?), int? anoFab = default(int?), string tpPint = default(string), int? tpVeic = default(int?), int? espVeic = default(int?), string vIN = default(string), int? condVeic = default(int?), string cMod = default(string), string cCorDENATRAN = default(string), int? lota = default(int?), int? tpRest = default(int?))
        {
            // to ensure "tpOp" is required (not null)
            if (tpOp == null)
            {
                throw new ArgumentNullException("tpOp is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.tpOp = tpOp;
            // to ensure "chassi" is required (not null)
            if (chassi == null)
            {
                throw new ArgumentNullException("chassi is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.chassi = chassi;
            // to ensure "cCor" is required (not null)
            if (cCor == null)
            {
                throw new ArgumentNullException("cCor is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.cCor = cCor;
            // to ensure "xCor" is required (not null)
            if (xCor == null)
            {
                throw new ArgumentNullException("xCor is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.xCor = xCor;
            // to ensure "pot" is required (not null)
            if (pot == null)
            {
                throw new ArgumentNullException("pot is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.pot = pot;
            // to ensure "cilin" is required (not null)
            if (cilin == null)
            {
                throw new ArgumentNullException("cilin is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.cilin = cilin;
            // to ensure "pesoL" is required (not null)
            if (pesoL == null)
            {
                throw new ArgumentNullException("pesoL is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.pesoL = pesoL;
            // to ensure "pesoB" is required (not null)
            if (pesoB == null)
            {
                throw new ArgumentNullException("pesoB is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.pesoB = pesoB;
            // to ensure "nSerie" is required (not null)
            if (nSerie == null)
            {
                throw new ArgumentNullException("nSerie is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.nSerie = nSerie;
            // to ensure "tpComb" is required (not null)
            if (tpComb == null)
            {
                throw new ArgumentNullException("tpComb is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.tpComb = tpComb;
            // to ensure "nMotor" is required (not null)
            if (nMotor == null)
            {
                throw new ArgumentNullException("nMotor is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.nMotor = nMotor;
            // to ensure "cMT" is required (not null)
            if (cMT == null)
            {
                throw new ArgumentNullException("cMT is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.CMT = cMT;
            // to ensure "dist" is required (not null)
            if (dist == null)
            {
                throw new ArgumentNullException("dist is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.dist = dist;
            // to ensure "anoMod" is required (not null)
            if (anoMod == null)
            {
                throw new ArgumentNullException("anoMod is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.anoMod = anoMod;
            // to ensure "anoFab" is required (not null)
            if (anoFab == null)
            {
                throw new ArgumentNullException("anoFab is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.anoFab = anoFab;
            // to ensure "tpPint" is required (not null)
            if (tpPint == null)
            {
                throw new ArgumentNullException("tpPint is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.tpPint = tpPint;
            // to ensure "tpVeic" is required (not null)
            if (tpVeic == null)
            {
                throw new ArgumentNullException("tpVeic is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.tpVeic = tpVeic;
            // to ensure "espVeic" is required (not null)
            if (espVeic == null)
            {
                throw new ArgumentNullException("espVeic is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.espVeic = espVeic;
            // to ensure "vIN" is required (not null)
            if (vIN == null)
            {
                throw new ArgumentNullException("vIN is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.VIN = vIN;
            // to ensure "condVeic" is required (not null)
            if (condVeic == null)
            {
                throw new ArgumentNullException("condVeic is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.condVeic = condVeic;
            // to ensure "cMod" is required (not null)
            if (cMod == null)
            {
                throw new ArgumentNullException("cMod is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.cMod = cMod;
            // to ensure "cCorDENATRAN" is required (not null)
            if (cCorDENATRAN == null)
            {
                throw new ArgumentNullException("cCorDENATRAN is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.cCorDENATRAN = cCorDENATRAN;
            // to ensure "lota" is required (not null)
            if (lota == null)
            {
                throw new ArgumentNullException("lota is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.lota = lota;
            // to ensure "tpRest" is required (not null)
            if (tpRest == null)
            {
                throw new ArgumentNullException("tpRest is a required property for NfeSefazVeicProd and cannot be null");
            }
            this.tpRest = tpRest;
        }

        /// <summary>
        /// Tipo da Operação (1 - Venda concessionária; 2 - Faturamento direto; 3 - Venda direta; 0 - Outros).
        /// </summary>
        /// <value>Tipo da Operação (1 - Venda concessionária; 2 - Faturamento direto; 3 - Venda direta; 0 - Outros).</value>
        [DataMember(Name = "tpOp", IsRequired = true, EmitDefaultValue = true)]
        public int? tpOp { get; set; }

        /// <summary>
        /// Chassi do veículo - VIN (código-identificação-veículo).
        /// </summary>
        /// <value>Chassi do veículo - VIN (código-identificação-veículo).</value>
        [DataMember(Name = "chassi", IsRequired = true, EmitDefaultValue = true)]
        public string chassi { get; set; }

        /// <summary>
        /// Cor do veículo (código de cada montadora).
        /// </summary>
        /// <value>Cor do veículo (código de cada montadora).</value>
        [DataMember(Name = "cCor", IsRequired = true, EmitDefaultValue = true)]
        public string cCor { get; set; }

        /// <summary>
        /// Descrição da cor.
        /// </summary>
        /// <value>Descrição da cor.</value>
        [DataMember(Name = "xCor", IsRequired = true, EmitDefaultValue = true)]
        public string xCor { get; set; }

        /// <summary>
        /// Potência máxima do motor do veículo em cavalo vapor (CV). (potência-veículo).
        /// </summary>
        /// <value>Potência máxima do motor do veículo em cavalo vapor (CV). (potência-veículo).</value>
        [DataMember(Name = "pot", IsRequired = true, EmitDefaultValue = true)]
        public string pot { get; set; }

        /// <summary>
        /// Capacidade voluntária do motor expressa em centímetros cúbicos (CC). (cilindradas).
        /// </summary>
        /// <value>Capacidade voluntária do motor expressa em centímetros cúbicos (CC). (cilindradas).</value>
        [DataMember(Name = "cilin", IsRequired = true, EmitDefaultValue = true)]
        public string cilin { get; set; }

        /// <summary>
        /// Peso líquido.
        /// </summary>
        /// <value>Peso líquido.</value>
        [DataMember(Name = "pesoL", IsRequired = true, EmitDefaultValue = true)]
        public string pesoL { get; set; }

        /// <summary>
        /// Peso bruto.
        /// </summary>
        /// <value>Peso bruto.</value>
        [DataMember(Name = "pesoB", IsRequired = true, EmitDefaultValue = true)]
        public string pesoB { get; set; }

        /// <summary>
        /// Serial (série).
        /// </summary>
        /// <value>Serial (série).</value>
        [DataMember(Name = "nSerie", IsRequired = true, EmitDefaultValue = true)]
        public string nSerie { get; set; }

        /// <summary>
        /// Tipo de combustível-Tabela RENAVAM: 01-Álcool  * 02 - Gasolina  * 03 - Diesel  * 16 - Álcool/Gas  * 17 - Gas./Álcool/GNV  * 18 - Gasolina/Elétrico
        /// </summary>
        /// <value>Tipo de combustível-Tabela RENAVAM: 01-Álcool  * 02 - Gasolina  * 03 - Diesel  * 16 - Álcool/Gas  * 17 - Gas./Álcool/GNV  * 18 - Gasolina/Elétrico</value>
        [DataMember(Name = "tpComb", IsRequired = true, EmitDefaultValue = true)]
        public string tpComb { get; set; }

        /// <summary>
        /// Número do motor.
        /// </summary>
        /// <value>Número do motor.</value>
        [DataMember(Name = "nMotor", IsRequired = true, EmitDefaultValue = true)]
        public string nMotor { get; set; }

        /// <summary>
        /// CMT-Capacidade Máxima de Tração - em Toneladas 4 casas decimais.
        /// </summary>
        /// <value>CMT-Capacidade Máxima de Tração - em Toneladas 4 casas decimais.</value>
        [DataMember(Name = "CMT", IsRequired = true, EmitDefaultValue = true)]
        public string CMT { get; set; }

        /// <summary>
        /// Distância entre eixos.
        /// </summary>
        /// <value>Distância entre eixos.</value>
        [DataMember(Name = "dist", IsRequired = true, EmitDefaultValue = true)]
        public string dist { get; set; }

        /// <summary>
        /// Ano Modelo de Fabricação.
        /// </summary>
        /// <value>Ano Modelo de Fabricação.</value>
        [DataMember(Name = "anoMod", IsRequired = true, EmitDefaultValue = true)]
        public int? anoMod { get; set; }

        /// <summary>
        /// Ano de Fabricação.
        /// </summary>
        /// <value>Ano de Fabricação.</value>
        [DataMember(Name = "anoFab", IsRequired = true, EmitDefaultValue = true)]
        public int? anoFab { get; set; }

        /// <summary>
        /// Tipo de pintura.
        /// </summary>
        /// <value>Tipo de pintura.</value>
        [DataMember(Name = "tpPint", IsRequired = true, EmitDefaultValue = true)]
        public string tpPint { get; set; }

        /// <summary>
        /// Tipo de veículo (utilizar tabela RENAVAM).
        /// </summary>
        /// <value>Tipo de veículo (utilizar tabela RENAVAM).</value>
        [DataMember(Name = "tpVeic", IsRequired = true, EmitDefaultValue = true)]
        public int? tpVeic { get; set; }

        /// <summary>
        /// Espécie de veículo (utilizar tabela RENAVAM).
        /// </summary>
        /// <value>Espécie de veículo (utilizar tabela RENAVAM).</value>
        [DataMember(Name = "espVeic", IsRequired = true, EmitDefaultValue = true)]
        public int? espVeic { get; set; }

        /// <summary>
        /// Informa-se o veículo tem VIN (chassi) remarcado.  * R-Remarcado  * N-NormalVIN
        /// </summary>
        /// <value>Informa-se o veículo tem VIN (chassi) remarcado.  * R-Remarcado  * N-NormalVIN</value>
        [DataMember(Name = "VIN", IsRequired = true, EmitDefaultValue = true)]
        public string VIN { get; set; }

        /// <summary>
        /// Condição do veículo (1 - acabado; 2 - inacabado; 3 - semi-acabado).
        /// </summary>
        /// <value>Condição do veículo (1 - acabado; 2 - inacabado; 3 - semi-acabado).</value>
        [DataMember(Name = "condVeic", IsRequired = true, EmitDefaultValue = true)]
        public int? condVeic { get; set; }

        /// <summary>
        /// Código Marca Modelo (utilizar tabela RENAVAM).
        /// </summary>
        /// <value>Código Marca Modelo (utilizar tabela RENAVAM).</value>
        [DataMember(Name = "cMod", IsRequired = true, EmitDefaultValue = true)]
        public string cMod { get; set; }

        /// <summary>
        /// Código da Cor Segundo as regras de pré-cadastro do DENATRAN: 01-AMARELO  * 02 - AZUL  * 03 - BEGE  * 04 - BRANCA  * 05 - CINZA  * 06 - DOURADA  * 07 - GRENA  * 08 - LARANJA  * 09 - MARROM  * 10 - PRATA  * 11 - PRETA  * 12 - ROSA  * 13 - ROXA  * 14 - VERDE  * 15 - VERMELHA  * 16 - FANTASIA
        /// </summary>
        /// <value>Código da Cor Segundo as regras de pré-cadastro do DENATRAN: 01-AMARELO  * 02 - AZUL  * 03 - BEGE  * 04 - BRANCA  * 05 - CINZA  * 06 - DOURADA  * 07 - GRENA  * 08 - LARANJA  * 09 - MARROM  * 10 - PRATA  * 11 - PRETA  * 12 - ROSA  * 13 - ROXA  * 14 - VERDE  * 15 - VERMELHA  * 16 - FANTASIA</value>
        [DataMember(Name = "cCorDENATRAN", IsRequired = true, EmitDefaultValue = true)]
        public string cCorDENATRAN { get; set; }

        /// <summary>
        /// Quantidade máxima de permitida de passageiros sentados, inclusive motorista.
        /// </summary>
        /// <value>Quantidade máxima de permitida de passageiros sentados, inclusive motorista.</value>
        [DataMember(Name = "lota", IsRequired = true, EmitDefaultValue = true)]
        public int? lota { get; set; }

        /// <summary>
        /// Restrição  * 0 - Não há  * 1 - Alienação Fiduciária  * 2 - Arrendamento Mercantil  * 3 - Reserva de Domínio  * 4 - Penhor de Veículos  * 9 - outras
        /// </summary>
        /// <value>Restrição  * 0 - Não há  * 1 - Alienação Fiduciária  * 2 - Arrendamento Mercantil  * 3 - Reserva de Domínio  * 4 - Penhor de Veículos  * 9 - outras</value>
        [DataMember(Name = "tpRest", IsRequired = true, EmitDefaultValue = true)]
        public int? tpRest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazVeicProd {\n");
            sb.Append("  tpOp: ").Append(tpOp).Append("\n");
            sb.Append("  chassi: ").Append(chassi).Append("\n");
            sb.Append("  cCor: ").Append(cCor).Append("\n");
            sb.Append("  xCor: ").Append(xCor).Append("\n");
            sb.Append("  pot: ").Append(pot).Append("\n");
            sb.Append("  cilin: ").Append(cilin).Append("\n");
            sb.Append("  pesoL: ").Append(pesoL).Append("\n");
            sb.Append("  pesoB: ").Append(pesoB).Append("\n");
            sb.Append("  nSerie: ").Append(nSerie).Append("\n");
            sb.Append("  tpComb: ").Append(tpComb).Append("\n");
            sb.Append("  nMotor: ").Append(nMotor).Append("\n");
            sb.Append("  CMT: ").Append(CMT).Append("\n");
            sb.Append("  dist: ").Append(dist).Append("\n");
            sb.Append("  anoMod: ").Append(anoMod).Append("\n");
            sb.Append("  anoFab: ").Append(anoFab).Append("\n");
            sb.Append("  tpPint: ").Append(tpPint).Append("\n");
            sb.Append("  tpVeic: ").Append(tpVeic).Append("\n");
            sb.Append("  espVeic: ").Append(espVeic).Append("\n");
            sb.Append("  VIN: ").Append(VIN).Append("\n");
            sb.Append("  condVeic: ").Append(condVeic).Append("\n");
            sb.Append("  cMod: ").Append(cMod).Append("\n");
            sb.Append("  cCorDENATRAN: ").Append(cCorDENATRAN).Append("\n");
            sb.Append("  lota: ").Append(lota).Append("\n");
            sb.Append("  tpRest: ").Append(tpRest).Append("\n");
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
            return this.Equals(input as NfeSefazVeicProd);
        }

        /// <summary>
        /// Returns true if NfeSefazVeicProd instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazVeicProd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazVeicProd input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpOp == input.tpOp ||
                    (this.tpOp != null &&
                    this.tpOp.Equals(input.tpOp))
                ) && 
                (
                    this.chassi == input.chassi ||
                    (this.chassi != null &&
                    this.chassi.Equals(input.chassi))
                ) && 
                (
                    this.cCor == input.cCor ||
                    (this.cCor != null &&
                    this.cCor.Equals(input.cCor))
                ) && 
                (
                    this.xCor == input.xCor ||
                    (this.xCor != null &&
                    this.xCor.Equals(input.xCor))
                ) && 
                (
                    this.pot == input.pot ||
                    (this.pot != null &&
                    this.pot.Equals(input.pot))
                ) && 
                (
                    this.cilin == input.cilin ||
                    (this.cilin != null &&
                    this.cilin.Equals(input.cilin))
                ) && 
                (
                    this.pesoL == input.pesoL ||
                    (this.pesoL != null &&
                    this.pesoL.Equals(input.pesoL))
                ) && 
                (
                    this.pesoB == input.pesoB ||
                    (this.pesoB != null &&
                    this.pesoB.Equals(input.pesoB))
                ) && 
                (
                    this.nSerie == input.nSerie ||
                    (this.nSerie != null &&
                    this.nSerie.Equals(input.nSerie))
                ) && 
                (
                    this.tpComb == input.tpComb ||
                    (this.tpComb != null &&
                    this.tpComb.Equals(input.tpComb))
                ) && 
                (
                    this.nMotor == input.nMotor ||
                    (this.nMotor != null &&
                    this.nMotor.Equals(input.nMotor))
                ) && 
                (
                    this.CMT == input.CMT ||
                    (this.CMT != null &&
                    this.CMT.Equals(input.CMT))
                ) && 
                (
                    this.dist == input.dist ||
                    (this.dist != null &&
                    this.dist.Equals(input.dist))
                ) && 
                (
                    this.anoMod == input.anoMod ||
                    (this.anoMod != null &&
                    this.anoMod.Equals(input.anoMod))
                ) && 
                (
                    this.anoFab == input.anoFab ||
                    (this.anoFab != null &&
                    this.anoFab.Equals(input.anoFab))
                ) && 
                (
                    this.tpPint == input.tpPint ||
                    (this.tpPint != null &&
                    this.tpPint.Equals(input.tpPint))
                ) && 
                (
                    this.tpVeic == input.tpVeic ||
                    (this.tpVeic != null &&
                    this.tpVeic.Equals(input.tpVeic))
                ) && 
                (
                    this.espVeic == input.espVeic ||
                    (this.espVeic != null &&
                    this.espVeic.Equals(input.espVeic))
                ) && 
                (
                    this.VIN == input.VIN ||
                    (this.VIN != null &&
                    this.VIN.Equals(input.VIN))
                ) && 
                (
                    this.condVeic == input.condVeic ||
                    (this.condVeic != null &&
                    this.condVeic.Equals(input.condVeic))
                ) && 
                (
                    this.cMod == input.cMod ||
                    (this.cMod != null &&
                    this.cMod.Equals(input.cMod))
                ) && 
                (
                    this.cCorDENATRAN == input.cCorDENATRAN ||
                    (this.cCorDENATRAN != null &&
                    this.cCorDENATRAN.Equals(input.cCorDENATRAN))
                ) && 
                (
                    this.lota == input.lota ||
                    (this.lota != null &&
                    this.lota.Equals(input.lota))
                ) && 
                (
                    this.tpRest == input.tpRest ||
                    (this.tpRest != null &&
                    this.tpRest.Equals(input.tpRest))
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
                if (this.tpOp != null)
                {
                    hashCode = (hashCode * 59) + this.tpOp.GetHashCode();
                }
                if (this.chassi != null)
                {
                    hashCode = (hashCode * 59) + this.chassi.GetHashCode();
                }
                if (this.cCor != null)
                {
                    hashCode = (hashCode * 59) + this.cCor.GetHashCode();
                }
                if (this.xCor != null)
                {
                    hashCode = (hashCode * 59) + this.xCor.GetHashCode();
                }
                if (this.pot != null)
                {
                    hashCode = (hashCode * 59) + this.pot.GetHashCode();
                }
                if (this.cilin != null)
                {
                    hashCode = (hashCode * 59) + this.cilin.GetHashCode();
                }
                if (this.pesoL != null)
                {
                    hashCode = (hashCode * 59) + this.pesoL.GetHashCode();
                }
                if (this.pesoB != null)
                {
                    hashCode = (hashCode * 59) + this.pesoB.GetHashCode();
                }
                if (this.nSerie != null)
                {
                    hashCode = (hashCode * 59) + this.nSerie.GetHashCode();
                }
                if (this.tpComb != null)
                {
                    hashCode = (hashCode * 59) + this.tpComb.GetHashCode();
                }
                if (this.nMotor != null)
                {
                    hashCode = (hashCode * 59) + this.nMotor.GetHashCode();
                }
                if (this.CMT != null)
                {
                    hashCode = (hashCode * 59) + this.CMT.GetHashCode();
                }
                if (this.dist != null)
                {
                    hashCode = (hashCode * 59) + this.dist.GetHashCode();
                }
                if (this.anoMod != null)
                {
                    hashCode = (hashCode * 59) + this.anoMod.GetHashCode();
                }
                if (this.anoFab != null)
                {
                    hashCode = (hashCode * 59) + this.anoFab.GetHashCode();
                }
                if (this.tpPint != null)
                {
                    hashCode = (hashCode * 59) + this.tpPint.GetHashCode();
                }
                if (this.tpVeic != null)
                {
                    hashCode = (hashCode * 59) + this.tpVeic.GetHashCode();
                }
                if (this.espVeic != null)
                {
                    hashCode = (hashCode * 59) + this.espVeic.GetHashCode();
                }
                if (this.VIN != null)
                {
                    hashCode = (hashCode * 59) + this.VIN.GetHashCode();
                }
                if (this.condVeic != null)
                {
                    hashCode = (hashCode * 59) + this.condVeic.GetHashCode();
                }
                if (this.cMod != null)
                {
                    hashCode = (hashCode * 59) + this.cMod.GetHashCode();
                }
                if (this.cCorDENATRAN != null)
                {
                    hashCode = (hashCode * 59) + this.cCorDENATRAN.GetHashCode();
                }
                if (this.lota != null)
                {
                    hashCode = (hashCode * 59) + this.lota.GetHashCode();
                }
                if (this.tpRest != null)
                {
                    hashCode = (hashCode * 59) + this.tpRest.GetHashCode();
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
            // chassi (string) maxLength
            if (this.chassi != null && this.chassi.Length > 17)
            {
                yield return new ValidationResult("Invalid value for chassi, length must be less than 17.", new [] { "chassi" });
            }

            // cCor (string) maxLength
            if (this.cCor != null && this.cCor.Length > 4)
            {
                yield return new ValidationResult("Invalid value for cCor, length must be less than 4.", new [] { "cCor" });
            }

            // cCor (string) minLength
            if (this.cCor != null && this.cCor.Length < 1)
            {
                yield return new ValidationResult("Invalid value for cCor, length must be greater than 1.", new [] { "cCor" });
            }

            // xCor (string) maxLength
            if (this.xCor != null && this.xCor.Length > 40)
            {
                yield return new ValidationResult("Invalid value for xCor, length must be less than 40.", new [] { "xCor" });
            }

            // xCor (string) minLength
            if (this.xCor != null && this.xCor.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xCor, length must be greater than 1.", new [] { "xCor" });
            }

            // pot (string) maxLength
            if (this.pot != null && this.pot.Length > 4)
            {
                yield return new ValidationResult("Invalid value for pot, length must be less than 4.", new [] { "pot" });
            }

            // pot (string) minLength
            if (this.pot != null && this.pot.Length < 1)
            {
                yield return new ValidationResult("Invalid value for pot, length must be greater than 1.", new [] { "pot" });
            }

            // cilin (string) maxLength
            if (this.cilin != null && this.cilin.Length > 4)
            {
                yield return new ValidationResult("Invalid value for cilin, length must be less than 4.", new [] { "cilin" });
            }

            // cilin (string) minLength
            if (this.cilin != null && this.cilin.Length < 1)
            {
                yield return new ValidationResult("Invalid value for cilin, length must be greater than 1.", new [] { "cilin" });
            }

            // pesoL (string) maxLength
            if (this.pesoL != null && this.pesoL.Length > 9)
            {
                yield return new ValidationResult("Invalid value for pesoL, length must be less than 9.", new [] { "pesoL" });
            }

            // pesoL (string) minLength
            if (this.pesoL != null && this.pesoL.Length < 1)
            {
                yield return new ValidationResult("Invalid value for pesoL, length must be greater than 1.", new [] { "pesoL" });
            }

            // pesoB (string) maxLength
            if (this.pesoB != null && this.pesoB.Length > 9)
            {
                yield return new ValidationResult("Invalid value for pesoB, length must be less than 9.", new [] { "pesoB" });
            }

            // pesoB (string) minLength
            if (this.pesoB != null && this.pesoB.Length < 1)
            {
                yield return new ValidationResult("Invalid value for pesoB, length must be greater than 1.", new [] { "pesoB" });
            }

            // nSerie (string) maxLength
            if (this.nSerie != null && this.nSerie.Length > 9)
            {
                yield return new ValidationResult("Invalid value for nSerie, length must be less than 9.", new [] { "nSerie" });
            }

            // nSerie (string) minLength
            if (this.nSerie != null && this.nSerie.Length < 1)
            {
                yield return new ValidationResult("Invalid value for nSerie, length must be greater than 1.", new [] { "nSerie" });
            }

            // tpComb (string) maxLength
            if (this.tpComb != null && this.tpComb.Length > 2)
            {
                yield return new ValidationResult("Invalid value for tpComb, length must be less than 2.", new [] { "tpComb" });
            }

            // tpComb (string) minLength
            if (this.tpComb != null && this.tpComb.Length < 1)
            {
                yield return new ValidationResult("Invalid value for tpComb, length must be greater than 1.", new [] { "tpComb" });
            }

            // nMotor (string) maxLength
            if (this.nMotor != null && this.nMotor.Length > 21)
            {
                yield return new ValidationResult("Invalid value for nMotor, length must be less than 21.", new [] { "nMotor" });
            }

            // nMotor (string) minLength
            if (this.nMotor != null && this.nMotor.Length < 1)
            {
                yield return new ValidationResult("Invalid value for nMotor, length must be greater than 1.", new [] { "nMotor" });
            }

            // CMT (string) maxLength
            if (this.CMT != null && this.CMT.Length > 9)
            {
                yield return new ValidationResult("Invalid value for CMT, length must be less than 9.", new [] { "CMT" });
            }

            // CMT (string) minLength
            if (this.CMT != null && this.CMT.Length < 1)
            {
                yield return new ValidationResult("Invalid value for CMT, length must be greater than 1.", new [] { "CMT" });
            }

            // dist (string) maxLength
            if (this.dist != null && this.dist.Length > 4)
            {
                yield return new ValidationResult("Invalid value for dist, length must be less than 4.", new [] { "dist" });
            }

            // dist (string) minLength
            if (this.dist != null && this.dist.Length < 1)
            {
                yield return new ValidationResult("Invalid value for dist, length must be greater than 1.", new [] { "dist" });
            }

            // anoMod (int?) maximum
            if (this.anoMod > (int?)9999)
            {
                yield return new ValidationResult("Invalid value for anoMod, must be a value less than or equal to 9999.", new [] { "anoMod" });
            }

            // anoMod (int?) minimum
            if (this.anoMod < (int?)0)
            {
                yield return new ValidationResult("Invalid value for anoMod, must be a value greater than or equal to 0.", new [] { "anoMod" });
            }

            // anoFab (int?) maximum
            if (this.anoFab > (int?)9999)
            {
                yield return new ValidationResult("Invalid value for anoFab, must be a value less than or equal to 9999.", new [] { "anoFab" });
            }

            // anoFab (int?) minimum
            if (this.anoFab < (int?)0)
            {
                yield return new ValidationResult("Invalid value for anoFab, must be a value greater than or equal to 0.", new [] { "anoFab" });
            }

            // tpPint (string) maxLength
            if (this.tpPint != null && this.tpPint.Length > 1)
            {
                yield return new ValidationResult("Invalid value for tpPint, length must be less than 1.", new [] { "tpPint" });
            }

            // tpVeic (int?) maximum
            if (this.tpVeic > (int?)99)
            {
                yield return new ValidationResult("Invalid value for tpVeic, must be a value less than or equal to 99.", new [] { "tpVeic" });
            }

            // tpVeic (int?) minimum
            if (this.tpVeic < (int?)0)
            {
                yield return new ValidationResult("Invalid value for tpVeic, must be a value greater than or equal to 0.", new [] { "tpVeic" });
            }

            // espVeic (int?) maximum
            if (this.espVeic > (int?)9)
            {
                yield return new ValidationResult("Invalid value for espVeic, must be a value less than or equal to 9.", new [] { "espVeic" });
            }

            // espVeic (int?) minimum
            if (this.espVeic < (int?)0)
            {
                yield return new ValidationResult("Invalid value for espVeic, must be a value greater than or equal to 0.", new [] { "espVeic" });
            }

            // VIN (string) maxLength
            if (this.VIN != null && this.VIN.Length > 1)
            {
                yield return new ValidationResult("Invalid value for VIN, length must be less than 1.", new [] { "VIN" });
            }

            // cCorDENATRAN (string) maxLength
            if (this.cCorDENATRAN != null && this.cCorDENATRAN.Length > 2)
            {
                yield return new ValidationResult("Invalid value for cCorDENATRAN, length must be less than 2.", new [] { "cCorDENATRAN" });
            }

            // cCorDENATRAN (string) minLength
            if (this.cCorDENATRAN != null && this.cCorDENATRAN.Length < 1)
            {
                yield return new ValidationResult("Invalid value for cCorDENATRAN, length must be greater than 1.", new [] { "cCorDENATRAN" });
            }

            // lota (int?) maximum
            if (this.lota > (int?)999)
            {
                yield return new ValidationResult("Invalid value for lota, must be a value less than or equal to 999.", new [] { "lota" });
            }

            // lota (int?) minimum
            if (this.lota < (int?)0)
            {
                yield return new ValidationResult("Invalid value for lota, must be a value greater than or equal to 0.", new [] { "lota" });
            }

            yield break;
        }
    }

}
