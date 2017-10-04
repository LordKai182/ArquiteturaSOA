using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_entrega_rota
    {
        #region Primitive Properties
        public virtual Int32 rota_id { get; set; }

        public virtual Int32 quadra_id { get; set; }

        public virtual String rota_descricao { get; set; }

        public virtual String rota_situacao { get; set; }

        public virtual Nullable<DateTime> rota_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> rota_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> rota_cpf_alteracao { get; set; }

        #endregion

    }
}
