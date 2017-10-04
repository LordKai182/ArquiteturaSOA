using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_ecf_tributacao
    {
        #region Primitive Properties
        public virtual Int32 trb_id { get; set; }

        public virtual String ecf_numero_serie { get; set; }

        public virtual String trbecf_codigo { get; set; }

        public virtual String trbecf_situacao { get; set; }

        public virtual Nullable<DateTime> trbecf_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> trbecf_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_ecf tb_ecf { get; set; }

        public virtual tb_tributacao tb_tributacao { get; set; }

        #endregion
    }
    
}
