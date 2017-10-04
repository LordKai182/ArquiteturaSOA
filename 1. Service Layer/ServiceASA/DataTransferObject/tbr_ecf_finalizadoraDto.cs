using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_ecf_finalizadora")]
    public partial class tbr_ecf_finalizadoraDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 final_id { get; set; }
        [DataMember]
        public virtual String ecf_numero_serie { get; set; }
        [DataMember]
        public virtual String finalecf_codigo { get; set; }
        [DataMember]
        public virtual Boolean finalecf_cupom_vinculado { get; set; }
        [DataMember]
        public virtual String finalecf_situacao { get; set; }
        [DataMember]
        public virtual DateTime finalecf_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> finalecf_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_ecfDto tb_ecf { get; set; }
        [DataMember]
        public virtual tb_finalizadoraDto tb_finalizadora { get; set; }

        #endregion
    }
}
