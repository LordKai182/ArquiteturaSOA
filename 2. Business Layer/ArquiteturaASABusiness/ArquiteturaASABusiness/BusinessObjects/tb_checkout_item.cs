using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_checkout_item
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 chkout_pdv { get; set; }

        public virtual Int32 chkout_id { get; set; }

        public virtual DateTime chkout_data { get; set; }

        public virtual Int32 ickout_id { get; set; }

        public virtual Nullable<Int32> pro_id { get; set; }

        public virtual Nullable<Decimal> ickout_cd_barra_lido { get; set; }

        public virtual Nullable<Decimal> ickout_quantidade { get; set; }

        public virtual String ickout_nu_lote { get; set; }

        public virtual Nullable<DateTime> ickout_val_lote { get; set; }

        public virtual Nullable<Boolean> ickout_conciliacao_nf { get; set; }

        #endregion

    }
    
}
