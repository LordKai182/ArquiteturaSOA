using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_recarga")]
    public partial class tb_recargaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 pin_pdv { get; set; }
        [DataMember]
        public virtual DateTime pin_data { get; set; }
        [DataMember]
        public virtual Int32 pin_id { get; set; }
        [DataMember]
        public virtual String pin_cod_convenio { get; set; }
        [DataMember]
        public virtual String pin_nome_convenio { get; set; }
        [DataMember]
        public virtual String pin_tipo_credito { get; set; }
        [DataMember]
        public virtual String pin_nome_credito { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> pin_qtde { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> pin_preco { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> pin_tot_pgto { get; set; }
        [DataMember]
        public virtual String pin_ddd { get; set; }
        [DataMember]
        public virtual String pin_telefone { get; set; }
        [DataMember]
        public virtual Nullable<Int32> pin_operado_cx { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_empresa_recargaDto tb_empresa_recarga { get; set; }

        private IList<tb_recarga_finalizadoraDto> tb_recarga_finalizadora;
        //public virtual ICollection<tb_recarga_finalizadora> tb_recarga_finalizadora
        //{
        //    get
        //    {
        //        if (_tb_recarga_finalizadora == null)
        //            _tb_recarga_finalizadora = new List<tb_recarga_finalizadora>();
        //        return _tb_recarga_finalizadora;
        //    }
        //    set { _tb_recarga_finalizadora = value; }
        //}

        #endregion
    }
}
