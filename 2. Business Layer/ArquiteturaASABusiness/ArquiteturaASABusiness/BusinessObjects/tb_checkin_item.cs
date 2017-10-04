using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{

    public partial class tb_checkin_item
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 chkin_pdv { get; set; }

        public virtual Int32 chkin_id { get; set; }

        public virtual DateTime chkin_data { get; set; }

        public virtual Int32 ickin_id { get; set; }

        public virtual Nullable<Int32> pro_id { get; set; }

        public virtual Nullable<Decimal> ickin_cd_barra_lido { get; set; }

        public virtual Nullable<Decimal> ickin_quantidade { get; set; }

        public virtual String ickin_nu_lote { get; set; }

        public virtual Nullable<DateTime> ickin_val_lote { get; set; }

        public virtual Nullable<Boolean> ickin_conciliacao_nf { get; set; }

        #endregion

    }
}
