using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_privatelabel_finalizadora")]
    public partial class tb_privatelabel_finalizadoraDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 plabel_pdv { get; set; }
        [DataMember]
        public virtual DateTime plabel_data { get; set; }
        [DataMember]
        public virtual Int32 plabel_id { get; set; }
        [DataMember]
        public virtual String vpag_id { get; set; }
        [DataMember]
        public virtual Int32 final_id { get; set; }
        [DataMember]
        public virtual Int32 subfin_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> vpag_num_referencia { get; set; }
        [DataMember]
        public virtual Decimal vpag_valor { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vpag_troco { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> vpag_vendatef { get; set; }
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
        public virtual Nullable<Int32> cli_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> bcaixa_id { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_financeiro_prazoDto tb_financeiro_prazo { get; set; }
        [DataMember]
        public virtual tb_privatelabelDto tb_privatelabel { get; set; }

        #endregion
    }
}
