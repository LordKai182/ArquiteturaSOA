using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_finalizadora_sub_un")]
    public partial class tbr_finalizadora_sub_unDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 final_id { get; set; }
        [DataMember]
        public virtual Int32 subfin_id { get; set; }
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> finsubun_taxa_adm { get; set; }
        [DataMember]
        public virtual String finsubun_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> finsubun_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> finsubun_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> finsubun_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_finalizadora_subDto tb_finalizadora_sub { get; set; }
        [DataMember]
        public virtual tb_financeiro_bancosDto tb_financeiro_bancos { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
}
