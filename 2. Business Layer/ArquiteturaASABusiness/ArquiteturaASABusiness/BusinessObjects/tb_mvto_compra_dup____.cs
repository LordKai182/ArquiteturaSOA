using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_mvto_compra_dup____
    {
        #region Primitive Properties
        public virtual Int32 cmpdup_id { get; set; }

        public virtual Nullable<Int32> cmpdup_numero { get; set; }

        public virtual Nullable<DateTime> cmpdup_vencimento { get; set; }

        public virtual Nullable<Decimal> cmpdup_valor { get; set; }

        public virtual Nullable<Decimal> cmpdup_mora_dia { get; set; }

        public virtual Nullable<Decimal> cmpdup_taxa { get; set; }

        public virtual Nullable<DateTime> cmpdup_dt_antecipacao { get; set; }

        public virtual Nullable<Decimal> cmpdup_vl_antecipacao { get; set; }

        public virtual Nullable<Int64> cmpdup_NossoNumero { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_mvto_compra_dup____ tb_mvto_compra_dup____1 { get; set; }

        public virtual tb_mvto_compra_dup____ tb_mvto_compra_dup____2 { get; set; }

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
