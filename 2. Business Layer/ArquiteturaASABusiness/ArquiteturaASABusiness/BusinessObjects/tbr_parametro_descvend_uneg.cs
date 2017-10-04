using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_parametro_descvend_uneg
    {
        #region Primitive Properties
        public virtual Int32 par_id { get; set; }

        public virtual Int32 uneg_id { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        #endregion
    }
}
