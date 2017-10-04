using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_cliente_fiscal
    {
        #region Primitive Properties
        public virtual String cli_fisc_cpf_cnpj { get; set; }

        public virtual String cli_fisc_nome { get; set; }

        public virtual String cli_fisc_email { get; set; }

        public virtual String cli_fisc_endereco { get; set; }

        public virtual String cli_fisc_tp_logradouro { get; set; }

        public virtual Nullable<Int32> cli_fisc_numero { get; set; }

        public virtual String cli_fisc_complemento { get; set; }

        public virtual String cli_fisc_bairro { get; set; }

        public virtual String cli_fisc_cidade { get; set; }

        public virtual String cli_fisc_uf { get; set; }

        public virtual String cli_fisc_cep { get; set; }

        public virtual DateTime cli_fisc_data_cadastro { get; set; }

        public virtual String cli_fisc_ibge_codigo { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }

        private ICollection<tb_venda> _tb_venda;
        public virtual ICollection<tb_venda> tb_venda
        {
            get
            {
                if (_tb_venda == null)
                    _tb_venda = new List<tb_venda>();
                return _tb_venda;
            }
            set { _tb_venda = value; }
        }

        #endregion
    }
}
