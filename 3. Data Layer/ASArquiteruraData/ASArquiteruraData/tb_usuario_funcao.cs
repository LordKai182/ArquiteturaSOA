
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
    
public partial class tb_usuario_funcao
{

    public tb_usuario_funcao()
    {

        this.tb_parametro_descvend = new HashSet<tb_parametro_descvend>();

        this.tb_usuario = new HashSet<tb_usuario>();

    }


    public int funcao_id { get; set; }

    public string funcao_descricao { get; set; }

    public Nullable<bool> funcao_param_lj_ponto { get; set; }

    public string funcao_situacao { get; set; }

    public Nullable<bool> funcao_cancela_venda { get; set; }

    public Nullable<bool> funcao_cancela_vendaItem { get; set; }

    public Nullable<bool> funcao_desconto_vendaItem { get; set; }

    public Nullable<bool> funcao_desconto_venda { get; set; }

    public Nullable<bool> funcao_gerenciar_ponto { get; set; }

    public Nullable<bool> funcao_reiniciar_setup { get; set; }

    public Nullable<bool> funcao_menu_gerencial { get; set; }

    public Nullable<bool> funcao_fundo_caixa { get; set; }

    public Nullable<bool> funcao_sangria { get; set; }

    public Nullable<bool> funcao_despesa { get; set; }

    public Nullable<System.DateTime> funcao_dt_cadastro { get; set; }

    public Nullable<System.DateTime> funcao_dt_alteracao { get; set; }

    public Nullable<bool> funcao_vendaItem_semCodBarra { get; set; }

    public Nullable<bool> funcao_libera_lote { get; set; }

    public Nullable<decimal> funcao_limite_desconto { get; set; }



    public virtual ICollection<tb_parametro_descvend> tb_parametro_descvend { get; set; }

    public virtual ICollection<tb_usuario> tb_usuario { get; set; }

}

}