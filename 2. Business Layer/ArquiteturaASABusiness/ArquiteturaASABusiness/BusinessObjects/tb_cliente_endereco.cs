using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_cliente_endereco
    {
        #region Primitive Properties
        public virtual Int64 cli_id { get; set; }

        public virtual Int32 end_id { get; set; }

        public virtual String end_cep { get; set; }

        public virtual String end_tp_logradouro { get; set; }

        public virtual String end_nm_logradouro { get; set; }

        public virtual Nullable<Int32> end_numero { get; set; }

        public virtual String end_complemento { get; set; }

        public virtual String end_bairro { get; set; }

        public virtual String end_cidade { get; set; }

        public virtual String end_referencia { get; set; }

        public virtual String end_tipo { get; set; }

        public virtual String end_situacao { get; set; }

        public virtual Nullable<DateTime> end_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> end_dt_alteracao { get; set; }

        public virtual String end_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_cliente tb_cliente { get; set; }

        public virtual tb_uf tb_uf { get; set; }

        #endregion
    }
    
}
