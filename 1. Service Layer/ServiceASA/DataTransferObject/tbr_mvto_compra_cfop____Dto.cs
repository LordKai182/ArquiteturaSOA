using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_mvto_compra_cfop____")]
    public partial class tbr_mvto_compra_cfop____Dto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cmp_id { get; set; }
        [DataMember]
        public virtual Int32 cfop_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> mvtoccfop_base_icms { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> mvtoccfop_aliq_icms { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> mvtoccfop_valor_icms { get; set; }
        [DataMember]
        public virtual String mvtoccfop_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> mvtoccfop_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> mvtoccfop_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> mvtoccfop_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_cfopDto tb_cfop { get; set; }
        [DataMember]
        public virtual tb_mvto_compra____Dto tb_mvto_compra____ { get; set; }

        #endregion
    }
}
