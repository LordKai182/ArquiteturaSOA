using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_banco")]
    public partial class tb_bancoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 banco_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> banco_codigo { get; set; }
        [DataMember]
        public virtual String banco_nome { get; set; }
        [DataMember]
        public virtual String banco_tipo { get; set; }
        [DataMember]
        public virtual String banco_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> banco_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> banco_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> banco_cpf_alteracao { get; set; }

        #endregion

    }
}
