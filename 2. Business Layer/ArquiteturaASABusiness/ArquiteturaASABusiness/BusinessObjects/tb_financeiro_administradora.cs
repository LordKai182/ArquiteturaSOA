using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_financeiro_administradora
    {
        #region Primitive Properties
        public virtual Int32 adm_id { get; set; }

        public virtual String adm_nome { get; set; }

        public virtual String adm_situacao { get; set; }

        public virtual Nullable<DateTime> adm_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> adm_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_finalizadora_sub> _tb_finalizadora_sub;
        public virtual ICollection<tb_finalizadora_sub> tb_finalizadora_sub
        {
            get
            {
                if (_tb_finalizadora_sub == null)
                    _tb_finalizadora_sub = new List<tb_finalizadora_sub>();
                return _tb_finalizadora_sub;
            }
            set { _tb_finalizadora_sub = value; }
        }

        #endregion
    }
}
