using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_dpto_aplicativo")]
    public partial class tbr_dpto_aplicativoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 dpto_id { get; set; }
        [DataMember]
        public virtual Int32 apl_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> dptapl_acesso { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dptapl_inclusao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dptapl_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dptapl_exclusao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dptapl_impressao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dptapl_exp_xls { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dptapl_exp_pdf { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dptapl_exp_txt { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dptapl_processo { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dptapl_edicao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> dptapl_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> dptapl_dt_alteracao { get; set; }
        [DataMember]
        public virtual String dptapl_aplicacao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_usuario_dptoDto tb_usuario_dpto { get; set; }

        #endregion
    }
}
