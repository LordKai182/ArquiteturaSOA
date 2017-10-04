using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_produto_estoque_dia")]
    public partial class tbr_produto_estoque_diaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 pro_id { get; set; }
        [DataMember]
        public virtual DateTime proes_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> proes_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> proes_dt_leiturax { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> proes_dt_update { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proes_estoque { get; set; }
        [DataMember]
        public virtual Decimal proes_estoque_dia { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proes_custo_nf { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proes_custo_real { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proes_custo_medio { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proes_preco_venda { get; set; }
        [DataMember]
        public virtual String ecf_numero_serie { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_produtoDto tb_produto { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
}
