using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_ponto
    {
        #region Primitive Properties
        public virtual Int32 ponto_id { get; set; }

        public virtual DateTime ponto_dt_ponto { get; set; }

        public virtual Nullable<DateTime> ponto_hr_entrada { get; set; }

        public virtual Nullable<DateTime> ponto_hr_almoco_inicio { get; set; }

        public virtual Nullable<DateTime> ponto_hr_almoco_fim { get; set; }

        public virtual Nullable<DateTime> ponto_hr_saida { get; set; }

        public virtual Int32 func_id { get; set; }

        public virtual String ponto_situacao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_ponto_motivo tb_ponto_motivo { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }

        #endregion
    }
}
