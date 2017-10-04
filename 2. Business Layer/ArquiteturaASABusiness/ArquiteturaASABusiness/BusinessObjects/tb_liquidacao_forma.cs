using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_liquidacao_forma
    {
        #region Primitive Properties
        public virtual Int32 formaliq_id { get; set; }

        public virtual String formaliq_descricao { get; set; }

        public virtual Nullable<Decimal> formaliq_cpmf { get; set; }

        public virtual String formaliq_tipo { get; set; }

        public virtual String formaliq_infor_cheque { get; set; }

        public virtual String formaliq_situacao { get; set; }

        public virtual Nullable<DateTime> formaliq_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> formaliq_dt_alteracao { get; set; }

        #endregion

    }
}
