using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_entrega_polo_bairro")]
    public partial class tb_entrega_polo_bairroDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 bairro_id { get; set; }
        [DataMember]
        public virtual Int32 polo_id { get; set; }
        [DataMember]
        public virtual String bairro_bairro { get; set; }
        [DataMember]
        public virtual String bairro_municipio { get; set; }
        [DataMember]
        public virtual String bairro_estado { get; set; }
        [DataMember]
        public virtual String bairro_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> bairro_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> bairro_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> bairro_cpf_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> rota_id { get; set; }

        #endregion

    }
}
