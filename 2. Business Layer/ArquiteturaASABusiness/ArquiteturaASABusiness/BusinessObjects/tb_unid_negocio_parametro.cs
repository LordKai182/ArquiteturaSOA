using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_unid_negocio_parametro
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual String par_msg_rodape { get; set; }

        public virtual Nullable<Int32> par_ponto_tmp_seguranca { get; set; }

        public virtual Nullable<Int32> par_ponto_tmp_apv_entrada { get; set; }

        public virtual Nullable<Int32> par_ponto_tmp_apv_almoco_said { get; set; }

        public virtual Nullable<Int32> par_ponto_tmp_apv_almoco_ret { get; set; }

        public virtual Nullable<Int32> par_ponto_tmp_apv_saida { get; set; }

        public virtual Nullable<Int32> par_ponto_meridiano_minutos { get; set; }

        public virtual Nullable<DateTime> par_dt_alteracao { get; set; }

        public virtual Nullable<Boolean> par_obriga_justif_diverg { get; set; }

        public virtual Nullable<Boolean> par_obriga_anvisa { get; set; }

        public virtual String par_obriga_comanda { get; set; }

        public virtual String par_tef_IdLoja { get; set; }

        public virtual String par_tef_IP { get; set; }

        public virtual Nullable<Boolean> par_incluir_item_preVenda { get; set; }

        public virtual Nullable<Boolean> par_vende_item_pdv { get; set; }

        public virtual Nullable<Int32> par_metodo_resgate_preVenda { get; set; }

        public virtual String par_venda_item_sem_cod_barra { get; set; }

        public virtual Nullable<Int32> par_qtd_maxima_item { get; set; }

        public virtual Nullable<Boolean> par_permite_qtd_fracionada { get; set; }

        public virtual Nullable<Boolean> par_etiqueta_peso { get; set; }

        public virtual Nullable<Boolean> par_altera_finalizadora_preVenda { get; set; }

        public virtual String par_msg_livre_rodape_cupom_01 { get; set; }

        public virtual String par_msg_livre_rodape_cupom_02 { get; set; }

        public virtual String par_msg_livre_rodape_cupom_03 { get; set; }

        public virtual String par_msg_livre_rodape_cupom_04 { get; set; }

        public virtual String par_sistema_externo { get; set; }

        public virtual String par_sistema_externo_ip_servidor { get; set; }

        public virtual String par_sistema_externo_caminho_banco { get; set; }

        public virtual Boolean par_multi_vendedor { get; set; }

        public virtual Nullable<Boolean> par_tem_preVenda { get; set; }

        public virtual Nullable<Boolean> par_tem_dav { get; set; }

        public virtual String par_aplica_desconto_cadastro { get; set; }

        public virtual Nullable<Boolean> par_balcao_old { get; set; }

        public virtual String par_controle_lote { get; set; }

        public virtual Nullable<DateTime> par_data_ult_exp_cobol { get; set; }

        public virtual Nullable<Boolean> par_mobile_dav { get; set; }

        #endregion

    }
}
