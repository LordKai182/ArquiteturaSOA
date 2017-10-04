using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_cliente
    {
        #region Primitive Properties
        public virtual Int64 cli_id { get; set; }

        public virtual String cli_email { get; set; }

        public virtual Decimal cli_limite_compra { get; set; }

        public virtual Decimal cli_compra_acumulada { get; set; }

        public virtual DateTime cli_dt_bloqueio { get; set; }

        public virtual Decimal cli_qtd_bloqueio { get; set; }

        public virtual String cli_obs { get; set; }

        public virtual DateTime cli_dt_ultima_compra { get; set; }

        public virtual String cli_cpf_alteracao { get; set; }

        public virtual String cli_tip_pessoa { get; set; }

        public virtual Nullable<Int32> cli_titular_id { get; set; }

        public virtual String cli_cpf { get; set; }

        public virtual String cli_nome { get; set; }

        public virtual String cli_id_numero { get; set; }

        public virtual String cli_id_orgao_expedidor { get; set; }

        public virtual DateTime cli_id_dt_expedicao { get; set; }

        public virtual DateTime cli_dt_nascimento { get; set; }

        public virtual String cli_sexo { get; set; }

        public virtual String cli_estado_civil { get; set; }

        public virtual Decimal cli_nu_filhos { get; set; }

        public virtual String cli_nm_pai { get; set; }

        public virtual String cli_nm_mae { get; set; }

        public virtual String cli_cnpj { get; set; }

        public virtual Decimal cli_insc_estadual { get; set; }

        public virtual String cli_razao_social { get; set; }

        public virtual String cli_nome_fantasia { get; set; }

        public virtual String cli_cnpj_rede { get; set; }

        public virtual Decimal cli_vlr_credito { get; set; }

        public virtual Decimal cli_polo_distribuidor { get; set; }

        public virtual Decimal cli_perc_csub { get; set; }

        public virtual Decimal cli_perc_ssub { get; set; }

        public virtual Boolean cli_venda_imp_fracionada { get; set; }

        public virtual Boolean cli_venda_imp_princativo { get; set; }

        public virtual String cli_nm_contato { get; set; }

        public virtual String cli_situacao { get; set; }

        public virtual DateTime cli_dt_cadastro { get; set; }

        public virtual DateTime cli_dt_alteracao { get; set; }

        public virtual Int32 final_id { get; set; }

        public virtual Int32 subfin_id { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_cliente_endereco> _tb_cliente_endereco;
        public virtual ICollection<tb_cliente_endereco> tb_cliente_endereco
        {
            get
            {
                if (_tb_cliente_endereco == null)
                    _tb_cliente_endereco = new List<tb_cliente_endereco>();
                return _tb_cliente_endereco;
            }
            set { _tb_cliente_endereco = value; }
        }

        public virtual tb_cliente_bloqueio tb_cliente_bloqueio { get; set; }

        public virtual tb_promocao tb_promocao { get; set; }

        public virtual tb_uf tb_uf { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        private ICollection<tb_convenio> _tb_convenio;
        public virtual ICollection<tb_convenio> tb_convenio
        {
            get
            {
                if (_tb_convenio == null)
                    _tb_convenio = new List<tb_convenio>();
                return _tb_convenio;
            }
            set { _tb_convenio = value; }
        }

        private ICollection<tb_crediario> _tb_crediario;
        public virtual ICollection<tb_crediario> tb_crediario
        {
            get
            {
                if (_tb_crediario == null)
                    _tb_crediario = new List<tb_crediario>();
                return _tb_crediario;
            }
            set { _tb_crediario = value; }
        }

        private ICollection<tb_funcionario> _tb_funcionario;
        public virtual ICollection<tb_funcionario> tb_funcionario
        {
            get
            {
                if (_tb_funcionario == null)
                    _tb_funcionario = new List<tb_funcionario>();
                return _tb_funcionario;
            }
            set { _tb_funcionario = value; }
        }

        private ICollection<tb_venda_dav> _tb_venda_dav;
        public virtual ICollection<tb_venda_dav> tb_venda_dav
        {
            get
            {
                if (_tb_venda_dav == null)
                    _tb_venda_dav = new List<tb_venda_dav>();
                return _tb_venda_dav;
            }
            set { _tb_venda_dav = value; }
        }

        private ICollection<tb_venda_pagamento> _tb_venda_pagamento;
        public virtual ICollection<tb_venda_pagamento> tb_venda_pagamento
        {
            get
            {
                if (_tb_venda_pagamento == null)
                    _tb_venda_pagamento = new List<tb_venda_pagamento>();
                return _tb_venda_pagamento;
            }
            set { _tb_venda_pagamento = value; }
        }

        private ICollection<tb_venda_prevenda> _tb_venda_prevenda;
        public virtual ICollection<tb_venda_prevenda> tb_venda_prevenda
        {
            get
            {
                if (_tb_venda_prevenda == null)
                    _tb_venda_prevenda = new List<tb_venda_prevenda>();
                return _tb_venda_prevenda;
            }
            set { _tb_venda_prevenda = value; }
        }

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

        private ICollection<tbr_convenio_cliente> _tbr_convenio_cliente;
        public virtual ICollection<tbr_convenio_cliente> tbr_convenio_cliente
        {
            get
            {
                if (_tbr_convenio_cliente == null)
                    _tbr_convenio_cliente = new List<tbr_convenio_cliente>();
                return _tbr_convenio_cliente;
            }
            set { _tbr_convenio_cliente = value; }
        }

        #endregion
    }
    
}
