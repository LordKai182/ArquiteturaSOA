using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_princ_ativo
    {
        #region Primitive Properties
        public virtual Int32 pat_id { get; set; }

        public virtual String pat_descricao { get; set; }

        public virtual DateTime pat_dt_alteracao { get; set; }

        #endregion

    }
}
