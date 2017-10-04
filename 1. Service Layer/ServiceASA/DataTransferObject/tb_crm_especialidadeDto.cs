using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_crm_especialidade")]
    public partial class tb_crm_especialidadeDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 esp_id { get; set; }
        [DataMember]
        public virtual String esp_descricao { get; set; }
        [DataMember]
        public virtual String esp_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> esp_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> esp_dt_alteracao { get; set; }

        #endregion

    }
}
