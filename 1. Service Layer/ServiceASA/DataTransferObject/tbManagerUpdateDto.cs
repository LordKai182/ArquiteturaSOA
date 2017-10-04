using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbManagerUpdate")]
    public partial class tbManagerUpdateDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 ManagerUpdateID { get; set; }
        [DataMember]
        public virtual String Rotina { get; set; }
        [DataMember]
        public virtual DateTime CreatedOn { get; set; }

        #endregion

    }
}
