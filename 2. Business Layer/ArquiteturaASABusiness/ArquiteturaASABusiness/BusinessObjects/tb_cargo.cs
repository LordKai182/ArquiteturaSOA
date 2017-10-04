using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_cargo
    {
        #region Primitive Properties
        public virtual Int32 cargo_id { get; set; }

        public virtual String cargo_descricao { get; set; }

        public virtual String cargo_situacao { get; set; }

        public virtual Nullable<DateTime> cargo_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> cargo_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_funcionario> _tb_funcionario;
        public virtual ICollection<tb_funcionario> tb_funcionario
        {
            get
            {
                if (_tb_funcionario == null)
                    _tb_funcionario = new List<tb_funcionario>();
                return _tb_funcionario;
            }
            set { _tb_funcionario = value; }
        }

        #endregion
    }
    
}
