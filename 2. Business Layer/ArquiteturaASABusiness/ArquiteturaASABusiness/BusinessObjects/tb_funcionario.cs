using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_funcionario
    {
        #region Primitive Properties
        public virtual Int32 func_id { get; set; }

        public virtual String func_nome { get; set; }

        public virtual Int32 func_matricula { get; set; }

        public virtual String func_filiacao_mae { get; set; }

        public virtual String func_filiacao_pai { get; set; }

        public virtual Nullable<DateTime> func_dt_nascimento { get; set; }

        public virtual String func_sexo { get; set; }

        public virtual String func_estado_civil { get; set; }

        public virtual Nullable<Decimal> func_nu_filhos { get; set; }

        public virtual String func_cpf { get; set; }

        public virtual String func_ident_numero { get; set; }

        public virtual String func_ident_orgao_expedidor { get; set; }

        public virtual Nullable<DateTime> func_ident_dt_expedicao { get; set; }

        public virtual String func_ctps { get; set; }

        public virtual String func_ctps_serie { get; set; }

        public virtual Nullable<Decimal> func_pis_pasep { get; set; }

        public virtual Nullable<DateTime> func_dt_admissao { get; set; }

        public virtual Nullable<DateTime> func_dt_demissao { get; set; }

        public virtual Nullable<Decimal> func_parente { get; set; }

        public virtual String func_parente_nome { get; set; }

        public virtual String func_end_cep { get; set; }

        public virtual String func_end_tip_logradouro { get; set; }

        public virtual String func_end_nm_logradouro { get; set; }

        public virtual Nullable<Decimal> func_end_numero { get; set; }

        public virtual String func_end_complemento { get; set; }

        public virtual String func_end_bairro { get; set; }

        public virtual String func_end_cidade { get; set; }

        public virtual String func_end_uf { get; set; }

        public virtual String func_end_referencia { get; set; }

        public virtual Nullable<Decimal> func_tel_residen_area { get; set; }

        public virtual Nullable<Decimal> func_tel_residen { get; set; }

        public virtual Nullable<Decimal> func_tel_celular_area { get; set; }

        public virtual Nullable<Decimal> func_tel_celular { get; set; }

        public virtual String func_email { get; set; }

        public virtual Nullable<Decimal> func_escolaridade { get; set; }

        public virtual String func_cursos { get; set; }

        public virtual String func_obs { get; set; }

        public virtual Nullable<DateTime> func_ferias_contab_dt_inicial { get; set; }

        public virtual Nullable<DateTime> func_ferias_contab_dt_final { get; set; }

        public virtual Nullable<DateTime> func_ferias_real_dt_inicial { get; set; }

        public virtual Nullable<DateTime> func_ferias_real_dt_final { get; set; }

        public virtual Nullable<Decimal> func_cc_agencia { get; set; }

        public virtual Nullable<Decimal> func_cc_numero { get; set; }

        public virtual Nullable<Decimal> func_salario { get; set; }

        public virtual Nullable<Decimal> func_quinzena { get; set; }

        public virtual Nullable<Decimal> func_deducao_fixa { get; set; }

        public virtual Nullable<Decimal> func_saldo_devedor { get; set; }

        public virtual Nullable<Decimal> func_vale_limite { get; set; }

        public virtual Nullable<Decimal> func_vale_acumulado { get; set; }

        public virtual Nullable<Boolean> func_biometria_confirm { get; set; }

        public virtual Byte[] func_biometria_image { get; set; }

        public virtual Byte[] func_image { get; set; }

        public virtual Byte[] func_biometria { get; set; }

        public virtual Nullable<DateTime> func_dt_alteracao_sync { get; set; }

        public virtual Nullable<DateTime> func_afastado_dt_inicial { get; set; }

        public virtual Nullable<DateTime> func_afastado_dt_final { get; set; }

        public virtual String func_situacao { get; set; }

        public virtual Nullable<DateTime> func_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> func_dt_alteracao { get; set; }

        public virtual Nullable<Boolean> func_biometria_nao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_cargo tb_cargo { get; set; }

        public virtual tb_cliente tb_cliente { get; set; }

        public virtual tb_convenio tb_convenio { get; set; }

        public virtual tb_financeiro_bancos tb_financeiro_bancos { get; set; }

        public virtual tb_funcionario_horario tb_funcionario_horario { get; set; }

        public virtual tb_funcionario_horario tb_funcionario_horario1 { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio1 { get; set; }

        #endregion
    }
}
