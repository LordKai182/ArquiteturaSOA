using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{

    public partial class tb_mvto_compra_item_lote____
    {
        #region Primitive Properties
        public virtual Int32 cmp_id { get; set; }

        public virtual Int32 icmp_id { get; set; }

        public virtual Int32 loteicmp_id { get; set; }

        public virtual String loteicmp_numero { get; set; }

        public virtual Nullable<Decimal> loteicmp_qtde { get; set; }

        public virtual Nullable<DateTime> loteicmp_validade { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_mvto_compra_item____ tb_mvto_compra_item____ { get; set; }

        #endregion
    }
}
