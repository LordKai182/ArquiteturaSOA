using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_mvto_compra_item_divergencia____")]
    public partial class tb_mvto_compra_item_divergencia____Dto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 divicmp_id { get; set; }
        [DataMember]
        public virtual Int32 pro_id { get; set; }
        [DataMember]
        public virtual String divicmp_tipo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> divicmp_qtde { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> divicmp_custo { get; set; }
        [DataMember]
        public virtual String divicmp_justificativa { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_mvto_compra____Dto tb_mvto_compra____ { get; set; }

        #endregion
    }
}
