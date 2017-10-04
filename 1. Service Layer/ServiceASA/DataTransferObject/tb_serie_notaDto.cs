using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_serie_nota")]
    public partial class tb_serie_notaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 serient_id { get; set; }
        [DataMember]
        public virtual String serient_serie { get; set; }
        [DataMember]
        public virtual String serient_descricao { get; set; }
        [DataMember]
        public virtual String serient_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> serient_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> serient_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_mvto_compra____Dto> tb_mvto_compra____;
        //public virtual ICollection<tb_mvto_compra____> tb_mvto_compra____
        //{
        //    get
        //    {
        //        if (_tb_mvto_compra____ == null)
        //            _tb_mvto_compra____ = new List<tb_mvto_compra____>();
        //        return _tb_mvto_compra____;
        //    }
        //    set { _tb_mvto_compra____ = value; }
        //}

        #endregion
    }
}
