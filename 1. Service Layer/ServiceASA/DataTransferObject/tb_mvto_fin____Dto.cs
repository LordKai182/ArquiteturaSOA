using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_mvto_fin____")]
    public partial class tb_mvto_fin____Dto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 mvtof_id { get; set; }
        [DataMember]
        public virtual DateTime mvtof_data { get; set; }
        [DataMember]
        public virtual Decimal mvtof_cod_caixa { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> mvtof_valor { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> mvtof_usr_respons { get; set; }
        [DataMember]
        public virtual String mvtof_historico { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> mvtof_usr_mat { get; set; }

        #endregion

    }
}
