using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_entrega_prod_continuo
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 end_pdv { get; set; }

        public virtual Int32 end_id { get; set; }

        public virtual DateTime end_data { get; set; }

        public virtual Int32 pro_id { get; set; }

        public virtual Nullable<DateTime> proc_dt_ultima_compra { get; set; }

        public virtual Nullable<Decimal> proc_qt_ultima_compra { get; set; }

        public virtual Nullable<Decimal> proc_pr_ultima_compra { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_produto tb_produto { get; set; }

        #endregion
    }
}
