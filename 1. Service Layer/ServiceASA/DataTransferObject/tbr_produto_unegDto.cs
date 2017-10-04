using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_produto_uneg")]
    public partial class tbr_produto_unegDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 pro_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_preco_venda { get; set; }
        [DataMember]
        public virtual String proun_situacao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_custo_nf { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_encargos_nf { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_descontos_nf { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_custo_real { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_custo_medio { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_dia_min { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_dia_max { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_qtd_min { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_qtd_max { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> proun_fixa_qtd_max { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_vnd_media { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> proun_repos_auto { get; set; }
        [DataMember]
        public virtual String proun_abc_qtde { get; set; }
        [DataMember]
        public virtual String proun_abc_val { get; set; }
        [DataMember]
        public virtual String proun_abc_mrg { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_abc_qtde_rank { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_abc_val_rank { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_abc_mrg_rank { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_qtd_estoque { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_qtd_pedida { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> proun_qtd_transferida { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> proun_dt_ult_compra { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> proun_dt_ult_venda { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> proun_dt_ult_mvto { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> proun_dt_ult_preco { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> proun_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> proun_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> proun_bloq_compra { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> proun_dt_ult_inventario { get; set; }
        [DataMember]
        public virtual Nullable<Int32> proun_id_ult_fornecedor { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_produtoDto tb_produto { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
}
