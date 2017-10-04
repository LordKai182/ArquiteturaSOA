using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_mvto_compra_item_lote____")]
    public partial class tb_mvto_compra_item_lote____Dto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cmp_id { get; set; }
        [DataMember]
        public virtual Int32 icmp_id { get; set; }
        [DataMember]
        public virtual Int32 loteicmp_id { get; set; }
        [DataMember]
        public virtual String loteicmp_numero { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> loteicmp_qtde { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> loteicmp_validade { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_mvto_compra_item____Dto tb_mvto_compra_item____ { get; set; }

        #endregion
    }
}
