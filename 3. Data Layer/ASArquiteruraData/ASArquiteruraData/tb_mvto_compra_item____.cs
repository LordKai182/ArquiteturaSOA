
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ASArquiteruraData
{

using System;
    using System.Collections.Generic;
    
public partial class tb_mvto_compra_item____
{

    public tb_mvto_compra_item____()
    {

        this.tb_mvto_compra_item_lote____ = new HashSet<tb_mvto_compra_item_lote____>();

    }


    public int cmp_id { get; set; }

    public int icmp_id { get; set; }

    public Nullable<decimal> icmp_qtd_checkin { get; set; }

    public Nullable<decimal> icmp_qtd_pedida { get; set; }

    public Nullable<decimal> icmp_qtd_nota { get; set; }

    public Nullable<decimal> icmp_custo_unit_ped { get; set; }

    public Nullable<decimal> icmp_custo_unit_prod { get; set; }

    public Nullable<decimal> icmp_custo_unit_nota { get; set; }

    public Nullable<decimal> icmp_tot_custo_ped { get; set; }

    public Nullable<decimal> icmp_tot_custo_prod { get; set; }

    public Nullable<decimal> icmp_tot_custo_nota { get; set; }

    public Nullable<decimal> icmp_qtd_bonificacao { get; set; }

    public Nullable<decimal> icmp_vlr_bonificacao { get; set; }

    public Nullable<decimal> icmp_aliq_ipi { get; set; }

    public Nullable<decimal> icmp_vlr_ipi { get; set; }

    public Nullable<decimal> icmp_base_icms { get; set; }

    public Nullable<decimal> icmp_aliq_icms { get; set; }

    public Nullable<decimal> icmp_vlr_icms { get; set; }

    public Nullable<decimal> icmp_perc_encfin { get; set; }

    public Nullable<decimal> icmp_vlr_encfin { get; set; }

    public Nullable<decimal> icmp_perc_desconto { get; set; }

    public Nullable<decimal> icmp_vlr_desconto { get; set; }

    public Nullable<decimal> icmp_mar_icmsst { get; set; }

    public Nullable<decimal> icmp_base_icmsst { get; set; }

    public Nullable<decimal> icmp_aliq_icmsst { get; set; }

    public Nullable<decimal> icmp_vlr_icmsst { get; set; }

    public Nullable<decimal> icmp_vlr_frete { get; set; }

    public Nullable<decimal> icmp_perc_descfin { get; set; }

    public Nullable<decimal> icmp_vlr_descfin { get; set; }

    public Nullable<decimal> icmp_perc_repassse { get; set; }

    public Nullable<decimal> icmp_vlr_repassse { get; set; }

    public Nullable<decimal> icmp_preco_sugerido { get; set; }

    public Nullable<decimal> icmp_preco_alterado { get; set; }

    public Nullable<int> pro_id { get; set; }

    public Nullable<int> cfop_id { get; set; }

    public Nullable<int> icmp_Num_Pedido { get; set; }



    public virtual tb_cfop tb_cfop { get; set; }

    public virtual tb_mvto_compra____ tb_mvto_compra____ { get; set; }

    public virtual ICollection<tb_mvto_compra_item_lote____> tb_mvto_compra_item_lote____ { get; set; }

    public virtual tb_produto tb_produto { get; set; }

}

}
