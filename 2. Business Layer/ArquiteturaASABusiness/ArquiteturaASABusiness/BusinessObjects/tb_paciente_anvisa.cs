using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_paciente_anvisa
    {
        #region Primitive Properties
        public virtual Int64 paciente_id { get; set; }

        public virtual String paciente_nome { get; set; }

        public virtual String paciente_sexo { get; set; }

        public virtual Nullable<DateTime> paciente_dt_nascimento { get; set; }

        public virtual Nullable<DateTime> paciente_dt_modific { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_uf tb_uf { get; set; }

        #endregion
    }
    
}
