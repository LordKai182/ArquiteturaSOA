using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_venda_estorno_tef")]
    public partial class tb_venda_estorno_tefDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 vestef_id { get; set; }
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 venda_id { get; set; }
        [DataMember]
        public virtual Int32 venda_pdv { get; set; }
        [DataMember]
        public virtual DateTime venda_data { get; set; }
        [DataMember]
        public virtual Int32 vpag_id { get; set; }
        [DataMember]
        public virtual Decimal vestef_usr_mat { get; set; }
        [DataMember]
        public virtual Decimal vestef_vendedor_mat { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_vendaDto tb_venda { get; set; }

        #endregion
    }
}
