using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_liquidacao_motivo
    {
        #region Primitive Properties
        public virtual Int32 motivoliq_id { get; set; }

        public virtual String motivoliq_descricao { get; set; }

        public virtual String motivoliq_situacao { get; set; }

        public virtual Nullable<DateTime> motivoliq_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> motivoliq_dt_alteracao { get; set; }

        #endregion

    }
}
