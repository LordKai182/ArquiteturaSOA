using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_conta
    {
        #region Primitive Properties
        public virtual Int32 grau_id { get; set; }

        public virtual String grau_1 { get; set; }

        public virtual String grau_2 { get; set; }

        public virtual String grau_3 { get; set; }

        public virtual String grau_descricao { get; set; }

        #endregion

    }
}
