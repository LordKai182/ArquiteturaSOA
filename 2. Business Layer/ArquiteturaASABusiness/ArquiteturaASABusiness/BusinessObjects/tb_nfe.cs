using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{

    public partial class tb_nfe
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 nfe_pdv { get; set; }

        public virtual Int32 nfe_id { get; set; }

        public virtual DateTime nfe_data { get; set; }

        public virtual Nullable<Int32> nfe_id_vendedor { get; set; }

        public virtual Nullable<Int32> nfe_id_atendente { get; set; }

        public virtual Nullable<Int32> nfe_id_cancelado { get; set; }

        public virtual String nfe_chave_acesso { get; set; }

        public virtual String nfe_situacao { get; set; }

        public virtual String nfe_uf_origem { get; set; }

        public virtual String nfe_uf_destino { get; set; }

        public virtual Nullable<Decimal> nfe_numero { get; set; }

        public virtual Nullable<Decimal> nfe_cfop { get; set; }

        public virtual Nullable<Decimal> nfe_nat_operacao { get; set; }

        public virtual String nfe_modelo { get; set; }

        public virtual Nullable<Decimal> nfe_serie { get; set; }

        public virtual String nfe_tipo { get; set; }

        public virtual Nullable<Decimal> nfe_cod_municipio { get; set; }

        public virtual String nfe_data_saida { get; set; }

        public virtual String nfe_hora_saida { get; set; }

        public virtual Nullable<Int32> nfe_itens_produto { get; set; }

        public virtual Nullable<Decimal> nfe_qtd_produto { get; set; }

        public virtual Nullable<Decimal> nfe_total_venda { get; set; }

        public virtual Nullable<Decimal> nfe_total_venda_padrao { get; set; }

        public virtual Nullable<Decimal> nfe_total_venda_praticado { get; set; }

        public virtual Nullable<Decimal> nfe_total_venda_real { get; set; }

        public virtual Nullable<Decimal> nfe_total_custo { get; set; }

        public virtual Nullable<Decimal> nfe_total_bonificado { get; set; }

        public virtual Nullable<Decimal> nfe_total_comissao { get; set; }

        public virtual Nullable<Decimal> nfe_desc_comercial { get; set; }

        public virtual Nullable<Decimal> nfe_desc_financeiro { get; set; }

        public virtual Nullable<Decimal> nfe_icmstot_vbc { get; set; }

        public virtual Nullable<Decimal> nfe_icmstot_vicms { get; set; }

        public virtual Nullable<Decimal> nfe_icmstot_vst { get; set; }

        public virtual Nullable<Decimal> nfe_icmstot_vprod { get; set; }

        public virtual Nullable<Decimal> nfe_icmstot_vfrete { get; set; }

        public virtual Nullable<Decimal> nfe_icmstot_vseg { get; set; }

        public virtual Nullable<Decimal> nfe_icmstot_vdesc { get; set; }

        public virtual Nullable<Decimal> nfe_icmstot_vii { get; set; }

        public virtual Nullable<Decimal> nfe_icmstot_vipi { get; set; }

        public virtual Nullable<Decimal> nfe_icmstot_vpis { get; set; }

        public virtual Nullable<Decimal> nfe_icmstot_vcofins { get; set; }

        public virtual Nullable<Decimal> nfe_icmstot_voutros { get; set; }

        public virtual Nullable<Decimal> nfe_icmstot_vnf { get; set; }

        public virtual Nullable<Decimal> nfe_vlr_totaltrib { get; set; }

        public virtual Nullable<Decimal> nfe_issqntot_vserv { get; set; }

        public virtual Nullable<Decimal> nfe_issqntot_vbc { get; set; }

        public virtual Nullable<Decimal> nfe_issqntot_viss { get; set; }

        public virtual Nullable<Decimal> nfe_issqntot_vpis { get; set; }

        public virtual Nullable<Decimal> nfe_issqntot_vcofins { get; set; }

        public virtual Nullable<Decimal> nfe_rettrib_vretpis { get; set; }

        public virtual Nullable<Decimal> nfe_rettrib_vretcofins { get; set; }

        public virtual Nullable<Decimal> nfe_rettrib_vretcsll { get; set; }

        public virtual Nullable<Decimal> nfe_rettrib_vbcirrf { get; set; }

        public virtual Nullable<Decimal> nfe_rettrib_virrf { get; set; }

        public virtual Nullable<Decimal> nfe_rettrib_vbcretprev { get; set; }

        public virtual Nullable<Decimal> nfe_rettrib_vretprev { get; set; }

        public virtual Nullable<Decimal> nfe_vlr_isento { get; set; }

        public virtual String nfe_nf_obs { get; set; }

        public virtual String nfe_tip_frete { get; set; }

        public virtual String nfe_destino { get; set; }

        public virtual Nullable<Decimal> nfe_peso_l { get; set; }

        public virtual Nullable<Decimal> nfe_peso_b { get; set; }

        public virtual String nfe_placa_veiculo { get; set; }

        public virtual Nullable<Decimal> nfe_transportadora { get; set; }

        public virtual String nfe_dispositivo { get; set; }

        public virtual String nfe_refecf_mod { get; set; }

        public virtual Nullable<Int32> nfe_refecf_necf { get; set; }

        public virtual Nullable<Int32> nfe_refecf_coo { get; set; }

        public virtual Nullable<Int32> transp_id { get; set; }

        public virtual Nullable<Int32> pedv_id { get; set; }

        public virtual Nullable<Int64> cli_id { get; set; }

        public virtual Nullable<Int32> cnv_id { get; set; }

        public virtual Nullable<Int32> serient_id { get; set; }

        public virtual Nullable<Int32> enft_id { get; set; }

        public virtual Nullable<Int32> venda_ecf_pdv { get; set; }

        public virtual Nullable<Int32> venda_ecf_id { get; set; }

        public virtual Nullable<DateTime> venda_ecf_data { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_nfe_item> _tb_nfe_item;
        public virtual ICollection<tb_nfe_item> tb_nfe_item
        {
            get
            {
                if (_tb_nfe_item == null)
                    _tb_nfe_item = new List<tb_nfe_item>();
                return _tb_nfe_item;
            }
            set { _tb_nfe_item = value; }
        }

        #endregion
    }
    
}
