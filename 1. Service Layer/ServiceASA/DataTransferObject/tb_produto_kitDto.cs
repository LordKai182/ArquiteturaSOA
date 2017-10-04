using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_produto_kit")]
    public partial class tb_produto_kitDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 pro_id { get; set; }
        [DataMember]
        public virtual Int32 kitpro_produto { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> kitpro_quantidade { get; set; }
        [DataMember]
        public virtual String kitpro_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> kitpro_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> kitpro_dt_alteracao { get; set; }

        #endregion

    }
}
