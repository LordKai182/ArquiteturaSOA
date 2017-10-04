using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_entrega_prod_continuo")]
    public partial class tb_entrega_prod_continuoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 end_pdv { get; set; }
        [DataMember]
        public virtual Int32 end_id { get; set; }
        [DataMember]
        public virtual DateTime end_data { get; set; }
        [DataMember]
        public virtual Int32 pro_id { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> proc_dt_ultima_compra { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proc_qt_ultima_compra { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proc_pr_ultima_compra { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_produtoDto tb_produto { get; set; }

        #endregion
    }
}
