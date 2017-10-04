using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_cliente_telefone
    {
        #region Primitive Properties
        public virtual Int64 cli_id { get; set; }

        public virtual Int32 tel_id { get; set; }

        public virtual Nullable<Decimal> tel_tipo { get; set; }

        public virtual Nullable<Decimal> tel_cod_area { get; set; }

        public virtual Nullable<Decimal> tel_numero { get; set; }

        public virtual String tel_situacao { get; set; }

        public virtual Nullable<DateTime> tel_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> tel_dt_alteracao { get; set; }

        public virtual String tel_cpf_alteracao { get; set; }

        #endregion

    }
}
