using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_sangrias")]
    public partial class tb_sangriasDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 sangriafl_pdv { get; set; }
        [DataMember]
        public virtual DateTime sangriaf_data { get; set; }
        [DataMember]
        public virtual Int32 sangriaf_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> sangriaf_valor { get; set; }
        [DataMember]
        public virtual Nullable<Int32> sangriaf_operadorCx { get; set; }
        [DataMember]
        public virtual String sangriaf_observacao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> sangriaf_responsavel { get; set; }
        [DataMember]
        public virtual String sangriaf_status { get; set; }
        [DataMember]
        public virtual Nullable<Int32> sangriaf_funcionario { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> sangriaf_dt_alteracao { get; set; }
        [DataMember]
        public virtual String sangriaf_cpf_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> final_id { get; set; }
        [DataMember]
        public virtual String sangriaf_md5 { get; set; }
        [DataMember]
        public virtual Nullable<Int32> bcaixa_id { get; set; }

        #endregion

    }
}
