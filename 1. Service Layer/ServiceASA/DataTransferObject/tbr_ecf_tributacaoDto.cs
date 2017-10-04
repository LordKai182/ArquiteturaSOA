using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_ecf_tributacao")]
    public partial class tbr_ecf_tributacaoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 trb_id { get; set; }
        [DataMember]
        public virtual String ecf_numero_serie { get; set; }
        [DataMember]
        public virtual String trbecf_codigo { get; set; }
        [DataMember]
        public virtual String trbecf_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> trbecf_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> trbecf_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_ecf_ddDto tb_ecf { get; set; }
        [DataMember]
        public virtual tb_tributacaoDto tb_tributacao { get; set; }

        #endregion
    }
}
