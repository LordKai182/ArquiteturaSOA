using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_entrega_polo
    {
        #region Primitive Properties
        public virtual Int32 polo_id { get; set; }

        public virtual String polo_descricao { get; set; }

        public virtual String polo_localizacao { get; set; }

        public virtual String polo_situacao { get; set; }

        public virtual Nullable<DateTime> polo_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> polo_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> polo_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        #endregion
    }
}
