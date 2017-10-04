using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_checkin_tmp
    {
        #region Primitive Properties
        public virtual Int32 chkin_id { get; set; }

        public virtual Nullable<Decimal> chkin_num_nf { get; set; }

        public virtual Nullable<DateTime> chkin_data { get; set; }

        public virtual Nullable<Decimal> chkin_cpf_usuario { get; set; }

        public virtual Nullable<DateTime> chkin_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_checkin_item_tmp> _tb_checkin_item_tmp;
        public virtual ICollection<tb_checkin_item_tmp> tb_checkin_item_tmp
        {
            get
            {
                if (_tb_checkin_item_tmp == null)
                    _tb_checkin_item_tmp = new List<tb_checkin_item_tmp>();
                return _tb_checkin_item_tmp;
            }
            set { _tb_checkin_item_tmp = value; }
        }

        public virtual tb_fornecedor_divisao tb_fornecedor_divisao { get; set; }

        public virtual tb_pedido_compra____ tb_pedido_compra____ { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        #endregion
    }
}
