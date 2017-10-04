using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_suprimentos")]
    public partial class tb_suprimentosDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 suprimentof_pdv { get; set; }
        [DataMember]
        public virtual DateTime suprimentof_data { get; set; }
        [DataMember]
        public virtual Int32 suprimentof_id { get; set; }
        [DataMember]
        public virtual Decimal suprimentof_valor { get; set; }
        [DataMember]
        public virtual Int32 suprimentof_operadorCx { get; set; }
        [DataMember]
        public virtual String suprimentof_observacao { get; set; }
        [DataMember]
        public virtual Int32 suprimentof_responsavel { get; set; }
        [DataMember]
        public virtual String suprimentof_status { get; set; }
        [DataMember]
        public virtual Nullable<Int32> suprimentof_funcionario { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> suprimentof_dt_alteracao { get; set; }
        [DataMember]
        public virtual String suprimentof_cpf_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> final_id { get; set; }
        [DataMember]
        public virtual String suprimentof_md5 { get; set; }
        [DataMember]
        public virtual Nullable<Int32> bcaixa_id { get; set; }

        #endregion

    }
}
