using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_usuario
    {
        #region Primitive Properties
        public virtual Int32 usr_id { get; set; }

        public virtual String usr_cpf { get; set; }

        public virtual String usr_nome { get; set; }

        public virtual String usr_apelido { get; set; }

        public virtual String usr_senha_local { get; set; }

        public virtual Nullable<DateTime> usr_senha_tmp { get; set; }

        public virtual Nullable<DateTime> usr_dt_alteracao_sync { get; set; }

        public virtual String usr_situacao { get; set; }

        public virtual Nullable<DateTime> usr_blq_dt_inicial { get; set; }

        public virtual Nullable<DateTime> usr_blq_dt_final { get; set; }

        public virtual Nullable<DateTime> usr_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> usr_dt_alteracao { get; set; }

        public virtual Nullable<Boolean> usr_online { get; set; }

        public virtual Nullable<Int32> func_id { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_agenda_produto> _tb_agenda_produto;
        public virtual ICollection<tb_agenda_produto> tb_agenda_produto
        {
            get
            {
                if (_tb_agenda_produto == null)
                    _tb_agenda_produto = new List<tb_agenda_produto>();
                return _tb_agenda_produto;
            }
            set { _tb_agenda_produto = value; }
        }

        private ICollection<tb_agenda_produto> _tb_agenda_produto1;
        public virtual ICollection<tb_agenda_produto> tb_agenda_produto1
        {
            get
            {
                if (_tb_agenda_produto1 == null)
                    _tb_agenda_produto1 = new List<tb_agenda_produto>();
                return _tb_agenda_produto1;
            }
            set { _tb_agenda_produto1 = value; }
        }

        private ICollection<tb_cliente_fiscal> _tb_cliente_fiscal;
        public virtual ICollection<tb_cliente_fiscal> tb_cliente_fiscal
        {
            get
            {
                if (_tb_cliente_fiscal == null)
                    _tb_cliente_fiscal = new List<tb_cliente_fiscal>();
                return _tb_cliente_fiscal;
            }
            set { _tb_cliente_fiscal = value; }
        }

        private ICollection<tb_financeiro_sangria> _tb_financeiro_sangria;
        public virtual ICollection<tb_financeiro_sangria> tb_financeiro_sangria
        {
            get
            {
                if (_tb_financeiro_sangria == null)
                    _tb_financeiro_sangria = new List<tb_financeiro_sangria>();
                return _tb_financeiro_sangria;
            }
            set { _tb_financeiro_sangria = value; }
        }

        private ICollection<tb_financeiro_suprimento> _tb_financeiro_suprimento;
        public virtual ICollection<tb_financeiro_suprimento> tb_financeiro_suprimento
        {
            get
            {
                if (_tb_financeiro_suprimento == null)
                    _tb_financeiro_suprimento = new List<tb_financeiro_suprimento>();
                return _tb_financeiro_suprimento;
            }
            set { _tb_financeiro_suprimento = value; }
        }

        private ICollection<tb_parametro_descvend> _tb_parametro_descvend;
        public virtual ICollection<tb_parametro_descvend> tb_parametro_descvend
        {
            get
            {
                if (_tb_parametro_descvend == null)
                    _tb_parametro_descvend = new List<tb_parametro_descvend>();
                return _tb_parametro_descvend;
            }
            set { _tb_parametro_descvend = value; }
        }

        private ICollection<tb_ponto> _tb_ponto;
        public virtual ICollection<tb_ponto> tb_ponto
        {
            get
            {
                if (_tb_ponto == null)
                    _tb_ponto = new List<tb_ponto>();
                return _tb_ponto;
            }
            set { _tb_ponto = value; }
        }

        public virtual tb_usuario_bloqueio tb_usuario_bloqueio { get; set; }

        public virtual tb_usuario_dpto tb_usuario_dpto { get; set; }

        public virtual tb_usuario_grupo tb_usuario_grupo { get; set; }

        public virtual tb_usuario_funcao tb_usuario_funcao { get; set; }

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

        private ICollection<tb_venda_prevenda_item> _tb_venda_prevenda_item;
        public virtual ICollection<tb_venda_prevenda_item> tb_venda_prevenda_item
        {
            get
            {
                if (_tb_venda_prevenda_item == null)
                    _tb_venda_prevenda_item = new List<tb_venda_prevenda_item>();
                return _tb_venda_prevenda_item;
            }
            set { _tb_venda_prevenda_item = value; }
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

        #endregion
    }
}
