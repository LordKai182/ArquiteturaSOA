using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_financeiro_administradora")]
    public partial class tb_financeiro_administradoraDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 adm_id { get; set; }
        [DataMember]
        public virtual String adm_nome { get; set; }
        [DataMember]
        public virtual String adm_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> adm_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> adm_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_finalizadora_subDto> tb_finalizadora_sub;
        //public virtual ICollection<tb_finalizadora_sub> tb_finalizadora_sub
        //{
        //    get
        //    {
        //        if (_tb_finalizadora_sub == null)
        //            _tb_finalizadora_sub = new List<tb_finalizadora_sub>();
        //        return _tb_finalizadora_sub;
        //    }
        //    set { _tb_finalizadora_sub = value; }
        //}

        #endregion
    }
}
