using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_funcionario_horario_item")]
    public partial class tb_funcionario_horario_itemDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 hora_id { get; set; }
        [DataMember]
        public virtual String ihora_dia { get; set; }
        [DataMember]
        public virtual String ihora_entrada { get; set; }
        [DataMember]
        public virtual String ihora_almoco_saida { get; set; }
        [DataMember]
        public virtual String ihora_almoco_retorno { get; set; }
        [DataMember]
        public virtual String ihora_saida { get; set; }
        [DataMember]
        public virtual String ihora_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> ihora_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> ihora_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> ihora_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_funcionario_horarioDto tb_funcionario_horario { get; set; }

        #endregion
    }
}
