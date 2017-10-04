using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_terminal_mobile")]
    public partial class tb_terminal_mobileDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 te_mobile_id { get; set; }
        [DataMember]
        public virtual String te_mobile_mac { get; set; }

        #endregion

    }
}
