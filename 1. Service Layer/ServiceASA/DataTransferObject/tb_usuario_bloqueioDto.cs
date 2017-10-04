using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_usuario_bloqueio")]
    public partial class tb_usuario_bloqueioDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 bloq_id { get; set; }
        [DataMember]
        public virtual String bloq_descricao { get; set; }
        [DataMember]
        public virtual String bloq_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> bloq_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> bloq_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_usuarioDto> tb_usuario;
        //public virtual ICollection<tb_usuario> tb_usuario
        //{
        //    get
        //    {
        //        if (_tb_usuario == null)
        //            _tb_usuario = new List<tb_usuario>();
        //        return _tb_usuario;
        //    }
        //    set { _tb_usuario = value; }
        //}

        #endregion
    }
}
