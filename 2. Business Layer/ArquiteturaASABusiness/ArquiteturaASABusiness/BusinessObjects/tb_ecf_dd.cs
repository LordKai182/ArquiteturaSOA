using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_ecf_dd
    {
        #region Primitive Properties
        public virtual Int32 ecfd_id { get; set; }

        public virtual DateTime ecfd_dt_movimento { get; set; }

        public virtual String ecfd_coo { get; set; }

        public virtual String ecfd_gnf { get; set; }

        public virtual String ecfd_grg { get; set; }

        public virtual String ecfd_cdc { get; set; }

        public virtual String ecfd_tipo { get; set; }

        public virtual Decimal ecfd_valor_pago { get; set; }

        public virtual String ecfd_tipos_lancamento { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_ecf tb_ecf { get; set; }

        public virtual tb_finalizadora tb_finalizadora { get; set; }

        #endregion
    }
}
