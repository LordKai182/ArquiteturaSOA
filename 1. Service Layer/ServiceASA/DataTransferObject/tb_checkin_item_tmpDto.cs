using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_checkin_item_tmp")]
    public partial class tb_checkin_item_tmpDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 chkin_id { get; set; }
        [DataMember]
        public virtual Int32 ickin_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> ickin_quantidade { get; set; }
        [DataMember]
        public virtual String ickin_nu_lote { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> ickin_val_lote { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_checkin_tmpDto tb_checkin_tmp { get; set; }
        [DataMember]
        public virtual tb_produtoDto tb_produto { get; set; }

        #endregion
    }
}
