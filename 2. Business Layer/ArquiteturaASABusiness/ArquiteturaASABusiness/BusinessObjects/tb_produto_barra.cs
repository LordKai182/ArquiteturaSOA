using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{

    public partial class tb_produto_barra
    {
        #region Primitive Properties
        public virtual Int32 pro_id { get; set; }

        public virtual Decimal barra_codigo { get; set; }

        public virtual String barra_tip_embalagem { get; set; }

        public virtual Nullable<Decimal> barra_qtd_embalagem { get; set; }

        public virtual String barra_situacao { get; set; }

        public virtual Nullable<DateTime> barra_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> barra_dt_alteracao { get; set; }

        public virtual String barra_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_produto tb_produto { get; set; }

        #endregion
    }
}
