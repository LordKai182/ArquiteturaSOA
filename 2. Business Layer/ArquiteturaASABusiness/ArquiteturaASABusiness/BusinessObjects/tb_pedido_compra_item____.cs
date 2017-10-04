using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_pedido_compra_item____
    {
        #region Primitive Properties
        public virtual Int32 pedc_id { get; set; }

        public virtual Int32 ipedc_id { get; set; }

        public virtual Nullable<Decimal> ipedc_qtd_atendida { get; set; }

        public virtual Nullable<Decimal> ipedv_qtd_embalagem { get; set; }

        public virtual Nullable<Decimal> ipedc_custo_unitario { get; set; }

        public virtual Nullable<Decimal> ipedc_perc_desconto { get; set; }

        public virtual Nullable<Int32> pro_id { get; set; }

        public virtual String ipedc_situacao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_pedido_compra____ tb_pedido_compra____ { get; set; }

        #endregion
    }
}
