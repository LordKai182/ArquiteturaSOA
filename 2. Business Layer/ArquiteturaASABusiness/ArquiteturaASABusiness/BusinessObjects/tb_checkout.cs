using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_checkout
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 chkout_pdv { get; set; }

        public virtual Int32 chkout_id { get; set; }

        public virtual DateTime chkout_data { get; set; }

        public virtual Nullable<Decimal> chkout_num_nf { get; set; }

        public virtual Nullable<Int32> chkout_operador_id { get; set; }

        public virtual Nullable<Int32> cli_id { get; set; }

        public virtual Nullable<Int32> pedv_id { get; set; }

        #endregion

    }
    
}
