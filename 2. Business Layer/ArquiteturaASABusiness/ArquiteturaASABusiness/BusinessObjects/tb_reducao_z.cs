using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_reducao_z
    {
        #region Primitive Properties
        public virtual String ecf_numero_serie { get; set; }

        public virtual DateTime reduz_data_movimento { get; set; }

        public virtual Int32 reduz_crz { get; set; }

        public virtual Int32 reduz_coo { get; set; }

        public virtual Int32 reduz_cro { get; set; }

        public virtual DateTime reduz_data_emissao { get; set; }

        public virtual Decimal reduz_venda_bruta { get; set; }

        public virtual Decimal reduz_gt { get; set; }

        public virtual String reduz_md5 { get; set; }

        public virtual Nullable<Int32> uneg_id { get; set; }

        public virtual Nullable<Int32> ecf_id { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_ecf tb_ecf { get; set; }

        private ICollection<tb_reducao_z_itens> _tb_reducao_z_itens;
        public virtual ICollection<tb_reducao_z_itens> tb_reducao_z_itens
        {
            get
            {
                if (_tb_reducao_z_itens == null)
                    _tb_reducao_z_itens = new List<tb_reducao_z_itens>();
                return _tb_reducao_z_itens;
            }
            set { _tb_reducao_z_itens = value; }
        }

        #endregion
    }
}
