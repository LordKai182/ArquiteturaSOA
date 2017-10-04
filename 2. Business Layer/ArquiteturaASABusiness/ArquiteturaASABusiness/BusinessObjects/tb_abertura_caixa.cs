using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_abertura_caixa
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 aberturaCx_usr_id_operador { get; set; }

        public virtual DateTime aberturaCx_dt_abertura { get; set; }

        public virtual Nullable<DateTime> aberturaCx_dt_fechamento { get; set; }

        public virtual Nullable<Int32> aberturaCx_usr_id_fechamento { get; set; }

        public virtual Nullable<Int32> aberturaCx_usr_id_conferente { get; set; }

        public virtual Nullable<DateTime> aberturaCx_dt_conferencia { get; set; }

        public virtual String aberturaCx_observacao { get; set; }

        public virtual Nullable<DateTime> aberturaCx_dt_alteracao { get; set; }

        #endregion

    }
    
}
