using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_produto_fam_categoria
    {
        #region Primitive Properties
        public virtual Int32 fam_id { get; set; }

        public virtual Int32 grp_id { get; set; }

        public virtual Int32 cat_id { get; set; }

        public virtual String cat_descricao { get; set; }

        public virtual String cat_situacao { get; set; }

        public virtual Nullable<DateTime> cat_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> cat_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_produto_fam_categ_sub> _tb_produto_fam_categ_sub;
        public virtual ICollection<tb_produto_fam_categ_sub> tb_produto_fam_categ_sub
        {
            get
            {
                if (_tb_produto_fam_categ_sub == null)
                    _tb_produto_fam_categ_sub = new List<tb_produto_fam_categ_sub>();
                return _tb_produto_fam_categ_sub;
            }
            set { _tb_produto_fam_categ_sub = value; }
        }

        public virtual tb_produto_fam_grupo tb_produto_fam_grupo { get; set; }

        #endregion
    }
    
}
