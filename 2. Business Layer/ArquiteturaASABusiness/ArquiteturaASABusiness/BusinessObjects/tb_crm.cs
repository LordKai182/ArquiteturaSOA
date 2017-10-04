using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_crm
    {
        #region Primitive Properties
        public virtual Int32 crm_id { get; set; }

        public virtual String crm_tipo { get; set; }

        public virtual Int32 uf_id { get; set; }

        public virtual String crm_nome { get; set; }

        public virtual String crm_crm { get; set; }

        public virtual String crm_email { get; set; }

        public virtual String crm_sexo { get; set; }

        public virtual Nullable<DateTime> crm_dt_nascimento { get; set; }

        public virtual String crm_celular { get; set; }

        public virtual String crm_obs { get; set; }

        public virtual String crm_situacao { get; set; }

        public virtual Nullable<DateTime> crm_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> crm_dt_alteracao { get; set; }

        public virtual String crm_cpf_alteracao { get; set; }

        public virtual Nullable<Int32> esp_id { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_crm_endereco> _tb_crm_endereco;
        public virtual ICollection<tb_crm_endereco> tb_crm_endereco
        {
            get
            {
                if (_tb_crm_endereco == null)
                    _tb_crm_endereco = new List<tb_crm_endereco>();
                return _tb_crm_endereco;
            }
            set { _tb_crm_endereco = value; }
        }

        public virtual tb_uf tb_uf { get; set; }

        #endregion
    }
    
}
