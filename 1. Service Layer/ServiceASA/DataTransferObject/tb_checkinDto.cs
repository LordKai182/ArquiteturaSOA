using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_checkin")]
    public partial class tb_checkinDto
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
        public virtual Nullable<Decimal> chkin_num_nf { get; set; }
        [DataMember]
        public virtual Nullable<Int32> chkin_operador_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> cmp_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> pedc_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> fab_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> div_id { get; set; }

        #endregion

    }
}
