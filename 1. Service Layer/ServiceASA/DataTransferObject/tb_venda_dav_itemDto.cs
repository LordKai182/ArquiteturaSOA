using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_venda_dav_item")]
    public partial class tb_venda_dav_itemDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 venda_dav_item_id { get; set; }
        [DataMember]
        public virtual DateTime venda_dav_data_preVenda { get; set; }
        [DataMember]
        public virtual Int32 venda_dav_id { get; set; }
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 venda_pdv { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_id { get; set; }
        [DataMember]
        public virtual Nullable<Int64> venda_dav_item_autorizacao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_dav_item_codigo { get; set; }
        [DataMember]
        public virtual String venda_dav_item_cpfCnpj { get; set; }
        [DataMember]
        public virtual String venda_dav_item_descricao { get; set; }
        [DataMember]
        public virtual String venda_dav_item_ean13 { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> venda_dav_item_marcaAgpuc { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_dav_item_preco { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_dav_item_precoPraticado { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_dav_item_precoPadrao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_dav_item_precoReal { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_dav_item_precoReembolso { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_dav_item_precoVista { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_dav_item_quantidade { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_dav_item_totalValor { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_dav_item_valorDesconto { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_dav_item_vendedor_id { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_dav_item_data { get; set; }
        [DataMember]
        public virtual String venda_dav_item_status { get; set; }
        [DataMember]
        public virtual Nullable<Int64> venda_dav_item_cancela_vendedor_id { get; set; }
        [DataMember]
        public virtual String venda_dav_item_vidaLink { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_dav_item_receita_data { get; set; }
        [DataMember]
        public virtual String venda_dav_item_receita_notificacao_num { get; set; }
        [DataMember]
        public virtual String venda_dav_item_receita_notificacao_tipo { get; set; }
        [DataMember]
        public virtual String venda_dav_item_comprador_nome { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_dav_item_comprador_tipdoc { get; set; }
        [DataMember]
        public virtual String venda_dav_item_comprador_doc { get; set; }
        [DataMember]
        public virtual String venda_dav_item_comprador_oexped { get; set; }
        [DataMember]
        public virtual String venda_dav_item_comprador_uf { get; set; }
        [DataMember]
        public virtual String venda_dav_item_paciente_doc { get; set; }
        [DataMember]
        public virtual String venda_dav_item_paciente_nome { get; set; }
        [DataMember]
        public virtual String venda_dav_item_paciente_sexo { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_dav_item_paciente_dt_nascimento { get; set; }
        [DataMember]
        public virtual String venda_dav_item_paciente_cid { get; set; }
        [DataMember]
        public virtual String venda_dav_item_lote_numero { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_dav_item_lote_validade { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_dav_item_lote_fabricacao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_dav_item_lote_vlr_pmc { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_dav_item_fpop_qtde_diaria { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_dav_item_fpop_qtde_unitaria { get; set; }
        [DataMember]
        public virtual Nullable<Int32> crm_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> treceita_id { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_produtoDto tb_produto { get; set; }
        [DataMember]
        public virtual tb_venda_davDto tb_venda_dav { get; set; }

        #endregion
    }
}
