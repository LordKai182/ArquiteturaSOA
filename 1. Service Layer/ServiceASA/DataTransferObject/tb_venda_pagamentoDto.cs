using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_venda_pagamento")]
    public partial class tb_venda_pagamentoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 venda_id { get; set; }
        [DataMember]
        public virtual Int32 venda_pdv { get; set; }
        [DataMember]
        public virtual DateTime venda_data { get; set; }
        [DataMember]
        public virtual Int32 vpag_id { get; set; }
        [DataMember]
        public virtual Int32 finsub_id { get; set; }
        [DataMember]
        public virtual Int32 final_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> vpag_num_referencia { get; set; }
        [DataMember]
        public virtual Decimal vpag_valor { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vpag_troco { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> vpag_vendatef { get; set; }
        [DataMember]
        public virtual Decimal vpag_valor_compra_saque { get; set; }
        [DataMember]
        public virtual String vpag_tef_nsu_venda { get; set; }
        [DataMember]
        public virtual String vpag_tef_nsu_host { get; set; }
        [DataMember]
        public virtual String vpag_tipo_cartao { get; set; }
        [DataMember]
        public virtual String vpag_comprovante_cliente { get; set; }
        [DataMember]
        public virtual String vpag_comprovante_loja { get; set; }
        [DataMember]
        public virtual String vpag_status { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> vpag_cli_data_ch { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vpag_cli_agencia_ch { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vpag_cli_c1_ch { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vpag_cli_conta_corrente_ch { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vpag_cli_c2_ch { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vpag_cli_numero_ch { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vpag_cli_c3_ch { get; set; }
        [DataMember]
        public virtual String vpag_cli_doc_troca { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_clienteDto tb_cliente { get; set; }
        [DataMember]
        public virtual tb_finalizadoraDto tb_finalizadora { get; set; }
        [DataMember]
        public virtual tb_financeiro_bancosDto tb_financeiro_bancos { get; set; }
        [DataMember]
        public virtual tb_financeiro_prazoDto tb_financeiro_prazo { get; set; }

        #endregion
    }
}
