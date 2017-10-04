using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_parametro_markup
    {
        #region Primitive Properties
        public virtual Int32 par_id { get; set; }

        public virtual Nullable<Int32> par_objeto { get; set; }

        public virtual String par_situacao { get; set; }

        public virtual Nullable<Boolean> par_tp_regra { get; set; }

        public virtual Nullable<DateTime> par_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> par_dt_alteracao { get; set; }

        public virtual String par_cpf_alteracao { get; set; }

        public virtual Nullable<Decimal> par_markup { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_fornecedor_divisao tb_fornecedor_divisao { get; set; }

        public virtual tb_produto tb_produto { get; set; }

        public virtual tb_produto_classe tb_produto_classe { get; set; }

        public virtual tb_produto_fam_categ_sub tb_produto_fam_categ_sub { get; set; }

        public virtual tb_produto_linha tb_produto_linha { get; set; }

        public virtual tb_produto_similaridade tb_produto_similaridade { get; set; }

        private ICollection<tbr_parametro_markup_uneg> _tbr_parametro_markup_uneg;
        public virtual ICollection<tbr_parametro_markup_uneg> tbr_parametro_markup_uneg
        {
            get
            {
                if (_tbr_parametro_markup_uneg == null)
                    _tbr_parametro_markup_uneg = new List<tbr_parametro_markup_uneg>();
                return _tbr_parametro_markup_uneg;
            }
            set { _tbr_parametro_markup_uneg = value; }
        }

        #endregion
    }
}
