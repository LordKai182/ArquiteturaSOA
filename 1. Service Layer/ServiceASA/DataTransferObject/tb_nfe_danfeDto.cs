using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_nfe_danfe")]
    public partial class tb_nfe_danfeDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 nfe_pdv { get; set; }
        [DataMember]
        public virtual Int32 nfe_id { get; set; }
        [DataMember]
        public virtual DateTime nfe_data { get; set; }
        [DataMember]
        public virtual String danfe_chave_acesso { get; set; }
        [DataMember]
        public virtual String danfe_xml { get; set; }
        [DataMember]
        public virtual String danfe_txt { get; set; }

        #endregion

    }
}
