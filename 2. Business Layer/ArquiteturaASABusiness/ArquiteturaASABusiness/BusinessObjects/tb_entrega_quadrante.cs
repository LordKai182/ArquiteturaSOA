using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_entrega_quadrante
    {
        #region Primitive Properties
        public virtual Int32 quadra_id { get; set; }

        public virtual String quadra_coordenada { get; set; }

        public virtual String quadra_situacao { get; set; }

        public virtual Nullable<DateTime> quadra_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> quadra_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> quadra_cpf_alteracao { get; set; }

        #endregion

    }
}
