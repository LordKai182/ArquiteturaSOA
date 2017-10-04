using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_produto_estoque_dia
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 pro_id { get; set; }

        public virtual DateTime proes_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> proes_dt_alteracao { get; set; }

        public virtual Nullable<DateTime> proes_dt_leiturax { get; set; }

        public virtual Nullable<DateTime> proes_dt_update { get; set; }

        public virtual Nullable<Decimal> proes_estoque { get; set; }

        public virtual Decimal proes_estoque_dia { get; set; }

        public virtual Nullable<Decimal> proes_custo_nf { get; set; }

        public virtual Nullable<Decimal> proes_custo_real { get; set; }

        public virtual Nullable<Decimal> proes_custo_medio { get; set; }

        public virtual Nullable<Decimal> proes_preco_venda { get; set; }

        public virtual String ecf_numero_serie { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_produto tb_produto { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        #endregion
    }
    
}
