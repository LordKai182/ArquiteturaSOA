using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_fornecedor_divisao
    {
        #region Primitive Properties
        public virtual Int32 fab_id { get; set; }

        public virtual Int32 div_id { get; set; }

        public virtual String div_nome { get; set; }

        public virtual String div_tip_logradouro { get; set; }

        public virtual String div_logradouro { get; set; }

        public virtual Nullable<Decimal> div_numero { get; set; }

        public virtual String div_complemento { get; set; }

        public virtual String div_bairro { get; set; }

        public virtual String div_cidade { get; set; }

        public virtual Nullable<Decimal> div_cod_municipio { get; set; }

        public virtual String div_cep { get; set; }

        public virtual String div_uf { get; set; }

        public virtual String div_ddd { get; set; }

        public virtual String div_telefone { get; set; }

        public virtual String div_ramal { get; set; }

        public virtual String div_fax { get; set; }

        public virtual String div_faxramal { get; set; }

        public virtual String div_cnpj { get; set; }

        public virtual Nullable<Decimal> div_insc_est { get; set; }

        public virtual String div_nm_represent { get; set; }

        public virtual String div_tel_represent { get; set; }

        public virtual String div_email_represent { get; set; }

        public virtual String div_nm_ger_regional { get; set; }

        public virtual String div_tel_ger_regional { get; set; }

        public virtual String div_email_ger_regional { get; set; }

        public virtual String div_nm_ger_nacional { get; set; }

        public virtual String div_tel_ger_nacional { get; set; }

        public virtual String div_email_ger_nacional { get; set; }

        public virtual String div_tipo_frete { get; set; }

        public virtual Nullable<Decimal> div_cond_pgto { get; set; }

        public virtual Nullable<Decimal> div_prazo_entrega { get; set; }

        public virtual Nullable<Decimal> div_pedido_min { get; set; }

        public virtual Nullable<Decimal> div_freq_compra { get; set; }

        public virtual String div_situacao { get; set; }

        public virtual Nullable<DateTime> div_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> div_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_checkin_tmp> _tb_checkin_tmp;
        public virtual ICollection<tb_checkin_tmp> tb_checkin_tmp
        {
            get
            {
                if (_tb_checkin_tmp == null)
                    _tb_checkin_tmp = new List<tb_checkin_tmp>();
                return _tb_checkin_tmp;
            }
            set { _tb_checkin_tmp = value; }
        }

        private ICollection<tb_empresa_privatelabel> _tb_empresa_privatelabel;
        public virtual ICollection<tb_empresa_privatelabel> tb_empresa_privatelabel
        {
            get
            {
                if (_tb_empresa_privatelabel == null)
                    _tb_empresa_privatelabel = new List<tb_empresa_privatelabel>();
                return _tb_empresa_privatelabel;
            }
            set { _tb_empresa_privatelabel = value; }
        }

        private ICollection<tb_empresa_recarga> _tb_empresa_recarga;
        public virtual ICollection<tb_empresa_recarga> tb_empresa_recarga
        {
            get
            {
                if (_tb_empresa_recarga == null)
                    _tb_empresa_recarga = new List<tb_empresa_recarga>();
                return _tb_empresa_recarga;
            }
            set { _tb_empresa_recarga = value; }
        }

        public virtual tb_fornecedor tb_fornecedor { get; set; }

        private ICollection<tb_mvto_compra____> _tb_mvto_compra____;
        public virtual ICollection<tb_mvto_compra____> tb_mvto_compra____
        {
            get
            {
                if (_tb_mvto_compra____ == null)
                    _tb_mvto_compra____ = new List<tb_mvto_compra____>();
                return _tb_mvto_compra____;
            }
            set { _tb_mvto_compra____ = value; }
        }

        private ICollection<tb_parametro_comissao> _tb_parametro_comissao;
        public virtual ICollection<tb_parametro_comissao> tb_parametro_comissao
        {
            get
            {
                if (_tb_parametro_comissao == null)
                    _tb_parametro_comissao = new List<tb_parametro_comissao>();
                return _tb_parametro_comissao;
            }
            set { _tb_parametro_comissao = value; }
        }

        private ICollection<tb_parametro_descconv> _tb_parametro_descconv;
        public virtual ICollection<tb_parametro_descconv> tb_parametro_descconv
        {
            get
            {
                if (_tb_parametro_descconv == null)
                    _tb_parametro_descconv = new List<tb_parametro_descconv>();
                return _tb_parametro_descconv;
            }
            set { _tb_parametro_descconv = value; }
        }

        private ICollection<tb_parametro_descmax> _tb_parametro_descmax;
        public virtual ICollection<tb_parametro_descmax> tb_parametro_descmax
        {
            get
            {
                if (_tb_parametro_descmax == null)
                    _tb_parametro_descmax = new List<tb_parametro_descmax>();
                return _tb_parametro_descmax;
            }
            set { _tb_parametro_descmax = value; }
        }

        private ICollection<tb_parametro_descprod> _tb_parametro_descprod;
        public virtual ICollection<tb_parametro_descprod> tb_parametro_descprod
        {
            get
            {
                if (_tb_parametro_descprod == null)
                    _tb_parametro_descprod = new List<tb_parametro_descprod>();
                return _tb_parametro_descprod;
            }
            set { _tb_parametro_descprod = value; }
        }

        private ICollection<tb_parametro_markup> _tb_parametro_markup;
        public virtual ICollection<tb_parametro_markup> tb_parametro_markup
        {
            get
            {
                if (_tb_parametro_markup == null)
                    _tb_parametro_markup = new List<tb_parametro_markup>();
                return _tb_parametro_markup;
            }
            set { _tb_parametro_markup = value; }
        }

        private ICollection<tb_pedido_compra____> _tb_pedido_compra____;
        public virtual ICollection<tb_pedido_compra____> tb_pedido_compra____
        {
            get
            {
                if (_tb_pedido_compra____ == null)
                    _tb_pedido_compra____ = new List<tb_pedido_compra____>();
                return _tb_pedido_compra____;
            }
            set { _tb_pedido_compra____ = value; }
        }

        private ICollection<tb_produto> _tb_produto;
        public virtual ICollection<tb_produto> tb_produto
        {
            get
            {
                if (_tb_produto == null)
                    _tb_produto = new List<tb_produto>();
                return _tb_produto;
            }
            set { _tb_produto = value; }
        }

        private ICollection<tbr_dicionario_un> _tbr_dicionario_un;
        public virtual ICollection<tbr_dicionario_un> tbr_dicionario_un
        {
            get
            {
                if (_tbr_dicionario_un == null)
                    _tbr_dicionario_un = new List<tbr_dicionario_un>();
                return _tbr_dicionario_un;
            }
            set { _tbr_dicionario_un = value; }
        }

        #endregion
    }
    
}
