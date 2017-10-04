using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_entrega_arearisco")]
    public partial class tb_entrega_areariscoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 arearisco_id { get; set; }
        [DataMember]
        public virtual String arearisco_descricao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> arearisco_cep_inicial { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> arearisco_cep_final { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> arearisco_nu_inicial { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> arearisco_nu_final { get; set; }
        [DataMember]
        public virtual String arearisco_mensagem { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> arearisco_acao { get; set; }
        [DataMember]
        public virtual String arearisco_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> arearisco_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> arearisco_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> arearisco_cpf_alteracao { get; set; }

        #endregion

    }
}
