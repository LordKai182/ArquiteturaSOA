using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_suprimentos
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 suprimentof_pdv { get; set; }

        public virtual DateTime suprimentof_data { get; set; }

        public virtual Int32 suprimentof_id { get; set; }

        public virtual Decimal suprimentof_valor { get; set; }

        public virtual Int32 suprimentof_operadorCx { get; set; }

        public virtual String suprimentof_observacao { get; set; }

        public virtual Int32 suprimentof_responsavel { get; set; }

        public virtual String suprimentof_status { get; set; }

        public virtual Nullable<Int32> suprimentof_funcionario { get; set; }

        public virtual Nullable<DateTime> suprimentof_dt_alteracao { get; set; }

        public virtual String suprimentof_cpf_alteracao { get; set; }

        public virtual Nullable<Int32> final_id { get; set; }

        public virtual String suprimentof_md5 { get; set; }

        public virtual Nullable<Int32> bcaixa_id { get; set; }

        #endregion

    }
}
