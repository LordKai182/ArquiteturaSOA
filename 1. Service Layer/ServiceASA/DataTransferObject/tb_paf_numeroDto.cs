using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_paf_numero")]
    public partial class tb_paf_numeroDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual String paf_ult_pv { get; set; }
        [DataMember]
        public virtual String paf_ult_dav { get; set; }

        #endregion

    }
}
