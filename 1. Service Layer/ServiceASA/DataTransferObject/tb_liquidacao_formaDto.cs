using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_liquidacao_forma")]
    public partial class tb_liquidacao_formaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 formaliq_id { get; set; }
        [DataMember]
        public virtual String formaliq_descricao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> formaliq_cpmf { get; set; }
        [DataMember]
        public virtual String formaliq_tipo { get; set; }
        [DataMember]
        public virtual String formaliq_infor_cheque { get; set; }
        [DataMember]
        public virtual String formaliq_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> formaliq_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> formaliq_dt_alteracao { get; set; }

        #endregion

    }
}
