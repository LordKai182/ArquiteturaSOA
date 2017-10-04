using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_produto_familia
    {
        #region Primitive Properties
        public virtual Int32 fam_id { get; set; }

        public virtual String fam_descricao { get; set; }

        public virtual String fam_situacao { get; set; }

        public virtual Nullable<DateTime> fam_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> fam_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_produto_fam_grupo> _tb_produto_fam_grupo;
        public virtual ICollection<tb_produto_fam_grupo> tb_produto_fam_grupo
        {
            get
            {
                if (_tb_produto_fam_grupo == null)
                    _tb_produto_fam_grupo = new List<tb_produto_fam_grupo>();
                return _tb_produto_fam_grupo;
            }
            set { _tb_produto_fam_grupo = value; }
        }

        #endregion
    }
    
}
