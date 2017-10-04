using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_princ_ativo")]
    public partial class tb_princ_ativoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 pat_id { get; set; }
        [DataMember]
        public virtual String pat_descricao { get; set; }
        [DataMember]
        public virtual DateTime pat_dt_alteracao { get; set; }

        #endregion

    }
}
