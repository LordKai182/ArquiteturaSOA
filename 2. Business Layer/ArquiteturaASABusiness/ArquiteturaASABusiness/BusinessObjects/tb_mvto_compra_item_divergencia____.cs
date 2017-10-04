using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_mvto_compra_item_divergencia____
    {
        #region Primitive Properties
        public virtual Int32 divicmp_id { get; set; }

        public virtual Int32 pro_id { get; set; }

        public virtual String divicmp_tipo { get; set; }

        public virtual Nullable<Decimal> divicmp_qtde { get; set; }

        public virtual Nullable<Decimal> divicmp_custo { get; set; }

        public virtual String divicmp_justificativa { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_mvto_compra____ tb_mvto_compra____ { get; set; }

        #endregion
    }
}
