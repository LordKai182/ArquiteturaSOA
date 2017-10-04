using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_ceps
    {
        #region Primitive Properties
        public virtual Int32 polo_id { get; set; }

        public virtual Int32 quadra_id { get; set; }

        public virtual Int32 rota_id { get; set; }

        public virtual Int32 cep_id { get; set; }

        public virtual Nullable<Decimal> cep_inicial { get; set; }

        public virtual Nullable<Decimal> cep_final { get; set; }

        public virtual Nullable<Decimal> cep_nu_inicial { get; set; }

        public virtual Nullable<Decimal> cep_nu_final { get; set; }

        public virtual String cep_situacao { get; set; }

        public virtual Nullable<DateTime> cep_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> cep_dt_alteracao { get; set; }

        #endregion

    }
}
