using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_dicionario_produto")]
    public partial class tbr_dicionario_produtoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 fab_id { get; set; }
        [DataMember]
        public virtual Int32 pro_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> dicprod_qtde_embal { get; set; }
        [DataMember]
        public virtual String dicprod_tipo_embal { get; set; }
        [DataMember]
        public virtual String dicprod_codigo { get; set; }
        [DataMember]
        public virtual String dicprod_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> dicprod_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> dicprod_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
       [DataMember]
        public virtual tb_fornecedorDto tb_fornecedor { get; set; }
        [DataMember]
        public virtual tb_produtoDto tb_produto { get; set; }

        #endregion
    }
}
