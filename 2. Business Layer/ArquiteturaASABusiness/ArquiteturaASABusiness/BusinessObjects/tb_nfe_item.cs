using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_nfe_item
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 nfe_pdv { get; set; }

        public virtual Int32 nfe_id { get; set; }

        public virtual DateTime nfe_data { get; set; }

        public virtual Int32 infe_id { get; set; }

        public virtual Nullable<Decimal> infe_qtd_checkin { get; set; }

        public virtual Nullable<Decimal> infe_qtd_pedida { get; set; }

        public virtual Nullable<Decimal> infe_qtd_nota { get; set; }

        public virtual String infe_lote_numero { get; set; }

        public virtual Nullable<DateTime> infe_lote_validade { get; set; }

        public virtual Nullable<DateTime> infe_lote_fabricacao { get; set; }

        public virtual Nullable<Decimal> infe_lote_vlr_pmc { get; set; }

        public virtual Nullable<Decimal> infe_custo_unit_ped { get; set; }

        public virtual Nullable<Decimal> infe_custo_unit_prod { get; set; }

        public virtual Nullable<Decimal> infe_custo_unit_nota { get; set; }

        public virtual Nullable<Decimal> infe_custo_unit_cont { get; set; }

        public virtual Nullable<Decimal> infe_preco_padrao { get; set; }

        public virtual Nullable<Decimal> infe_preco_praticado { get; set; }

        public virtual Nullable<Decimal> infe_custo_medio { get; set; }

        public virtual Nullable<Decimal> infe_tot_custo_ped { get; set; }

        public virtual Nullable<Decimal> infe_tot_custo_prod { get; set; }

        public virtual Nullable<Decimal> infe_tot_custo_nota { get; set; }

        public virtual Nullable<Decimal> infe_tot_custo_cont { get; set; }

        public virtual Nullable<Decimal> infe_tot_preco_padrao { get; set; }

        public virtual Nullable<Decimal> infe_tot_preco_praticado { get; set; }

        public virtual Nullable<Decimal> infe_tot_custo_medio { get; set; }

        public virtual Nullable<Decimal> infe_qtd_bonificacao { get; set; }

        public virtual Nullable<Decimal> infe_vlr_bonificacao { get; set; }

        public virtual Nullable<Decimal> infe_vlr_encfin { get; set; }

        public virtual Nullable<Decimal> infe_vlr_desconto { get; set; }

        public virtual Nullable<Decimal> infe_vlr_frete { get; set; }

        public virtual Nullable<Decimal> infe_vlr_descfin { get; set; }

        public virtual Nullable<Decimal> infe_vlr_repassse { get; set; }

        public virtual Nullable<Decimal> infe_vlr_comissao { get; set; }

        public virtual Nullable<Int32> infe_Num_Pedido { get; set; }

        public virtual Nullable<Int32> infe_icms_orig { get; set; }

        public virtual Nullable<Int32> infe_icms_cst { get; set; }

        public virtual Nullable<Int32> infe_icms_modbc { get; set; }

        public virtual Nullable<Decimal> infe_icms_predbc { get; set; }

        public virtual Nullable<Decimal> infe_icms_vbc { get; set; }

        public virtual Nullable<Decimal> infe_icms_picms { get; set; }

        public virtual Nullable<Decimal> infe_icms_vicms { get; set; }

        public virtual Nullable<Int32> infe_icms_modbst { get; set; }

        public virtual Nullable<Decimal> infe_icms_pmvast { get; set; }

        public virtual Nullable<Decimal> infe_icms_predbcst { get; set; }

        public virtual Nullable<Decimal> infe_icms_vbcst { get; set; }

        public virtual Nullable<Decimal> infe_icms_picmsst { get; set; }

        public virtual Nullable<Decimal> infe_icms_vicmsst { get; set; }

        public virtual Nullable<Decimal> infe_icms_vbstret { get; set; }

        public virtual Nullable<Decimal> infe_icms_vicmsstret { get; set; }

        public virtual Nullable<Decimal> infe_qcom { get; set; }

        public virtual Nullable<Decimal> infe_vuncom { get; set; }

        public virtual Nullable<Decimal> infe_vprod { get; set; }

        public virtual Nullable<Decimal> infe_vdesc { get; set; }

        public virtual Nullable<Decimal> infe_vprodcont { get; set; }

        public virtual Nullable<Int32> infe_ipi_cenq { get; set; }

        public virtual Nullable<Int32> infe_ipi_cst { get; set; }

        public virtual Nullable<Decimal> infe_ipi_pipi { get; set; }

        public virtual Nullable<Decimal> infe_ipi_vipi { get; set; }

        public virtual Nullable<Int32> infe_pis_cst { get; set; }

        public virtual Nullable<Decimal> infe_pis_vbcpis { get; set; }

        public virtual Nullable<Decimal> infe_pis_ppis { get; set; }

        public virtual Nullable<Decimal> infe_pis_vpis { get; set; }

        public virtual Nullable<Int32> infe_cofins_cst { get; set; }

        public virtual Nullable<Decimal> infe_cofins_vbccofins { get; set; }

        public virtual Nullable<Decimal> infe_cofins_pcofins { get; set; }

        public virtual Nullable<Decimal> infe_cofins_vcofiins { get; set; }

        public virtual Nullable<Decimal> infe_voutro { get; set; }

        public virtual Nullable<Decimal> infe_vdescfin { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_cfop tb_cfop { get; set; }

        public virtual tb_nfe tb_nfe { get; set; }

        public virtual tb_produto tb_produto { get; set; }

        #endregion
    }
}
