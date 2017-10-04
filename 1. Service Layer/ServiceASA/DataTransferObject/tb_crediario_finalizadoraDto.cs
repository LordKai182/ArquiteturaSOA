using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_crediario_finalizadora")]
    public partial class tb_crediario_finalizadoraDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cred_id { get; set; }
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 venda_pdv { get; set; }
        [DataMember]
        public virtual Int32 crpgto_id { get; set; }
        [DataMember]
        public virtual DateTime crpgto_data { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> crpgto_valor { get; set; }
        [DataMember]
        public virtual Nullable<Int32> crpgto_atendente { get; set; }
        [DataMember]
        public virtual Nullable<Int32> crpgto_operadorCX { get; set; }
        [DataMember]
        public virtual Nullable<Int32> final_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> subfin_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> crpgto_troco { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> crpgto_cli_data_ch { get; set; }
        [DataMember]
        public virtual Nullable<Int32> crpgto_cli_banco_id_ch { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> crpgto_cli_agencia_ch { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> crpgto_cli_c1_ch { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> crpgto_cli_conta_corrente_ch { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> crpgto_cli_c2_ch { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> crpgto_cli_numero_ch { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> crpgto_cli_c3_ch { get; set; }
        [DataMember]
        public virtual Nullable<Int32> prazo_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> cheqrec_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> bcaixa_id { get; set; }

        #endregion

    }
}
