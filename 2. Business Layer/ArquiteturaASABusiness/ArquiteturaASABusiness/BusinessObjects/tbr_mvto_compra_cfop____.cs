using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_mvto_compra_cfop____
    {
        #region Primitive Properties
        public virtual Int32 cmp_id { get; set; }

        public virtual Int32 cfop_id { get; set; }

        public virtual Nullable<Decimal> mvtoccfop_base_icms { get; set; }

        public virtual Nullable<Decimal> mvtoccfop_aliq_icms { get; set; }

        public virtual Nullable<Decimal> mvtoccfop_valor_icms { get; set; }

        public virtual String mvtoccfop_situacao { get; set; }

        public virtual Nullable<DateTime> mvtoccfop_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> mvtoccfop_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> mvtoccfop_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_cfop tb_cfop { get; set; }

        public virtual tb_mvto_compra____ tb_mvto_compra____ { get; set; }

        #endregion
    }
}
