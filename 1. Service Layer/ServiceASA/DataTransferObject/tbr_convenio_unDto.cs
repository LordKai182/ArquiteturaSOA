using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_convenio_un")]
    public partial class tbr_convenio_unDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cnv_id { get; set; }
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual String convun_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> convun_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> convun_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> convun_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_convenioDto tb_convenio { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
    
}
