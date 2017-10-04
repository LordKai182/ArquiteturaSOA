using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_convenio_un
    {
        #region Primitive Properties
        public virtual Int32 cnv_id { get; set; }

        public virtual Int32 uneg_id { get; set; }

        public virtual String convun_situacao { get; set; }

        public virtual Nullable<DateTime> convun_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> convun_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> convun_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_convenio tb_convenio { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        #endregion
    }
    
}
