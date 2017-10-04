using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_nfe_danfe
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 nfe_pdv { get; set; }

        public virtual Int32 nfe_id { get; set; }

        public virtual DateTime nfe_data { get; set; }

        public virtual String danfe_chave_acesso { get; set; }

        public virtual String danfe_xml { get; set; }

        public virtual String danfe_txt { get; set; }

        #endregion

    }
    
}
