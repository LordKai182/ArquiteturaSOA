using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_convenio")]
    public partial class tb_convenioDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cnv_id { get; set; }
        [DataMember]
        public virtual String cnv_titulo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cnv_dia_fechamento { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cnv_tipo { get; set; }
        [DataMember]
        public virtual String cnv_tipo_pagamento { get; set; }
        [DataMember]
        public virtual String cnv_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cnv_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cnv_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_clienteDto tb_cliente { get; set; }
        [DataMember]
        public virtual tb_financeiro_prazoDto tb_financeiro_prazo { get; set; }

        private IList<tb_crediarioDto> tb_crediario;
        //public virtual ICollection<tb_crediario> tb_crediario
        //{
        //    get
        //    {
        //        if (_tb_crediario == null)
        //            _tb_crediario = new List<tb_crediario>();
        //        return _tb_crediario;
        //    }
        //    set { _tb_crediario = value; }
        //}

        private IList<tb_funcionarioDto> tb_funcionario;
        //public virtual ICollection<tb_funcionario> tb_funcionario
        //{
        //    get
        //    {
        //        if (_tb_funcionario == null)
        //            _tb_funcionario = new List<tb_funcionario>();
        //        return _tb_funcionario;
        //    }
        //    set { _tb_funcionario = value; }
        //}

        private IList<tb_parametro_descconvDto> tb_parametro_descconv;
        //public virtual ICollection<tb_parametro_descconv> tb_parametro_descconv
        //{
        //    get
        //    {
        //        if (_tb_parametro_descconv == null)
        //            _tb_parametro_descconv = new List<tb_parametro_descconv>();
        //        return _tb_parametro_descconv;
        //    }
        //    set { _tb_parametro_descconv = value; }
        //}

        private IList<tbr_convenio_clienteDto> tbr_convenio_cliente;
        //public virtual ICollection<tbr_convenio_cliente> tbr_convenio_cliente
        //{
        //    get
        //    {
        //        if (_tbr_convenio_cliente == null)
        //            _tbr_convenio_cliente = new List<tbr_convenio_cliente>();
        //        return _tbr_convenio_cliente;
        //    }
        //    set { _tbr_convenio_cliente = value; }
        //}

        private IList<tbr_convenio_finalizadora_subDto> tbr_convenio_finalizadora_sub;
        //public virtual ICollection<tbr_convenio_finalizadora_sub> tbr_convenio_finalizadora_sub
        //{
        //    get
        //    {
        //        if (_tbr_convenio_finalizadora_sub == null)
        //            _tbr_convenio_finalizadora_sub = new List<tbr_convenio_finalizadora_sub>();
        //        return _tbr_convenio_finalizadora_sub;
        //    }
        //    set { _tbr_convenio_finalizadora_sub = value; }
        //}

        private IList<tbr_convenio_unDto> tbr_convenio_un;
        //public virtual ICollection<tbr_convenio_un> tbr_convenio_un
        //{
        //    get
        //    {
        //        if (_tbr_convenio_un == null)
        //            _tbr_convenio_un = new List<tbr_convenio_un>();
        //        return _tbr_convenio_un;
        //    }
        //    set { _tbr_convenio_un = value; }
        //}

        private IList<tb_promocaoDto> tb_promocao;
        //public virtual ICollection<tb_promocao> tb_promocao
        //{
        //    get
        //    {
        //        if (_tb_promocao == null)
        //            _tb_promocao = new List<tb_promocao>();
        //        return _tb_promocao;
        //    }
        //    set { _tb_promocao = value; }
        //}

        #endregion
    }
}
