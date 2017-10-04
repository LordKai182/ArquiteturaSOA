using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_hist_sangria____
    {
        #region Primitive Properties
        public virtual Int32 hsang_id { get; set; }

        public virtual DateTime hsang_data { get; set; }

        public virtual Decimal hsang_cod_caixa { get; set; }

        public virtual Nullable<Decimal> hsang_fund_dinh { get; set; }

        public virtual Nullable<Decimal> hsang_sang_dinh { get; set; }

        public virtual Nullable<Decimal> hsang_sang_cheq { get; set; }

        public virtual Nullable<Decimal> hsang_sang_cheP { get; set; }

        public virtual Nullable<Decimal> hsang_sang_carv { get; set; }

        public virtual Nullable<Decimal> hsang_sang_carp { get; set; }

        public virtual Nullable<Decimal> hsang_sang_dev { get; set; }

        public virtual Nullable<Decimal> hsang_sang_canc { get; set; }

        public virtual Nullable<Decimal> hsang_sang_cext { get; set; }

        public virtual Nullable<Decimal> hsang_sang_desp { get; set; }

        public virtual Nullable<Decimal> hsang_sang_conv { get; set; }

        public virtual Nullable<Decimal> hsang_sang_outr { get; set; }

        public virtual Nullable<Decimal> hsang_usr_respons { get; set; }

        #endregion

    }
}
