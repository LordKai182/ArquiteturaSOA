using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_convenio_finalizadora_sub
    {
        #region Primitive Properties
        public virtual Int32 cnv_id { get; set; }

        public virtual Int32 final_id { get; set; }

        public virtual Int32 subfin_id { get; set; }

        public virtual String cfinaliza_situacao { get; set; }

        public virtual Nullable<DateTime> cfinaliza_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> cfinaliza_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> cfinaliza_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_convenio tb_convenio { get; set; }

        #endregion
    }
}
