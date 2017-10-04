using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_paciente_anvisa")]
    public partial class tb_paciente_anvisaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int64 paciente_id { get; set; }
        [DataMember]
        public virtual String paciente_nome { get; set; }
        [DataMember]
        public virtual String paciente_sexo { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> paciente_dt_nascimento { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> paciente_dt_modific { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_ufDto tb_uf { get; set; }

        #endregion
    }
}
