using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_venda_prevenda_item
    {
        #region Primitive Properties
        public virtual Int32 vendaPv_item_id { get; set; }

        public virtual DateTime vendaPv_data_preVenda { get; set; }

        public virtual Int32 vendaPv_id { get; set; }

        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 venda_pdv { get; set; }

        public virtual Nullable<Int32> venda_id { get; set; }

        public virtual Nullable<Int64> vendaPv_item_autorizacao { get; set; }

        public virtual Nullable<Int32> vendaPv_item_codigo { get; set; }

        public virtual String vendaPv_item_cpfCnpj { get; set; }

        public virtual String vendaPv_item_descricao { get; set; }

        public virtual String vendaPv_item_ean13 { get; set; }

        public virtual Nullable<Boolean> vendaPv_item_agenda_marca_puc { get; set; }

        public virtual Nullable<Decimal> vendaPv_item_preco { get; set; }

        public virtual Nullable<Decimal> vendaPv_item_precoPraticado { get; set; }

        public virtual Nullable<Decimal> vendaPv_item_precoPadrao { get; set; }

        public virtual Nullable<Decimal> vendaPv_item_precoReal { get; set; }

        public virtual Nullable<Decimal> vendaPv_item_precoReembolso { get; set; }

        public virtual Nullable<Decimal> vendaPv_item_precoVista { get; set; }

        public virtual Nullable<Int32> vendaPv_item_quantidade { get; set; }

        public virtual Nullable<Decimal> vendaPv_item_totalValor { get; set; }

        public virtual Nullable<Decimal> vendaPv_item_valorDesconto { get; set; }

        public virtual Nullable<DateTime> vendaPv_item_data { get; set; }

        public virtual String vendaPv_item_status { get; set; }

        public virtual Nullable<Int64> vendaPv_item_cancela_vendedor_id { get; set; }

        public virtual String vendaPv_item_vidaLink { get; set; }

        public virtual Nullable<DateTime> vendaPv_item_receita_data { get; set; }

        public virtual String vendaPv_item_receita_notificacao_num { get; set; }

        public virtual String vendaPv_item_receita_notificacao_tipo { get; set; }

        public virtual String vendaPv_item_comprador_nome { get; set; }

        public virtual Nullable<Decimal> vendaPv_item_comprador_tipdoc { get; set; }

        public virtual String vendaPv_item_comprador_doc { get; set; }

        public virtual String vendaPv_item_comprador_oexped { get; set; }

        public virtual String vendaPv_item_comprador_uf { get; set; }

        public virtual String vendaPv_item_paciente_doc { get; set; }

        public virtual String vendaPv_item_paciente_nome { get; set; }

        public virtual String vendaPv_item_paciente_sexo { get; set; }

        public virtual Nullable<DateTime> vendaPv_item_paciente_dt_nascimento { get; set; }

        public virtual String vendaPv_item_paciente_cid { get; set; }

        public virtual String vendaPv_item_lote_numero { get; set; }

        public virtual Nullable<DateTime> vendaPv_item_lote_validade { get; set; }

        public virtual Nullable<DateTime> vendaPv_lote_fabricacao { get; set; }

        public virtual Nullable<Decimal> vendaPv_item_lote_vlr_pmc { get; set; }

        public virtual Nullable<Int32> vendaPv_item_fpop_qtde_Diaria { get; set; }

        public virtual Nullable<Int32> vendaPv_item_fpop_qtde_Unitaria { get; set; }

        public virtual Nullable<Int32> crm_id { get; set; }

        public virtual Nullable<Int32> treceita_id { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_produto tb_produto { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }

        #endregion
    }
}
