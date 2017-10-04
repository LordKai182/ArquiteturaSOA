using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_produto_familia")]
    public partial class tb_produto_familiaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 fam_id { get; set; }
        [DataMember]
        public virtual String fam_descricao { get; set; }
        [DataMember]
        public virtual String fam_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> fam_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> fam_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_produto_fam_grupoDto> tb_produto_fam_grupo;
        //public virtual ICollection<tb_produto_fam_grupo> tb_produto_fam_grupo
        //{
        //    get
        //    {
        //        if (_tb_produto_fam_grupo == null)
        //            _tb_produto_fam_grupo = new List<tb_produto_fam_grupo>();
        //        return _tb_produto_fam_grupo;
        //    }
        //    set { _tb_produto_fam_grupo = value; }
        //}

        #endregion
    }
}
