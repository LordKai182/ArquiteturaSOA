using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_usuario_grupo
    {
        #region Primitive Properties
        public virtual Int32 grp_id { get; set; }

        public virtual String grp_nome { get; set; }

        public virtual String grp_diautil { get; set; }

        public virtual String grp_sabado { get; set; }

        public virtual String grp_domingo { get; set; }

        public virtual String grp_feriado { get; set; }

        public virtual Nullable<Decimal> grp_tmp_senha { get; set; }

        public virtual Nullable<Boolean> grp_acesso_filial_ilimitada { get; set; }

        public virtual String grp_situacao { get; set; }

        public virtual Nullable<DateTime> grp_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> grp_dt_alteracao { get; set; }

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
