using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_sincronizacao
    {
        #region Primitive Properties
        public virtual Int32 id_sincronizacao { get; set; }

        public virtual Nullable<Int32> id_registro { get; set; }

        public virtual String entidade_registro { get; set; }

        public virtual Nullable<DateTime> dt_alteracao { get; set; }

        public virtual Nullable<DateTime> dt_inclusao { get; set; }

        public virtual Nullable<Int32> status { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_terminal tb_terminal { get; set; }

        #endregion
    }
}
