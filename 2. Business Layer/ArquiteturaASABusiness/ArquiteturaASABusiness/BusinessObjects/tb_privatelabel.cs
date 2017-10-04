using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_privatelabel
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 plabel_pdv { get; set; }

        public virtual DateTime plabel_data { get; set; }

        public virtual Int32 plabel_id { get; set; }

        public virtual String plabel_nsu { get; set; }

        public virtual String plabel_nome_rec { get; set; }

        public virtual Nullable<Decimal> plabel_tipo_rec { get; set; }

        public virtual Nullable<Decimal> plabel_tot_rec { get; set; }

        public virtual Nullable<Int32> plabel_operado_cx { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_empresa_privatelabel tb_empresa_privatelabel { get; set; }

        private ICollection<tb_privatelabel_finalizadora> _tb_privatelabel_finalizadora;
        public virtual ICollection<tb_privatelabel_finalizadora> tb_privatelabel_finalizadora
        {
            get
            {
                if (_tb_privatelabel_finalizadora == null)
                    _tb_privatelabel_finalizadora = new List<tb_privatelabel_finalizadora>();
                return _tb_privatelabel_finalizadora;
            }
            set { _tb_privatelabel_finalizadora = value; }
        }

        #endregion
    }
}
