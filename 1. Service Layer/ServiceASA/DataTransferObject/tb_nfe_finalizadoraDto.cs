using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_nfe_finalizadora")]
    public partial class tb_nfe_finalizadoraDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 nfe_pdv { get; set; }
        [DataMember]
        public virtual Int32 nfe_id { get; set; }
        [DataMember]
        public virtual DateTime nfe_data { get; set; }
        [DataMember]
        public virtual Int32 final_seq { get; set; }
        [DataMember]
        public virtual Int32 final_id { get; set; }
        [DataMember]
        public virtual Int32 subfin_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> vpag_num_referencia { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vpag_valor { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vpag_troco { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> vpag_vendatef { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vpag_valor_compra_saque { get; set; }
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
        public virtual Nullable<Int32> vpag_cli_banco_id_ch { get; set; }
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
        [DataMember]
        public virtual Nullable<Int32> prazo_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> cheqrec_id { get; set; }
        [DataMember]
        public virtual Nullable<Int64> cli_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> boleto_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> bcaixa_id { get; set; }

        #endregion

    }
}
