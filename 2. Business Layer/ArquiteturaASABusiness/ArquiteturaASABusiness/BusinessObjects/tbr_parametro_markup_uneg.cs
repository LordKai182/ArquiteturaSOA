using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_parametro_markup_uneg
    {
        #region Primitive Properties
        public virtual Int32 par_id { get; set; }

        public virtual Int32 uneg_id { get; set; }

        public virtual Nullable<Decimal> par_percentual { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_parametro_markup tb_parametro_markup { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        #endregion
    }
}
