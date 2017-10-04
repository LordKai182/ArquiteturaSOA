using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_dicionario_un
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 fab_id { get; set; }

        public virtual Int32 div_id { get; set; }

        public virtual String dicun_codigo { get; set; }

        public virtual String dicun_situacao { get; set; }

        public virtual Nullable<DateTime> dicun_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> dicun_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_fornecedor_divisao tb_fornecedor_divisao { get; set; }

        #endregion
    }
}
