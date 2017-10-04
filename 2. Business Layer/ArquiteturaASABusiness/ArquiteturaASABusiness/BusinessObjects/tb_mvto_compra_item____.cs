using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_mvto_compra_item____
    {
        #region Primitive Properties
        public virtual Int32 cmp_id { get; set; }

        public virtual Int32 icmp_id { get; set; }

        public virtual Nullable<Decimal> icmp_qtd_checkin { get; set; }

        public virtual Nullable<Decimal> icmp_qtd_pedida { get; set; }

        public virtual Nullable<Decimal> icmp_qtd_nota { get; set; }

        public virtual Nullable<Decimal> icmp_custo_unit_ped { get; set; }

        public virtual Nullable<Decimal> icmp_custo_unit_prod { get; set; }

        public virtual Nullable<Decimal> icmp_custo_unit_nota { get; set; }

        public virtual Nullable<Decimal> icmp_tot_custo_ped { get; set; }

        public virtual Nullable<Decimal> icmp_tot_custo_prod { get; set; }

        public virtual Nullable<Decimal> icmp_tot_custo_nota { get; set; }

        public virtual Nullable<Decimal> icmp_qtd_bonificacao { get; set; }

        public virtual Nullable<Decimal> icmp_vlr_bonificacao { get; set; }

        public virtual Nullable<Decimal> icmp_aliq_ipi { get; set; }

        public virtual Nullable<Decimal> icmp_vlr_ipi { get; set; }

        public virtual Nullable<Decimal> icmp_base_icms { get; set; }

        public virtual Nullable<Decimal> icmp_aliq_icms { get; set; }

        public virtual Nullable<Decimal> icmp_vlr_icms { get; set; }

        public virtual Nullable<Decimal> icmp_perc_encfin { get; set; }

        public virtual Nullable<Decimal> icmp_vlr_encfin { get; set; }

        public virtual Nullable<Decimal> icmp_perc_desconto { get; set; }

        public virtual Nullable<Decimal> icmp_vlr_desconto { get; set; }

        public virtual Nullable<Decimal> icmp_mar_icmsst { get; set; }

        public virtual Nullable<Decimal> icmp_base_icmsst { get; set; }

        public virtual Nullable<Decimal> icmp_aliq_icmsst { get; set; }

        public virtual Nullable<Decimal> icmp_vlr_icmsst { get; set; }

        public virtual Nullable<Decimal> icmp_vlr_frete { get; set; }

        public virtual Nullable<Decimal> icmp_perc_descfin { get; set; }

        public virtual Nullable<Decimal> icmp_vlr_descfin { get; set; }

        public virtual Nullable<Decimal> icmp_perc_repassse { get; set; }

        public virtual Nullable<Decimal> icmp_vlr_repassse { get; set; }

        public virtual Nullable<Decimal> icmp_preco_sugerido { get; set; }

        public virtual Nullable<Decimal> icmp_preco_alterado { get; set; }

        public virtual Nullable<Int32> icmp_Num_Pedido { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_cfop tb_cfop { get; set; }

        public virtual tb_mvto_compra____ tb_mvto_compra____ { get; set; }

        private ICollection<tb_mvto_compra_item_lote____> _tb_mvto_compra_item_lote____;
        public virtual ICollection<tb_mvto_compra_item_lote____> tb_mvto_compra_item_lote____
        {
            get
            {
                if (_tb_mvto_compra_item_lote____ == null)
                    _tb_mvto_compra_item_lote____ = new List<tb_mvto_compra_item_lote____>();
                return _tb_mvto_compra_item_lote____;
            }
            set { _tb_mvto_compra_item_lote____ = value; }
        }

        public virtual tb_produto tb_produto { get; set; }

        #endregion
    }
}
