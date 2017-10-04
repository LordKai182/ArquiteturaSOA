using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_nfe_item")]
    public partial class tb_nfe_itemDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 nfe_pdv { get; set; }
        [DataMember]
        public virtual Int32 nfe_id { get; set; }
        [DataMember]
        public virtual DateTime nfe_data { get; set; }
        [DataMember]
        public virtual Int32 infe_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_qtd_checkin { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_qtd_pedida { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_qtd_nota { get; set; }
        [DataMember]
        public virtual String infe_lote_numero { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> infe_lote_validade { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> infe_lote_fabricacao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_lote_vlr_pmc { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_custo_unit_ped { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_custo_unit_prod { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_custo_unit_nota { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_custo_unit_cont { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_preco_padrao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_preco_praticado { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_custo_medio { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_tot_custo_ped { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_tot_custo_prod { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_tot_custo_nota { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_tot_custo_cont { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_tot_preco_padrao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_tot_preco_praticado { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_tot_custo_medio { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_qtd_bonificacao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_vlr_bonificacao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_vlr_encfin { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_vlr_desconto { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_vlr_frete { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_vlr_descfin { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_vlr_repassse { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_vlr_comissao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> infe_Num_Pedido { get; set; }
        [DataMember]
        public virtual Nullable<Int32> infe_icms_orig { get; set; }
        [DataMember]
        public virtual Nullable<Int32> infe_icms_cst { get; set; }
        [DataMember]
        public virtual Nullable<Int32> infe_icms_modbc { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_icms_predbc { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_icms_vbc { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_icms_picms { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_icms_vicms { get; set; }
        [DataMember]
        public virtual Nullable<Int32> infe_icms_modbst { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_icms_pmvast { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_icms_predbcst { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_icms_vbcst { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_icms_picmsst { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_icms_vicmsst { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_icms_vbstret { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_icms_vicmsstret { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_qcom { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_vuncom { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_vprod { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_vdesc { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_vprodcont { get; set; }
        [DataMember]
        public virtual Nullable<Int32> infe_ipi_cenq { get; set; }
        [DataMember]
        public virtual Nullable<Int32> infe_ipi_cst { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_ipi_pipi { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_ipi_vipi { get; set; }
        [DataMember]
        public virtual Nullable<Int32> infe_pis_cst { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_pis_vbcpis { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_pis_ppis { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_pis_vpis { get; set; }
        [DataMember]
        public virtual Nullable<Int32> infe_cofins_cst { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_cofins_vbccofins { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_cofins_pcofins { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_cofins_vcofiins { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_voutro { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> infe_vdescfin { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_cfopDto tb_cfop { get; set; }
        [DataMember]
        public virtual tb_nfeDto tb_nfe { get; set; }
        [DataMember]
        public virtual tb_produtoDto tb_produto { get; set; }

        #endregion
    }
}
