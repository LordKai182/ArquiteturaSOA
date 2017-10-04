using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_dav_itens____")]
    public partial class tb_dav_itens____Dto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 davi_id { get; set; }
        [DataMember]
        public virtual String davi_codigo { get; set; }
        [DataMember]
        public virtual String davi_descricao { get; set; }
        [DataMember]
        public virtual Decimal davi_quantidade { get; set; }
        [DataMember]
        public virtual String davi_embalagem { get; set; }
        [DataMember]
        public virtual Decimal davi_valor_unitario { get; set; }
        [DataMember]
        public virtual Decimal davi_valor_desconto { get; set; }
        [DataMember]
        public virtual Decimal davi_valor_acrescimo { get; set; }
        [DataMember]
        public virtual Decimal davi_total_liquido { get; set; }
        [DataMember]
        public virtual String davi_situacao_tributaria { get; set; }
        [DataMember]
        public virtual Int32 davi_aliquota { get; set; }
        [DataMember]
        public virtual String davi_indicador_cancelamento { get; set; }
        [DataMember]
        public virtual Int32 davi_decimais_quantidade { get; set; }
        [DataMember]
        public virtual Int32 davi_decimais_vlr_unitario { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_davDto tb_dav { get; set; }

        #endregion
    }
}
