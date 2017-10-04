using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_financeiro_prazo")]
    public partial class tb_financeiro_prazoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 prazo_id { get; set; }
        [DataMember]
        public virtual String prazo_titulo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> prazo_tipo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> prazo_qtd_meses { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> prazo_qtd_dias { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> prazo_fora_a { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> prazo_nu_parcelas { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> prazo_entrada { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> prazo_intervalo_dias { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> prazo_nu_retorno_tef { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> prazo_inibe_promocao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> prazo_pratica_pmc { get; set; }
        [DataMember]
        public virtual String prazo_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> prazo_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> prazo_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_convenioDto> tb_convenio;
        //public virtual ICollection<tb_convenio> tb_convenio
        //{
        //    get
        //    {
        //        if (_tb_convenio == null)
        //            _tb_convenio = new List<tb_convenio>();
        //        return _tb_convenio;
        //    }
        //    set { _tb_convenio = value; }
        //}

        private IList<tb_empresa_privatelabelDto> stb_empresa_privatelabel;
        //public virtual ICollection<tb_empresa_privatelabel> tb_empresa_privatelabel
        //{
        //    get
        //    {
        //        if (_tb_empresa_privatelabel == null)
        //            _tb_empresa_privatelabel = new List<tb_empresa_privatelabel>();
        //        return _tb_empresa_privatelabel;
        //    }
        //    set { _tb_empresa_privatelabel = value; }
        //}

        private IList<tb_empresa_recargaDto> tb_empresa_recarga;
        //public virtual ICollection<tb_empresa_recarga> tb_empresa_recarga
        //{
        //    get
        //    {
        //        if (_tb_empresa_recarga == null)
        //            _tb_empresa_recarga = new List<tb_empresa_recarga>();
        //        return _tb_empresa_recarga;
        //    }
        //    set { _tb_empresa_recarga = value; }
        //}

        private IList<tb_finalizadora_subDto> tb_finalizadora_sub;
        //public virtual ICollection<tb_finalizadora_sub> tb_finalizadora_sub
        //{
        //    get
        //    {
        //        if (_tb_finalizadora_sub == null)
        //            _tb_finalizadora_sub = new List<tb_finalizadora_sub>();
        //        return _tb_finalizadora_sub;
        //    }
        //    set { _tb_finalizadora_sub = value; }
        //}

        private IList<tb_mvto_compra____Dto> tb_mvto_compra____;
        //public virtual ICollection<tb_mvto_compra____> tb_mvto_compra____
        //{
        //    get
        //    {
        //        if (_tb_mvto_compra____ == null)
        //            _tb_mvto_compra____ = new List<tb_mvto_compra____>();
        //        return _tb_mvto_compra____;
        //    }
        //    set { _tb_mvto_compra____ = value; }
        //}

        private IList<tb_privatelabel_finalizadoraDto> tb_privatelabel_finalizadora;
        //public virtual ICollection<tb_privatelabel_finalizadora> tb_privatelabel_finalizadora
        //{
        //    get
        //    {
        //        if (_tb_privatelabel_finalizadora == null)
        //            _tb_privatelabel_finalizadora = new List<tb_privatelabel_finalizadora>();
        //        return _tb_privatelabel_finalizadora;
        //    }
        //    set { _tb_privatelabel_finalizadora = value; }
        //}

        private IList<tb_recarga_finalizadoraDto> tb_recarga_finalizadora;
        //public virtual ICollection<tb_recarga_finalizadora> tb_recarga_finalizadora
        //{
        //    get
        //    {
        //        if (_tb_recarga_finalizadora == null)
        //            _tb_recarga_finalizadora = new List<tb_recarga_finalizadora>();
        //        return _tb_recarga_finalizadora;
        //    }
        //    set { _tb_recarga_finalizadora = value; }
        //}

        private IList<tb_venda_pagamentoDto> tb_venda_pagamento;
        //public virtual ICollection<tb_venda_pagamento> tb_venda_pagamento
        //{
        //    get
        //    {
        //        if (_tb_venda_pagamento == null)
        //            _tb_venda_pagamento = new List<tb_venda_pagamento>();
        //        return _tb_venda_pagamento;
        //    }
        //    set { _tb_venda_pagamento = value; }
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

        #endregion
    }
}
