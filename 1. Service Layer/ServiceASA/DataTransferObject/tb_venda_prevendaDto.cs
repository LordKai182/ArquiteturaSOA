using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_venda_prevenda")]
    public partial class tb_venda_prevendaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 vendaPv_id { get; set; }
        [DataMember]
        public virtual DateTime vendaPv_data_preVenda { get; set; }
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 venda_pdv { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_id { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_data { get; set; }
        [DataMember]
        public virtual String vendaPv_num_preVenda { get; set; }
        [DataMember]
        public virtual String vendaPv_num_comanda { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vendaPv_valorTotal { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vendaPv_valorTroco { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vendaPv_vlr_creditos { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vendaPv_desconto_final { get; set; }
        [DataMember]
        public virtual Nullable<Int32> vendaPv_itens { get; set; }
        [DataMember]
        public virtual Nullable<Int32> vendaPv_volmes { get; set; }
        [DataMember]
        public virtual String vendaPv_observacao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> vendaPv_atendente_id { get; set; }
        [DataMember]
        public virtual String vendaPv_situacao { get; set; }
        [DataMember]
        public virtual String vendaPv_tip_pedido { get; set; }
        [DataMember]
        public virtual String vendaPv_tip_faturamento { get; set; }
        [DataMember]
        public virtual String vendaPv_dispositivo { get; set; }
        [DataMember]
        public virtual Nullable<Int32> vendaPv_id_origem { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> vendaPv_data_preVenda_origem { get; set; }
        [DataMember]
        public virtual Nullable<Int32> uneg_id_origem { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_pdv_origem { get; set; }
        [DataMember]
        public virtual Nullable<Int32> vendaPv_end_cobranca { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> vendaPv_dt_entrega { get; set; }
        [DataMember]
        public virtual Nullable<Int32> vendaPv_telefone_id { get; set; }
        [DataMember]
        public virtual String vendaPv_paf_numero { get; set; }
        [DataMember]
        public virtual String vendaPv_pbm_autorizacao_num { get; set; }
        [DataMember]
        public virtual String vendaPv_pbm_autorizacao_tipo { get; set; }
        [DataMember]
        public virtual Nullable<Int64> vendaPv_pbm_cpf { get; set; }
        [DataMember]
        public virtual Nullable<Int64> vendaPv_pbm_cnpj { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vendaPv_pbm_avista { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> vendaPv_pbm_reembolso { get; set; }
        [DataMember]
        public virtual String vendaPv_pedido_compra_cliente { get; set; }
        [DataMember]
        public virtual Nullable<Int32> vendaPv_cancela_vendedor_id { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> vendaPv_cancela_data { get; set; }
        [DataMember]
        public virtual String vendaPv_cancela_motivo { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> vendaPv_entrega_dt_separacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> vendaPv_entrega_dt_retorno { get; set; }
        [DataMember]
        public virtual Nullable<Int32> vendaPv_entrega_id_entregador { get; set; }
           [DataMember]
        public virtual String vendaPv_status { get; set; }
           [DataMember]
        public virtual Nullable<DateTime> vendaPv_data_alteracao { get; set; }
           [DataMember]
        public virtual String vendaPv_nome_arquivo { get; set; }
           [DataMember]
        public virtual String vendaPv_chave_acesso_nfe { get; set; }
           [DataMember]
        public virtual String vendaPv_ecf_dv { get; set; }
           [DataMember]
        public virtual String vendaPv_coo_dv { get; set; }
           [DataMember]
        public virtual String vendaPv_chave_nfce_dv { get; set; }
           [DataMember]
        public virtual String cli_fisc_cpf_cnpj { get; set; }
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
        public virtual tb_usuarioDto tb_usuario { get; set; }

        #endregion
    }
}
