using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_tipo_logradouro")]
    public partial class tb_tipo_logradouroDto
    {
        #region Primitive Properties
       [DataMember]
        public virtual Int32 tiplog_id { get; set; }
        [DataMember]
        public virtual String tiplog_abreviatura { get; set; }
        [DataMember]
        public virtual String tiplog_descricao { get; set; }
        [DataMember]
        public virtual String tiplog_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> tiplog_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> tiplog_dt_alteracao { get; set; }
        [DataMember]
        public virtual String tiplog_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_unid_negocioDto> tb_unid_negocio;
        //public virtual ICollection<tb_unid_negocio> tb_unid_negocio
        //{
        //    get
        //    {
        //        if (_tb_unid_negocio == null)
        //            _tb_unid_negocio = new List<tb_unid_negocio>();
        //        return _tb_unid_negocio;
        //    }
        //    set { _tb_unid_negocio = value; }
        //}

        #endregion
    }
}
