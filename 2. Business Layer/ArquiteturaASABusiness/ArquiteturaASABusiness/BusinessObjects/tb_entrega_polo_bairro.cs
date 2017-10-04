using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_entrega_polo_bairro
    {
        #region Primitive Properties
        public virtual Int32 bairro_id { get; set; }

        public virtual Int32 polo_id { get; set; }

        public virtual String bairro_bairro { get; set; }

        public virtual String bairro_municipio { get; set; }

        public virtual String bairro_estado { get; set; }

        public virtual String bairro_situacao { get; set; }

        public virtual Nullable<DateTime> bairro_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> bairro_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> bairro_cpf_alteracao { get; set; }

        public virtual Nullable<Int32> rota_id { get; set; }

        #endregion

    }
}
