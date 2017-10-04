using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_venda_estorno_tef
    {
        #region Primitive Properties
        public virtual Int32 vestef_id { get; set; }

        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 venda_id { get; set; }

        public virtual Int32 venda_pdv { get; set; }

        public virtual DateTime venda_data { get; set; }

        public virtual Int32 vpag_id { get; set; }

        public virtual Decimal vestef_usr_mat { get; set; }

        public virtual Decimal vestef_vendedor_mat { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_venda tb_venda { get; set; }

        #endregion
    }
}
