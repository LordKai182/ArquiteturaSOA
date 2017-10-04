using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_promocao_produto
    {
        #region Primitive Properties
        public virtual Int32 prm_id { get; set; }

        public virtual Int32 pro_id { get; set; }

        public virtual Nullable<Decimal> prom_preco { get; set; }

        public virtual String prom_situacao { get; set; }

        public virtual Nullable<DateTime> prom_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> prom_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> prom_cpf_alteracao { get; set; }

        public virtual String prom_app_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_promocao tb_promocao { get; set; }

        #endregion
    }
}
