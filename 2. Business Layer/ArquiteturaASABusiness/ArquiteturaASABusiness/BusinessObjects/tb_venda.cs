using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_venda
    {
        #region Primitive Properties
        public virtual Int32 venda_id { get; set; }

        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 venda_pdv { get; set; }

        public virtual DateTime venda_data { get; set; }

        public virtual Nullable<Int32> ecf_numero_ecf { get; set; }

        public virtual Nullable<Decimal> venda_num_cupom { get; set; }

        public virtual String venda_tipo { get; set; }

        public virtual Nullable<Int32> venda_vendedor_id { get; set; }

        public virtual Nullable<Boolean> venda_cli_fidelizacao { get; set; }

        public virtual Nullable<Int32> venda_prevenda_id { get; set; }

        public virtual Nullable<DateTime> venda_prevenda_data { get; set; }

        public virtual Nullable<Int32> venda_prevenda_uneg_id { get; set; }

        public virtual Nullable<Int32> venda_prevenda_pdv { get; set; }

        public virtual Nullable<Decimal> venda_tot_acrescimo { get; set; }

        public virtual Nullable<Int32> venda_tot_itens { get; set; }

        public virtual Nullable<Decimal> venda_tot_quant { get; set; }

        public virtual Nullable<Decimal> venda_tot_valor { get; set; }

        public virtual Nullable<Decimal> venda_tot_preco { get; set; }

        public virtual Nullable<Decimal> venda_tot_preco_padrao { get; set; }

        public virtual Nullable<Decimal> venda_tot_preco_praticado { get; set; }

        public virtual Nullable<Decimal> venda_tot_preco_Reembolso { get; set; }

        public virtual Nullable<Decimal> venda_tot_preco_avista { get; set; }

        public virtual Nullable<Decimal> venda_tot_custo { get; set; }

        public virtual Nullable<Decimal> venda_vlr_comissao { get; set; }

        public virtual Nullable<Decimal> venda_vlr_desc { get; set; }

        public virtual Nullable<Decimal> venda_vlr_desc_fin { get; set; }

        public virtual Nullable<Int32> venda_vlr_desc_usr_id { get; set; }

        public virtual Nullable<Boolean> venda_cancelada { get; set; }

        public virtual Nullable<DateTime> venda_cancelada_data { get; set; }

        public virtual Nullable<Int32> venda_cancelada_usr_id { get; set; }

        public virtual Nullable<Decimal> venda_cancelada_coo { get; set; }

        public virtual Boolean venda_cancelamento_paf { get; set; }

        public virtual String venda_ccf { get; set; }

        public virtual String venda_coo_cupom_vinculado { get; set; }

        public virtual Nullable<Boolean> venda_finalizada { get; set; }

        public virtual String venda_obs { get; set; }

        public virtual String venda_md5 { get; set; }

        public virtual String venda_status { get; set; }

        public virtual Nullable<DateTime> venda_data_fiscal { get; set; }

        public virtual Nullable<DateTime> venda_data_cupom_ecf { get; set; }

        public virtual String venda_pre_venda { get; set; }

        public virtual String venda_num_paf { get; set; }

        public virtual Nullable<Decimal> venda_operadorcx_id { get; set; }

        public virtual Nullable<Int32> venda_atendente_id { get; set; }

        public virtual Nullable<Int64> venda_fpop_autorizacao { get; set; }

        public virtual Nullable<Int32> venda_telefone_id { get; set; }

        public virtual Nullable<DateTime> venda_dt_entrega { get; set; }

        public virtual String venda_observacao { get; set; }

        public virtual String venda_entrega_situacao { get; set; }

        public virtual Nullable<DateTime> venda_entrega_dt_separacao { get; set; }

        public virtual Nullable<DateTime> venda_entrega_dt_retorno { get; set; }

        public virtual Nullable<DateTime> venda_entrega_dt_saida { get; set; }

        public virtual Nullable<Int32> venda_entrega_id_entregador { get; set; }

        public virtual Nullable<Int32> venda_entrega_operadorcx_retorno { get; set; }

        public virtual String venda_pbm_autorizacao_num { get; set; }

        public virtual String venda_pbm_autorizacao_tipo { get; set; }

        public virtual Nullable<Int64> venda_pbm_cpf { get; set; }

        public virtual Nullable<Int64> venda_pbm_cnpj { get; set; }

        public virtual Nullable<DateTime> venda_dt_alteracao { get; set; }

        public virtual String venda_nfce_chave { get; set; }

        public virtual String venda_nfce_protocolo { get; set; }

        public virtual Nullable<Int32> venda_conferente_id { get; set; }

        public virtual Nullable<Int32> cnv_id { get; set; }

        public virtual Nullable<Int32> pbm_id { get; set; }

        public virtual Nullable<Int64> end_telefone { get; set; }

        public virtual Nullable<Int32> polo_id { get; set; }

        public virtual Nullable<Int32> quadra_id { get; set; }

        public virtual Nullable<Int32> rota_id { get; set; }

        public virtual Nullable<Int32> arearisco_id { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_cliente tb_cliente { get; set; }

        public virtual tb_cliente_fiscal tb_cliente_fiscal { get; set; }

        private ICollection<tb_dav> _tb_dav;
        public virtual ICollection<tb_dav> tb_dav
        {
            get
            {
                if (_tb_dav == null)
                    _tb_dav = new List<tb_dav>();
                return _tb_dav;
            }
            set { _tb_dav = value; }
        }

        public virtual tb_ecf tb_ecf { get; set; }

        private ICollection<tb_venda_estorno_tef> _tb_venda_estorno_tef;
        public virtual ICollection<tb_venda_estorno_tef> tb_venda_estorno_tef
        {
            get
            {
                if (_tb_venda_estorno_tef == null)
                    _tb_venda_estorno_tef = new List<tb_venda_estorno_tef>();
                return _tb_venda_estorno_tef;
            }
            set { _tb_venda_estorno_tef = value; }
        }

        //public virtual tb_venda tb_venda1 { get; set; }

        //public virtual tb_venda tb_venda2 { get; set; }

        #endregion
    }
}
