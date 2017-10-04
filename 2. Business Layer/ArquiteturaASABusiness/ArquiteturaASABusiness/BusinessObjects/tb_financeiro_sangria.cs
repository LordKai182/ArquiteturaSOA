using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_financeiro_sangria
    {
        #region Primitive Properties
        public virtual Int32 sangriaf_id { get; set; }

        public virtual DateTime sangriaf_data { get; set; }

        public virtual Decimal sangriaf_valor { get; set; }

        public virtual String sangriaf_observacao { get; set; }

        public virtual String sangriaf_cpf_responsavel { get; set; }

        public virtual String sangriaf_status { get; set; }

        public virtual String sangriaf_cpf_funcionario { get; set; }

        public virtual Nullable<DateTime> sangriaf_dt_alteracao { get; set; }

        public virtual String sangriaf_cpf_alteracao { get; set; }

        public virtual String sangriaf_md5 { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_finalizadora tb_finalizadora { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }

        #endregion
    }
    
}
