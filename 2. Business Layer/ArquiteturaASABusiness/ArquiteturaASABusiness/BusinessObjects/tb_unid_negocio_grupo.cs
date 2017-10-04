using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_unid_negocio_grupo
    {
        #region Primitive Properties
        public virtual Int32 guneg_id { get; set; }

        public virtual String guneg_descricao { get; set; }

        public virtual String guneg_situacao { get; set; }

        public virtual Nullable<DateTime> guneg_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> guneg_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> guneg_cpf_alteracao { get; set; }

        #endregion

    }
}
