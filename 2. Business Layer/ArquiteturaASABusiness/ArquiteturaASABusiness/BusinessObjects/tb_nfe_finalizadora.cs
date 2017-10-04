using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_nfe_finalizadora
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 nfe_pdv { get; set; }

        public virtual Int32 nfe_id { get; set; }

        public virtual DateTime nfe_data { get; set; }

        public virtual Int32 final_seq { get; set; }

        public virtual Int32 final_id { get; set; }

        public virtual Int32 subfin_id { get; set; }

        public virtual Nullable<Int32> vpag_num_referencia { get; set; }

        public virtual Nullable<Decimal> vpag_valor { get; set; }

        public virtual Nullable<Decimal> vpag_troco { get; set; }

        public virtual Nullable<Boolean> vpag_vendatef { get; set; }

        public virtual Nullable<Decimal> vpag_valor_compra_saque { get; set; }

        public virtual String vpag_tef_nsu_venda { get; set; }

        public virtual String vpag_tef_nsu_host { get; set; }

        public virtual String vpag_tipo_cartao { get; set; }

        public virtual String vpag_comprovante_cliente { get; set; }

        public virtual String vpag_comprovante_loja { get; set; }

        public virtual String vpag_status { get; set; }

        public virtual Nullable<DateTime> vpag_cli_data_ch { get; set; }

        public virtual Nullable<Int32> vpag_cli_banco_id_ch { get; set; }

        public virtual Nullable<Decimal> vpag_cli_agencia_ch { get; set; }

        public virtual Nullable<Decimal> vpag_cli_c1_ch { get; set; }

        public virtual Nullable<Decimal> vpag_cli_conta_corrente_ch { get; set; }

        public virtual Nullable<Decimal> vpag_cli_c2_ch { get; set; }

        public virtual Nullable<Decimal> vpag_cli_numero_ch { get; set; }

        public virtual Nullable<Decimal> vpag_cli_c3_ch { get; set; }

        public virtual String vpag_cli_doc_troca { get; set; }

        public virtual Nullable<Int32> prazo_id { get; set; }

        public virtual Nullable<Int32> cheqrec_id { get; set; }

        public virtual Nullable<Int64> cli_id { get; set; }

        public virtual Nullable<Int32> boleto_id { get; set; }

        public virtual Nullable<Int32> bcaixa_id { get; set; }

        #endregion

    }
}
