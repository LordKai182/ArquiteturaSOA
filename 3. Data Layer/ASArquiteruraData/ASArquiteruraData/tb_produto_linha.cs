
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
    
public partial class tb_produto_linha
{

    public tb_produto_linha()
    {

        this.tb_parametro_comissao = new HashSet<tb_parametro_comissao>();

        this.tb_parametro_descconv = new HashSet<tb_parametro_descconv>();

        this.tb_parametro_descmax = new HashSet<tb_parametro_descmax>();

        this.tb_parametro_descprod = new HashSet<tb_parametro_descprod>();

        this.tb_parametro_descvend = new HashSet<tb_parametro_descvend>();

        this.tb_parametro_markup = new HashSet<tb_parametro_markup>();

        this.tb_produto = new HashSet<tb_produto>();

    }


    public int lin_id { get; set; }

    public string lin_descricao { get; set; }

    public string lin_situacao { get; set; }

    public Nullable<System.DateTime> lin_dt_cadastro { get; set; }

    public Nullable<System.DateTime> lin_dt_alteracao { get; set; }



    public virtual ICollection<tb_parametro_comissao> tb_parametro_comissao { get; set; }

    public virtual ICollection<tb_parametro_descconv> tb_parametro_descconv { get; set; }

    public virtual ICollection<tb_parametro_descmax> tb_parametro_descmax { get; set; }

    public virtual ICollection<tb_parametro_descprod> tb_parametro_descprod { get; set; }

    public virtual ICollection<tb_parametro_descvend> tb_parametro_descvend { get; set; }

    public virtual ICollection<tb_parametro_markup> tb_parametro_markup { get; set; }

    public virtual ICollection<tb_produto> tb_produto { get; set; }

}

}
