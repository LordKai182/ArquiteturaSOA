
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
    
public partial class tbr_dicionario_un
{

    public int uneg_id { get; set; }

    public int fab_id { get; set; }

    public int div_id { get; set; }

    public string dicun_codigo { get; set; }

    public string dicun_situacao { get; set; }

    public Nullable<System.DateTime> dicun_dt_cadastro { get; set; }

    public Nullable<System.DateTime> dicun_dt_alteracao { get; set; }



    public virtual tb_fornecedor_divisao tb_fornecedor_divisao { get; set; }

}

}