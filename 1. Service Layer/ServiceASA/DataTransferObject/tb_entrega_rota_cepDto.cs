using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_entrega_rota_cep")]
    public partial class tb_entrega_rota_cepDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cep_id { get; set; }
        [DataMember]
        public virtual Int32 rota_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cep_inicial { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cep_final { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cep_nu_inicial { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cep_nu_final { get; set; }
        [DataMember]
        public virtual String cep_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cep_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cep_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cep_cpf_alteracao { get; set; }

        #endregion

    }
}
