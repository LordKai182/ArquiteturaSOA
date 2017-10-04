using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_checkout_item")]
    public partial class tb_checkout_itemDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 chkout_pdv { get; set; }
        [DataMember]
        public virtual Int32 chkout_id { get; set; }
        [DataMember]
        public virtual DateTime chkout_data { get; set; }
        [DataMember]
        public virtual Int32 ickout_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> pro_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> ickout_cd_barra_lido { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> ickout_quantidade { get; set; }
        [DataMember]
        public virtual String ickout_nu_lote { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> ickout_val_lote { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> ickout_conciliacao_nf { get; set; }

        #endregion

    }
}
