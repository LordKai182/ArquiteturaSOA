using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_conta")]
    public partial class tb_contaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 grau_id { get; set; }
        [DataMember]
        public virtual String grau_1 { get; set; }
        [DataMember]
        public virtual String grau_2 { get; set; }
        [DataMember]
        public virtual String grau_3 { get; set; }
        [DataMember]
        public virtual String grau_descricao { get; set; }

        #endregion

    }
}
