using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_produto_estoque_lote")]
    public partial class tbr_produto_estoque_loteDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 pro_id { get; set; }
        [DataMember]
        public virtual String lote_numero { get; set; }
        [DataMember]
        public virtual DateTime lote_validade { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> lote_estoque { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> lote_fabricacao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> lote_vlr_pmc { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> lote_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_produtoDto tb_produto { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
}
