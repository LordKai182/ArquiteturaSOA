
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
    
public partial class tb_cfop
{

    public tb_cfop()
    {

        this.tb_mvto_compra_item____ = new HashSet<tb_mvto_compra_item____>();

        this.tb_nfe_item = new HashSet<tb_nfe_item>();

        this.tb_tipo_nota = new HashSet<tb_tipo_nota>();

        this.tbr_mvto_compra_cfop____ = new HashSet<tbr_mvto_compra_cfop____>();

        this.tb_nfe_cfop = new HashSet<tb_nfe_cfop>();

    }


    public int cfop_id { get; set; }

    public Nullable<decimal> cfop_codigo { get; set; }

    public string cfop_descricao { get; set; }

    public string cfop_situacao { get; set; }

    public Nullable<System.DateTime> cfop_dt_cadastro { get; set; }

    public Nullable<System.DateTime> cfop_dt_alteracao { get; set; }



    public virtual ICollection<tb_mvto_compra_item____> tb_mvto_compra_item____ { get; set; }

    public virtual ICollection<tb_nfe_item> tb_nfe_item { get; set; }

    public virtual ICollection<tb_tipo_nota> tb_tipo_nota { get; set; }

    public virtual ICollection<tbr_mvto_compra_cfop____> tbr_mvto_compra_cfop____ { get; set; }

    public virtual ICollection<tb_nfe_cfop> tb_nfe_cfop { get; set; }

}

}