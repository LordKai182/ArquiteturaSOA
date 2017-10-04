using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_parametro_descconv
    {
        #region Primitive Properties
        public virtual Int32 par_id { get; set; }

        public virtual String par_objeto { get; set; }

        public virtual String par_situacao { get; set; }

        public virtual Nullable<Boolean> par_tp_regra { get; set; }

        public virtual String par_locked { get; set; }

        public virtual Nullable<DateTime> par_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> par_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> par_cpf_alteracao { get; set; }

        public virtual String par_app_alteracao { get; set; }

        public virtual Nullable<Decimal> par_preco_ate_1 { get; set; }

        public virtual Nullable<Decimal> par_percentual_1 { get; set; }

        public virtual Nullable<Decimal> par_preco_ate_2 { get; set; }

        public virtual Nullable<Decimal> par_percentual_2 { get; set; }

        public virtual Nullable<Decimal> par_preco_ate_3 { get; set; }

        public virtual Nullable<Decimal> par_percentual_3 { get; set; }

        public virtual Nullable<Decimal> par_preco_ate_4 { get; set; }

        public virtual Nullable<Decimal> par_percentual_4 { get; set; }

        public virtual Nullable<Decimal> par_preco_ate_5 { get; set; }

        public virtual Nullable<Decimal> par_percentual_5 { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_convenio tb_convenio { get; set; }

        public virtual tb_fornecedor_divisao tb_fornecedor_divisao { get; set; }

        public virtual tb_produto tb_produto { get; set; }

        public virtual tb_produto_classe tb_produto_classe { get; set; }

        public virtual tb_produto_fam_categ_sub tb_produto_fam_categ_sub { get; set; }

        public virtual tb_produto_linha tb_produto_linha { get; set; }

        public virtual tb_produto_similaridade tb_produto_similaridade { get; set; }

        #endregion
    }
    
}
