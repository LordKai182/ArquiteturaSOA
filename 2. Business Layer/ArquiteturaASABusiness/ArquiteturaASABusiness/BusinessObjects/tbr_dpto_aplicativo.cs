using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_dpto_aplicativo
    {
        #region Primitive Properties
        public virtual Int32 dpto_id { get; set; }

        public virtual Int32 apl_id { get; set; }

        public virtual Nullable<Int32> dptapl_acesso { get; set; }

        public virtual Nullable<Boolean> dptapl_inclusao { get; set; }

        public virtual Nullable<Boolean> dptapl_alteracao { get; set; }

        public virtual Nullable<Boolean> dptapl_exclusao { get; set; }

        public virtual Nullable<Boolean> dptapl_impressao { get; set; }

        public virtual Nullable<Boolean> dptapl_exp_xls { get; set; }

        public virtual Nullable<Boolean> dptapl_exp_pdf { get; set; }

        public virtual Nullable<Boolean> dptapl_exp_txt { get; set; }

        public virtual Nullable<Boolean> dptapl_processo { get; set; }

        public virtual Nullable<Boolean> dptapl_edicao { get; set; }

        public virtual Nullable<DateTime> dptapl_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> dptapl_dt_alteracao { get; set; }

        public virtual String dptapl_aplicacao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_usuario_dpto tb_usuario_dpto { get; set; }

        #endregion
    }
    
}
