using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_sangrias
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 sangriafl_pdv { get; set; }

        public virtual DateTime sangriaf_data { get; set; }

        public virtual Int32 sangriaf_id { get; set; }

        public virtual Nullable<Decimal> sangriaf_valor { get; set; }

        public virtual Nullable<Int32> sangriaf_operadorCx { get; set; }

        public virtual String sangriaf_observacao { get; set; }

        public virtual Nullable<Int32> sangriaf_responsavel { get; set; }

        public virtual String sangriaf_status { get; set; }

        public virtual Nullable<Int32> sangriaf_funcionario { get; set; }

        public virtual Nullable<DateTime> sangriaf_dt_alteracao { get; set; }

        public virtual String sangriaf_cpf_alteracao { get; set; }

        public virtual Nullable<Int32> final_id { get; set; }

        public virtual String sangriaf_md5 { get; set; }

        public virtual Nullable<Int32> bcaixa_id { get; set; }

        #endregion

    }
}
