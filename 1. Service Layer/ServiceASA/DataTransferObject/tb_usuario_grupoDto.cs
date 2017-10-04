using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_usuario_grupo")]
    public partial class tb_usuario_grupoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 grp_id { get; set; }
        [DataMember]
        public virtual String grp_nome { get; set; }
        [DataMember]
        public virtual String grp_diautil { get; set; }
        [DataMember]
        public virtual String grp_sabado { get; set; }
        [DataMember]
        public virtual String grp_domingo { get; set; }
        [DataMember]
        public virtual String grp_feriado { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> grp_tmp_senha { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> grp_acesso_filial_ilimitada { get; set; }
        [DataMember]
        public virtual String grp_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> grp_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> grp_dt_alteracao { get; set; }

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
