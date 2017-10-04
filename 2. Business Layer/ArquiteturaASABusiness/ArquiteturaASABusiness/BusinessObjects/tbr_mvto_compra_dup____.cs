using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_mvto_compra_dup____
    {
        #region Primitive Properties
        public virtual Int32 cmp_id { get; set; }

        public virtual Int32 cmpdup_id { get; set; }

        public virtual String mvtocdup_situacao { get; set; }

        public virtual Nullable<DateTime> mvtocdup_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> mvtocdup_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> mvtocdup_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_mvto_compra____ tb_mvto_compra____ { get; set; }

        public virtual tb_mvto_compra_dup____ tb_mvto_compra_dup____ { get; set; }

        #endregion
    }
}
