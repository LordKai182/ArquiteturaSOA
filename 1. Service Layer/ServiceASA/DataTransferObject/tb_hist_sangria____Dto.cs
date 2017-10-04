using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_hist_sangria____Dto")]
    public partial class tb_hist_sangria____
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 hsang_id { get; set; }
        [DataMember]
        public virtual DateTime hsang_data { get; set; }
        [DataMember]
        public virtual Decimal hsang_cod_caixa { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> hsang_fund_dinh { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> hsang_sang_dinh { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> hsang_sang_cheq { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> hsang_sang_cheP { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> hsang_sang_carv { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> hsang_sang_carp { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> hsang_sang_dev { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> hsang_sang_canc { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> hsang_sang_cext { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> hsang_sang_desp { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> hsang_sang_conv { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> hsang_sang_outr { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> hsang_usr_respons { get; set; }

        #endregion

    }
}
