using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_venda_item
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 venda_id { get; set; }

        public virtual Int32 venda_pdv { get; set; }

        public virtual DateTime venda_data { get; set; }

        public virtual Int32 vitem_id { get; set; }

        public virtual Nullable<Int32> vitem_sequencia_impressora { get; set; }

        public virtual String vitem_descricao { get; set; }

        public virtual Nullable<Decimal> vitem_qtde { get; set; }

        public virtual Nullable<Decimal> vitem_preco { get; set; }

        public virtual Nullable<Decimal> vitem_preco_padrao { get; set; }

        public virtual Nullable<Decimal> vitem_preco_praticado { get; set; }

        public virtual Nullable<Decimal> vitem_preco_real { get; set; }

        public virtual Nullable<Decimal> vitem_preco_reembolso { get; set; }

        public virtual Nullable<Decimal> vitem_preco_a_vista { get; set; }

        public virtual Nullable<Decimal> vitem_desconto { get; set; }

        public virtual Nullable<Int32> vitem_desconto_percent { get; set; }

        public virtual Nullable<Int32> vitem_desc_aut_usr_mat { get; set; }

        public virtual Nullable<Decimal> vitem_desc_financ { get; set; }

        public virtual Nullable<Decimal> vitem_custo_medio { get; set; }

        public virtual Nullable<Decimal> vitem_comissao { get; set; }

        public virtual Nullable<Int32> vitem_comissao_percent { get; set; }

        public virtual Nullable<Int32> vitem_vendedor_id { get; set; }

        public virtual Nullable<Decimal> vitem_ean_pistolado { get; set; }

        public virtual String vitem_sit_trib { get; set; }

        public virtual String vitem_situacao { get; set; }

        public virtual Nullable<Int32> vitem_cancel_usr_mat { get; set; }

        public virtual Nullable<DateTime> vitem_cancel_data { get; set; }

        public virtual String vitem_md5 { get; set; }

        public virtual Nullable<Int32> vitem_id_cancelado { get; set; }

        public virtual Nullable<Decimal> barra_codigo { get; set; }

        public virtual Nullable<Boolean> vitem_pre_venda { get; set; }

        public virtual Nullable<Decimal> vitem_tot_preco { get; set; }

        public virtual Nullable<Decimal> vitem_tot_preco_padrao { get; set; }

        public virtual Nullable<Decimal> vitem_tot_preco_praticado { get; set; }

        public virtual Nullable<Decimal> vitem_tot_preco_real { get; set; }

        public virtual Nullable<Decimal> vitem_tot_preco_Reembolso { get; set; }

        public virtual Nullable<Decimal> vitem_tot_preco_a_vista { get; set; }

        public virtual Nullable<Decimal> vitem_tot_custo_medio { get; set; }

        public virtual Nullable<Decimal> vitem_tot_comissao { get; set; }

        public virtual Nullable<Decimal> vitem_tot_desconto { get; set; }

        public virtual Nullable<Decimal> vitem_tot_desc_financ { get; set; }

        public virtual String vitem_vidaLink { get; set; }

        public virtual Nullable<DateTime> vitem_receita_data { get; set; }

        public virtual String vitem_receita_notificacao_num { get; set; }

        public virtual String vitem_receita_notificacao_tipo { get; set; }

        public virtual String vitem_comprador_nome { get; set; }

        public virtual Nullable<Decimal> vitem_comprador_tipdoc { get; set; }

        public virtual String vitem_comprador_doc { get; set; }

        public virtual String vitem_comprador_oexped { get; set; }

        public virtual String vitem_comprador_uf { get; set; }

        public virtual String vitem_paciente_oexped { get; set; }

        public virtual String vitem_paciente_doc { get; set; }

        public virtual String vitem_paciente_nome { get; set; }

        public virtual String vitem_paciente_sexo { get; set; }

        public virtual Nullable<DateTime> vitem_paciente_dt_nascimento { get; set; }

        public virtual String vitem_paciente_cid { get; set; }

        public virtual String vitem_lote_numero { get; set; }

        public virtual Nullable<DateTime> vitem_lote_validade { get; set; }

        public virtual Nullable<DateTime> vitem_lote_fabricacao { get; set; }

        public virtual Nullable<Decimal> vitem_lote_vlr_pmc { get; set; }

        public virtual Nullable<Int32> vitem_fpop_qtde_Diaria { get; set; }

        public virtual Nullable<Int32> vitem_fpop_qtde_Unitaria { get; set; }

        public virtual Nullable<Int32> treceita_id { get; set; }

        public virtual Nullable<Int32> crm_id { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_produto tb_produto { get; set; }

        #endregion
    }
}
