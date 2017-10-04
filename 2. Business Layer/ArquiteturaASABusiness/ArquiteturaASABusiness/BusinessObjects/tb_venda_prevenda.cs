using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_venda_prevenda
    {
        #region Primitive Properties
        public virtual Int32 vendaPv_id { get; set; }

        public virtual DateTime vendaPv_data_preVenda { get; set; }

        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 venda_pdv { get; set; }

        public virtual Nullable<Int32> venda_id { get; set; }

        public virtual Nullable<DateTime> venda_data { get; set; }

        public virtual String vendaPv_num_preVenda { get; set; }

        public virtual String vendaPv_num_comanda { get; set; }

        public virtual Nullable<Decimal> vendaPv_valorTotal { get; set; }

        public virtual Nullable<Decimal> vendaPv_valorTroco { get; set; }

        public virtual Nullable<Decimal> vendaPv_vlr_creditos { get; set; }

        public virtual Nullable<Decimal> vendaPv_desconto_final { get; set; }

        public virtual Nullable<Int32> vendaPv_itens { get; set; }

        public virtual Nullable<Int32> vendaPv_volmes { get; set; }

        public virtual String vendaPv_observacao { get; set; }

        public virtual Nullable<Int32> vendaPv_atendente_id { get; set; }

        public virtual String vendaPv_situacao { get; set; }

        public virtual String vendaPv_tip_pedido { get; set; }

        public virtual String vendaPv_tip_faturamento { get; set; }

        public virtual String vendaPv_dispositivo { get; set; }

        public virtual Nullable<Int32> vendaPv_id_origem { get; set; }

        public virtual Nullable<DateTime> vendaPv_data_preVenda_origem { get; set; }

        public virtual Nullable<Int32> uneg_id_origem { get; set; }

        public virtual Nullable<Int32> venda_pdv_origem { get; set; }

        public virtual Nullable<Int32> vendaPv_end_cobranca { get; set; }

        public virtual Nullable<DateTime> vendaPv_dt_entrega { get; set; }

        public virtual Nullable<Int32> vendaPv_telefone_id { get; set; }

        public virtual String vendaPv_paf_numero { get; set; }

        public virtual String vendaPv_pbm_autorizacao_num { get; set; }

        public virtual String vendaPv_pbm_autorizacao_tipo { get; set; }

        public virtual Nullable<Int64> vendaPv_pbm_cpf { get; set; }

        public virtual Nullable<Int64> vendaPv_pbm_cnpj { get; set; }

        public virtual Nullable<Decimal> vendaPv_pbm_avista { get; set; }

        public virtual Nullable<Decimal> vendaPv_pbm_reembolso { get; set; }

        public virtual String vendaPv_pedido_compra_cliente { get; set; }

        public virtual Nullable<Int32> vendaPv_cancela_vendedor_id { get; set; }

        public virtual Nullable<DateTime> vendaPv_cancela_data { get; set; }

        public virtual String vendaPv_cancela_motivo { get; set; }

        public virtual Nullable<DateTime> vendaPv_entrega_dt_separacao { get; set; }

        public virtual Nullable<DateTime> vendaPv_entrega_dt_retorno { get; set; }

        public virtual Nullable<Int32> vendaPv_entrega_id_entregador { get; set; }

        public virtual String vendaPv_status { get; set; }

        public virtual Nullable<DateTime> vendaPv_data_alteracao { get; set; }

        public virtual String vendaPv_nome_arquivo { get; set; }

        public virtual String vendaPv_chave_acesso_nfe { get; set; }

        public virtual String vendaPv_ecf_dv { get; set; }

        public virtual String vendaPv_coo_dv { get; set; }

        public virtual String vendaPv_chave_nfce_dv { get; set; }

        public virtual String cli_fisc_cpf_cnpj { get; set; }

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

        public virtual tb_usuario tb_usuario { get; set; }

        #endregion
    }
}
