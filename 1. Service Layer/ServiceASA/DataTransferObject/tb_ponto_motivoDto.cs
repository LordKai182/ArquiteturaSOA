using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_ponto_motivo")]
    public partial class tb_ponto_motivoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 motivo_id { get; set; }
        [DataMember]
        public virtual String motivo_descricao { get; set; }
        [DataMember]
        public virtual String motivo_situacao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_pontoDto> tb_ponto;
     

        #endregion
    }
}
