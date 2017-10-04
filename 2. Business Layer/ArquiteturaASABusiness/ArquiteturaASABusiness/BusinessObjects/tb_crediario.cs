using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_crediario
    {
        #region Primitive Properties
        public virtual Int32 cred_id { get; set; }

        public virtual Nullable<DateTime> cred_dt_entrada { get; set; }

        public virtual Nullable<DateTime> cred_dt_vencimento { get; set; }

        public virtual Nullable<Decimal> cred_vlr_documento { get; set; }

        public virtual Nullable<Decimal> cred_vlr_pago { get; set; }

        public virtual Nullable<DateTime> cred_dt_liquidacao { get; set; }

        public virtual Nullable<Decimal> cred_vlr_liquidacao { get; set; }

        public virtual Nullable<Decimal> cred_desconto_liq { get; set; }

        public virtual Nullable<Decimal> cred_juros_liq { get; set; }

        public virtual Nullable<Decimal> cred_taxa_liq { get; set; }

        public virtual String cred_situacao { get; set; }

        public virtual Nullable<Decimal> cred_cpf_cadastro { get; set; }

        public virtual Nullable<DateTime> cred_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> cred_cpf_alteracao { get; set; }

        public virtual Nullable<Int32> venda_pdv { get; set; }

        public virtual Nullable<Int32> venda_id { get; set; }

        public virtual Nullable<DateTime> venda_data { get; set; }

        public virtual Int32 rec_id { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_cliente tb_cliente { get; set; }

        public virtual tb_convenio tb_convenio { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        #endregion
    }
}
