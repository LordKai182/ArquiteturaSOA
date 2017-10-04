using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_funcionario_visitante
    {
        #region Primitive Properties
        public virtual Int32 funcvisit_id { get; set; }

        public virtual Nullable<DateTime> funcvisit_dt_visita { get; set; }

        public virtual String funcvisit_situacao { get; set; }

        public virtual Nullable<DateTime> funcvisit_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> funcvisit_dt_alteracao { get; set; }

        public virtual Nullable<Int32> func_id { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        #endregion
    }
}
