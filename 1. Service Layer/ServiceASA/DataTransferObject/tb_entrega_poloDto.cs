using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_entrega_polo")]
    public partial class tb_entrega_poloDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 polo_id { get; set; }
        [DataMember]
        public virtual String polo_descricao { get; set; }
        [DataMember]
        public virtual String polo_localizacao { get; set; }
        [DataMember]
        public virtual String polo_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> polo_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> polo_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> polo_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
}
