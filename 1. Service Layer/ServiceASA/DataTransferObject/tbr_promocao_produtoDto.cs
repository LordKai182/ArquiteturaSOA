using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_promocao_produto")]
    public partial class tbr_promocao_produtoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 prm_id { get; set; }
        [DataMember]
        public virtual Int32 pro_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> prom_preco { get; set; }
        [DataMember]
        public virtual String prom_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> prom_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> prom_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> prom_cpf_alteracao { get; set; }
        [DataMember]
        public virtual String prom_app_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_promocaoDto tb_promocao { get; set; }

        #endregion
    }
}
