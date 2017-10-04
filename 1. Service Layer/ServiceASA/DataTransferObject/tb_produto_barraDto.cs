using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_produto_barra")]
    public partial class tb_produto_barraDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 pro_id { get; set; }
        [DataMember]
        public virtual Decimal barra_codigo { get; set; }
        [DataMember]
        public virtual String barra_tip_embalagem { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> barra_qtd_embalagem { get; set; }
        [DataMember]
        public virtual String barra_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> barra_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> barra_dt_alteracao { get; set; }
        [DataMember]
        public virtual String barra_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_produtoDto tb_produto { get; set; }

        #endregion
    }
}
