using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_convenio
    {
        #region Primitive Properties
        public virtual Int32 cnv_id { get; set; }

        public virtual String cnv_titulo { get; set; }

        public virtual Nullable<Decimal> cnv_dia_fechamento { get; set; }

        public virtual Nullable<Decimal> cnv_tipo { get; set; }

        public virtual String cnv_tipo_pagamento { get; set; }

        public virtual String cnv_situacao { get; set; }

        public virtual Nullable<DateTime> cnv_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> cnv_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_cliente tb_cliente { get; set; }

        public virtual tb_financeiro_prazo tb_financeiro_prazo { get; set; }

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

        private ICollection<tbr_convenio_finalizadora_sub> _tbr_convenio_finalizadora_sub;
        public virtual ICollection<tbr_convenio_finalizadora_sub> tbr_convenio_finalizadora_sub
        {
            get
            {
                if (_tbr_convenio_finalizadora_sub == null)
                    _tbr_convenio_finalizadora_sub = new List<tbr_convenio_finalizadora_sub>();
                return _tbr_convenio_finalizadora_sub;
            }
            set { _tbr_convenio_finalizadora_sub = value; }
        }

        private ICollection<tbr_convenio_un> _tbr_convenio_un;
        public virtual ICollection<tbr_convenio_un> tbr_convenio_un
        {
            get
            {
                if (_tbr_convenio_un == null)
                    _tbr_convenio_un = new List<tbr_convenio_un>();
                return _tbr_convenio_un;
            }
            set { _tbr_convenio_un = value; }
        }

        private ICollection<tb_promocao> _tb_promocao;
        public virtual ICollection<tb_promocao> tb_promocao
        {
            get
            {
                if (_tb_promocao == null)
                    _tb_promocao = new List<tb_promocao>();
                return _tb_promocao;
            }
            set { _tb_promocao = value; }
        }

        #endregion
    }
    
}
