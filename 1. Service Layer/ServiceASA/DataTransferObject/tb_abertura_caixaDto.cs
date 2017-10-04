using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_abertura_caixa")]
    public partial class tb_abertura_caixaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 aberturaCx_usr_id_operador { get; set; }
        [DataMember]
        public virtual DateTime aberturaCx_dt_abertura { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> aberturaCx_dt_fechamento { get; set; }
        [DataMember]
        public virtual Nullable<Int32> aberturaCx_usr_id_fechamento { get; set; }
        [DataMember]
        public virtual Nullable<Int32> aberturaCx_usr_id_conferente { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> aberturaCx_dt_conferencia { get; set; }
        [DataMember]
        public virtual String aberturaCx_observacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> aberturaCx_dt_alteracao { get; set; }

        #endregion

    }
}
