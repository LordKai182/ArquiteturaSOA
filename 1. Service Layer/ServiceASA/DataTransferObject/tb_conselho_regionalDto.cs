using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_conselho_regional")]
    public partial class tb_conselho_regionalDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cr_id { get; set; }
        [DataMember]
        public virtual Decimal cr_numero { get; set; }
        [DataMember]
        public virtual String cr_nome { get; set; }
        [DataMember]
        public virtual String cr_cons_uf { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cr_especialidade_id { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_conselhoDto tb_conselho { get; set; }

        #endregion
    }
    
}
