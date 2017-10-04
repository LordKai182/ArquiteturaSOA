using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_conselho")]
    public partial class tb_conselhoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int16 cs_id { get; set; }
        [DataMember]
        public virtual String cs_descricao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_conselho_regionalDto> tb_conselho_regional;
        //public virtual ICollection<tb_conselho_regional> tb_conselho_regional
        //{
        //    get
        //    {
        //        if (_tb_conselho_regional == null)
        //            _tb_conselho_regional = new List<tb_conselho_regional>();
        //        return _tb_conselho_regional;
        //    }
        //    set { _tb_conselho_regional = value; }
        //}

        #endregion
    }
}
