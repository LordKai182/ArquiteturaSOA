using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_cliente_anvisa
    {
        #region Primitive Properties
        public virtual String cli_anv_num_documento { get; set; }

        public virtual String cli_anv_orgao_expedidor { get; set; }

        public virtual String cli_anv_nome { get; set; }

        public virtual String cli_anv_telefone { get; set; }

        public virtual DateTime cli_anv_data_cadastro { get; set; }

        public virtual Int32 usr_id { get; set; }

        public virtual Int32 uneg_id { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_uf tb_uf { get; set; }

        #endregion
    }
    
}
