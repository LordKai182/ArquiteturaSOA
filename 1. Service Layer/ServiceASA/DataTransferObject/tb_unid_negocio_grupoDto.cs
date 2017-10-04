using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_unid_negocio_grupo")]
    public partial class tb_unid_negocio_grupoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 guneg_id { get; set; }
        [DataMember]
        public virtual String guneg_descricao { get; set; }
        [DataMember]
        public virtual String guneg_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> guneg_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> guneg_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> guneg_cpf_alteracao { get; set; }

        #endregion

    }
}
