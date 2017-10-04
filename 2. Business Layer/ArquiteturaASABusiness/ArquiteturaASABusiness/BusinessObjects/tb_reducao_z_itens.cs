using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_reducao_z_itens
    {
        #region Primitive Properties
        public virtual Int32 reduz_itens_id { get; set; }

        public virtual String ecf_numero_serie { get; set; }

        public virtual DateTime reduz_data_movimento { get; set; }

        public virtual String reduz_itens_sequencia { get; set; }

        public virtual String reduz_itens_tipo { get; set; }

        public virtual Nullable<Decimal> reduz_itens_valor { get; set; }

        public virtual Nullable<Decimal> reduz_itens_total { get; set; }

        public virtual String reduz_itens_md5 { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_reducao_z tb_reducao_z { get; set; }

        #endregion
    }
}
