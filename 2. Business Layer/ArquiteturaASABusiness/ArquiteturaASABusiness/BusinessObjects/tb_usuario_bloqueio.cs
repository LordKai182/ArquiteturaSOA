using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_usuario_bloqueio
    {
        #region Primitive Properties
        public virtual Int32 bloq_id { get; set; }

        public virtual String bloq_descricao { get; set; }

        public virtual String bloq_situacao { get; set; }

        public virtual Nullable<DateTime> bloq_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> bloq_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_usuario> _tb_usuario;
        public virtual ICollection<tb_usuario> tb_usuario
        {
            get
            {
                if (_tb_usuario == null)
                    _tb_usuario = new List<tb_usuario>();
                return _tb_usuario;
            }
            set { _tb_usuario = value; }
        }

        #endregion
    }
}
