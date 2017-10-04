using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_produto_uneg
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 pro_id { get; set; }

        public virtual Nullable<Decimal> proun_preco_venda { get; set; }

        public virtual String proun_situacao { get; set; }

        public virtual Nullable<Decimal> proun_custo_nf { get; set; }

        public virtual Nullable<Decimal> proun_encargos_nf { get; set; }

        public virtual Nullable<Decimal> proun_descontos_nf { get; set; }

        public virtual Nullable<Decimal> proun_custo_real { get; set; }

        public virtual Nullable<Decimal> proun_custo_medio { get; set; }

        public virtual Nullable<Decimal> proun_dia_min { get; set; }

        public virtual Nullable<Decimal> proun_dia_max { get; set; }

        public virtual Nullable<Decimal> proun_qtd_min { get; set; }

        public virtual Nullable<Decimal> proun_qtd_max { get; set; }

        public virtual Nullable<Boolean> proun_fixa_qtd_max { get; set; }

        public virtual Nullable<Decimal> proun_vnd_media { get; set; }

        public virtual Nullable<Boolean> proun_repos_auto { get; set; }

        public virtual String proun_abc_qtde { get; set; }

        public virtual String proun_abc_val { get; set; }

        public virtual String proun_abc_mrg { get; set; }

        public virtual Nullable<Decimal> proun_abc_qtde_rank { get; set; }

        public virtual Nullable<Decimal> proun_abc_val_rank { get; set; }

        public virtual Nullable<Decimal> proun_abc_mrg_rank { get; set; }

        public virtual Nullable<Decimal> proun_qtd_estoque { get; set; }

        public virtual Nullable<Decimal> proun_qtd_pedida { get; set; }

        public virtual Nullable<Decimal> proun_qtd_transferida { get; set; }

        public virtual Nullable<DateTime> proun_dt_ult_compra { get; set; }

        public virtual Nullable<DateTime> proun_dt_ult_venda { get; set; }

        public virtual Nullable<DateTime> proun_dt_ult_mvto { get; set; }

        public virtual Nullable<DateTime> proun_dt_ult_preco { get; set; }

        public virtual Nullable<DateTime> proun_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> proun_dt_alteracao { get; set; }

        public virtual Nullable<Boolean> proun_bloq_compra { get; set; }

        public virtual Nullable<DateTime> proun_dt_ult_inventario { get; set; }

        public virtual Nullable<Int32> proun_id_ult_fornecedor { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_produto tb_produto { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        #endregion
    }
}
