using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_produto_fam_categoria")]
    public partial class tb_produto_fam_categoriaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 fam_id { get; set; }
        [DataMember]
        public virtual Int32 grp_id { get; set; }
        [DataMember]
        public virtual Int32 cat_id { get; set; }
        [DataMember]
        public virtual String cat_descricao { get; set; }
        [DataMember]
        public virtual String cat_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cat_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cat_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_produto_fam_categ_subDto> tb_produto_fam_categ_sub;
        //public virtual ICollection<tb_produto_fam_categ_sub> tb_produto_fam_categ_sub
        //{
        //    get
        //    {
        //        if (_tb_produto_fam_categ_sub == null)
        //            _tb_produto_fam_categ_sub = new List<tb_produto_fam_categ_sub>();
        //        return _tb_produto_fam_categ_sub;
        //    }
        //    set { _tb_produto_fam_categ_sub = value; }
        //}
        [DataMember]
        public virtual tb_produto_fam_grupoDto tb_produto_fam_grupo { get; set; }

        #endregion
    }
    
}
