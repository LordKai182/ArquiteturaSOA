using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_finalizadora")]
    public partial class tb_finalizadoraDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 final_id { get; set; }
        [DataMember]
        public virtual String final_descricao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> final_permite_troco { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> final_permite_sangria { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> final_vlr_sangria_aviso { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> final_vlr_sangria_bloqueio { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> final_consulta_cli_tef { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> final_venda_tef { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> final_obriga_cliente { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> final_solicita_dados_ch { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> final_tipo_convenio { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> final_obriga_autenticacao { get; set; }
        [DataMember]
        public virtual String final_tecla_atalho { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> final_db_folha { get; set; }
        [DataMember]
        public virtual Nullable<Int32> final_emite_recibo { get; set; }
        [DataMember]
        public virtual String final_situacao { get; set; }
        [DataMember]
        public virtual String final_imagem { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> final_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> final_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_ecf_ddDto> tb_ecf_dd;
        //public virtual ICollection<tb_ecf_dd> tb_ecf_dd
        //{
        //    get
        //    {
        //        if (_tb_ecf_dd == null)
        //            _tb_ecf_dd = new List<tb_ecf_dd>();
        //        return _tb_ecf_dd;
        //    }
        //    set { _tb_ecf_dd = value; }
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

        private IList<tb_financeiro_sangriaDto> tb_financeiro_sangria;
        //public virtual ICollection<tb_financeiro_sangria> tb_financeiro_sangria
        //{
        //    get
        //    {
        //        if (_tb_financeiro_sangria == null)
        //            _tb_financeiro_sangria = new List<tb_financeiro_sangria>();
        //        return _tb_financeiro_sangria;
        //    }
        //    set { _tb_financeiro_sangria = value; }
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

        private IList<tbr_ecf_finalizadoraDto> tbr_ecf_finalizadora;
        //public virtual ICollection<tbr_ecf_finalizadora> tbr_ecf_finalizadora
        //{
        //    get
        //    {
        //        if (_tbr_ecf_finalizadora == null)
        //            _tbr_ecf_finalizadora = new List<tbr_ecf_finalizadora>();
        //        return _tbr_ecf_finalizadora;
        //    }
        //    set { _tbr_ecf_finalizadora = value; }
        //}

        private IList<tbr_finalizadora_unDto> tbr_finalizadora_un;
        //public virtual ICollection<tbr_finalizadora_un> tbr_finalizadora_un
        //{
        //    get
        //    {
        //        if (_tbr_finalizadora_un == null)
        //            _tbr_finalizadora_un = new List<tbr_finalizadora_un>();
        //        return _tbr_finalizadora_un;
        //    }
        //    set { _tbr_finalizadora_un = value; }
        //}

        #endregion
    }
}
