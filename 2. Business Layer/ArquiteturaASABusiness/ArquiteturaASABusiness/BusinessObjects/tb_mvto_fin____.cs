using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_mvto_fin____
    {
        #region Primitive Properties
        public virtual Int32 mvtof_id { get; set; }

        public virtual DateTime mvtof_data { get; set; }

        public virtual Decimal mvtof_cod_caixa { get; set; }

        public virtual Nullable<Decimal> mvtof_valor { get; set; }

        public virtual Nullable<Decimal> mvtof_usr_respons { get; set; }

        public virtual String mvtof_historico { get; set; }

        public virtual Nullable<Decimal> mvtof_usr_mat { get; set; }

        #endregion

    }
}
