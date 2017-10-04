using ArquiteturaASABusiness.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_abcfarma_uf
    {
        #region Primitive Properties
        public virtual Int32 per_id { get; set; }

        public virtual Int32 abcf_id { get; set; }

        public virtual Int32 uf_id { get; set; }

        public virtual Nullable<Decimal> prouf_preco_fabrica { get; set; }

        public virtual Nullable<Decimal> prouf_pmc { get; set; }

        public virtual Nullable<Decimal> prouf_pmc_fracao { get; set; }

        public virtual String prouf_situacao { get; set; }

        public virtual Nullable<DateTime> prouf_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> prouf_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_abcfarma tb_abcfarma { get; set; }

        public virtual tb_abcfarma_periodo tb_abcfarma_periodo { get; set; }

        public virtual tb_uf tb_uf { get; set; }

        #endregion
    }
}
