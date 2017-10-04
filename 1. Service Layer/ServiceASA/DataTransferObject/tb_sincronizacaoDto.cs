using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_sincronizacao")]
    public partial class tb_sincronizacaoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 id_sincronizacao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> id_registro { get; set; }
        [DataMember]
        public virtual String entidade_registro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> dt_inclusao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> status { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_terminalDto tb_terminal { get; set; }

        #endregion
    }
}
