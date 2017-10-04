using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_abcfarma_periodo")]
    public partial class tb_abcfarma_periodoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 per_id { get; set; }
        [DataMember]
        public virtual String per_periodo { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> per_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> per_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tbr_abcfarma_ufDto> tbr_abcfarma_uf;
        //public virtual ICollection<tbr_abcfarma_uf> tbr_abcfarma_uf
        //{
        //    get
        //    {
        //        if (_tbr_abcfarma_uf == null)
        //            _tbr_abcfarma_uf = new List<tbr_abcfarma_uf>();
        //        return _tbr_abcfarma_uf;
        //    }
        //    set { _tbr_abcfarma_uf = value; }
        //}

        #endregion
    }
}
