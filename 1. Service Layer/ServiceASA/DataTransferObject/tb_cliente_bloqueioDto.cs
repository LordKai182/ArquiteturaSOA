using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_cliente_bloqueio")]
    public partial class tb_cliente_bloqueioDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 bloq_id { get; set; }
        [DataMember]
        public virtual String bloq_descricao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> bloq_tip_acao { get; set; }
        [DataMember]
        public virtual String bloq_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> bloq_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> bloq_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties

        private IList<tb_clienteDto> tb_cliente;
        //public virtual ICollection<tb_cliente> tb_cliente
        //{
        //    get
        //    {
        //        if (_tb_cliente == null)
        //            _tb_cliente = new List<tb_cliente>();
        //        return _tb_cliente;
        //    }
        //    set { _tb_cliente = value; }
        //}

        private IList<tbr_convenio_clienteDto> tbr_convenio_cliente;
        //public virtual ICollection<tbr_convenio_cliente> tbr_convenio_cliente
        //{
        //    get
        //    {
        //        if (_tbr_convenio_cliente == null)
        //            _tbr_convenio_cliente = new List<tbr_convenio_cliente>();
        //        return _tbr_convenio_cliente;
        //    }
        //    set { _tbr_convenio_cliente = value; }
        //}

        #endregion
    }
}
