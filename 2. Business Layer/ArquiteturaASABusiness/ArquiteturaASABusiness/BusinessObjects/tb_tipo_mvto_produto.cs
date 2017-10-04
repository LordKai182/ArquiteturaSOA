using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_tipo_mvto_produto
    {
        #region Primitive Properties
        public virtual Int32 cdmvto_codigo { get; set; }

        public virtual String cdmvto_descricao { get; set; }

        public virtual String cdmvto_tipo { get; set; }

        public virtual Nullable<Boolean> cdmvto_lanc_manual { get; set; }

        public virtual String cdmvto_cd_anvisa { get; set; }

        public virtual String cdmvto_situacao { get; set; }

        public virtual Nullable<DateTime> cdmvto_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> cdmvto_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_tipo_nota> _tb_tipo_nota;
        public virtual ICollection<tb_tipo_nota> tb_tipo_nota
        {
            get
            {
                if (_tb_tipo_nota == null)
                    _tb_tipo_nota = new List<tb_tipo_nota>();
                return _tb_tipo_nota;
            }
            set { _tb_tipo_nota = value; }
        }

        #endregion
    }
}
