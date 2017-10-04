using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_promocao_tipo
    {
        #region Primitive Properties
        public virtual Int32 tippro_id { get; set; }

        public virtual String tippro_descricao { get; set; }

        public virtual String tippro_situacao { get; set; }

        public virtual Nullable<DateTime> tippro_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> tippro_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> tippro_cpf_alteracao { get; set; }

        #endregion

    }
    
}
