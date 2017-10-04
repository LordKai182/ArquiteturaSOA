using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_checkout")]
    public partial class tb_checkoutDto
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
        public virtual Nullable<Decimal> chkout_num_nf { get; set; }
        [DataMember]
        public virtual Nullable<Int32> chkout_operador_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> cli_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> pedv_id { get; set; }

        #endregion

    }
}
