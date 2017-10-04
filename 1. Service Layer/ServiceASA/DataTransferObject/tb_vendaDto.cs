using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_venda")]
    public partial class tb_vendaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 venda_id { get; set; }
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 venda_pdv { get; set; }
        [DataMember]
        public virtual DateTime venda_data { get; set; }
        [DataMember]
        public virtual Nullable<Int32> ecf_numero_ecf { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_num_cupom { get; set; }
        [DataMember]
        public virtual String venda_tipo { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_vendedor_id { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> venda_cli_fidelizacao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_prevenda_id { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_prevenda_data { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_prevenda_uneg_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_prevenda_pdv { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_tot_acrescimo { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_tot_itens { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_tot_quant { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_tot_valor { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_tot_preco { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_tot_preco_padrao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_tot_preco_praticado { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_tot_preco_Reembolso { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_tot_preco_avista { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_tot_custo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_vlr_comissao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_vlr_desc { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_vlr_desc_fin { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_vlr_desc_usr_id { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> venda_cancelada { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_cancelada_data { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_cancelada_usr_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_cancelada_coo { get; set; }
        [DataMember]
        public virtual Boolean venda_cancelamento_paf { get; set; }
        [DataMember]
        public virtual String venda_ccf { get; set; }
        [DataMember]
        public virtual String venda_coo_cupom_vinculado { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> venda_finalizada { get; set; }
        [DataMember]
        public virtual String venda_obs { get; set; }
        [DataMember]
        public virtual String venda_md5 { get; set; }
        [DataMember]
        public virtual String venda_status { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_data_fiscal { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_data_cupom_ecf { get; set; }
        [DataMember]
        public virtual String venda_pre_venda { get; set; }
        [DataMember]
        public virtual String venda_num_paf { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_operadorcx_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_atendente_id { get; set; }
        [DataMember]
        public virtual Nullable<Int64> venda_fpop_autorizacao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_telefone_id { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_dt_entrega { get; set; }
        [DataMember]
        public virtual String venda_observacao { get; set; }
        [DataMember]
        public virtual String venda_entrega_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_entrega_dt_separacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_entrega_dt_retorno { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_entrega_dt_saida { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_entrega_id_entregador { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_entrega_operadorcx_retorno { get; set; }
        [DataMember]
        public virtual String venda_pbm_autorizacao_num { get; set; }
        [DataMember]
        public virtual String venda_pbm_autorizacao_tipo { get; set; }
        [DataMember]
        public virtual Nullable<Int64> venda_pbm_cpf { get; set; }
        [DataMember]
        public virtual Nullable<Int64> venda_pbm_cnpj { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_dt_alteracao { get; set; }
        [DataMember]
        public virtual String venda_nfce_chave { get; set; }
        [DataMember]
        public virtual String venda_nfce_protocolo { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_conferente_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> cnv_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> pbm_id { get; set; }
        [DataMember]
        public virtual Nullable<Int64> end_telefone { get; set; }
        [DataMember]
        public virtual Nullable<Int32> polo_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> quadra_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> rota_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> arearisco_id { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_clienteDto tb_cliente { get; set; }
        [DataMember]
        public virtual tb_cliente_fiscalDto tb_cliente_fiscal { get; set; }

        private IList<tb_davDto> tb_dav;
        //public virtual ICollection<tb_dav> tb_dav
        //{
        //    get
        //    {
        //        if (_tb_dav == null)
        //            _tb_dav = new List<tb_dav>();
        //        return _tb_dav;
        //    }
        //    set { _tb_dav = value; }
        //}
        [DataMember]
        public virtual tb_ecfDto tb_ecf { get; set; }

        private IList<tb_venda_estorno_tefDto> tb_venda_estorno_tef;
        //public virtual ICollection<tb_venda_estorno_tef> tb_venda_estorno_tef
        //{
        //    get
        //    {
        //        if (_tb_venda_estorno_tef == null)
        //            _tb_venda_estorno_tef = new List<tb_venda_estorno_tef>();
        //        return _tb_venda_estorno_tef;
        //    }
        //    set { _tb_venda_estorno_tef = value; }
        //}
        //[DataMember]
        //public virtual tb_vendaDto tb_venda1 { get; set; }
        //[DataMember]
        //public virtual tb_vendaDto tb_venda2 { get; set; }

        #endregion
    }
}
