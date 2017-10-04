using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_ibpt_ax
    {
        #region Primitive Properties
        public virtual Int64 iax_id { get; set; }

        public virtual Nullable<Int32> iax_tabela { get; set; }

        public virtual Nullable<Int32> iax_excecoes { get; set; }

        public virtual Nullable<Decimal> iax_ncm { get; set; }

        public virtual String iax_ncm_descricao_reduz { get; set; }

        public virtual String iax_ncm_descricao { get; set; }

        public virtual String iax_situacao { get; set; }

        public virtual Nullable<DateTime> iax_data_alteracao { get; set; }

        public virtual Nullable<Decimal> iax_aliq_nacional { get; set; }

        public virtual Nullable<Decimal> iax_aliq_importado { get; set; }

        public virtual Nullable<Decimal> iax_aliq_estadual { get; set; }

        public virtual Nullable<Decimal> iax_aliq_municipal { get; set; }

        public virtual Nullable<DateTime> iax_vigencia_inicio { get; set; }

        public virtual Nullable<DateTime> iax_vigencia_fim { get; set; }

        public virtual String iax_fonte { get; set; }

        public virtual String iax_chave { get; set; }

        public virtual String iax_versao { get; set; }

        #endregion

    }
}
