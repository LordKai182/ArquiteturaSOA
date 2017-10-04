using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_tipo_nota")]
    public partial class tb_tipo_notaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 tipnota_id { get; set; }
        [DataMember]
        public virtual String tipnota_descricao { get; set; }
        [DataMember]
        public virtual String tipnota_tipo { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> tipnota_bonificado_alt_custo { get; set; }
        [DataMember]
        public virtual String tipnota_tipo_aplicacao_financ { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> tipnota_romaneio { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> tipnota_obrigar_checkin { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> tipnota_obrigar_icms { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> tipnota_permitir_alterar_dic { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> tipnota_aplicar_preco_rede { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> tipnota_desprezar_sngpc { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> tipnota_nf_contabil { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> tipnota_ac_qtde_prod_fora_ped { get; set; }
        [DataMember]
        public virtual String tipnota_acao_custo_maior_vend { get; set; }
        [DataMember]
        public virtual String tipnota_acao_alterar_prec_vend { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> tipnota_obrigar_pedido_compra { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> tipnota_limite_acert_dif_fech { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> tipnota_ignora_justif_diverg { get; set; }
        [DataMember]
        public virtual String tipnota_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> tipnota_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> tipnota_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_cfopDto tb_cfop { get; set; }
        [DataMember]
        public virtual tb_financeiro_eventoDto tb_financeiro_evento { get; set; }

        private ICollection<tb_mvto_compra____Dto> _tb_mvto_compra____;
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
        [DataMember]
        public virtual tb_tipo_mvto_produtoDto tb_tipo_mvto_produto { get; set; }

        #endregion
    }
}
