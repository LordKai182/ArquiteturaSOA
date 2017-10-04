using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_checkin_item_tmp
    {
        #region Primitive Properties
        public virtual Int32 chkin_id { get; set; }

        public virtual Int32 ickin_id { get; set; }

        public virtual Nullable<Decimal> ickin_quantidade { get; set; }

        public virtual String ickin_nu_lote { get; set; }

        public virtual Nullable<DateTime> ickin_val_lote { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_checkin_tmp tb_checkin_tmp { get; set; }

        public virtual tb_produto tb_produto { get; set; }

        #endregion
    }
}
