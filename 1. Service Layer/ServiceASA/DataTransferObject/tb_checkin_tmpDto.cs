using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_checkin_tmp")]
    public partial class tb_checkin_tmpDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 chkin_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> chkin_num_nf { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> chkin_data { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> chkin_cpf_usuario { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> chkin_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        
        private IList<tb_checkin_item_tmpDto> tb_checkin_item_tmp;
        //public virtual ICollection<tb_checkin_item_tmp> tb_checkin_item_tmp
        //{
        //    get
        //    {
        //        if (_tb_checkin_item_tmp == null)
        //            _tb_checkin_item_tmp = new List<tb_checkin_item_tmp>();
        //        return _tb_checkin_item_tmp;
        //    }
        //    set { _tb_checkin_item_tmp = value; }
        //}
        [DataMember]
        public virtual tb_fornecedor_divisaoDto tb_fornecedor_divisao { get; set; }
        [DataMember]
        public virtual tb_pedido_compra____Dto tb_pedido_compra____ { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
}
