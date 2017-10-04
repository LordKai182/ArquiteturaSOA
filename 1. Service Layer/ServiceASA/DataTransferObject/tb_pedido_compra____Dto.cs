using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_pedido_compra____")]
    public partial class tb_pedido_compra____Dto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 pedc_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> pedc_nu_nf { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> pedc_dt_pedido { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> pedc_dt_emissao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> pedc_dt_vencimento { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> pedc_vlr_total { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> pedc_qtd_itens { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> pedc_vlr_desconto { get; set; }
        [DataMember]
        public virtual String pedc_situacao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> ped_id { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> pedc_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_checkin_tmpDto> tb_checkin_tmp;
        //public virtual ICollection<tb_checkin_tmp> tb_checkin_tmp
        //{
        //    get
        //    {
        //        if (_tb_checkin_tmp == null)
        //            _tb_checkin_tmp = new List<tb_checkin_tmp>();
        //        return _tb_checkin_tmp;
        //    }
        //    set { _tb_checkin_tmp = value; }
        //}
        [DataMember]
        public virtual tb_fornecedor_divisaoDto tb_fornecedor_divisao { get; set; }

        private IList<tb_pedido_compra_item____Dto> tb_pedido_compra_item____;
        //public virtual ICollection<tb_pedido_compra_item____> tb_pedido_compra_item____
        //{
        //    get
        //    {
        //        if (_tb_pedido_compra_item____ == null)
        //            _tb_pedido_compra_item____ = new List<tb_pedido_compra_item____>();
        //        return _tb_pedido_compra_item____;
        //    }
        //    set { _tb_pedido_compra_item____ = value; }
        //}
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
}
