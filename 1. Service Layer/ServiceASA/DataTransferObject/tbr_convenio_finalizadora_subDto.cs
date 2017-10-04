using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_convenio_finalizadora_sub")]
    public partial class tbr_convenio_finalizadora_subDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cnv_id { get; set; }
        [DataMember]
        public virtual Int32 final_id { get; set; }
        [DataMember]
        public virtual Int32 subfin_id { get; set; }
        [DataMember]
        public virtual String cfinaliza_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cfinaliza_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cfinaliza_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cfinaliza_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_convenioDto tb_convenio { get; set; }

        #endregion
    }
}
