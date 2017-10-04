using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_venda_pagamento
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 venda_id { get; set; }

        public virtual Int32 venda_pdv { get; set; }

        public virtual DateTime venda_data { get; set; }

        public virtual Int32 vpag_id { get; set; }

        public virtual Int32 finsub_id { get; set; }

        public virtual Int32 final_id { get; set; }

        public virtual Nullable<Int32> vpag_num_referencia { get; set; }

        public virtual Decimal vpag_valor { get; set; }

        public virtual Nullable<Decimal> vpag_troco { get; set; }

        public virtual Nullable<Boolean> vpag_vendatef { get; set; }

        public virtual Decimal vpag_valor_compra_saque { get; set; }

        public virtual String vpag_tef_nsu_venda { get; set; }

        public virtual String vpag_tef_nsu_host { get; set; }

        public virtual String vpag_tipo_cartao { get; set; }

        public virtual String vpag_comprovante_cliente { get; set; }

        public virtual String vpag_comprovante_loja { get; set; }

        public virtual String vpag_status { get; set; }

        public virtual Nullable<DateTime> vpag_cli_data_ch { get; set; }

        public virtual Nullable<Decimal> vpag_cli_agencia_ch { get; set; }

        public virtual Nullable<Decimal> vpag_cli_c1_ch { get; set; }

        public virtual Nullable<Decimal> vpag_cli_conta_corrente_ch { get; set; }

        public virtual Nullable<Decimal> vpag_cli_c2_ch { get; set; }

        public virtual Nullable<Decimal> vpag_cli_numero_ch { get; set; }

        public virtual Nullable<Decimal> vpag_cli_c3_ch { get; set; }

        public virtual String vpag_cli_doc_troca { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_cliente tb_cliente { get; set; }

        public virtual tb_finalizadora tb_finalizadora { get; set; }

        public virtual tb_financeiro_bancos tb_financeiro_bancos { get; set; }

        public virtual tb_financeiro_prazo tb_financeiro_prazo { get; set; }

        #endregion
    }
    
}
