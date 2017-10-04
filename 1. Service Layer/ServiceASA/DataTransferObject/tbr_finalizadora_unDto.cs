using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_finalizadora_un")]
    public partial class tbr_finalizadora_unDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 final_id { get; set; }
        [DataMember]
        public virtual String finalun_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> finalun_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> finalun_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> finalun_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_finalizadoraDto tb_finalizadora { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
    
}
