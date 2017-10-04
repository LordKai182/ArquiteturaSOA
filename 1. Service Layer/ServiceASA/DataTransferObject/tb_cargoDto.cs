using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_cargo")]
    public partial class tb_cargoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cargo_id { get; set; }
        [DataMember]
        public virtual String cargo_descricao { get; set; }
        [DataMember]
        public virtual String cargo_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cargo_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cargo_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_funcionarioDto> tb_funcionario;
        //public virtual ICollection<tb_funcionario> tb_funcionario
        //{
        //    get
        //    {
        //        if (_tb_funcionario == null)
        //            _tb_funcionario = new List<tb_funcionario>();
        //        return _tb_funcionario;
        //    }
        //    set { _tb_funcionario = value; }
        //}

        #endregion
    }
}
