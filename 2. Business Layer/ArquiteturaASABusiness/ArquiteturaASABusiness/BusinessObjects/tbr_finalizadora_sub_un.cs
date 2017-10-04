using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_finalizadora_sub_un
    {
        #region Primitive Properties
        public virtual Int32 final_id { get; set; }

        public virtual Int32 subfin_id { get; set; }

        public virtual Int32 uneg_id { get; set; }

        public virtual Nullable<Decimal> finsubun_taxa_adm { get; set; }

        public virtual String finsubun_situacao { get; set; }

        public virtual Nullable<DateTime> finsubun_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> finsubun_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> finsubun_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_finalizadora_sub tb_finalizadora_sub { get; set; }

        public virtual tb_financeiro_bancos tb_financeiro_bancos { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        #endregion
    }
}
