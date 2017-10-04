using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_abcfarma_periodo
    {
        #region Primitive Properties
        public virtual Int32 per_id { get; set; }

        public virtual String per_periodo { get; set; }

        public virtual Nullable<DateTime> per_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> per_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tbr_abcfarma_uf> _tbr_abcfarma_uf;
        public virtual ICollection<tbr_abcfarma_uf> tbr_abcfarma_uf
        {
            get
            {
                if (_tbr_abcfarma_uf == null)
                    _tbr_abcfarma_uf = new List<tbr_abcfarma_uf>();
                return _tbr_abcfarma_uf;
            }
            set { _tbr_abcfarma_uf = value; }
        }

        #endregion
    }
}
