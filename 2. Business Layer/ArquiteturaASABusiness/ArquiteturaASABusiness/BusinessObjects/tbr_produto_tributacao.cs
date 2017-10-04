using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_produto_tributacao
    {
        #region Primitive Properties
        public virtual Int32 pro_id { get; set; }

        public virtual Int32 uf_id { get; set; }

        public virtual String protrb_class_tributaria { get; set; }

        public virtual Nullable<Int32> protrb_origem_cst { get; set; }

        public virtual String protrb_situacao { get; set; }

        public virtual Nullable<DateTime> protrb_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> protrb_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_produto tb_produto { get; set; }

        public virtual tb_tributacao tb_tributacao { get; set; }

        public virtual tb_tributacao tb_tributacao1 { get; set; }

        public virtual tb_uf tb_uf { get; set; }

        #endregion
    }
    
}
