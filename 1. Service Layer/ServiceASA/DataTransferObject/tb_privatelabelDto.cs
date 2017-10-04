using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_privatelabel")]
    public partial class tb_privatelabelDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 plabel_pdv { get; set; }
        [DataMember]
        public virtual DateTime plabel_data { get; set; }
        [DataMember]
        public virtual Int32 plabel_id { get; set; }
        [DataMember]
        public virtual String plabel_nsu { get; set; }
        [DataMember]
        public virtual String plabel_nome_rec { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> plabel_tipo_rec { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> plabel_tot_rec { get; set; }
        [DataMember]
        public virtual Nullable<Int32> plabel_operado_cx { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_empresa_privatelabelDto tb_empresa_privatelabel { get; set; }

        private IList<tb_privatelabel_finalizadoraDto> tb_privatelabel_finalizadora;
        //public virtual ICollection<tb_privatelabel_finalizadora> tb_privatelabel_finalizadora
        //{
        //    get
        //    {
        //        if (_tb_privatelabel_finalizadora == null)
        //            _tb_privatelabel_finalizadora = new List<tb_privatelabel_finalizadora>();
        //        return _tb_privatelabel_finalizadora;
        //    }
        //    set { _tb_privatelabel_finalizadora = value; }
        //}

        #endregion
    }
}
