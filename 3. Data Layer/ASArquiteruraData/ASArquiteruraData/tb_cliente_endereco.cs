
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
    
public partial class tb_cliente_endereco
{

    public long cli_id { get; set; }

    public int end_id { get; set; }

    public string end_cep { get; set; }

    public string end_tp_logradouro { get; set; }

    public string end_nm_logradouro { get; set; }

    public Nullable<int> end_numero { get; set; }

    public string end_complemento { get; set; }

    public string end_bairro { get; set; }

    public string end_cidade { get; set; }

    public string end_referencia { get; set; }

    public string end_tipo { get; set; }

    public string end_situacao { get; set; }

    public Nullable<System.DateTime> end_dt_cadastro { get; set; }

    public Nullable<System.DateTime> end_dt_alteracao { get; set; }

    public string end_cpf_alteracao { get; set; }

    public Nullable<int> uf_id { get; set; }



    public virtual tb_cliente tb_cliente { get; set; }

    public virtual tb_uf tb_uf { get; set; }

}

}
