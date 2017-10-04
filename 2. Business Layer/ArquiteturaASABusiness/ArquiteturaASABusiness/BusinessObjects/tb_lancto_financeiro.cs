using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_lancto_financeiro
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 lanctof_pdv { get; set; }

        public virtual DateTime lanctof_data { get; set; }

        public virtual Int32 lanctof_id { get; set; }

        public virtual Nullable<Decimal> lanctof_valor { get; set; }

        public virtual String lanctof_observacao { get; set; }

        public virtual Nullable<Decimal> lanctof_num_documento { get; set; }

        public virtual Nullable<Int32> lanctof_responsavel { get; set; }

        public virtual String lanctof_tipo_movimento { get; set; }

        public virtual String lanctof_tipo_operacao { get; set; }

        public virtual Nullable<Int32> lanctof_funcionario_id { get; set; }

        public virtual Nullable<Int32> bancocx_id { get; set; }

        public virtual Nullable<Int32> lanctof_operadorCX { get; set; }

        public virtual String lanctof_md5 { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_financeiro_evento tb_financeiro_evento { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        #endregion
    }
}
