using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_ecf_dd")]
    public partial class tb_ecf_ddDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 ecfd_id { get; set; }
        [DataMember]
        public virtual DateTime ecfd_dt_movimento { get; set; }
        [DataMember]
        public virtual String ecfd_coo { get; set; }
        [DataMember]
        public virtual String ecfd_gnf { get; set; }
        [DataMember]
        public virtual String ecfd_grg { get; set; }
        [DataMember]
        public virtual String ecfd_cdc { get; set; }
        [DataMember]
        public virtual String ecfd_tipo { get; set; }
        [DataMember]
        public virtual Decimal ecfd_valor_pago { get; set; }
        [DataMember]
        public virtual String ecfd_tipos_lancamento { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_ecfDto tb_ecf { get; set; }
        [DataMember]
        public virtual tb_finalizadoraDto tb_finalizadora { get; set; }

        #endregion
    }
}
