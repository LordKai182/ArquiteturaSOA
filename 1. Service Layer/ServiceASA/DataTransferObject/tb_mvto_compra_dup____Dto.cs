using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_mvto_compra_dup____")]
    public partial class tb_mvto_compra_dup____Dto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cmpdup_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> cmpdup_numero { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cmpdup_vencimento { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmpdup_valor { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmpdup_mora_dia { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmpdup_taxa { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cmpdup_dt_antecipacao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cmpdup_vl_antecipacao { get; set; }
        [DataMember]
        public virtual Nullable<Int64> cmpdup_NossoNumero { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_mvto_compra_dup____Dto tb_mvto_compra_dup____1 { get; set; }
        [DataMember]
        public virtual tb_mvto_compra_dup____Dto tb_mvto_compra_dup____2 { get; set; }

        private ICollection<tbr_mvto_compra_dup____Dto> tbr_mvto_compra_dup____;
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
