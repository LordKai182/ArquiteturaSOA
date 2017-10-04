using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_banco
    {
        #region Primitive Properties
        public virtual Int32 banco_id { get; set; }

        public virtual Nullable<Decimal> banco_codigo { get; set; }

        public virtual String banco_nome { get; set; }

        public virtual String banco_tipo { get; set; }

        public virtual String banco_situacao { get; set; }

        public virtual Nullable<DateTime> banco_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> banco_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> banco_cpf_alteracao { get; set; }

        #endregion

    }
    
}
