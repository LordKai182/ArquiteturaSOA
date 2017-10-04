using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_produto_fam_grupo")]
    public partial class tb_produto_fam_grupoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 fam_id { get; set; }
        [DataMember]
        public virtual Int32 grp_id { get; set; }
        [DataMember]
        public virtual String grp_descricao { get; set; }
        [DataMember]
        public virtual String grp_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> grp_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> grp_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_produto_fam_categoriaDto> tb_produto_fam_categoria;
        //public virtual ICollection<tb_produto_fam_categoria> tb_produto_fam_categoria
        //{
        //    get
        //    {
        //        if (_tb_produto_fam_categoria == null)
        //            _tb_produto_fam_categoria = new List<tb_produto_fam_categoria>();
        //        return _tb_produto_fam_categoria;
        //    }
        //    set { _tb_produto_fam_categoria = value; }
        //}
        [DataMember]
        public virtual tb_produto_familiaDto tb_produto_familia { get; set; }

        #endregion
    }
}
