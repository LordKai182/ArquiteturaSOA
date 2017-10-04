using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_funcionario")]
    public partial class tb_funcionarioDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 func_id { get; set; }
        [DataMember]
        public virtual String func_nome { get; set; }
        [DataMember]
        public virtual Int32 func_matricula { get; set; }
        [DataMember]
        public virtual String func_filiacao_mae { get; set; }
        [DataMember]
        public virtual String func_filiacao_pai { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> func_dt_nascimento { get; set; }
        [DataMember]
        public virtual String func_sexo { get; set; }
        [DataMember]
        public virtual String func_estado_civil { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_nu_filhos { get; set; }
        [DataMember]
        public virtual String func_cpf { get; set; }
        [DataMember]
        public virtual String func_ident_numero { get; set; }
        [DataMember]
        public virtual String func_ident_orgao_expedidor { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> func_ident_dt_expedicao { get; set; }
        [DataMember]
        public virtual String func_ctps { get; set; }
        [DataMember]
        public virtual String func_ctps_serie { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_pis_pasep { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> func_dt_admissao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> func_dt_demissao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_parente { get; set; }
        [DataMember]
        public virtual String func_parente_nome { get; set; }
        [DataMember]
        public virtual String func_end_cep { get; set; }
        [DataMember]
        public virtual String func_end_tip_logradouro { get; set; }
        [DataMember]
        public virtual String func_end_nm_logradouro { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_end_numero { get; set; }
        [DataMember]
        public virtual String func_end_complemento { get; set; }
        [DataMember]
        public virtual String func_end_bairro { get; set; }
        [DataMember]
        public virtual String func_end_cidade { get; set; }
        [DataMember]
        public virtual String func_end_uf { get; set; }
        [DataMember]
        public virtual String func_end_referencia { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_tel_residen_area { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_tel_residen { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_tel_celular_area { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_tel_celular { get; set; }
        [DataMember]
        public virtual String func_email { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_escolaridade { get; set; }
        [DataMember]
        public virtual String func_cursos { get; set; }
        [DataMember]
        public virtual String func_obs { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> func_ferias_contab_dt_inicial { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> func_ferias_contab_dt_final { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> func_ferias_real_dt_inicial { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> func_ferias_real_dt_final { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_cc_agencia { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_cc_numero { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_salario { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_quinzena { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_deducao_fixa { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_saldo_devedor { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_vale_limite { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> func_vale_acumulado { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> func_biometria_confirm { get; set; }
        [DataMember]
        public virtual Byte[] func_biometria_image { get; set; }
        [DataMember]
        public virtual Byte[] func_image { get; set; }
        [DataMember]
        public virtual Byte[] func_biometria { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> func_dt_alteracao_sync { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> func_afastado_dt_inicial { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> func_afastado_dt_final { get; set; }
        [DataMember]
        public virtual String func_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> func_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> func_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> func_biometria_nao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_cargoDto tb_cargo { get; set; }
        [DataMember]
        public virtual tb_clienteDto tb_cliente { get; set; }
        [DataMember]
        public virtual tb_convenioDto tb_convenio { get; set; }
        [DataMember]
        public virtual tb_financeiro_bancosDto tb_financeiro_bancos { get; set; }
        [DataMember]
        public virtual tb_funcionario_horarioDto tb_funcionario_horario { get; set; }
        [DataMember]
        public virtual tb_funcionario_horarioDto tb_funcionario_horario1 { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio1 { get; set; }

        #endregion
    }
}
