using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_mvto_compra____
    {
        #region Primitive Properties
        public virtual Int32 cmp_id { get; set; }

        public virtual Nullable<Decimal> cmp_num_nf { get; set; }

        public virtual Nullable<DateTime> cmp_dt_entrada { get; set; }

        public virtual Nullable<DateTime> cmp_dt_emissao { get; set; }

        public virtual Nullable<Decimal> cmp_vlr_produtos { get; set; }

        public virtual Nullable<Decimal> cmp_vlr_nota { get; set; }

        public virtual Nullable<Decimal> cmp_vlr_informado { get; set; }

        public virtual Nullable<Decimal> cmp_desc_comercial { get; set; }

        public virtual Nullable<Decimal> cmp_desc_financeiro { get; set; }

        public virtual Nullable<Decimal> cmp_vlr_frete { get; set; }

        public virtual Nullable<Decimal> cmp_vlr_seguro { get; set; }

        public virtual Nullable<Decimal> cmp_vlr_ipi { get; set; }

        public virtual Nullable<Decimal> cmp_base_icms_st { get; set; }

        public virtual Nullable<Decimal> cmp_vlr_icms_st { get; set; }

        public virtual Nullable<Decimal> cmp_vlr_icms { get; set; }

        public virtual Nullable<Decimal> cmp_base_icms { get; set; }

        public virtual Nullable<Decimal> cmp_vlr_repasse { get; set; }

        public virtual Nullable<Decimal> cmp_vlr_encargos { get; set; }

        public virtual Nullable<Decimal> cmp_vlr_bonificacao { get; set; }

        public virtual String cmp_observacao { get; set; }

        public virtual Nullable<Boolean> cmp_duplicata { get; set; }

        public virtual Nullable<Decimal> cmp_qtde_itens { get; set; }

        public virtual Nullable<Decimal> cmp_cd_operador { get; set; }

        public virtual String cmp_situacao { get; set; }

        public virtual Nullable<DateTime> cmp_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> cmp_cpf_alteracao { get; set; }

        public virtual Nullable<Int32> chkin_id { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_financeiro_prazo tb_financeiro_prazo { get; set; }

        public virtual tb_fornecedor_divisao tb_fornecedor_divisao { get; set; }

        private ICollection<tb_mvto_compra_item_divergencia____> _tb_mvto_compra_item_divergencia____;
        public virtual ICollection<tb_mvto_compra_item_divergencia____> tb_mvto_compra_item_divergencia____
        {
            get
            {
                if (_tb_mvto_compra_item_divergencia____ == null)
                    _tb_mvto_compra_item_divergencia____ = new List<tb_mvto_compra_item_divergencia____>();
                return _tb_mvto_compra_item_divergencia____;
            }
            set { _tb_mvto_compra_item_divergencia____ = value; }
        }

        private ICollection<tb_mvto_compra_item____> _tb_mvto_compra_item____;
        public virtual ICollection<tb_mvto_compra_item____> tb_mvto_compra_item____
        {
            get
            {
                if (_tb_mvto_compra_item____ == null)
                    _tb_mvto_compra_item____ = new List<tb_mvto_compra_item____>();
                return _tb_mvto_compra_item____;
            }
            set { _tb_mvto_compra_item____ = value; }
        }

        public virtual tb_serie_nota tb_serie_nota { get; set; }

        public virtual tb_uf tb_uf { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        public virtual tb_tipo_nota tb_tipo_nota { get; set; }

        public virtual tb_transportadora tb_transportadora { get; set; }

        private ICollection<tbr_mvto_compra_cfop____> _tbr_mvto_compra_cfop____;
        public virtual ICollection<tbr_mvto_compra_cfop____> tbr_mvto_compra_cfop____
        {
            get
            {
                if (_tbr_mvto_compra_cfop____ == null)
                    _tbr_mvto_compra_cfop____ = new List<tbr_mvto_compra_cfop____>();
                return _tbr_mvto_compra_cfop____;
            }
            set { _tbr_mvto_compra_cfop____ = value; }
        }

        private ICollection<tbr_mvto_compra_dup____> _tbr_mvto_compra_dup____;
        public virtual ICollection<tbr_mvto_compra_dup____> tbr_mvto_compra_dup____
        {
            get
            {
                if (_tbr_mvto_compra_dup____ == null)
                    _tbr_mvto_compra_dup____ = new List<tbr_mvto_compra_dup____>();
                return _tbr_mvto_compra_dup____;
            }
            set { _tbr_mvto_compra_dup____ = value; }
        }

        #endregion
    }
    
}
