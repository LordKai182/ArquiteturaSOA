using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_dicionario_un")]
    public partial class tbr_dicionario_unDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 fab_id { get; set; }
        [DataMember]
        public virtual Int32 div_id { get; set; }
        [DataMember]
        public virtual String dicun_codigo { get; set; }
        [DataMember]
        public virtual String dicun_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> dicun_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> dicun_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
       [DataMember]
        public virtual tb_fornecedor_divisaoDto tb_fornecedor_divisao { get; set; }

        #endregion
    }
}
