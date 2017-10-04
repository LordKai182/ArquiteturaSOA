using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_uf
    {
        #region Primitive Properties
        public virtual Int32 uf_id { get; set; }

        public virtual String uf_sigla { get; set; }

        public virtual String uf_descricao { get; set; }

        public virtual String uf_situacao { get; set; }

        public virtual Nullable<DateTime> uf_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> uf_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_cliente> _tb_cliente;
        public virtual ICollection<tb_cliente> tb_cliente
        {
            get
            {
                if (_tb_cliente == null)
                    _tb_cliente = new List<tb_cliente>();
                return _tb_cliente;
            }
            set { _tb_cliente = value; }
        }

        private ICollection<tb_cliente_anvisa> _tb_cliente_anvisa;
        public virtual ICollection<tb_cliente_anvisa> tb_cliente_anvisa
        {
            get
            {
                if (_tb_cliente_anvisa == null)
                    _tb_cliente_anvisa = new List<tb_cliente_anvisa>();
                return _tb_cliente_anvisa;
            }
            set { _tb_cliente_anvisa = value; }
        }

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

        private ICollection<tb_crm> _tb_crm;
        public virtual ICollection<tb_crm> tb_crm
        {
            get
            {
                if (_tb_crm == null)
                    _tb_crm = new List<tb_crm>();
                return _tb_crm;
            }
            set { _tb_crm = value; }
        }

        private ICollection<tb_ibge> _tb_ibge;
        public virtual ICollection<tb_ibge> tb_ibge
        {
            get
            {
                if (_tb_ibge == null)
                    _tb_ibge = new List<tb_ibge>();
                return _tb_ibge;
            }
            set { _tb_ibge = value; }
        }

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

        private ICollection<tb_paciente_anvisa> _tb_paciente_anvisa;
        public virtual ICollection<tb_paciente_anvisa> tb_paciente_anvisa
        {
            get
            {
                if (_tb_paciente_anvisa == null)
                    _tb_paciente_anvisa = new List<tb_paciente_anvisa>();
                return _tb_paciente_anvisa;
            }
            set { _tb_paciente_anvisa = value; }
        }

        public virtual tb_uf tb_uf1 { get; set; }

        public virtual tb_uf tb_uf2 { get; set; }

        private ICollection<tb_unid_negocio> _tb_unid_negocio;
        public virtual ICollection<tb_unid_negocio> tb_unid_negocio
        {
            get
            {
                if (_tb_unid_negocio == null)
                    _tb_unid_negocio = new List<tb_unid_negocio>();
                return _tb_unid_negocio;
            }
            set { _tb_unid_negocio = value; }
        }

        private ICollection<tbr_abcfarma_uf> _tbr_abcfarma_uf;
        public virtual ICollection<tbr_abcfarma_uf> tbr_abcfarma_uf
        {
            get
            {
                if (_tbr_abcfarma_uf == null)
                    _tbr_abcfarma_uf = new List<tbr_abcfarma_uf>();
                return _tbr_abcfarma_uf;
            }
            set { _tbr_abcfarma_uf = value; }
        }

        private ICollection<tbr_produto_tributacao> _tbr_produto_tributacao;
        public virtual ICollection<tbr_produto_tributacao> tbr_produto_tributacao
        {
            get
            {
                if (_tbr_produto_tributacao == null)
                    _tbr_produto_tributacao = new List<tbr_produto_tributacao>();
                return _tbr_produto_tributacao;
            }
            set { _tbr_produto_tributacao = value; }
        }

        #endregion
    }
}
