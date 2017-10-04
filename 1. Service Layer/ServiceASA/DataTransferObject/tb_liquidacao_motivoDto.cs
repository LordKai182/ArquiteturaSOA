using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_liquidacao_motivo")]
    public partial class tb_liquidacao_motivoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 motivoliq_id { get; set; }
        [DataMember]
        public virtual String motivoliq_descricao { get; set; }
        [DataMember]
        public virtual String motivoliq_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> motivoliq_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> motivoliq_dt_alteracao { get; set; }

        #endregion

    }
}
