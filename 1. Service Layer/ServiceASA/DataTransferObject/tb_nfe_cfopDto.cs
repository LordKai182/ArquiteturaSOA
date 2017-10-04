using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_nfe_cfop")]
    public partial class tb_nfe_cfopDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 nfe_pdv { get; set; }
        [DataMember]
        public virtual Int32 nfe_id { get; set; }
        [DataMember]
        public virtual DateTime nfe_data { get; set; }
        [DataMember]
        public virtual Int32 cfop_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cfop_base_icms { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cfop_aliq_icms { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cfop_valor_icms { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_cfopDto tb_cfop { get; set; }

        #endregion
    }
}
