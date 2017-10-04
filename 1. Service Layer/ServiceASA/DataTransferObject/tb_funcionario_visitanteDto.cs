using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_funcionario_visitante")]
    public partial class tb_funcionario_visitanteDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 funcvisit_id { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> funcvisit_dt_visita { get; set; }
        [DataMember]
        public virtual String funcvisit_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> funcvisit_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> funcvisit_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> func_id { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
}
