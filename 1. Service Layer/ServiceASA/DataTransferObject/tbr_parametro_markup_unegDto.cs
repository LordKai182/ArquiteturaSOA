using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_parametro_markup_uneg")]
    public partial class tbr_parametro_markup_unegDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 par_id { get; set; }
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> par_percentual { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_parametro_markupDto tb_parametro_markup { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
}
