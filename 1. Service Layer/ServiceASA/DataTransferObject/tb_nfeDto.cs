using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_nfe")]
    public partial class tb_nfeDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 nfe_pdv { get; set; }
        [DataMember]
        public virtual Int32 nfe_id { get; set; }
        [DataMember]
        public virtual DateTime nfe_data { get; set; }
        [DataMember]
        public virtual Nullable<Int32> nfe_id_vendedor { get; set; }
        [DataMember]
        public virtual Nullable<Int32> nfe_id_atendente { get; set; }
        [DataMember]
        public virtual Nullable<Int32> nfe_id_cancelado { get; set; }
        [DataMember]
        public virtual String nfe_chave_acesso { get; set; }
        [DataMember]
        public virtual String nfe_situacao { get; set; }
        [DataMember]
        public virtual String nfe_uf_origem { get; set; }
        [DataMember]
        public virtual String nfe_uf_destino { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_numero { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_cfop { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_nat_operacao { get; set; }
        [DataMember]
        public virtual String nfe_modelo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_serie { get; set; }
        [DataMember]
        public virtual String nfe_tipo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_cod_municipio { get; set; }
        [DataMember]
        public virtual String nfe_data_saida { get; set; }
        [DataMember]
        public virtual String nfe_hora_saida { get; set; }
        [DataMember]
        public virtual Nullable<Int32> nfe_itens_produto { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_qtd_produto { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_total_venda { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_total_venda_padrao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_total_venda_praticado { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_total_venda_real { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_total_custo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_total_bonificado { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_total_comissao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_desc_comercial { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_desc_financeiro { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_icmstot_vbc { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_icmstot_vicms { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_icmstot_vst { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_icmstot_vprod { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_icmstot_vfrete { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_icmstot_vseg { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_icmstot_vdesc { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_icmstot_vii { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_icmstot_vipi { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_icmstot_vpis { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_icmstot_vcofins { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_icmstot_voutros { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_icmstot_vnf { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_vlr_totaltrib { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_issqntot_vserv { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_issqntot_vbc { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_issqntot_viss { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_issqntot_vpis { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_issqntot_vcofins { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_rettrib_vretpis { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_rettrib_vretcofins { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_rettrib_vretcsll { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_rettrib_vbcirrf { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_rettrib_virrf { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_rettrib_vbcretprev { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_rettrib_vretprev { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_vlr_isento { get; set; }
        [DataMember]
        public virtual String nfe_nf_obs { get; set; }
        [DataMember]
        public virtual String nfe_tip_frete { get; set; }
        [DataMember]
        public virtual String nfe_destino { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_peso_l { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_peso_b { get; set; }
        [DataMember]
        public virtual String nfe_placa_veiculo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> nfe_transportadora { get; set; }
        [DataMember]
        public virtual String nfe_dispositivo { get; set; }
        [DataMember]
        public virtual String nfe_refecf_mod { get; set; }
        [DataMember]
        public virtual Nullable<Int32> nfe_refecf_necf { get; set; }
        [DataMember]
        public virtual Nullable<Int32> nfe_refecf_coo { get; set; }
        [DataMember]
        public virtual Nullable<Int32> transp_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> pedv_id { get; set; }
        [DataMember]
        public virtual Nullable<Int64> cli_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> cnv_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> serient_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> enft_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_ecf_pdv { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_ecf_id { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_ecf_data { get; set; }

        #endregion

        #region Navigation Properties

        private IList<tb_nfe_itemDto> tb_nfe_item;
        
        //public virtual ICollection<tb_nfe_item> tb_nfe_item
        //{
        //    get
        //    {
        //        if (_tb_nfe_item == null)
        //            _tb_nfe_item = new List<tb_nfe_item>();
        //        return _tb_nfe_item;
        //    }
        //    set { _tb_nfe_item = value; }
        //}

        #endregion
    }
}
