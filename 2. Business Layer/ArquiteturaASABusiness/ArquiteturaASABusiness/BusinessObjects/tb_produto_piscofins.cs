using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_produto_piscofins
    {
        #region Primitive Properties
        public virtual String piscofins_cod { get; set; }

        public virtual String piscofins_legenda { get; set; }

        public virtual String piscofins_situacao { get; set; }

        public virtual Nullable<DateTime> piscofins_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> piscofins_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_produto> _tb_produto;
        public virtual ICollection<tb_produto> tb_produto
        {
            get
            {
                if (_tb_produto == null)
                    _tb_produto = new List<tb_produto>();
                return _tb_produto;
            }
            set { _tb_produto = value; }
        }

        #endregion
    }
}
