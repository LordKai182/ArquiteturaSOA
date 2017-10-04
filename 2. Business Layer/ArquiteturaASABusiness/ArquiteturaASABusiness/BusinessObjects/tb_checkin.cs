using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_checkin
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 chkin_pdv { get; set; }

        public virtual Int32 chkin_id { get; set; }

        public virtual DateTime chkin_data { get; set; }

        public virtual Nullable<Decimal> chkin_num_nf { get; set; }

        public virtual Nullable<Int32> chkin_operador_id { get; set; }

        public virtual Nullable<Int32> cmp_id { get; set; }

        public virtual Nullable<Int32> pedc_id { get; set; }

        public virtual Nullable<Int32> fab_id { get; set; }

        public virtual Nullable<Int32> div_id { get; set; }

        #endregion

    }

}
