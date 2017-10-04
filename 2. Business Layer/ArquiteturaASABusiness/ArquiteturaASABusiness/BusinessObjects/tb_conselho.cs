using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_conselho
    {
        #region Primitive Properties
        public virtual Int16 cs_id { get; set; }

        public virtual String cs_descricao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_conselho_regional> _tb_conselho_regional;
        public virtual ICollection<tb_conselho_regional> tb_conselho_regional
        {
            get
            {
                if (_tb_conselho_regional == null)
                    _tb_conselho_regional = new List<tb_conselho_regional>();
                return _tb_conselho_regional;
            }
            set { _tb_conselho_regional = value; }
        }

        #endregion
    }
}
