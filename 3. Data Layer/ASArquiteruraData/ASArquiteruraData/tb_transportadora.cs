
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
    
public partial class tb_transportadora
{

    public tb_transportadora()
    {

        this.tb_mvto_compra____ = new HashSet<tb_mvto_compra____>();

    }


    public int transp_id { get; set; }

    public string transp_nome { get; set; }

    public string transp_situacao { get; set; }

    public Nullable<System.DateTime> transp_dt_cadastro { get; set; }

    public Nullable<System.DateTime> transp_dt_alteracao { get; set; }



    public virtual ICollection<tb_mvto_compra____> tb_mvto_compra____ { get; set; }

}

}