using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_nfe_cfop
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 nfe_pdv { get; set; }

        public virtual Int32 nfe_id { get; set; }

        public virtual DateTime nfe_data { get; set; }

        public virtual Int32 cfop_id { get; set; }

        public virtual Nullable<Decimal> cfop_base_icms { get; set; }

        public virtual Nullable<Decimal> cfop_aliq_icms { get; set; }

        public virtual Nullable<Decimal> cfop_valor_icms { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_cfop tb_cfop { get; set; }

        #endregion
    }
}
