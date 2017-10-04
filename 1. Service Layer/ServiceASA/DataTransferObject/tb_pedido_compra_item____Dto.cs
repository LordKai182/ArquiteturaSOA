using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_pedido_compra_item____")]
    public partial class tb_pedido_compra_item____Dto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 pedc_id { get; set; }
        [DataMember]
        public virtual Int32 ipedc_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> ipedc_qtd_atendida { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> ipedv_qtd_embalagem { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> ipedc_custo_unitario { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> ipedc_perc_desconto { get; set; }
        [DataMember]
        public virtual Nullable<Int32> pro_id { get; set; }
        [DataMember]
        public virtual String ipedc_situacao { get; set; }

        #endregion

        #region Navigation Properties
       [DataMember]
        public virtual tb_pedido_compra____Dto tb_pedido_compra____ { get; set; }

        #endregion
    }
}
