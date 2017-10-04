using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_transportadora
    {
        #region Primitive Properties
        public virtual Int32 transp_id { get; set; }

        public virtual String transp_nome { get; set; }

        public virtual String transp_situacao { get; set; }

        public virtual Nullable<DateTime> transp_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> transp_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_mvto_compra____> _tb_mvto_compra____;
        public virtual ICollection<tb_mvto_compra____> tb_mvto_compra____
        {
            get
            {
                if (_tb_mvto_compra____ == null)
                    _tb_mvto_compra____ = new List<tb_mvto_compra____>();
                return _tb_mvto_compra____;
            }
            set { _tb_mvto_compra____ = value; }
        }

        #endregion
    }
}
