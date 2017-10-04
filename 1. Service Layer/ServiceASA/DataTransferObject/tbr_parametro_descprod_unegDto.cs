using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_parametro_descprod_uneg")]
    public partial class tbr_parametro_descprod_unegDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 par_id { get; set; }
        [DataMember]
        public virtual Int32 uneg_id { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
}
