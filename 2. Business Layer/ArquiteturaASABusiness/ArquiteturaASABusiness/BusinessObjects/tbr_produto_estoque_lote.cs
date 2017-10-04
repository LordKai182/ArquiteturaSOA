using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_produto_estoque_lote
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 pro_id { get; set; }

        public virtual String lote_numero { get; set; }

        public virtual DateTime lote_validade { get; set; }

        public virtual Nullable<Decimal> lote_estoque { get; set; }

        public virtual Nullable<DateTime> lote_fabricacao { get; set; }

        public virtual Nullable<Decimal> lote_vlr_pmc { get; set; }

        public virtual Nullable<DateTime> lote_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_produto tb_produto { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        #endregion
    }
}
