using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_financeiro_suprimento
    {
        #region Primitive Properties
        public virtual Int32 suprimentof_id { get; set; }

        public virtual DateTime suprimentof_data { get; set; }

        public virtual Decimal suprimentof_valor { get; set; }

        public virtual String suprimentof_observacao { get; set; }

        public virtual String suprimentof_cpf_responsavel { get; set; }

        public virtual String suprimentof_status { get; set; }

        public virtual String suprimentof_cpf_funcionario { get; set; }

        public virtual Nullable<DateTime> suprimentof_dt_alteracao { get; set; }

        public virtual String suprimentof_cpf_alteracao { get; set; }

        public virtual String suprimentof_md5 { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_usuario tb_usuario { get; set; }

        #endregion
    }
    
}
