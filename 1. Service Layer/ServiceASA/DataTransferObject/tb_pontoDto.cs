using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_ponto")]
    public partial class tb_pontoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 ponto_id { get; set; }
        [DataMember]
        public virtual DateTime ponto_dt_ponto { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> ponto_hr_entrada { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> ponto_hr_almoco_inicio { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> ponto_hr_almoco_fim { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> ponto_hr_saida { get; set; }
        [DataMember]
        public virtual Int32 func_id { get; set; }
        [DataMember]
        public virtual String ponto_situacao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_ponto_motivoDto tb_ponto_motivo { get; set; }
        [DataMember]
        public virtual tb_usuarioDto tb_usuario { get; set; }

        #endregion
    }
}
