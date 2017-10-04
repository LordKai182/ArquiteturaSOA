using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_crediario_finalizadora
    {
        #region Primitive Properties
        public virtual Int32 cred_id { get; set; }

        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 venda_pdv { get; set; }

        public virtual Int32 crpgto_id { get; set; }

        public virtual DateTime crpgto_data { get; set; }

        public virtual Nullable<Decimal> crpgto_valor { get; set; }

        public virtual Nullable<Int32> crpgto_atendente { get; set; }

        public virtual Nullable<Int32> crpgto_operadorCX { get; set; }

        public virtual Nullable<Int32> final_id { get; set; }

        public virtual Nullable<Int32> subfin_id { get; set; }

        public virtual Nullable<Decimal> crpgto_troco { get; set; }

        public virtual Nullable<DateTime> crpgto_cli_data_ch { get; set; }

        public virtual Nullable<Int32> crpgto_cli_banco_id_ch { get; set; }

        public virtual Nullable<Decimal> crpgto_cli_agencia_ch { get; set; }

        public virtual Nullable<Decimal> crpgto_cli_c1_ch { get; set; }

        public virtual Nullable<Decimal> crpgto_cli_conta_corrente_ch { get; set; }

        public virtual Nullable<Decimal> crpgto_cli_c2_ch { get; set; }

        public virtual Nullable<Decimal> crpgto_cli_numero_ch { get; set; }

        public virtual Nullable<Decimal> crpgto_cli_c3_ch { get; set; }

        public virtual Nullable<Int32> prazo_id { get; set; }

        public virtual Nullable<Int32> cheqrec_id { get; set; }

        public virtual Nullable<Int32> bcaixa_id { get; set; }

        #endregion

    }
}
