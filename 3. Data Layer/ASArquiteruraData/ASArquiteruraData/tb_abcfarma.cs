
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
    
public partial class tb_abcfarma
{

    public tb_abcfarma()
    {

        this.tb_produto = new HashSet<tb_produto>();

        this.tbr_abcfarma_uf = new HashSet<tbr_abcfarma_uf>();

    }


    public int abcf_id { get; set; }

    public Nullable<decimal> abcf_codigo { get; set; }

    public Nullable<decimal> abcf_cd_barra { get; set; }

    public Nullable<decimal> abcf_preco_fabrica { get; set; }

    public Nullable<decimal> abcf_pmc { get; set; }

    public Nullable<decimal> abcf_pmc_fracao { get; set; }

    public string abcf_descricao1 { get; set; }

    public string abcf_descricao2 { get; set; }

    public Nullable<decimal> abcf_cod_fabricante { get; set; }

    public string abcf_fabricante { get; set; }

    public string abcf_tip_produto { get; set; }

    public string abcf_prod_novo { get; set; }

    public string abcf_generico { get; set; }

    public string abcf_princativo { get; set; }

    public string abcf_tip_lista { get; set; }

    public Nullable<decimal> abcf_qtd_caixa { get; set; }

    public Nullable<decimal> abcf_ipi { get; set; }

    public Nullable<System.DateTime> abcf_dt_alteracao { get; set; }

    public Nullable<decimal> abcf_cpf_alteracao { get; set; }



    public virtual ICollection<tb_produto> tb_produto { get; set; }

    public virtual ICollection<tbr_abcfarma_uf> tbr_abcfarma_uf { get; set; }

}

}