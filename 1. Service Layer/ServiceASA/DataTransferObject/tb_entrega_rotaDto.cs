using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_entrega_rota")]
    public partial class tb_entrega_rotaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 rota_id { get; set; }
        [DataMember]
        public virtual Int32 quadra_id { get; set; }
        [DataMember]
        public virtual String rota_descricao { get; set; }
        [DataMember]
        public virtual String rota_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> rota_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> rota_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> rota_cpf_alteracao { get; set; }

        #endregion

    }
}
