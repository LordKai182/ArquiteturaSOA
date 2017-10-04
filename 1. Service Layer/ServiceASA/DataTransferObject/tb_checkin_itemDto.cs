using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_checkin_item")]
    public partial class tb_checkin_itemDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 chkin_pdv { get; set; }
        [DataMember]
        public virtual Int32 chkin_id { get; set; }
        [DataMember]
        public virtual DateTime chkin_data { get; set; }
        [DataMember]
        public virtual Int32 ickin_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> pro_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> ickin_cd_barra_lido { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> ickin_quantidade { get; set; }
        [DataMember]
        public virtual String ickin_nu_lote { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> ickin_val_lote { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> ickin_conciliacao_nf { get; set; }

        #endregion

    }
}
