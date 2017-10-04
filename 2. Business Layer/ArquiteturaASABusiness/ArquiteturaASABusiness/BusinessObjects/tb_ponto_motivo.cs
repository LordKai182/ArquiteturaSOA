using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_ponto_motivo
    {
        #region Primitive Properties
        public virtual Int32 motivo_id { get; set; }

        public virtual String motivo_descricao { get; set; }

        public virtual String motivo_situacao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_ponto> _tb_ponto;
        public virtual ICollection<tb_ponto> tb_ponto
        {
            get
            {
                if (_tb_ponto == null)
                    _tb_ponto = new List<tb_ponto>();
                return _tb_ponto;
            }
            set { _tb_ponto = value; }
        }

        #endregion
    }
}
