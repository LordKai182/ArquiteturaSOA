using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_dicionario_produto
    {
        #region Primitive Properties
        public virtual Int32 fab_id { get; set; }

        public virtual Int32 pro_id { get; set; }

        public virtual Nullable<Decimal> dicprod_qtde_embal { get; set; }

        public virtual String dicprod_tipo_embal { get; set; }

        public virtual String dicprod_codigo { get; set; }

        public virtual String dicprod_situacao { get; set; }

        public virtual Nullable<DateTime> dicprod_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> dicprod_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_fornecedor tb_fornecedor { get; set; }

        public virtual tb_produto tb_produto { get; set; }

        #endregion
    }
}
