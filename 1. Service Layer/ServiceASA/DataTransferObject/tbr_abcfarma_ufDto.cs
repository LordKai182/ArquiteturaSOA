using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tbr_abcfarma_uf")]
    public partial class tbr_abcfarma_ufDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 per_id { get; set; }
        [DataMember]
        public virtual Int32 abcf_id { get; set; }
        [DataMember]
        public virtual Int32 uf_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> prouf_preco_fabrica { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> prouf_pmc { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> prouf_pmc_fracao { get; set; }
        [DataMember]
        public virtual String prouf_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> prouf_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> prouf_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_abcfarmaDto tb_abcfarma { get; set; }
        [DataMember]
        public virtual tb_abcfarma_periodoDto tb_abcfarma_periodo { get; set; }
        [DataMember]
        public virtual tb_ufDto tb_uf { get; set; }

        #endregion
    }
}
