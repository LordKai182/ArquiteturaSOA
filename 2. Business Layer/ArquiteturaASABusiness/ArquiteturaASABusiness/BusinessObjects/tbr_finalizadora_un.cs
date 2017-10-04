using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_finalizadora_un
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 final_id { get; set; }

        public virtual String finalun_situacao { get; set; }

        public virtual Nullable<DateTime> finalun_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> finalun_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> finalun_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_finalizadora tb_finalizadora { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        #endregion
    }
    
}
