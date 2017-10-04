using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbManagerUpdate
    {
        #region Primitive Properties
        public virtual Int32 ManagerUpdateID { get; set; }

        public virtual String Rotina { get; set; }

        public virtual DateTime CreatedOn { get; set; }

        #endregion

    }
}
