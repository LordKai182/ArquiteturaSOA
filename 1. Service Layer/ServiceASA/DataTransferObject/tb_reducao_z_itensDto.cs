using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_reducao_z_itens")]
    public partial class tb_reducao_z_itensDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 reduz_itens_id { get; set; }
        [DataMember]
        public virtual String ecf_numero_serie { get; set; }
        [DataMember]
        public virtual DateTime reduz_data_movimento { get; set; }
        [DataMember]
        public virtual String reduz_itens_sequencia { get; set; }
        [DataMember]
        public virtual String reduz_itens_tipo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> reduz_itens_valor { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> reduz_itens_total { get; set; }
        [DataMember]
        public virtual String reduz_itens_md5 { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_reducao_zDto tb_reducao_z { get; set; }

        #endregion
    }
}
