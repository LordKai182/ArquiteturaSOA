using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_tipo_mvto_produto")]
    public partial class tb_tipo_mvto_produtoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cdmvto_codigo { get; set; }
        [DataMember]
        public virtual String cdmvto_descricao { get; set; }
        [DataMember]
        public virtual String cdmvto_tipo { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> cdmvto_lanc_manual { get; set; }
        [DataMember]
        public virtual String cdmvto_cd_anvisa { get; set; }
        [DataMember]
        public virtual String cdmvto_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cdmvto_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cdmvto_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_tipo_notaDto> tb_tipo_nota;
        //public virtual ICollection<tb_tipo_nota> tb_tipo_nota
        //{
        //    get
        //    {
        //        if (_tb_tipo_nota == null)
        //            _tb_tipo_nota = new List<tb_tipo_nota>();
        //        return _tb_tipo_nota;
        //    }
        //    set { _tb_tipo_nota = value; }
        //}

        #endregion
    }
}
