using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_mvto_compra____")]
    public partial class tb_mvto_compra____Dto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cmp_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_num_nf { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cmp_dt_entrada { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cmp_dt_emissao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_vlr_produtos { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_vlr_nota { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_vlr_informado { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_desc_comercial { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_desc_financeiro { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_vlr_frete { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_vlr_seguro { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_vlr_ipi { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_base_icms_st { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_vlr_icms_st { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_vlr_icms { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_base_icms { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_vlr_repasse { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_vlr_encargos { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_vlr_bonificacao { get; set; }
        [DataMember]
        public virtual String cmp_observacao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> cmp_duplicata { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_qtde_itens { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_cd_operador { get; set; }
        [DataMember]
        public virtual String cmp_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cmp_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmp_cpf_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> chkin_id { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_financeiro_prazoDto tb_financeiro_prazo { get; set; }
        [DataMember]
        public virtual tb_fornecedor_divisaoDto tb_fornecedor_divisao { get; set; }

        private IList<tb_mvto_compra_item_divergencia____Dto> tb_mvto_compra_item_divergencia____;
        //public virtual ICollection<tb_mvto_compra_item_divergencia____> tb_mvto_compra_item_divergencia____
        //{
        //    get
        //    {
        //        if (_tb_mvto_compra_item_divergencia____ == null)
        //            _tb_mvto_compra_item_divergencia____ = new List<tb_mvto_compra_item_divergencia____>();
        //        return _tb_mvto_compra_item_divergencia____;
        //    }
        //    set { _tb_mvto_compra_item_divergencia____ = value; }
        //}

        private IList<tb_mvto_compra_item____Dto> tb_mvto_compra_item____;
        //public virtual ICollection<tb_mvto_compra_item____> tb_mvto_compra_item____
        //{
        //    get
        //    {
        //        if (_tb_mvto_compra_item____ == null)
        //            _tb_mvto_compra_item____ = new List<tb_mvto_compra_item____>();
        //        return _tb_mvto_compra_item____;
        //    }
        //    set { _tb_mvto_compra_item____ = value; }
        //}
        [DataMember]
        public virtual tb_serie_notaDto tb_serie_nota { get; set; }
        [DataMember]
        public virtual tb_ufDto tb_uf { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }
        [DataMember]
        public virtual tb_tipo_notaDto tb_tipo_nota { get; set; }
        [DataMember]
        public virtual tb_transportadoraDto tb_transportadora { get; set; }

        private IList<tbr_mvto_compra_cfop____Dto> tbr_mvto_compra_cfop____;
        //public virtual ICollection<tbr_mvto_compra_cfop____> tbr_mvto_compra_cfop____
        //{
        //    get
        //    {
        //        if (_tbr_mvto_compra_cfop____ == null)
        //            _tbr_mvto_compra_cfop____ = new List<tbr_mvto_compra_cfop____>();
        //        return _tbr_mvto_compra_cfop____;
        //    }
        //    set { _tbr_mvto_compra_cfop____ = value; }
        //}

        private IList<tbr_mvto_compra_dup____Dto> tbr_mvto_compra_dup____;
        //public virtual ICollection<tbr_mvto_compra_dup____> tbr_mvto_compra_dup____
        //{
        //    get
        //    {
        //        if (_tbr_mvto_compra_dup____ == null)
        //            _tbr_mvto_compra_dup____ = new List<tbr_mvto_compra_dup____>();
        //        return _tbr_mvto_compra_dup____;
        //    }
        //    set { _tbr_mvto_compra_dup____ = value; }
        //}

        #endregion
    }
}
