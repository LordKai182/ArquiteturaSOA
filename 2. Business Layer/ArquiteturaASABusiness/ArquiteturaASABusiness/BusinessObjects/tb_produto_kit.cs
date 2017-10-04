using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_produto_kit
    {
        #region Primitive Properties
        public virtual Int32 pro_id { get; set; }

        public virtual Int32 kitpro_produto { get; set; }

        public virtual Nullable<Decimal> kitpro_quantidade { get; set; }

        public virtual String kitpro_situacao { get; set; }

        public virtual Nullable<DateTime> kitpro_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> kitpro_dt_alteracao { get; set; }

        #endregion

    }
}
