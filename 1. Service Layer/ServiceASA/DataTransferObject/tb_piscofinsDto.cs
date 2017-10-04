using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{   [DataContract (Name = "tb_piscofins")]
    public partial class tb_piscofinsDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 piscofins_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> piscofins_cst { get; set; }
    [DataMember]
        public virtual Nullable<Decimal> piscofins_aliq_LP_pis { get; set; }
    [DataMember]
        public virtual Nullable<Decimal> piscofins_aliq_LP_cofins { get; set; }
    [DataMember]
        public virtual Nullable<Decimal> piscofins_aliq_LR_pis { get; set; }
    [DataMember]
        public virtual Nullable<Decimal> piscofins_aliq_LR_cofins { get; set; }
    [DataMember]
        public virtual String piscofins_situacao { get; set; }
    [DataMember]
        public virtual Nullable<DateTime> piscofins_dt_cadastro { get; set; }
    [DataMember]
        public virtual Nullable<DateTime> piscofins_dt_alteracao { get; set; }
    [DataMember]
        public virtual Nullable<Decimal> piscofins_cpf_alteracao { get; set; }
  
        #endregion
    
    }
}
