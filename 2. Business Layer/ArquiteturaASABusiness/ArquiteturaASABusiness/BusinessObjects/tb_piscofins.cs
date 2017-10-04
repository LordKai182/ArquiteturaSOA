using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_piscofins
    {
        #region Primitive Properties
        public virtual Int32 piscofins_id { get; set; }

        public virtual Nullable<Decimal> piscofins_cst { get; set; }

        public virtual Nullable<Decimal> piscofins_aliq_LP_pis { get; set; }

        public virtual Nullable<Decimal> piscofins_aliq_LP_cofins { get; set; }

        public virtual Nullable<Decimal> piscofins_aliq_LR_pis { get; set; }

        public virtual Nullable<Decimal> piscofins_aliq_LR_cofins { get; set; }

        public virtual String piscofins_situacao { get; set; }

        public virtual Nullable<DateTime> piscofins_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> piscofins_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> piscofins_cpf_alteracao { get; set; }

        #endregion

    }
}
