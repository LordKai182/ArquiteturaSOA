using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_produto_tributacao")]
    public partial class tbr_produto_tributacaoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 pro_id { get; set; }
        [DataMember]
        public virtual Int32 uf_id { get; set; }
        [DataMember]
        public virtual String protrb_class_tributaria { get; set; }
        [DataMember]
        public virtual Nullable<Int32> protrb_origem_cst { get; set; }
        [DataMember]
        public virtual String protrb_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> protrb_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> protrb_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_produtoDto tb_produto { get; set; }
        [DataMember]
        public virtual tb_tributacaoDto tb_tributacao { get; set; }
        [DataMember]
        public virtual tb_tributacaoDto tb_tributacao1 { get; set; }
        [DataMember]
        public virtual tb_ufDto tb_uf { get; set; }

        #endregion
    }
}
