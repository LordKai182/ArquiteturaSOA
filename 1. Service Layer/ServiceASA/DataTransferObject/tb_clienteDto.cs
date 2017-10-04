using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_cliente")]
    public partial class tb_clienteDto
    {
       
        [DataMember]
        public long cli_id { get; set; }
        [DataMember]
        public string cli_email { get; set; }
        [DataMember]
        public Nullable<decimal> cli_limite_compra { get; set; }
        [DataMember]
        public Nullable<decimal> cli_compra_acumulada { get; set; }
        [DataMember]
        public Nullable<System.DateTime> cli_dt_bloqueio { get; set; }
        [DataMember]
        public Nullable<decimal> cli_qtd_bloqueio { get; set; }
        [DataMember]
        public string cli_obs { get; set; }
        [DataMember]
        public Nullable<System.DateTime> cli_dt_ultima_compra { get; set; }
        [DataMember]
        public string cli_cpf_alteracao { get; set; }
        [DataMember]
        public string cli_tip_pessoa { get; set; }
        [DataMember]
        public Nullable<int> cli_titular_id { get; set; }
        [DataMember]
        public string cli_cpf { get; set; }
        [DataMember]
        public string cli_nome { get; set; }
        [DataMember]
        public string cli_id_numero { get; set; }
        [DataMember]
        public string cli_id_orgao_expedidor { get; set; }
        [DataMember]
        public Nullable<System.DateTime> cli_id_dt_expedicao { get; set; }
        [DataMember]
        public Nullable<System.DateTime> cli_dt_nascimento { get; set; }
        [DataMember]
        public string cli_sexo { get; set; }
        [DataMember]
        public string cli_estado_civil { get; set; }
        [DataMember]
        public Nullable<decimal> cli_nu_filhos { get; set; }
        [DataMember]
        public string cli_nm_pai { get; set; }
        [DataMember]
        public string cli_nm_mae { get; set; }
        [DataMember]
        public string cli_cnpj { get; set; }
        [DataMember]
        public Nullable<decimal> cli_insc_estadual { get; set; }
        [DataMember]
        public string cli_razao_social { get; set; }
        [DataMember]
        public string cli_nome_fantasia { get; set; }
        [DataMember]
        public string cli_cnpj_rede { get; set; }
        [DataMember]
        public Nullable<decimal> cli_vlr_credito { get; set; }
        [DataMember]
        public Nullable<decimal> cli_polo_distribuidor { get; set; }
        [DataMember]
        public Nullable<decimal> cli_perc_csub { get; set; }
        [DataMember]
        public Nullable<decimal> cli_perc_ssub { get; set; }
        [DataMember]
        public Nullable<bool> cli_venda_imp_fracionada { get; set; }
        [DataMember]
        public Nullable<bool> cli_venda_imp_princativo { get; set; }
        [DataMember]
        public string cli_nm_contato { get; set; }
        [DataMember]
        public string cli_situacao { get; set; }
        [DataMember]
        public Nullable<System.DateTime> cli_dt_cadastro { get; set; }
        [DataMember]
        public Nullable<System.DateTime> cli_dt_alteracao { get; set; }
        [DataMember]
        public Nullable<int> prm_id { get; set; }
        [DataMember]
        public Nullable<int> final_id { get; set; }
        [DataMember]
        public Nullable<int> subfin_id { get; set; }
        [DataMember]
        public Nullable<int> bloq_id { get; set; }
        [DataMember]
        public Nullable<int> uneg_id { get; set; }
        [DataMember]
        public Nullable<int> uf_id { get; set; }

        [DataMember]
        public virtual IList<tb_cliente_enderecoDto> tb_cliente_endereco { get; set; }
        [DataMember]
        public virtual tb_cliente_bloqueioDto tb_cliente_bloqueio { get; set; }
        [DataMember]
        public virtual tb_promocaoDto tb_promocao { get; set; }
        [DataMember]

        public virtual tb_ufDto tb_uf { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }
        [DataMember]
        public virtual IList<tb_convenioDto> tb_convenio { get; set; }
        [DataMember]
        public virtual IList<tb_crediarioDto> tb_crediario { get; set; }
        [DataMember]
        public virtual IList<tb_funcionarioDto> tb_funcionario { get; set; }
        [DataMember]
        public virtual IList<tb_venda_davDto> tb_venda_dav { get; set; }
        [DataMember]
        public virtual IList<tb_venda_pagamentoDto> tb_venda_pagamento { get; set; }
        [DataMember]
        public virtual IList<tb_venda_prevendaDto> tb_venda_prevenda { get; set; }
        [DataMember]
        public virtual IList<tb_venda_prevendaDto> tb_venda { get; set; }
        [DataMember]
        public virtual IList<tbr_convenio_clienteDto> tbr_convenio_cliente { get; set; }
    }
}
