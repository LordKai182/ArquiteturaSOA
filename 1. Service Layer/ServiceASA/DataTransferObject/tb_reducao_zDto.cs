using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_reducao_z")]
    public partial class tb_reducao_zDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual String ecf_numero_serie { get; set; }
        [DataMember]
        public virtual DateTime reduz_data_movimento { get; set; }
        [DataMember]
        public virtual Int32 reduz_crz { get; set; }
        [DataMember]
        public virtual Int32 reduz_coo { get; set; }
        [DataMember]
        public virtual Int32 reduz_cro { get; set; }
        [DataMember]
        public virtual DateTime reduz_data_emissao { get; set; }
        [DataMember]
        public virtual Decimal reduz_venda_bruta { get; set; }
        [DataMember]
        public virtual Decimal reduz_gt { get; set; }
        [DataMember]
        public virtual String reduz_md5 { get; set; }
        [DataMember]
        public virtual Nullable<Int32> uneg_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> ecf_id { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_ecfDto tb_ecf { get; set; }

        private IList<tb_reducao_z_itensDto> tb_reducao_z_itens;
        //public virtual ICollection<tb_reducao_z_itens> tb_reducao_z_itens
        //{
        //    get
        //    {
        //        if (_tb_reducao_z_itens == null)
        //            _tb_reducao_z_itens = new List<tb_reducao_z_itens>();
        //        return _tb_reducao_z_itens;
        //    }
        //    set { _tb_reducao_z_itens = value; }
        //}

        #endregion
    }
}
