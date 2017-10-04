using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_financeiro_suprimento")]
    public partial class tb_financeiro_suprimentoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 suprimentof_id { get; set; }
        [DataMember]
        public virtual DateTime suprimentof_data { get; set; }
        [DataMember]
        public virtual Decimal suprimentof_valor { get; set; }
        [DataMember]
        public virtual String suprimentof_observacao { get; set; }
        [DataMember]
        public virtual String suprimentof_cpf_responsavel { get; set; }
        [DataMember]
        public virtual String suprimentof_status { get; set; }
        [DataMember]
        public virtual String suprimentof_cpf_funcionario { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> suprimentof_dt_alteracao { get; set; }
        [DataMember]
        public virtual String suprimentof_cpf_alteracao { get; set; }
        [DataMember]
        public virtual String suprimentof_md5 { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_usuarioDto tb_usuario { get; set; }

        #endregion
    }
    
}
