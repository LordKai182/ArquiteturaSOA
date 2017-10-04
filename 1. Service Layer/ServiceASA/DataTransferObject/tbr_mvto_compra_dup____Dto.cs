using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_mvto_compra_dup____")]
    public partial class tbr_mvto_compra_dup____Dto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cmp_id { get; set; }
        [DataMember]
        public virtual Int32 cmpdup_id { get; set; }
        [DataMember]
        public virtual String mvtocdup_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> mvtocdup_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> mvtocdup_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> mvtocdup_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_mvto_compra____Dto tb_mvto_compra____ { get; set; }
        [DataMember]
        public virtual tb_mvto_compra_dup____Dto tb_mvto_compra_dup____ { get; set; }

        #endregion
    }
}
