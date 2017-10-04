using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_pbm")]
    public partial class tb_pbmDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 pbm_id { get; set; }
        [DataMember]
        public virtual String pbm_descricao { get; set; }

        #endregion

    }
}
