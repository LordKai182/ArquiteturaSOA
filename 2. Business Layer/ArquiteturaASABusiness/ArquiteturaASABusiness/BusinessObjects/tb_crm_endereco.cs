using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_crm_endereco
    {
        #region Primitive Properties
        public virtual Int32 crm_end_id { get; set; }

        public virtual Int32 crm_id { get; set; }

        public virtual Int32 uf_id { get; set; }

        public virtual String crm_tipo { get; set; }

        public virtual String crm_end_tel { get; set; }

        public virtual String crm_end_cep { get; set; }

        public virtual String crm_end_tp_logradouro { get; set; }

        public virtual String crm_end_nm_logradouro { get; set; }

        public virtual Nullable<Int32> crm_end_numero { get; set; }

        public virtual String crm_end_complemento { get; set; }

        public virtual String crm_end_bairro { get; set; }

        public virtual String crm_end_referencia { get; set; }

        public virtual String crm_end_cidade { get; set; }

        public virtual String crm_end_situacao { get; set; }

        public virtual Nullable<DateTime> crm_end_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> crm_end_dt_alteracao { get; set; }

        public virtual String crm_end_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_crm tb_crm { get; set; }

        #endregion
    }
}
