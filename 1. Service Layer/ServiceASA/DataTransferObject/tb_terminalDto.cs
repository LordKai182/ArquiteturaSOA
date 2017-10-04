using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_terminal")]
    public partial class tb_terminalDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 te_id_terminal { get; set; }
        [DataMember]
        public virtual String te_nome { get; set; }
        [DataMember]
        public virtual String te_nome_rede { get; set; }
        [DataMember]
        public virtual String te_database { get; set; }
        [DataMember]
        public virtual String te_tipo { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> te_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> te_dt_inclusao { get; set; }
        [DataMember]
        public virtual String te_status { get; set; }
        [DataMember]
        public virtual String te_acbr_ecf_marca { get; set; }
        [DataMember]
        public virtual String te_acbr_ecf_porta { get; set; }
        [DataMember]
        public virtual Nullable<Int32> te_acbr_ecf_velocidade_porta { get; set; }
        [DataMember]
        public virtual Nullable<Int32> te_acbr_ecf_timeout { get; set; }
        [DataMember]
        public virtual Nullable<Int32> te_acbr_ecf_intervalo_apos_comando { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> te_acbr_ecf_controla_gaveta { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> te_acbr_ecf_gaveta_sinal_invertido { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> te_acbr_ecf_descricao_grande { get; set; }
        [DataMember]
        public virtual String te_acbr_caminho_log { get; set; }
        [DataMember]
        public virtual String te_caminho_servidor { get; set; }
        [DataMember]
        public virtual String te_caminho_preVenda { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> te_balanca { get; set; }
        [DataMember]
        public virtual String te_acbr_bal_marca { get; set; }
        [DataMember]
        public virtual String te_acbr_bal_porta { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> te_imprimir_dav { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> te_data_ult_imp_srv_web { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> te_data_ult_imp_srv_loja { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> te_data_ult_imp_pdv { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> te_servidor_loja { get; set; }
        [DataMember]
        public virtual Nullable<Int32> te_percentual_importacao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> te_nfce { get; set; }
        [DataMember]
        public virtual String te_certificado { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> te_sat { get; set; }
        [DataMember]
        public virtual String te_num_ativacao_aparelho { get; set; }
        [DataMember]
        public virtual String te_ambiente_sefaz { get; set; }
        [DataMember]
        public virtual String te_drive_rede { get; set; }
        [DataMember]
        public virtual String te_id_token_sefaz { get; set; }
        [DataMember]
        public virtual String te_token_sefaz { get; set; }
        [DataMember]
        public virtual String te_debug { get; set; }
        [DataMember]
        public virtual String te_serie_hd { get; set; }
        [DataMember]
        public virtual String te_serie_placa_mae { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> te_terminal_atualizado { get; set; }
        [DataMember]
        public virtual Nullable<Int32> te_serie_nfce { get; set; }
        [DataMember]
        public virtual Nullable<Int32> te_numero_nfce { get; set; }
        [DataMember]
        public virtual String te_aparelho_sat { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_ecf_modeloDto tb_ecf_modelo { get; set; }

        private IList<tb_sincronizacaoDto> tb_sincronizacao;
        //public virtual ICollection<tb_sincronizacao> tb_sincronizacao
        //{
        //    get
        //    {
        //        if (_tb_sincronizacao == null)
        //            _tb_sincronizacao = new List<tb_sincronizacao>();
        //        return _tb_sincronizacao;
        //    }
        //    set { _tb_sincronizacao = value; }
        //}
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
}
