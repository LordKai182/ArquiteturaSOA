using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_promocao_tipo")]
    public partial class tb_promocao_tipoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 tippro_id { get; set; }
        [DataMember]
        public virtual String tippro_descricao { get; set; }
        [DataMember]
        public virtual String tippro_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> tippro_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> tippro_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> tippro_cpf_alteracao { get; set; }

        #endregion

    }
    
}
