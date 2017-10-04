using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_conselho_regional
    {
        #region Primitive Properties
        public virtual Int32 cr_id { get; set; }

        public virtual Decimal cr_numero { get; set; }

        public virtual String cr_nome { get; set; }

        public virtual String cr_cons_uf { get; set; }

        public virtual Nullable<Decimal> cr_especialidade_id { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_conselho tb_conselho { get; set; }

        #endregion
    }
    
}
