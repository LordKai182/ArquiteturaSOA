using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_cliente_telefone")]
    public partial class tb_cliente_telefoneDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int64 cli_id { get; set; }
        [DataMember]
        public virtual Int32 tel_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> tel_tipo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> tel_cod_area { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> tel_numero { get; set; }
        [DataMember]
        public virtual String tel_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> tel_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> tel_dt_alteracao { get; set; }
        [DataMember]
        public virtual String tel_cpf_alteracao { get; set; }

        #endregion

    }
}
