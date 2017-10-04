using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_ecf_finalizadora
    {
        #region Primitive Properties
        public virtual Int32 final_id { get; set; }

        public virtual String ecf_numero_serie { get; set; }

        public virtual String finalecf_codigo { get; set; }

        public virtual Boolean finalecf_cupom_vinculado { get; set; }

        public virtual String finalecf_situacao { get; set; }

        public virtual DateTime finalecf_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> finalecf_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_ecf tb_ecf { get; set; }

        public virtual tb_finalizadora tb_finalizadora { get; set; }

        #endregion
    }
}
