using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_produto_fam_grupo
    {
        #region Primitive Properties
        public virtual Int32 fam_id { get; set; }

        public virtual Int32 grp_id { get; set; }

        public virtual String grp_descricao { get; set; }

        public virtual String grp_situacao { get; set; }

        public virtual Nullable<DateTime> grp_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> grp_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_produto_fam_categoria> _tb_produto_fam_categoria;
        public virtual ICollection<tb_produto_fam_categoria> tb_produto_fam_categoria
        {
            get
            {
                if (_tb_produto_fam_categoria == null)
                    _tb_produto_fam_categoria = new List<tb_produto_fam_categoria>();
                return _tb_produto_fam_categoria;
            }
            set { _tb_produto_fam_categoria = value; }
        }

        public virtual tb_produto_familia tb_produto_familia { get; set; }

        #endregion
    }
}
