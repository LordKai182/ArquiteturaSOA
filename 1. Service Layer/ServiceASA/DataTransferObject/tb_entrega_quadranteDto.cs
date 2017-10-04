using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_entrega_quadrante")]
    public partial class tb_entrega_quadranteDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 quadra_id { get; set; }
        [DataMember]
        public virtual String quadra_coordenada { get; set; }
        [DataMember]
        public virtual String quadra_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> quadra_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> quadra_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> quadra_cpf_alteracao { get; set; }

        #endregion

    }
}
