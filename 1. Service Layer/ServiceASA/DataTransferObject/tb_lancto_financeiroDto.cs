using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_lancto_financeiro")]
    public partial class tb_lancto_financeiroDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 lanctof_pdv { get; set; }
        [DataMember]
        public virtual DateTime lanctof_data { get; set; }
        [DataMember]
        public virtual Int32 lanctof_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> lanctof_valor { get; set; }
        [DataMember]
        public virtual String lanctof_observacao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> lanctof_num_documento { get; set; }
        [DataMember]
        public virtual Nullable<Int32> lanctof_responsavel { get; set; }
        [DataMember]
        public virtual String lanctof_tipo_movimento { get; set; }
        [DataMember]
        public virtual String lanctof_tipo_operacao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> lanctof_funcionario_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> bancocx_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> lanctof_operadorCX { get; set; }
        [DataMember]
        public virtual String lanctof_md5 { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_financeiro_eventoDto tb_financeiro_evento { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
}
