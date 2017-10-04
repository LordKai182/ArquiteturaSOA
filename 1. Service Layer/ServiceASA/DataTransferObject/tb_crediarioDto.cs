using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_crediario")]
    public partial class tb_crediarioDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cred_id { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cred_dt_entrada { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cred_dt_vencimento { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cred_vlr_documento { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cred_vlr_pago { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cred_dt_liquidacao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cred_vlr_liquidacao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cred_desconto_liq { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cred_juros_liq { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cred_taxa_liq { get; set; }
        [DataMember]
        public virtual String cred_situacao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cred_cpf_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cred_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cred_cpf_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_pdv { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_id { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_data { get; set; }
        [DataMember]
        public virtual Int32 rec_id { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_clienteDto tb_cliente { get; set; }
        [DataMember]
        public virtual tb_convenioDto tb_convenio { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
}
